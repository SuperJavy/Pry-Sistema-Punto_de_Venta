using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using MySqlConnector;
namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    public class ClsConexion : IDisposable
    {
        private static readonly string RutaXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_Conexion.xml");
        private static string _cadenaCacheada;
        private static readonly object _lock = new object();
        protected MySqlConnection conexion;

        //Lectura y construccion de la linea de conexion

        private string ObtenerCadenaDesdeXml()
        {
            lock (_lock)
            {
                if (_cadenaCacheada != null)
                {
                    return _cadenaCacheada;
                }
                if (!File.Exists(RutaXml))
                {
                    throw new FileNotFoundException(
                        "No se cargo el archivo de la configuracion de conexion. " +
                        "Configure la conexion dese la vista correcpodiente antes de continuar. ",
                        RutaXml
                        );
                }
                try
                {
                    XDocument doc = XDocument.Load(RutaXml);

                    string server = LeerEtiquetaRequerida(doc, "Servidor");
                    string Db = LeerEtiquetaRequerida(doc, "BaseDatos");
                    string uid = LeerEtiquetaRequerida(doc, "Usuario");

                    // Leemos la contraseña directamente para permitir que pueda estar vacía
                    string pwCifrada = doc.Root?.Element("Password")?.Value ?? "";
                    string pwd = "";

                    if (!string.IsNullOrEmpty(pwCifrada))
                    {
                        try
                        {
                            // Intentamos desencriptarla
                            pwd = Desencriptar(pwCifrada);
                        }
                        catch
                        {
                            // Si crashea, significa que viene en texto plano desde Inno Setup
                            pwd = pwCifrada;

                            // La encriptamos inmediatamente y actualizamos el XML para blindarlo
                            doc.Root.Element("Password").Value = Encriptar(pwd);
                            doc.Save(RutaXml);
                        }
                    }

                    var builder = new MySqlConnectionStringBuilder
                    {
                        Server = server,
                        Database = Db,
                        UserID = uid,
                        Password = pwd,
                        SslMode = MySqlSslMode.Preferred, // Recuerda dejarlo en Prefer para conexiones locales
                        ConnectionTimeout = 15
                    };

                    // Es vital permitir el uso de variables para que el script de autoconstrucción funcione
                    builder.AllowUserVariables = true;

                    _cadenaCacheada = builder.ConnectionString;
                    return _cadenaCacheada;

                }
                catch (FileNotFoundException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                            "El archivo de conexion es invalido o esta corrupto. Detalles: " + ex.Message, ex
                        );
                }
            }
        }

        private static string LeerEtiquetaRequerida(XDocument doc, string nombre)
        {
            var elemento = doc.Root?.Element(nombre);
            if (elemento == null || string.IsNullOrWhiteSpace(elemento.Value))
            {
                throw new InvalidDataException($"Falra la etiqueta requerida '{nombre}' en el archivo de cofiguracion");
            }
            return elemento.Value;
        }

        //Cifrado de conexion

        public static string Encriptar(string textoPlano)
        {
            byte[] datosPlano = Encoding.UTF8.GetBytes(textoPlano);
            byte[] datosCifrados = ProtectedData.Protect(datosPlano, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(datosCifrados);
        }

        private static string Desencriptar(string textoCifrado)
        {
            byte[] datosCifrados = Convert.FromBase64String(textoCifrado);
            byte[] datosPlano = ProtectedData.Unprotect(datosCifrados, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(datosPlano);
        }

        // Apertura y cierre de conexión

        public MySqlConnection abrirConexion()
        {
            string CadenaConexion = ObtenerCadenaDesdeXml();
            conexion = new MySqlConnection(CadenaConexion);

            try
            {

                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("No fue posible conectar la base de datos. Vefirque la configuración", ex);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }
        public void Dispose()
        {
            cerrarConexion();
            conexion?.Dispose();
        }
        public void VerificarYCrearBaseDeDatos()
        {
            // Usamos tu método existente que lee el XML, descifra la contraseña y cachea la cadena
            string cadenaConexion = ObtenerCadenaDesdeXml();

            try
            {
                // 1. Intentamos conectar normalmente a la BD
                using (var con = new MySqlConnection(cadenaConexion))
                {
                    con.Open();
                    // Si entra aquí, la base de datos ya existe, todo está perfecto.
                }
            }
            catch (MySqlException ex) when (ex.Number == 1049) // 1049: Base de datos desconocida
            {
                // 2. Si no existe, buscamos el script SQL en la misma carpeta que el ejecutable
                string rutaScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Proyecto.sql");

                if (File.Exists(rutaScript))
                {
                    // 3. Modificamos tu cadena cacheada para conectarnos al servidor SIN apuntar a una BD específica
                    var builder = new MySqlConnectionStringBuilder(cadenaConexion);
                    builder.Database = ""; // Dejamos la BD en blanco para poder inyectarla
                    builder.AllowUserVariables = true;
                    using (var conCruda = new MySqlConnection(builder.ConnectionString))
                    {
                        conCruda.Open();
                        // 4. Ejecutamos el archivo Proyecto.sql
                        string scriptSQL = File.ReadAllText(rutaScript);
                    }
                }
                else
                {
                    throw new Exception("La base de datos no existe y no se encontró el archivo 'Proyecto.sql' para construirla automáticamente.");
                }
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro error (servidor apagado, contraseña incorrecta, etc.)
                throw new Exception("Ocurrió un error al verificar la conexión inicial: " + ex.Message);
            }
        }

    }

}

