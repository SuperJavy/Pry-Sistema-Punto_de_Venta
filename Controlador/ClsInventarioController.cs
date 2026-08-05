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
        ClsInventarioModelo modeloInventario = new ClsInventarioModelo();

        public DataTable CargarProductosBajos(FrmProductosbajos vista)
        {
            DataTable dt = null;
            try
            {
                dt = modeloInventario.ObtenerProductosBajos();
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
                DataTable dt = modeloInventario.ObtenerEstadisticas(catId);

                decimal costo = 0;
                int cantidad = 0;

                if (dt.Rows.Count > 0)
                {
                    costo = Convert.ToDecimal(dt.Rows[0]["TotalCosto"]);
                    cantidad = Convert.ToInt32(dt.Rows[0]["TotalCantidad"]);
                }

                vista.ActualizarUI(costo, cantidad);

                if (cantidad == 0)
                {
                    vista.notificarUsuario("No hay productos en esta categoría.", false);
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
                dtcategorias = modeloInventario.Extraercategoria();
            }
            catch (Exception)
            {
                vista.notificarUsuario("Error al cargar las categorias", true);
            }
            return dtcategorias;
        }

        // Método actualizado que conecta la Vista con la nueva consulta de auditoría del Modelo
        public void ActualizarVistaInventario(string catId, FrmReporteinventario vista)
        {
            try
            {
                DataTable dtLista = modeloInventario.ObtenerDetalleProductosConAuditoria(catId);

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
