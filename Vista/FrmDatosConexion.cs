using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmDatosConexion : Form
    {
        private readonly string _rutaXml =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_conexion.xml");

        // Solo se permite guardar después de una prueba de conexión exitosa
        // con los datos que están actualmente escritos en el formulario.
        private bool _conexionProbadaOk = false;

        public FrmDatosConexion()
        {
            InitializeComponent();
            this.Load += FrmDatosConexion_Load;

            // Si el usuario modifica cualquier campo, la prueba anterior deja de ser válida.
            txtServidor.TextChanged += InvalidarPruebaAnterior;
            txtBaseDatos.TextChanged += InvalidarPruebaAnterior;
            txtUsuario.TextChanged += InvalidarPruebaAnterior;
            txtPassword.TextChanged += InvalidarPruebaAnterior;

            btnGuardar.Enabled = false;
        }

        private void InvalidarPruebaAnterior(object sender, EventArgs e)
        {
            _conexionProbadaOk = false;
            btnGuardar.Enabled = false;
        }

        private void FrmDatosConexion_Load(object sender, EventArgs e)
        {
            CargarConfiguracionExistente();
        }

        private void CargarConfiguracionExistente()
        {
            if (!File.Exists(_rutaXml))
                return;

            try
            {
                var doc = XDocument.Load(_rutaXml);
                txtServidor.Text = doc.Root?.Element("Servidor")?.Value ?? string.Empty;
                txtBaseDatos.Text = doc.Root?.Element("BaseDatos")?.Value ?? string.Empty;
                txtUsuario.Text = doc.Root?.Element("Usuario")?.Value ?? string.Empty;
                // La contraseña NO se precarga por seguridad. Si el usuario no la
                // vuelve a escribir, no se sobreescribe al guardar (ver btnGuardar_Click).

                lblEstadoConexion.ForeColor = Color.Black;
                lblEstadoConexion.Text = "Configuración existente cargada. Escriba la contraseña para probar/guardar.";
            }
            catch
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "No se pudo leer la configuración existente (archivo corrupto).";
            }
        }

        private async void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServidor.Text) ||
                string.IsNullOrWhiteSpace(txtBaseDatos.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "Complete servidor, base de datos y usuario.";
                return;
            }

            btnProbarConexion.Enabled = false;
            _conexionProbadaOk = false;
            btnGuardar.Enabled = false;
            lblEstadoConexion.ForeColor = Color.Black;
            lblEstadoConexion.Text = "Probando conexión...";

            var builder = new MySqlConnectionStringBuilder
            {
                Server = txtServidor.Text.Trim(),
                Database = txtBaseDatos.Text.Trim(),
                UserID = txtUsuario.Text.Trim(),
                Password = txtPassword.Text,
                SslMode = MySqlSslMode.Preferred,
                ConnectionTimeout = 5
            };

            try
            {
                using var conexion = new MySqlConnection(builder.ConnectionString);
                await conexion.OpenAsync();

                lblEstadoConexion.ForeColor = Color.Green;
                lblEstadoConexion.Text = "✔ Conexión exitosa";

                _conexionProbadaOk = true;
                btnGuardar.Enabled = true;
            }
            catch (MySqlException ex)
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "✘ " + InterpretarError(ex);
            }
            catch (Exception)
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "✘ Error inesperado al conectar.";
                // El detalle real debería registrarse en un log interno, no mostrarse al usuario.
            }
            finally
            {
                btnProbarConexion.Enabled = true;
            }
        }

        private string InterpretarError(MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0: return "No se pudo alcanzar el servidor. Verifique host/puerto.";
                case 1042: return "Host inválido o servidor no accesible.";
                case 1045: return "Usuario o contraseña incorrectos.";
                case 1049: return "La base de datos especificada no existe.";
                default: return $"Error de conexión ({ex.Number}): {ex.Message}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!_conexionProbadaOk)
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "Pruebe la conexión exitosamente antes de guardar.";
                return;
            }

            try
            {
                string passwordCifrada;

                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    // Se escribió una contraseña nueva: se cifra y se usa esa.
                    passwordCifrada = ClsConexion.Encriptar(txtPassword.Text);
                }
                else if (File.Exists(_rutaXml))
                {
                    // No se tocó el campo de contraseña: se conserva la que ya
                    // estaba guardada (cifrada) en el archivo existente.
                    var docExistente = XDocument.Load(_rutaXml);
                    passwordCifrada = docExistente.Root?.Element("Password")?.Value ?? string.Empty;
                }
                else
                {
                    lblEstadoConexion.ForeColor = Color.Red;
                    lblEstadoConexion.Text = "Ingrese una contraseña para guardar la configuración.";
                    return;
                }

                var doc = new XDocument(
                    new XElement("Configuracion",
                        new XElement("Servidor", txtServidor.Text.Trim()),
                        new XElement("BaseDatos", txtBaseDatos.Text.Trim()),
                        new XElement("Usuario", txtUsuario.Text.Trim()),
                        new XElement("Password", passwordCifrada)
                    ));

                doc.Save(_rutaXml);

                lblEstadoConexion.ForeColor = Color.Green;
                lblEstadoConexion.Text = "✔ Configuración guardada correctamente.";

                MessageBox.Show(
                    "La configuración de conexión se guardó correctamente.",
                    "Guardado exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "✘ No se pudo guardar la configuración.";
                // Registrar ex en un log interno para diagnóstico.
            }
        }
    }
}
