using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsReportesModelo : clsConexion
    {

        public DataTable ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dtVentas = new DataTable();
            try
            {
                using (var conexion = abrirConexion())
                {
                    // Usamos DATE() para ignorar las horas y buscar solo por días completos
                    string consulta = @"
                        SELECT 
                            id AS 'Folio de Venta',
                            fecha AS 'Fecha y Hora',
                            total AS 'Total Vendido'
                        FROM venta 
                        WHERE DATE(fecha) BETWEEN DATE(@fechaInicio) AND DATE(@fechaFin)
                        ORDER BY fecha DESC";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        // Pasamos las fechas como parámetros seguros
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(dtVentas); // Llenamos la tabla virtual con los resultados
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el reporte de ventas: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return dtVentas;
        
        }
        public DataTable ObtenerReporteCompras(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dtCompras = new DataTable();
            try
            {
                using (var conexion = abrirConexion())
                {
                    // Usamos tu tabla 'compra' y tu columna 'fecha_de_compra'
                    string consulta = @"
                SELECT 
                    id AS 'Folio de Compra',
                    fecha_de_compra AS 'Fecha de Compra',
                    total AS 'Total Pagado'
                FROM compra 
                WHERE DATE(fecha_de_compra) BETWEEN DATE(@fechaInicio) AND DATE(@fechaFin)
                ORDER BY fecha_de_compra DESC";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(dtCompras);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el reporte de compras: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return dtCompras;
        }

        public DataTable ObtenerCorteCaja(DateTime fechaCorte)
        {
            DataTable dtCorte = new DataTable();
            try
            {
                using (var conexion = abrirConexion())
                {
                    // Extraemos el detalle del día, separando solo la Hora para que sea más fácil de leer
                    string consulta = @"
                SELECT 
                    id AS 'Folio de Venta',
                    TIME(fecha) AS 'Hora de Venta',
                    total AS 'Monto Ingresado'
                FROM venta 
                WHERE DATE(fecha) = DATE(@fechaCorte)
                ORDER BY fecha DESC";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        // Aquí solo pasamos una fecha, porque el corte es diario
                        cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(dtCorte);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el corte de caja: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return dtCorte;
        }
        public DataTable ObtenerDetalleVenta(int idVenta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conexion = abrirConexion())
                {
                    // d.precio y d.codigo_producto deben coincidir con tus columnas de detalle_venta
                    string query = @"
                SELECT 
                    d.id_producto AS 'Código',
                    p.nombre AS 'Producto',
                    d.cantidad AS 'Cantidad',
                    d.precio_unitario AS 'Precio Unitario',
                    (d.cantidad * d.precio_unitario) AS 'Importe'
                FROM detalle_venta d
                INNER JOIN productos p ON d.id_producto = p.id
                WHERE d.id_venta = @idVenta";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle de venta: " + ex.Message);
            }
            finally { cerrarConexion(); }
            return dt;
        }

        public DataTable ObtenerDetalleCompra(int idCompra)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conexion = abrirConexion())
                {
                    // d.precio_costo debe coincidir con tu columna de detalle_compra
                    string query = @"
                SELECT 
                    d.id_producto AS 'Código',
                    p.nombre AS 'Producto',
                    d.cantidad AS 'Cantidad',
                    d.precio AS 'Precio Costo',
                    (d.cantidad * d.precio) AS 'Importe'
                FROM detalle_compra d
                INNER JOIN productos p ON d.id_producto = p.id
                WHERE d.id_compra = @idCompra";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idCompra", idCompra);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle de compra: " + ex.Message);
            }
            finally { cerrarConexion(); }
            return dt;
        }
    }
}
