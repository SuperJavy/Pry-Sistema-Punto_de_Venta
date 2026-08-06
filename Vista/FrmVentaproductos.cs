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

            // 1. Se guarda la venta en Base de Datos vía Controlador
            bool exito = controller.guardarVenta(this, idUsuario);

            if (exito)
            {
                // 2. Si se guardó, se delega la impresión al Controlador de Tickets
                try
                {
                    ClsTicketController ticketController = new ClsTicketController();

                    string nombreImpresora = Properties.Settings.Default.ImpresoraCaja;
                    bool esTermica = Properties.Settings.Default.EsTermica;
                    ticketController.ImprimirTicketVenta(controller.ObtenerVentaActual(), "Canon G4010 Series", false);
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
                ClsCajonDinero.AbrirCajon(nombreImpresora);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
       
        
    }
}