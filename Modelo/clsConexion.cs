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
                    string pwCifrada = LeerEtiquetaRequerida(doc, "Password");
                    string pwd = Desencriptar(pwCifrada);

                    var builder = new MySqlConnectionStringBuilder
                    {
                        Server = server,
                        Database = Db,
                        UserID = uid,
                        Password = pwd,
                        SslMode = MySqlSslMode.Required,
                        ConnectionTimeout = 15
                    };
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
                            "El archvio de conexion es invalido esta corrupto. ", ex
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

    }

}

