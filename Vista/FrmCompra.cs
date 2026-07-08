using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
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
    public partial class FrmCompra : Form
    {
        ClsComprasController controller = new ClsComprasController();
        private Producto productoEnEspera = null;
        public FrmCompra()
        {
            InitializeComponent();
            controller.recuperarCompraPendiente(this);
            this.ActiveControl = txtCodigoProducto;
        }
        private void FrmCompra_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnAgregarproducto_Click(sender, e);
                    break;

                case Keys.F10:
                    btnBuscar_Click(sender, e);
                    break;

                case Keys.Delete:
                    btnBorrar_Click(sender, e);
                    break;
                case Keys.F12:btnComprar_Click(sender, e);
                    break;
            }
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            string codigoActual = txtCodigoProducto.Text.Trim();
            if (productoEnEspera != null && productoEnEspera.codigo_de_barras != codigoActual)
            {
                productoEnEspera = null;
            }

            if (productoEnEspera == null)
            {
                string codigo = txtCodigoProducto.Text.Trim();
                if (!string.IsNullOrEmpty(codigo))
                {
                    Producto prod = controller.buscarProducto(codigo);
                    if (prod != null)
                    {
                        prepararProductoEnPantalla(prod);
                    }
                    else
                    {
                        notificarUsuario("El código de producto no coincide con ningún registro.", true);
                        txtCodigoProducto.SelectAll();
                    }
                }
                return;
            }

            controller.procesarEntradaCompra(
                productoEnEspera,
                txtCantidadCompra.Text,
                txtCostoCompra.Text,
                this
            );
            txtCodigoProducto.Clear();
            txtCodigoProducto.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FrmBuscarProducto frmBuscar = new FrmBuscarProducto(controller.busquedaAvanzada))
            {
                if (frmBuscar.ShowDialog() == DialogResult.OK)
                {
                    prepararProductoEnPantalla(frmBuscar.productoSeleccionado);
                }
            }
            txtCodigoProducto.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgCompras.CurrentRow != null && dtgCompras.CurrentRow.Index >= 0)
            {
                controller.eliminarProducto(dtgCompras.CurrentRow.Index, this);
            }
            else
            {
                notificarUsuario("Por favor, seleccione una fila del listado para eliminar.", false);
            }
            txtCodigoProducto.Focus();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            controller.guardarCompra(this);
        }
        public void actualizarTabla(List<DetalleCompra> listaCompra)
        {
            dtgCompras.Rows.Clear();
            foreach (var item in listaCompra)
            {
                dtgCompras.Rows.Add(
                    item.producto.codigo_de_barras,
                    item.producto.nombre,
                    item.cantidad,
                    item.precioCompra,
                    item.subtotalCompra

                    );
            }
        
        }
        public void mostrarTotal(decimal totalCompta) 
        {
            txtTotalCompra.Text ="$ " + totalCompta.ToString();
        }
        private void prepararProductoEnPantalla(Producto prod)
        {
            productoEnEspera = prod;
            txtCodigoProducto.Text = prod.codigo_de_barras;
            txtCostoCompra.Text = prod.precio_compra.ToString();
            txtCantidadCompra.Text = "1";

            // Foco interactivo: selecciona el texto para sobreescribir de inmediato
            txtCantidadCompra.Focus();
            txtCantidadCompra.SelectAll();
        }
        public void limpiarCamposEdicion()
        {
            productoEnEspera = null;
            txtCodigoProducto.Clear();
            txtCantidadCompra.Clear();
            txtCostoCompra.Clear();
            txtCodigoProducto.Focus();
        }
        public void notificarUsuario(string mensaje, bool esError)
        {
            MessageBoxIcon icono = esError ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
            string titulo = esError ? "Error en Operación" : "Notificación del Sistema";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
    }
}
