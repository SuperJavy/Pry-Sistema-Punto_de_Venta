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
    public partial class FrmInventario : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmProductosbajos(), pnlinventario);
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmReporteinventario(), pnlinventario);
        }

        private void pnlinventario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
