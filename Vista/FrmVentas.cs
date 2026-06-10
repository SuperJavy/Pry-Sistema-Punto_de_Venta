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
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();

        }

        clsVentasController controler = new clsVentasController();

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            FrmVentaproductos Vproduct = new FrmVentaproductos(controler);
            Vproduct.Show();
            
        }

        private void btnReporteventas_Click(object sender, EventArgs e)
        {
            FrmReporteDeVentas frmventa = new FrmReporteDeVentas();
            frmventa.Show();
        }

        private void FrmVentas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    btnagregarproducto_Click(sender, e);
                    break;

                case Keys.F10:
                    btnBuscar_Click(sender, e);
                    break;

                case Keys.Delete:
                    btnBorrar_Click(sender, e);
                    break;

                case Keys.F12:
                    btnCobrar_Click(sender, e);
                    break;

            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoBusq.Text;
            controler.procesarBusqueda(codigo, this);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgVenta.CurrentRow == null)
            {
                return;
            }
            int indice = dtgVenta.CurrentRow.Index;

            controler.eliminarProducto(indice, this);
            
        }
        public void actualizarTabla(List<detalleVenta> detalleVenta)
        {
            dtgVenta.Rows.Clear();
            foreach (var item in detalleVenta)
            {

                dtgVenta.Rows.Add(
                    item.Producto.codigo_de_barras,
                    item.Producto.nombre,
                    "producto",
                    item.Cantidad,
                    item.PrecioUnitario,
                    item.Importe,
                    null,
                    "productos"

                    );
            }

        }
        public void mostrarTotal(decimal TotalVenta)
        {

            txtTotal.Text = "$ " + TotalVenta.ToString();

        }

        
    }
}
