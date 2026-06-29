using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsReportesController
    {
        ClsReportesModelo modelo = new ClsReportesModelo();
        public DataTable obtenerHistorialVentas(string estado, DateTime fechaInicio, DateTime fechaCorte)
        {

            try
            {
                if (estado == null)
                {
                    throw new Exception("El estado no puede estar vacio");
                }
                if (fechaInicio>fechaCorte)
                {
                    throw new Exception("La fecha de inicio no puede ser mayor a la fecha de cierre del reporte");
                }

                return modelo.consultarReporteVentas(estado, fechaInicio, fechaCorte);

            }
            catch (Exception e)
            {
                throw new Exception("Error de configuracion " + e.Message);
            }

        }

        public DataTable obtenerHistorialCompras(DateTime fechaInicio, DateTime fechaCorte)
        {
            try
            {
                if (fechaInicio > fechaCorte)
                {
                    throw new Exception("La fecha de inicio no puede ser mayor a la fecha final.");
                }

                return modelo.consultarReporteCompras(fechaInicio, fechaCorte);
            }
            catch (Exception e)
            {
                throw new Exception("Error al procesar el reporte de compras: " + e.Message);
            }
        }
        public Dictionary<string, decimal> obtenerCorteDiario(DateTime fechaCorte)
        {
            try
            {       
                return modelo.consultarResumenCorte(fechaCorte);
            }
            catch (Exception e)
            {
                throw new Exception("Error al procesar el corte: " + e.Message);
            }
        }
    }
}
