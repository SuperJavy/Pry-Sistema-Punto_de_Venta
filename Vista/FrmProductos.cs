using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmProductos : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        public FrmProductos()
        {
            InitializeComponent();
        }
        public Panel PnlProductos
        {
            get { return pnlproductos; }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregaralcontenedor(new FrmNuevoProducto(), pnlproductos);
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModoficar modificar = new FrmModoficar();
            principal.agregaralcontenedor(modificar, pnlproductos);
        }
        public Panel PnlProducto
        {
            get { return pnlproductos; }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarproductos eliminar = new FrmEliminarproductos();
            principal.agregaralcontenedor(eliminar, pnlproductos);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new FrmCategorias();
            principal.agregaralcontenedor(categorias, pnlproductos);
        }

        private void pnlproductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestorDeEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualizar_Etiquetas V_Etiquetas = new FrmVisualizar_Etiquetas();
            principal.agregaralcontenedor(V_Etiquetas, pnlproductos);
        }
    }
}
