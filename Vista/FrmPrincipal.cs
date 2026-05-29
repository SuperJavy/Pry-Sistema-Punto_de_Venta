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
        ClsPrincipal principal = new ClsPrincipal();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmVentas(), pnlcontenedor);
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmProductos(), pnlcontenedor);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompras = new FrmCompra();
            frmCompras.FormBorderStyle = FormBorderStyle.None;
            frmCompras.Dock = DockStyle.Fill;
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmCompra(), pnlcontenedor);

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmInventario(), pnlcontenedor);
        }
        private void agregraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmConfiguraciones(), pnlcontenedor);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
