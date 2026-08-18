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
            decimal pago = 0;
            decimal.TryParse(txtPagoCon.Text, out pago);

            if (pago < controller.obtenerTotal())
            {
                NotificarUsuario("El pago ingresado es menor al total de la venta.", true);
                return;
            }

            ClsTicketController ticketController = new ClsTicketController();

            if (ticketController.cargarConfiguracion() == null)
            {
                MessageBox.Show("Aún no se ha configurado el formato del ticket. Vaya a 'Configuraciones > Ticket' en el menú principal antes de realizar cobros con impresión.", "Configuración faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos el proceso aquí, la venta no se guarda.
            }
            
            bool exito = controller.guardarVenta(this, idUsuario);

            if (exito)
            {
                try
                {
                    string nombreImpresora = Properties.Settings.Default.ImpresoraCaja;
                    bool esTermica = Properties.Settings.Default.EsTermica;

                    ticketController.ImprimirTicketVenta(controller.ObtenerVentaActual(), nombreImpresora, esTermica);

                    if (esTermica)
                    {
                        ClsCajonDinero.AbrirCajon(nombreImpresora);
                    }
                }
                catch (Exception ex)
                {
                    NotificarUsuario("Venta guardada, pero ocurrió un problema al imprimir: " + ex.Message, true);
                }

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
            string nombreImpresora = Properties.Settings.Default.ImpresoraCaja;
            bool esTermica = Properties.Settings.Default.EsTermica; // Agregamos la validación del hardware

            decimal pago = 0;
            decimal.TryParse(txtPagoCon.Text, out pago);

            if (pago < controller.obtenerTotal())
            {
                NotificarUsuario("El pago ingresado es menor al total de la venta.", true);
                return;
            }

            // Aquí guardamos la venta, pero no instanciamos el ClsTicketController, por lo que no se imprime.
            bool exito = controller.guardarVenta(this, idUsuario);

            if (exito)
            {
                // Protegemos el disparo del RJ11 con un try-catch
                try
                {
                    if (esTermica)
                    {
                        ClsCajonDinero.AbrirCajon(nombreImpresora);
                    }
                }
                catch (Exception ex)
                {
                    NotificarUsuario("Venta guardada, pero no se pudo abrir el cajón: " + ex.Message, true);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }


    }
}