using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pry_Sistema_Punto_de_Venta.vista
{
    public partial class Frmticket : Form
    {
        ClsTicketController controladorTicket = new ClsTicketController();
        private string rutaLogoSeleccionado = "";
        public Frmticket()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controladorTicket.registrarConfiguracion(
                rutaLogoSeleccionado,
                txtNombreNegocio.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                txtRfc.Text,
                txtMensajeFinal.Text,
                this
            );

            rutaLogoSeleccionado = "";
        }

        private void Frmticket_Load(object sender, EventArgs e)
        {
            try
            {
                clsTicketModelo datos = controladorTicket.cargarConfiguracion();

                if (datos != null)
                {
                    picLogo.Image = datos.Logo;
                    txtNombreNegocio.Text = datos.NombreNegocio;
                    txtTelefono.Text = datos.Telefono;
                    txtDireccion.Text = datos.Direccion;
                    txtRfc.Text = datos.RFC;
                    txtMensajeFinal.Text = datos.MensajeFinal;
                }


                txtNombreNegocio.MaxLength = 50;
                txtTelefono.MaxLength = 10;
                txtDireccion.MaxLength = 100;
                txtRfc.MaxLength = 13;
                txtMensajeFinal.MaxLength = 100;
            }
            catch (Exception ex)
            {
                this.notificarUsuario("Error al cargar los datos: " + ex.Message, true);
            }
        }
        public void notificarUsuario(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuitarLogo_Click(object sender, EventArgs e)
        {
            if (picLogo.Image != null)
            {
                picLogo.Image.Dispose();
                picLogo.Image = null;
            }
        }

        private void btnCargarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
            buscador.Title = "Seleccionar Logo del Negocio";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(buscador.FileName);
                rutaLogoSeleccionado = buscador.FileName; // <-- Guardamos la ruta física
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FrmVistaPreviaTicket frmPrevia = new FrmVistaPreviaTicket(
            picLogo.Image,
            txtNombreNegocio.Text,
            txtTelefono.Text,
            txtDireccion.Text,
            txtRfc.Text,
            txtMensajeFinal.Text);


            frmPrevia.ShowDialog();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (isDigit) y borrar (isControl)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea letras, espacios, guiones y puntos
            }
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Convertir automáticamente a mayúsculas 
            e.KeyChar = char.ToUpper(e.KeyChar);

            // Solo permite letras, números y la tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro carácter
            }

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números y teclas de control(como borrar o enter)
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir explícitamente caracteres especiales de domicilio: espacio, coma, punto y '#'
            if (e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '#')
            {
                return;
            }

            // Si es cualquier otra cosa (como $, %, @), la bloquea
            e.Handled = true;
        }
    }

}
