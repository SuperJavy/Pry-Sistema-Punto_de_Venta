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
        clsVentasController controller = new clsVentasController();
        FrmVentas vista;

        private List<Producto> resultadosBusqueda = new();
        public FrmBuscarProducto(clsVentasController controller, FrmVentas vista)
        {
            InitializeComponent();
            this.controller = controller;
            this.vista = vista;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();

            controller.busquedaAvanzada(filtro, this);
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
            if (e.RowIndex < 0) return;

            Producto producto =
                controller.ObtenerProductoBusqueda(e.RowIndex);

            if (producto != null)
            {
                
                controller.agregarProducto(producto, vista);

                // Opcional 
                MessageBox.Show(
                    $"Agregado: {producto.nombre}");

                Close();
                
            }
        }
    }
}
