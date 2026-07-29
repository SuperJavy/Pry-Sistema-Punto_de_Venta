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
    public partial class FrmHistorialCompras : Form
    {
        ClsReportesController controller = new ClsReportesController();
        public FrmHistorialCompras()
        {
            InitializeComponent();
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Conectar el evento del doble clic
            dtgResultados.CellDoubleClick += dtgResultados_CellDoubleClick;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpDesde.Value.Date;
                DateTime fechaCorte = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

                DataTable datos = controller.obtenerHistorialCompras(fechaInicio, fechaCorte);

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron compras o abastecimientos en este rango de fechas.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dtgResultados.DataSource = datos;

                if (dtgResultados.Columns["Total Invertido"] != null)
                {
                    dtgResultados.Columns["Total Invertido"].DefaultCellStyle.Format = "C2";
                }

                CalcularTotalInvertido(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcularTotalInvertido(DataTable datos)
        {
            decimal totalInvertido = 0;


            foreach (DataRow fila in datos.Rows)
            {
                totalInvertido += Convert.ToDecimal(fila["Total Invertido"]);
            }

            lblTotalInvertido.Text = totalInvertido.ToString("C2");
        }
        private void dtgResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Sacamos el folio de compra
                int idCompra = Convert.ToInt32(dtgResultados.Rows[e.RowIndex].Cells["Folio"].Value);

                // 2. Pedimos los datos al controlador usando la nueva función
                DataTable datosCompra = controller.obtenerDetalleCompra(idCompra);

                // 3. Abrimos la MISMA ventana, pero con otro título y otra tabla
                FrmDetalle ventana = new FrmDetalle("Detalle de Inversión/Compra Folio: " + idCompra, datosCompra);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.ShowDialog();
            }
        }
    }
}
