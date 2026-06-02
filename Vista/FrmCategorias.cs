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

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private clsCategoriasController categoria = new clsCategoriasController();

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            categoria.agregarCategoria(txtNombreCategoria.Text);

            txtNombreCategoria.Clear();
            txtNombreCategoria.Focus();
        }
    }
}
