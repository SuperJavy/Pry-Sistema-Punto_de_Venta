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
    public partial class FrmReportes : Form
    {
        private string reporteActual = "Ventas";
        public FrmReportes()
        {
            InitializeComponent();
            PrepararInterfazVentas();
            this.dtgResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellDoubleClick);
        }
        private ClsReportesController controlador = new ClsReportesController();

        private void btnVentas_Click(object sender, EventArgs e)
        {
            PrepararInterfazVentas();
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            reporteActual = "Compras";
            lblInstruccion.Text = "Reporte de Compras a Proveedores";
            dtgResultados.DataSource = null;
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            reporteActual = "Corte";
            lblInstruccion.Text = "Corte Diario (Seleccione el día en 'Desde')";
            dtgResultados.DataSource = null;
        }

        private void PrepararInterfazVentas()
        {
            reporteActual = "Ventas";
            lblInstruccion.Text = "Reporte de Ventas por Periodo";
            dtgResultados.DataSource = null;
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            DateTime inicio = dtpDesde.Value;
            DateTime fin = dtpHasta.Value;
            switch (reporteActual)
            {

                case "Ventas":
                    controlador.GenerarReporteVentas(inicio, fin, this, dtgResultados);
                    break;
                case "Compras": 
                    controlador.GenerarReporteCompras(inicio, fin, this, dtgResultados);
                    break;

                case "Corte":
                    controlador.GenerarCorteCaja(inicio, this, dtgResultados);
                    break;
            }
        }

       
        private void dtgResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (reporteActual == "Ventas" || reporteActual == "Compras")
            {
                int idRegistro = Convert.ToInt32(dtgResultados.Rows[e.RowIndex].Cells[0].Value);

                FrmReporteDetalle ventanaPopUp = new FrmReporteDetalle($"Artículos en Folio #{idRegistro} ({reporteActual})");
                controlador.CargarDetalleEmergente(reporteActual, idRegistro, ventanaPopUp.dtgDetalle);
                ventanaPopUp.ShowDialog();
            }
        }
    }
}
