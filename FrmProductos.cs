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
    public partial class FrmProductos : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmNuevoProductio(), pnlproductos);
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlertaM mdf= new FrmAlertaM(this);
            mdf.Show();
        }
        public Panel PnlProductos
        {
            get { return pnlproductos; }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlertaEliminar alertaEliminar = new FrmAlertaEliminar(this);
            alertaEliminar.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new FrmCategorias();
            principal.agregaralcontenedor(categorias, pnlproductos);
        }
    }
}
