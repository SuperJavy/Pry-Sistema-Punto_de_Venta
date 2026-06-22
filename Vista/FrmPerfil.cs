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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtUsuario.ReadOnly = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            Form frmLoginOculto = Application.OpenForms["FrmLogin"];

            if (frmLoginOculto != null)
            {
                frmLoginOculto.Show();
            }
            else
            {
                FrmLogin nuevoLogin = new FrmLogin();
                nuevoLogin.Show();
            }

            // 2. Buscamos el FrmPrincipal activo en pantalla y lo cerramos de verdad
            Form frmPrincipalReal = Application.OpenForms["FrmPrincipal"];
            if (frmPrincipalReal != null)
            {
                frmPrincipalReal.Close(); 
            }

            this.Close();

        }
    }
}
