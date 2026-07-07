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

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmLogin : Form
    {
        ClsLoginController LOGIN = new ClsLoginController();
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                LOGIN.validarcampos(txtUsuario.Text, txtpassword.Text, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return;
            }
        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Al marcarlo como Handled = true, cancelamos la acción de la tecla en el TextBox
                e.Handled = true;
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
                FrmPrincipal principal = new FrmPrincipal(LOGIN.ROl, txtUsuario.Text);
                principal.Show();
                this.Hide();
            }
        }

        private void pcbMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
        }

        private void pcbMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '*';

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar_Click(sender, e);
                //ruido windows
                e.SuppressKeyPress = true;
            }
        }
        
    }
}
