using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal  = new FrmPrincipal();
            principal.Show();

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su Usuario")
            {
                txtUsuario.Text = ""; 
                txtUsuario.ForeColor = Color.Black; 
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Ingrese su contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.PlaceholderText = "Ingrese su contraseña";
            
        }
    }
}
