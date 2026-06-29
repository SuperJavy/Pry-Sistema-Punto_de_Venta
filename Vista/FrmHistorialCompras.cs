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
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Aplicamos la misma regla de horas para abarcar todo el día completo
                DateTime fechaInicio = dtpDesde.Value.Date;
                DateTime fechaCorte = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

                // 2. Pedimos los datos al controlador
                DataTable datos = controller.obtenerHistorialCompras(fechaInicio, fechaCorte);

                // 3. Avisamos si el negocio no invirtió nada esos días (sin que el sistema explote)
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron compras o abastecimientos en este rango de fechas.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 4. Llenamos la tabla visual
                dtgResultados.DataSource = datos;

                // 5. Le damos formato de dinero a la columna de 'Total Invertido'
                if (dtgResultados.Columns["Total Invertido"] != null)
                {
                    dtgResultados.Columns["Total Invertido"].DefaultCellStyle.Format = "C2";
                }

                // 6. Calculamos el total de dinero gastado en surtir
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

            // Recorremos todas las filas de la consulta sumando el total
            foreach (DataRow fila in datos.Rows)
            {
                totalInvertido += Convert.ToDecimal(fila["Total Invertido"]);
            }

            // Mostramos el resultado en el label gigante naranja
            lblTotalInvertido.Text = totalInvertido.ToString("C2");
        }
    }
}
