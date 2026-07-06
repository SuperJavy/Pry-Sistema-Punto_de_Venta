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
        public DataTable consultarReporteVentas(string estado, DateTime fechaInicio, DateTime fechaCorte)
        {
            DataTable historialVentas = new DataTable();

            string query = @"SELECT
                    v.id AS 'Folio',
                    u.nickname AS 'Cajero',
                    v.fecha AS 'Fecha y Hora',
                    v.total AS 'Total',
                    e.estado AS 'Estado'
                FROM venta v
                INNER JOIN usuario u ON v.id_usuario = u.id
                INNER JOIN estado e ON v.id_estado = e.id
                WHERE DATE(v.fecha) BETWEEN DATE(@fechaInicio) AND DATE(@fechaCorte)";
            if (estado == "Solo Completadas")
            {
                query += " AND v.id_estado = 1"; 
            }
            else if (estado == "Solo Canceladas")
            {
                query += " AND v.id_estado = 3"; 
            }
            query += " ORDER BY v.fecha DESC";

            try 
            {
                using (MySqlConnection conexion = abrirConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            
                            adaptador.Fill(historialVentas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el historial de ventas "+ex.Message);
            }
            return historialVentas;
        }
        public DataTable consultarReporteCompras(DateTime fechaInicio, DateTime fechaCorte)
        {
            DataTable historialCompras = new DataTable();

            string query = @"
        SELECT 
            c.id AS 'Folio',
            u.nickname AS 'Registró',
            c.fecha_de_compra AS 'Fecha y Hora',
            c.total AS 'Total Invertido'
        FROM compra c
        INNER JOIN usuario u ON c.id_usuario = u.id
        WHERE DATE(c.fecha_de_compra) BETWEEN DATE(@fechaInicio) AND DATE(@fechaCorte)
        ORDER BY c.fecha_de_compra DESC";

            try
            {
                using (MySqlConnection conexion = abrirConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(historialCompras);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el historial de compras: " + ex.Message);
            }

            return historialCompras;
        }
        public Dictionary<string, decimal> consultarResumenCorte(DateTime fechaCorte)
        {      
            Dictionary<string, decimal> totales = new Dictionary<string, decimal>();

            string query = @"
        SELECT 
            (SELECT IFNULL(SUM(total), 0) FROM venta WHERE DATE(fecha) = DATE(@fechaCorte) AND id_estado = 1) AS VentasEfectivo,
            (SELECT COUNT(id) FROM venta WHERE DATE(fecha) = DATE(@fechaCorte) AND id_estado = 1) AS TotalTickets,
            (SELECT IFNULL(SUM(total), 0) FROM compra WHERE DATE(fecha_de_compra) = DATE(@fechaCorte)) AS Salidas,
            (SELECT IFNULL(SUM(dv.cantidad), 0) FROM detalle_venta dv INNER JOIN venta v ON dv.id_venta = v.id WHERE DATE(v.fecha) = DATE(@fechaCorte) AND v.id_estado = 1) AS ArticulosVendidos,
            (SELECT IFNULL(SUM(dv.cantidad), 0) FROM detalle_venta dv INNER JOIN venta v ON dv.id_venta = v.id WHERE DATE(v.fecha) = DATE(@fechaCorte) AND v.id_estado = 3) AS ArticulosCancelados";

            try
            {
                using (MySqlConnection conexion = abrirConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totales.Add("VentasEfectivo", Convert.ToDecimal(reader["VentasEfectivo"]));
                                totales.Add("TotalTickets", Convert.ToDecimal(reader["TotalTickets"]));
                                totales.Add("Salidas", Convert.ToDecimal(reader["Salidas"]));
                                totales.Add("ArticulosVendidos", Convert.ToDecimal(reader["ArticulosVendidos"]));
                                totales.Add("ArticulosCancelados", Convert.ToDecimal(reader["ArticulosCancelados"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el corte de caja: " + ex.Message);
            }

            return totales;
        }

        // Añadir en ClsReportesModelo.cs
        public DataTable consultarDetalleVenta(int idVenta)
        {
            DataTable detalles = new DataTable();

            string query = @"
                            SELECT 
                                p.nombre AS 'Producto',
                                dv.cantidad AS 'Cantidad',
                                dv.precio_unitario AS 'Precio Unit.',
                                dv.subtotal AS 'Subtotal',
                                e.estado AS 'Estado'
                            FROM detalle_venta dv
                            INNER JOIN productos p ON dv.id_producto = p.id
                            LEFT JOIN estado e ON dv.id_estado = e.id
                            WHERE dv.id_venta = @idVenta";

            try
            {
                using (MySqlConnection conexion = abrirConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(detalles);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los detalles de la venta: " + ex.Message);
            }

            return detalles;
        }

        public DataTable consultarDetalleCompra(int idCompra)
        {
            DataTable detalles = new DataTable();

            // Consulta para cruzar el detalle_compra con los productos
            string query = @"
                            SELECT 
                                p.nombre AS 'Producto',
                                dc.cantidad AS 'Cantidad',
                                dc.precio AS 'Precio Compra',
                                dc.subtotal AS 'Subtotal',
                                e.estado AS 'Estado'
                            FROM detalle_compra dc
                            INNER JOIN productos p ON dc.id_producto = p.id
                            LEFT JOIN estado e ON dc.id_estado = e.id
                            WHERE dc.id_compra = @idCompra";

            try
            {
                using (MySqlConnection conexion = abrirConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idCompra", idCompra);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(detalles);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles de la compra: " + ex.Message);
            }
            return detalles;
        }
    }
}
