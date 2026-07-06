using Pry_Sistema_Punto_de_Venta.Controlador;
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
    public partial class FrmCorteCaja : Form
    {
        ClsReportesController controller = new ClsReportesController();

        public FrmCorteCaja()
        {
            InitializeComponent();
            this.Load += FrmCorteCaja_Load;
        }

        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            GenerarCorteDelDia();
        }

        private void GenerarCorteDelDia()
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;

                Dictionary<string, decimal> datosCorte = controller.obtenerCorteDiario(fechaHoy);

                decimal fondoInicial = 500.00m;
                decimal ventasEfectivo = datosCorte["VentasEfectivo"];
                decimal salidasCompras = datosCorte["Salidas"];
                decimal totalTickets = datosCorte["TotalTickets"];
                decimal articulosVendidos = datosCorte["ArticulosVendidos"];
                decimal articulosCancelados = datosCorte["ArticulosCancelados"];


                decimal totalEnCajon = fondoInicial + ventasEfectivo - salidasCompras;

                lblFondoValor.Text = fondoInicial.ToString("C2");
                lblVentasEfectivoValor.Text = "+ " + ventasEfectivo.ToString("C2");
                lblSalidasValor.Text = "- " + salidasCompras.ToString("C2");
                lblTotalCajonValor.Text = totalEnCajon.ToString("C2");

                lblTicketsValor.Text = totalTickets.ToString("N0");
                lblArticulosValor.Text = articulosVendidos.ToString("N0");
                lblCanceladosValor.Text = articulosCancelados.ToString("N0");
                lblTotalVentasValor.Text = ventasEfectivo.ToString("C2"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el Corte de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
