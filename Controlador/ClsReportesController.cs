using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsReportesController
    {

        private ClsReportesModelo modeloReportes = new ClsReportesModelo();

        public void GenerarReporteVentas(DateTime desde, DateTime hasta, FrmReportes vista, DataGridView tablaDestino)
        {
            if (desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable datosVentas = modeloReportes.ObtenerReporteVentas(desde, hasta);

                if (datosVentas.Rows.Count > 0)
                {
                    tablaDestino.DataSource = datosVentas;
                }
                else
                {
                    tablaDestino.DataSource = null; 
                    MessageBox.Show("No se encontraron ventas en el periodo seleccionado.", "Reporte Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GenerarReporteCompras(DateTime desde, DateTime hasta, FrmReportes vista, DataGridView tablaDestino)
        {
            if (desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable datosCompras = modeloReportes.ObtenerReporteCompras(desde, hasta);

                if (datosCompras.Rows.Count > 0)
                {
                    tablaDestino.DataSource = datosCompras;

                    if (tablaDestino.Columns.Contains("Total Pagado"))
                    {
                        tablaDestino.Columns["Total Pagado"].DefaultCellStyle.Format = "C2";
                    }
                }
                else
                {
                    tablaDestino.DataSource = null;
                    MessageBox.Show("No se encontraron compras a proveedores en el periodo seleccionado.", "Reporte Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de compras: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GenerarCorteCaja(DateTime fechaCorte, FrmReportes vista, DataGridView tablaDestino)
        {
            try
            {
                DataTable datosCorte = modeloReportes.ObtenerCorteCaja(fechaCorte);

                if (datosCorte.Rows.Count > 0)
                {
                    tablaDestino.DataSource = datosCorte;

                    if (tablaDestino.Columns.Contains("Monto Ingresado"))
                    {
                        tablaDestino.Columns["Monto Ingresado"].DefaultCellStyle.Format = "C2";
                    }

                    decimal totalCaja = 0;
                    foreach (DataRow fila in datosCorte.Rows)
                    {
                        totalCaja += Convert.ToDecimal(fila["Monto Ingresado"]);
                    }

                    MessageBox.Show(
                        $"El sistema ha calculado los ingresos para el día {fechaCorte.ToShortDateString()}:\n\n" +
                        $"💰 TOTAL EN CAJA: {totalCaja.ToString("C2")}\n" +
                        $"📝 Transacciones realizadas: {datosCorte.Rows.Count}",
                        "Resumen de Corte de Caja",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    tablaDestino.DataSource = null;
                    MessageBox.Show("No se registraron ventas en el día seleccionado. La caja debería estar en ceros.", "Corte Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el corte de caja: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDetalleEmergente(string tipoReporte, int idRegistro, DataGridView tablaDestino)
        {
            try
            {
                DataTable dtDetalle = null;

                if (tipoReporte == "Ventas")
                {
                    dtDetalle = modeloReportes.ObtenerDetalleVenta(idRegistro);
                }
                else if (tipoReporte == "Compras")
                {
                    dtDetalle = modeloReportes.ObtenerDetalleCompra(idRegistro);
                }

                if (dtDetalle != null)
                {
                    tablaDestino.DataSource = dtDetalle;

                    if (tablaDestino.Columns.Contains("Precio Unitario"))
                        tablaDestino.Columns["Precio Unitario"].DefaultCellStyle.Format = "C2";
                    if (tablaDestino.Columns.Contains("Precio Costo"))
                        tablaDestino.Columns["Precio Costo"].DefaultCellStyle.Format = "C2";
                    if (tablaDestino.Columns.Contains("Importe"))
                        tablaDestino.Columns["Importe"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos del folio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
