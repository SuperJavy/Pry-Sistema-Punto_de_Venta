using Pry_Sistema_Punto_de_Venta.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmRecuperarPassword : Form
    {
        ClsLoginController controller = new ClsLoginController();
        public FrmRecuperarPassword()
        {
            InitializeComponent();
            panelRestablecer.Visible = false;
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            btnEnviarCodigo.Enabled = false; // Evitar multiples clics

            string respuesta = controller.SolicitarCodigo(txtCorreo.Text.Trim());

            if (respuesta == "OK")
            {
                MessageBox.Show("Código enviado a tu correo. Revisa tu bandeja de entrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreo.Enabled = false; // Bloqueamos el correo para que no lo cambie
                panelRestablecer.Visible = true; // Mostramos el panel para ingresar código y nueva pass
            }
            else
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnEnviarCodigo.Enabled = true;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string respuesta = controller.CambiarPassword(
                txtCorreo.Text.Trim(),
                txtCodigo.Text.Trim(),
                txtNuevaPass.Text.Trim(),
                txtConfirmarPass.Text.Trim()
            );

            if (respuesta == "OK")
            {
                MessageBox.Show("Contraseña actualizada correctamente. Ya puedes iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerramos la ventana de recuperación y volvemos al Login
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
