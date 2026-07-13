using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsCorteDiarioModelo: ClsConexion
    {
        public Dictionary<string, decimal> ConsultarTotalesTurnoActivo(int idUsuario)
        {
            Dictionary<string, decimal> datosTurno = new Dictionary<string, decimal>
            {
                { "FondoInicial", 0m },
                { "VentasEfectivo", 0m },
                { "TotalTickets", 0m },
                { "ArticulosVendidos", 0m },
                { "Salidas", 0m }, // Reservado para cuando implementes retiros/compras
                { "ArticulosCancelados", 0m }
            };

            string query = @"
                SELECT 
                    c.monto_inicial AS FondoInicial,
                    (SELECT IFNULL(SUM(total), 0) FROM venta WHERE id_usuario = c.id_usuario AND fecha >= c.fecha_inicial) AS VentasEfectivo,
                    (SELECT COUNT(id) FROM venta WHERE id_usuario = c.id_usuario AND fecha >= c.fecha_inicial) AS TotalTickets,
                    (SELECT IFNULL(SUM(cantidad), 0) 
                     FROM detalle_venta dv 
                     INNER JOIN venta v ON dv.id_venta = v.id 
                     WHERE v.id_usuario = c.id_usuario AND v.fecha >= c.fecha_inicial) AS ArticulosVendidos
                FROM corte c
                WHERE c.id_usuario = @idUsuario AND c.fecha_de_cierre IS NULL
                LIMIT 1;";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            datosTurno["FondoInicial"] = Convert.ToDecimal(reader["FondoInicial"]);
                            datosTurno["VentasEfectivo"] = Convert.ToDecimal(reader["VentasEfectivo"]);
                            datosTurno["TotalTickets"] = Convert.ToDecimal(reader["TotalTickets"]);
                            datosTurno["ArticulosVendidos"] = Convert.ToDecimal(reader["ArticulosVendidos"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al extraer datos de la BD: " + ex.Message);
            }

            return datosTurno;
        }

        public bool CerrarTurnoActivo(int idUsuario, decimal montoEsperado, decimal montoReal, decimal diferencia)
        {
            string query = @"
        UPDATE corte 
        SET fecha_de_cierre = NOW(), 
            monto_esperado = @esperado, 
            monto_real = @real, 
            diferencia = @diferencia 
        WHERE id_usuario = @idUsuario AND fecha_de_cierre IS NULL;";
            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@esperado", montoEsperado);
                    cmd.Parameters.AddWithValue("@real", montoReal);
                    cmd.Parameters.AddWithValue("@diferencia", diferencia);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    // ExecuteNonQuery devuelve el número de filas afectadas. Si es > 0, se cerró con éxito.
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el cierre en la base de datos: " + ex.Message);
            }
        }

        public bool TieneTurnoAbierto(int idUsuario)
        {
            string query = "SELECT COUNT(*) FROM corte WHERE id_usuario = @idUsuario AND fecha_de_cierre IS NULL;";
            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    // Si el conteo es mayor a 0, significa que hay una caja abierta sin cerrar
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el estado de la caja: " + ex.Message);
            }
        }
    }
}
