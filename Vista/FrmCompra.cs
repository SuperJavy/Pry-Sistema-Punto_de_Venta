using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmCompra : Form
    {
        ClsComprasController controller = new ClsComprasController();
        private Producto productoEnEspera = null;
        int idUsuario;

        public FrmCompra(int idUsuarioActual)
        {
            InitializeComponent();
            controller.recuperarCompraPendiente(this);
            this.ActiveControl = txtCodigoProducto;
            this.idUsuario = idUsuarioActual;
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
                case Keys.F12:
                    btnComprar_Click(sender, e);
                    break;
            }
        }
        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            string codigoActual = txtCodigoProducto.Text.Trim();

            // Si el cajero borra o escanea un código distinto al que estaba esperando, reiniciamos.
            if (productoEnEspera != null && productoEnEspera.codigo_de_barras != codigoActual)
            {
                productoEnEspera = null;
            }

            // PASO 1: Primer "ENTER" 
            if (productoEnEspera == null)
            {
                if (!string.IsNullOrEmpty(codigoActual))
                {
                    // El controlador nos devuelve la información cruda
                    Producto prod = controller.buscarProducto(codigoActual);

                    if (prod != null)
                    {
                        // Mostramos los datos y esperamos a que el cajero edite o confirme
                        prepararProductoEnPantalla(prod);
                    }
                    else
                    {
                        // Si no existe, lanzamos la alerta de la ventana flotante
                        ConfirmarRegistroNuevoProducto();
                    }
                }
                return; // Detenemos la ejecución aquí.
            }

            // PASO 2: Segundo "ENTER" (Disparado por el cajero tras revisar cantidades y costos).
            controller.VerificarYProcesarEntrada(
                codigoActual,
                txtCantidadCompra.Text,
                txtCostoCompra.Text,
                txtMargenCompra.Text,
                this
            );
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
            controller.guardarCompra(this, idUsuario);
        }
        public void actualizarTabla(List<DetalleCompra> listaCompra)
        {
            dtgCompras.Rows.Clear();
            foreach (var item in listaCompra)
            {
                decimal precioVentaCalculado = controller.CalcularPrecioDeVenta(item.precioCompra, item.porcentajeGanancia);
                dtgCompras.Rows.Add(
                    item.producto.codigo_de_barras,
                    item.producto.nombre,
                    item.cantidad,
                    item.precioCompra,
                    item.porcentajeGanancia + "%",
                    "$ " + Math.Round(precioVentaCalculado, 2),
                    item.subtotalCompra

                    );
            }

        }
        public void mostrarTotal(decimal totalCompta)
        {
            txtTotalCompra.Text = "$ " + totalCompta.ToString();
        }
        private void prepararProductoEnPantalla(Producto prod)
        {
            productoEnEspera = prod;
            txtCodigoProducto.Text = prod.codigo_de_barras;
            txtCostoCompra.Text = prod.precio_compra.ToString();
            txtMargenCompra.Text = prod.porcentaje.ToString();
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
            txtMargenCompra.Clear();
            txtCodigoProducto.Focus();
        }
        public void notificarUsuario(string mensaje, bool esError)
        {
            MessageBoxIcon icono = esError ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
            string titulo = esError ? "Error en Operación" : "Notificación del Sistema";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
        public void ConfirmarRegistroNuevoProducto()
        {
            string codigoEscaneado = txtCodigoProducto.Text;

            var respuesta = MessageBox.Show(
            "El código escaneado no coincide con ningún registro.\n\n¿Desea registrar este nuevo producto ahora?",
            "Producto no encontrado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 1. Creamos un efecto de oscurecimiento para el fondo (Toque profesional de UI)
                Form fondoOscuro = new Form();
                fondoOscuro.StartPosition = FormStartPosition.Manual;
                fondoOscuro.FormBorderStyle = FormBorderStyle.None;
                fondoOscuro.Opacity = 0.60d; // 60% de transparencia
                fondoOscuro.BackColor = Color.Black;
                fondoOscuro.WindowState = FormWindowState.Maximized;
                fondoOscuro.ShowInTaskbar = false;
                fondoOscuro.Show();

                // 2. Instanciamos el formulario de Nuevo Producto
                FrmNuevoProducto frmNuevo = new FrmNuevoProducto(codigoEscaneado);

                // 3. Lo forzamos a comportarse como una ventana de diálogo centrada
                frmNuevo.FormBorderStyle = FormBorderStyle.FixedDialog;
                frmNuevo.StartPosition = FormStartPosition.CenterScreen;
                frmNuevo.MaximizeBox = false;
                frmNuevo.MinimizeBox = false;
                frmNuevo.Text = "Registro Rápido de Producto"; // Título de la ventana flotante

                // 4. Mostramos el formulario flotante atado al fondo oscuro
                frmNuevo.ShowDialog(fondoOscuro);

                // 5. Al cerrar el registro, destruimos el efecto oscuro para regresar a la compra
                fondoOscuro.Dispose();
            }
            txtCodigoProducto.Focus();
            txtCodigoProducto.SelectAll();
        }
    }
}
