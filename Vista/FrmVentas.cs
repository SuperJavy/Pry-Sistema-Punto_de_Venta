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
using Pry_Sistema_Punto_de_Venta.Vista;
namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmVentas : Form
    {
        public  bool ventaPendiente = false;

        private int IdUsuario;
        public FrmVentas(int usuario)
        {
            InitializeComponent();

            this.colCantidad.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.colPrecio.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.colImporte.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colImporte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.colImagen.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colImagen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            this.colCodigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.colCodigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.colNombre.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.colNombre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.colTipoVenta.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.colTipoVenta.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            IdUsuario = usuario;
            controler.recuperarVentaPendiente(this,IdUsuario);

            this.ActiveControl = txtCodigoBusq;
            

        }

        clsVentasController controler = new clsVentasController();

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (!controler.TieneProductos())
            {
                MessageBox.Show("No hay productos en la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmVentaproductos Vproduct = new FrmVentaproductos(controler, IdUsuario);

            if (Vproduct.ShowDialog() == DialogResult.OK)
            {
                ventaPendiente = false;
                controler.LimpiarVenta(this);
            }
            txtCodigoBusq.Focus();
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
                case Keys.Add:      
                case Keys.Oemplus:  
                    AumentarCantidad();
                    e.SuppressKeyPress = true; 
                    break;

                case Keys.Subtract: 
                case Keys.OemMinus: 
                    DisminuirCantidad();
                    e.SuppressKeyPress = true; 
                    break;

            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoBusq.Text;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                txtCodigoBusq.Focus();
                return;
            }

            Producto prod = controler.procesarBusqueda(codigo);

            if (prod != null)
            {
                decimal cantidadFinal = 1;

                // Si es a granel, la Vista es responsable de pedir el peso
                if (prod.tipoVenta.ToLower() == "a granel")
                {
                    FrmPedirPeso frmpeso = new FrmPedirPeso(prod.nombre);
                    if (frmpeso.ShowDialog() == DialogResult.OK)
                    {
                        // Validación de seguridad: no permitir 0 ni negativos
                        if (frmpeso.PesoIngresado <= 0)
                        {
                            MessageBox.Show("El peso debe ser mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCodigoBusq.Clear();
                            txtCodigoBusq.Focus();
                            return;
                        }
                        cantidadFinal = frmpeso.PesoIngresado;
                    }
                    else
                    {
                        txtCodigoBusq.Clear();
                        txtCodigoBusq.Focus();
                        return; // Se canceló la ventana de peso
                    }
                }

                string msjError;
                bool agregado = controler.agregarProducto(prod, cantidadFinal, out msjError);

                if (agregado)
                {
                    // Si se agregó correctamente, actualizamos la interfaz
                    ventaPendiente = true;
                    actualizarTabla(controler.ObtenerVentaActual().detalleVenta);
                    mostrarTotal(controler.obtenerTotal());
                }
                else
                {
                    // Ayudamos al cajero avisándole exactamente por qué no se agregó
                    MessageBox.Show(msjError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El producto no existe en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtCodigoBusq.Clear();
            txtCodigoBusq.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(FrmBuscarProducto frm = new FrmBuscarProducto(controler.busquedaAvanzada)) 
            { 

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCodigoBusq.Text = frm.productoSeleccionado.codigo_de_barras;

                    // 2. Disparamos el mismo evento de "Enter" que ya programaste, 
                    // reutilizando toda la lógica del peso y la suma a la tabla
                    btnagregarproducto_Click(null, null);
                }
            }
            txtCodigoBusq.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgVenta.CurrentRow == null)
            {
                return;
            }
            int indice = dtgVenta.CurrentRow.Index;

            controler.eliminarProducto(indice, this);
            txtCodigoBusq.Focus();

        }
        public void actualizarTabla(List<detalleVenta> detalleVenta)
        {
            if (detalleVenta.Count > 0)
                ventaPendiente = true;
            else
                ventaPendiente = false; 


                dtgVenta.Rows.Clear();
            foreach (var item in detalleVenta)
            {

                dtgVenta.Rows.Add(
                    item.Producto.codigo_de_barras,
                    item.Producto.nombre,
                    item.Producto.tipoVenta,
                    item.Cantidad,
                    item.PrecioUnitario,
                    item.Importe,
                    item.Producto.imagen,
                    "productos"

                    );
            }

        }
        public void mostrarTotal(decimal TotalVenta)
        {

            txtTotal.Text = "$ " + TotalVenta.ToString();

        }
        private void AumentarCantidad()
        {
            if (dtgVenta.CurrentRow == null) return;

            int indice = dtgVenta.CurrentRow.Index;
            controler.ModificarCantidad(indice, 1, this);

            if (dtgVenta.Rows.Count > indice)
            {

                dtgVenta.CurrentCell = dtgVenta.Rows[indice].Cells[0];
            }
        }

        private void DisminuirCantidad()
        {
            if (dtgVenta.CurrentRow == null) return;

            int indice = dtgVenta.CurrentRow.Index;
            controler.ModificarCantidad(indice, -1, this);

            if (dtgVenta.Rows.Count > indice)
            {
                dtgVenta.CurrentCell = dtgVenta.Rows[indice].Cells[0];
            }
        }

    }
}
