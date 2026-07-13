using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo;
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
    public partial class FrmVentaproductos : Form
    {
        private clsVentasController controller;
        int idUsuario;
        public FrmVentaproductos(clsVentasController controller, int idUsuario)
        {
            InitializeComponent();
            this.controller = controller;

            lblTotalMonto.Text = controller.obtenerTotal().ToString();
            this.idUsuario = idUsuario;
        }

        private void FrmVentaproductos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnCobrarImprimir.PerformClick();
                    break;
                case Keys.F2:
                    btnCobrarSolo.PerformClick();
                    break;
                case Keys.Escape:
                    btnCancelar.PerformClick();
                    break;
            }
        }

        private void btnCobrarImprimir_Click(object sender, EventArgs e)
        {
            // 1. Validar que el pago cubra el total
            decimal pago = 0;
            decimal.TryParse(txtPagoCon.Text, out pago);

            if (pago < controller.obtenerTotal())
            {
                NotificarUsuario("El pago ingresado es menor al total de la venta.", true);
                return;
            }

            // 2. Guardar la venta en base de datos
            bool exito = controller.guardarVenta(this, idUsuario);

            if (exito)
            {
                // 3. Generar Ticket y Cajón
                GenerarTicket(pago);

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPagoCon_TextChanged(object sender, EventArgs e)
        {

            decimal pago = 0;
            decimal.TryParse(txtPagoCon.Text, out pago);
            decimal cambio = controller.obtenerCambio(pago);

            if (cambio < 0)
            {

                lblCambioMonto.ForeColor = System.Drawing.Color.Red;
                lblCambioMonto.Text = " -" + Math.Abs(cambio).ToString("N2");
            }
            else
            {
                lblCambioMonto.ForeColor = System.Drawing.Color.Green;
                lblCambioMonto.Text = cambio.ToString("N2");
            }
        }

        public void NotificarUsuario(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cerrarVentana()
        {
            Close();
        }

        private void btnCobrarSolo_Click(object sender, EventArgs e)
        {
            decimal pago = 0;
            decimal.TryParse(txtPagoCon.Text, out pago);

            if (pago < controller.obtenerTotal())
            {
                NotificarUsuario("El pago ingresado es menor al total de la venta.", true);
                return;
            }

            bool exito = controller.guardarVenta(this,idUsuario);

            if (exito)
            {
                // Solo mandamos la señal del cajón
                ClsImpresoraTermica impresora = new ClsImpresoraTermica();
                impresora.AbrirCajon();
                impresora.Imprimir("POS-58"); // Reemplaza "POS-58" por el nombre de tu impresora en Windows

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void GenerarTicket(decimal pagoRecibido)
        {
            try
            {
                // Traemos la configuración guardada
                ClsTicketController ticketController = new ClsTicketController();
                clsTicketModelo config = ticketController.cargarConfiguracion();

                ClsImpresoraTermica impresora = new ClsImpresoraTermica();

                // Encabezado
                if (config != null)
                {
                    impresora.AgregarLinea(config.NombreNegocio);
                    impresora.AgregarLinea("RFC: " + config.RFC);
                    impresora.AgregarLinea("Dir: " + config.Direccion);
                    impresora.AgregarLinea("Tel: " + config.Telefono);
                }

                impresora.AgregarLinea("--------------------------------");
                impresora.AgregarLinea("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                impresora.AgregarLinea("--------------------------------");

                // Detalle de Venta (Aquí deberás iterar sobre los productos de tu carrito)
                impresora.AgregarLinea("CANT  PRODUCTO           IMPORTE");

                // EJEMPLO: (Reemplaza este foreach con tu lista real de productos en venta)
                /*
                foreach(var item in controller.ObtenerDetallesVenta())
                {
                    impresora.AgregarLinea(item.Cantidad + "x " + item.Producto.Nombre + "  $" + item.Subtotal);
                }
                */

                impresora.AgregarLinea("--------------------------------");
                impresora.AgregarLinea("TOTAL:      $" + controller.obtenerTotal().ToString("N2"));
                impresora.AgregarLinea("PAGO CON:   $" + pagoRecibido.ToString("N2"));
                impresora.AgregarLinea("SU CAMBIO:  $" + controller.obtenerCambio(pagoRecibido).ToString("N2"));

                impresora.AgregarLinea("--------------------------------");
                if (config != null)
                {
                    impresora.AgregarLinea(config.MensajeFinal);
                }

                // Espaciado final, cortar papel y abrir cajón
                impresora.AgregarLinea("\n\n");
                impresora.CortarPapel();
                impresora.AbrirCajon();

                // ¡IMPORTANTE! Aquí va el nombre exacto de la impresora térmica en Windows
                impresora.Imprimir("POS-58");
            }
            catch (Exception ex)
            {
                NotificarUsuario("Error al imprimir el ticket: " + ex.Message, true);
            }
        }
    }
}
