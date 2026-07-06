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
using System.Drawing;
namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmHistorialVentas : Form
    {
        public FrmHistorialVentas()
        {
            InitializeComponent();
            if (cmbEstadoVenta.Items.Count > 0)
            {
                cmbEstadoVenta.SelectedIndex = 0;
            }

            dtgResultados.CellFormatting += dtgResultados_CellFormatting;

            // NUEVO: Conectamos el evento del doble clic
            dtgResultados.CellDoubleClick += dtgResultados_CellDoubleClick;
        }
        ClsReportesController controller = new ClsReportesController();
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            try
            {
                string estado = cmbEstadoVenta.Text;
                DateTime fechaInicio = dtpDesde.Value.Date;
                DateTime fechaCorte = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

                DataTable datos = controller.obtenerHistorialVentas(estado, fechaInicio, fechaCorte);
                if (datos.Rows.Count == null)
                {
                    MessageBox.Show("Los datos estan vacios", "Holi", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                dtgResultados.DataSource = datos;

                if (datos.Columns["Total"] != null)
                {
                    dtgResultados.Columns["Total"].DefaultCellStyle.Format = "C2";
                }
                calcularEfectivo(datos);
           
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error al generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        public void calcularEfectivo(DataTable datos)
        {

            decimal totalEfectivo = 0;

            foreach (DataRow fila in datos.Rows)
            {
                string estadoVenta = fila["Estado"].ToString().ToLower();

                if (estadoVenta == "completa" || estadoVenta == "Completada")
                {
                    totalEfectivo += Convert.ToDecimal(fila["Total"]);
                }
            }
            
            lblTotalEfectivo.Text = totalEfectivo.ToString("C2");
        }
        private void dtgResultados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dtgResultados.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                string estado = e.Value.ToString().ToLower();


                if (estado == "cancelada" || estado == "cancelado")
                {
                    dtgResultados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(253, 237, 236);
                    dtgResultados.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(192, 57, 43);
                }
                else
                {

                    dtgResultados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dtgResultados.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(47, 53, 66);
                }
            }
        }
        private void dtgResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dtgResultados.Rows[e.RowIndex].Cells["Folio"].Value);

                DataTable datosVenta = controller.obtenerDetalleVenta(idVenta);

                FrmDetalle ventana = new FrmDetalle("Detalle del Ticket de Venta Folio: " + idVenta, datosVenta);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.ShowDialog();
            }
        }



    }
}
