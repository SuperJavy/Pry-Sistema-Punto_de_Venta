using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
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
    public partial class FrmBuscarProducto : Form
    {
        public Producto productoSeleccionado { get; private set; }

        private readonly Func<string, List<Producto>> funcionBusqueda;
     
        private List<Producto> resultadosBusqueda = new List<Producto>();

        public FrmBuscarProducto(Func<string, List<Producto>> funcionBusqueda)
        {
            InitializeComponent();
            this.funcionBusqueda = funcionBusqueda;
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                actualizarLista(new List<Producto>());
                return;
            }

            List<Producto> resultados = funcionBusqueda(filtro);

            actualizarLista(resultados);
        }
        public void actualizarLista(List<Producto> producto)
        {
            resultadosBusqueda = producto;
            dtgResultados.Rows.Clear();
            foreach (var item in producto)
            {
                dtgResultados.Rows.Add(

                    item.id_producto,
                    item.nombre,
                    item.precio,
                    item.stock
                );
            }

        }

        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            productoSeleccionado = resultadosBusqueda[e.RowIndex];

            DialogResult = DialogResult.OK;

            Close();

        }
    }
}

