using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsInventarioController
    {
        ClsInventarioModelo producto = new ClsInventarioModelo();
        public DataTable CargarProductosBajos(FrmProductosbajos vista)
        {
            DataTable dt = null;
            try
            {
                dt = producto.ObtenerProductosBajos();
                if (dt != null && dt.Rows.Count == 0)
                {
                    vista.notificarUsuario("No hay productos con inventario bajo.", false);
                }
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar inventario: " + e.Message, true);
            }
            return dt;
        }


        public void ObtenerReporte(string catId, FrmReporteinventario vista)
        {
            try
            {
                DataTable dt = producto.ObtenerEstadisticas(catId);

                // Verificamos si la tabla tiene datos
                if (dt.Rows.Count > 0 && dt.Rows[0]["TotalCosto"] != DBNull.Value)
                {
                    decimal costo = Convert.ToDecimal(dt.Rows[0]["TotalCosto"]);
                    int cantidad = Convert.ToInt32(dt.Rows[0]["TotalCantidad"]);

                    vista.ActualizarUI(costo, cantidad);
                }
                else
                {
                    // Aquí usamos la función que pediste cuando no hay datos
                    vista.notificarUsuario("No hay productos con inventario bajo.", false);
                    vista.ActualizarUI(0, 0); // Limpiamos la pantalla
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al obtener reporte: " + ex.Message, true);
            }

        }

        public DataTable Cargarcategorias(FrmReporteinventario vista)
        {
            DataTable dtcategorias = null;
            try
            {
                dtcategorias = producto.Extraercategoria();

            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar las categorias", true);
            }
            return dtcategorias;

        }


        public void ActualizarVistaInventario(string catId, FrmReporteinventario vista)
        {
            try
            { 

                DataTable dtLista = producto.ObtenerDetalleProductos(catId);

                if (dtLista.Rows.Count > 0)
                {
                    vista.FuenteDatosGrid = dtLista;
                }
                else
                {
                    vista.FuenteDatosGrid = null;
                    vista.notificarUsuario("No hay productos en esta categoría.", false);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al cargar datos: " + ex.Message, true);
            }
        }
    }
}
