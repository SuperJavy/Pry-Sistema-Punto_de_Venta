using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmPrincipal : Form
    {

        private string Rolusuario;
        public FrmPrincipal(string rolusuario)
        {
            InitializeComponent();


            Rolusuario = rolusuario;
            controller.verificarrol(Rolusuario, this);
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
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmProductos(), pnlcontenedor);
        }

        private void mnsCompra_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompras = new FrmCompra();
            frmCompras.FormBorderStyle = FormBorderStyle.None;
            frmCompras.Dock = DockStyle.Fill;
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmCompra(), pnlcontenedor);
        }

        private void mnsInventario_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmInventario(), pnlcontenedor);
        }

        private void mnsConfiguraciones_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmConfiguraciones(), pnlcontenedor);
        }
    }
}
