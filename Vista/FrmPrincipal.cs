using Microsoft.VisualBasic.Logging;
using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Vista;
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
    public partial class FrmPrincipal : Form
    {
        ClsLoginController login = new ClsLoginController();
        private string Rolusuario;
        private string Usuario;
        ClsPrincipal principal = new ClsPrincipal();
        public FrmPrincipal(string rolusuario, string usuario)
        {
            InitializeComponent();
            Rolusuario = rolusuario;
            Usuario = usuario;
        }
        public void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void mnsVentas_Click_1(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmVentas(), pnlcontenedor);
        }

        public void mnsProductos_Click(object sender, EventArgs e)
        {
            IntentarAcceso(new FrmProductos())
;
        }

        private void mnsCompra_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompras = new FrmCompra();
            frmCompras.FormBorderStyle = FormBorderStyle.None;
            frmCompras.Dock = DockStyle.Fill;
            IntentarAcceso(new FrmCompra());

        }

        private void mnsInventario_Click(object sender, EventArgs e)
        {
            IntentarAcceso(new FrmInventario());
        }

        private void mnsConfiguraciones_Click(object sender, EventArgs e)
        {
            IntentarAcceso(new FrmConfiguraciones());
        }

        private void IntentarAcceso(Form formulario)
        {
            // Si el usuario actual ya es Admin (rol "1"), accede directo
            if (Rolusuario == "1")
            {
                principal.agregaralcontenedor(formulario, pnlcontenedor);
            }
            else
            {
                // Es cajero: pedir llave maestra
                FrmAlertaCodigo frmAuth = new FrmAlertaCodigo();
                if (frmAuth.ShowDialog() == DialogResult.OK)
                {
                    // Validamos contra la contraseña del admin en BD
                    if (login.Validaradmin(frmAuth.PasswordIngresado))
                    {
                        principal.agregaralcontenedor(formulario, pnlcontenedor);
                    }
                    else
                    {
                        MessageBox.Show("Acceso denegado: Contraseña de Administrador incorrecta",
                                        "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnsReportes_Click(object sender, EventArgs e)
        {
            IntentarAcceso(new FrmReportes());
        }

        private void pcbPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil(Usuario);
            perfil.ShowDialog();
        }
    }
}
