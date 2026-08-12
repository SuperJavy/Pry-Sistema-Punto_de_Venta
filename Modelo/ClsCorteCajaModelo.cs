using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    // CAPA MODELO: única responsable de hablar con la base de datos.
    // No conoce Labels, Forms ni MessageBox — solo datos.
    internal class ClsCorteCajaModelo : ClsConexion
    {

        public int AbrirCaja(int idUsuario, decimal montoInicial)
        {
            string query = @"INSERT INTO corte (id_usuario, fecha_inicial, monto_inicial, monto_esperado) 
                     VALUES (@id_usuario, @fecha_actual, @monto_inicial, @monto_inicial);
                     SELECT LAST_INSERT_ID();";
            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fecha_actual", DateTime.Now); // C# dicta la hora
                    cmd.Parameters.AddWithValue("@monto_inicial", montoInicial);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir caja: " + ex.Message);
            }
        }

        // Busca el turno ABIERTO (fecha_de_cierre IS NULL) más reciente de ese usuario
        // y, en el mismo viaje a la BD, calcula todo lo que ha movido la caja desde
        // que se abrió (fecha_inicial en adelante):
        //   - VentasEfectivo:  suma de venta.total con id_estado = 1 (Completa).
        //                      venta.total ya excluye las líneas canceladas de ese
        //                      mismo ticket (detalle_venta.id_estado = 3), así que
        //                      no hay que restarlas de nuevo aquí.
        //   - Salidas:         suma de compra.total con id_estado = 1, es decir,
        //                      dinero que salió del cajón para pagar a proveedor.
        //   - TotalTickets:    número de ventas completas del turno.
        //   - ArticulosVendidos: se lee de detalle_venta con dv.id_estado = 1, sumando
        //     cantidad (funciona bien para piezas; para "a granel" refleja el peso vendido).
        //   - ArticulosCancelados: se cuenta con COUNT(*) el número de líneas canceladas
        //     (dv.id_estado = 3), NO se suma cantidad. Si se sumara cantidad, un solo
        //     producto "a granel" cancelado con mucho peso (ej. 108.000 kg) infla el
        //     número muy por encima de la cantidad real de productos cancelados.
        //     COUNT(*) siempre representa "cuántos productos se cancelaron", sin
        //     importar si eran piezas o a granel.
        //
        // Todas las columnas van con COALESCE(...,0) para que un turno recién
        // abierto sin movimientos todavía devuelva 0 y no NULL.
        public Dictionary<string, decimal> ObtenerCorteDinamico(int idUsuario)
        {
            var resultado = new Dictionary<string, decimal>();

            string query = @"
                SELECT 
                    c.id AS IdCorte,
                    c.monto_inicial AS FondoInicial,
                    COALESCE((SELECT SUM(v.total)
                                FROM venta v
                               WHERE v.id_usuario = c.id_usuario
                                 AND v.fecha >= c.fecha_inicial
                                 AND v.id_estado = 1), 0) AS VentasEfectivo,
                    COALESCE((SELECT SUM(co.total)
                                FROM compra co
                               WHERE co.id_usuario = c.id_usuario
                                 AND co.fecha_de_compra >= c.fecha_inicial
                                 AND co.id_estado = 1), 0) AS Salidas,
                    COALESCE((SELECT COUNT(*)
                                FROM venta v2
                               WHERE v2.id_usuario = c.id_usuario
                                 AND v2.fecha >= c.fecha_inicial
                                 AND v2.id_estado = 1), 0) AS TotalTickets,
                    COALESCE((SELECT SUM(dv.cantidad)
                                FROM detalle_venta dv
                                INNER JOIN venta v3 ON v3.id = dv.id_venta
                               WHERE v3.id_usuario = c.id_usuario
                                 AND v3.fecha >= c.fecha_inicial
                                 AND dv.id_estado = 1), 0) AS ArticulosVendidos,
                   COALESCE((SELECT SUM(dv2.cantidad)
                                FROM detalle_venta dv2
                                INNER JOIN venta v4 ON v4.id = dv2.id_venta
                               WHERE v4.id_usuario = c.id_usuario
                                 AND v4.fecha >= c.fecha_inicial
                                 AND dv2.id_estado = 3), 0) AS ArticulosCancelados
                                    FROM corte c
                WHERE c.id_usuario = @id_usuario
                  AND c.fecha_de_cierre IS NULL
                ORDER BY c.fecha_inicial DESC
                LIMIT 1;";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado["TurnoEncontrado"] = 1;
                            resultado["IdCorte"] = Convert.ToDecimal(reader["IdCorte"]);
                            resultado["FondoInicial"] = Convert.ToDecimal(reader["FondoInicial"]);
                            resultado["VentasEfectivo"] = Convert.ToDecimal(reader["VentasEfectivo"]);
                            resultado["Salidas"] = Convert.ToDecimal(reader["Salidas"]);
                            resultado["TotalTickets"] = Convert.ToDecimal(reader["TotalTickets"]);
                            resultado["ArticulosVendidos"] = Convert.ToDecimal(reader["ArticulosVendidos"]);
                            resultado["ArticulosCancelados"] = Convert.ToDecimal(reader["ArticulosCancelados"]);
                        }
                        else
                        {
                            // No existe ningún turno abierto para este usuario.
                            resultado["TurnoEncontrado"] = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el corte dinámico: " + ex.Message);
            }

            return resultado;
        }

        // Responde si el usuario ya tiene un turno sin cerrar (fecha_de_cierre IS NULL).
        // La usa el login para decidir si reabre el turno existente o exige abrir uno nuevo.
        public bool TieneTurnoAbierto(int idUsuario)
        {
            string query = @"SELECT COUNT(*) 
                                FROM corte 
                               WHERE id_usuario = @id_usuario 
                                 AND fecha_de_cierre IS NULL;";
            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el usuario tiene un turno abierto: " + ex.Message);
            }
        }

        // Trae el listado de cortes (abiertos y cerrados) dentro de un rango de fechas,
        // opcionalmente filtrado por cajero y por estado calculado del corte.
        // "Estado" no existe como columna en la tabla: se calcula aquí mismo con un CASE
        // a partir de fecha_de_cierre y diferencia, para no duplicar esa lógica en la Vista.
        //   - Abierto:   fecha_de_cierre IS NULL (el turno sigue en curso)
        //   - Cuadrado:  diferencia = 0
        //   - Faltante:  diferencia < 0 (faltó dinero en caja)
        //   - Sobrante:  diferencia > 0 (sobró dinero en caja)
        // idCajero = 0 significa "todos los cajeros". estado = "Todos" significa "sin filtrar".
        // NOTA: se asume una tabla "usuario" con columnas (id, nombre); si el nombre real de
        // esa tabla/columna difiere en tu base de datos, ajusta el JOIN de abajo.
        public List<Dictionary<string, object>> ObtenerHistorial(DateTime fechaDesde, DateTime fechaHastaExclusiva, int idCajero, string estado)
        {
            var resultado = new List<Dictionary<string, object>>();

            string query = @"
                SELECT 
                    c.id AS IdCorte,
                    c.fecha_inicial,
                    c.fecha_de_cierre,
                    u.nombre AS Cajero,
                    c.monto_inicial,
                    c.monto_esperado,
                    c.monto_real,
                    c.diferencia,
                    CASE 
                        WHEN c.fecha_de_cierre IS NULL THEN 'Abierto'
                        WHEN c.diferencia = 0 THEN 'Cuadrado'
                        WHEN c.diferencia < 0 THEN 'Faltante'
                        ELSE 'Sobrante'
                    END AS Estado
                FROM corte c
                INNER JOIN usuario u ON u.id = c.id_usuario
                WHERE c.fecha_inicial >= @fecha_desde
                  AND c.fecha_inicial < @fecha_hasta
                  AND (@id_cajero = 0 OR c.id_usuario = @id_cajero)
                  AND (@estado = 'Todos'
                       OR (@estado = 'Abierto'  AND c.fecha_de_cierre IS NULL)
                       OR (@estado = 'Cuadrado' AND c.diferencia = 0)
                       OR (@estado = 'Faltante' AND c.diferencia < 0)
                       OR (@estado = 'Sobrante' AND c.diferencia > 0))
                ORDER BY c.fecha_inicial DESC;";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@fecha_desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fecha_hasta", fechaHastaExclusiva);
                    cmd.Parameters.AddWithValue("@id_cajero", idCajero);
                    cmd.Parameters.AddWithValue("@estado", string.IsNullOrWhiteSpace(estado) ? "Todos" : estado);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fila = new Dictionary<string, object>
                            {
                                ["IdCorte"] = Convert.ToInt32(reader["IdCorte"]),
                                ["FechaInicial"] = Convert.ToDateTime(reader["fecha_inicial"]),
                                ["FechaCierre"] = reader["fecha_de_cierre"] == DBNull.Value ? null : (object)Convert.ToDateTime(reader["fecha_de_cierre"]),
                                ["Cajero"] = reader["Cajero"].ToString(),
                                ["MontoInicial"] = Convert.ToDecimal(reader["monto_inicial"]),
                                ["MontoEsperado"] = Convert.ToDecimal(reader["monto_esperado"]),
                                ["MontoReal"] = reader["monto_real"] == DBNull.Value ? null : (object)Convert.ToDecimal(reader["monto_real"]),
                                ["Diferencia"] = reader["diferencia"] == DBNull.Value ? null : (object)Convert.ToDecimal(reader["diferencia"]),
                                ["Estado"] = reader["Estado"].ToString()
                            };
                            resultado.Add(fila);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial de cortes: " + ex.Message);
            }

            return resultado;
        }

        // Lista de cajeros que aparecen en al menos un corte, para llenar el combo de filtro.
        // Devuelve id -> nombre.
        public Dictionary<int, string> ObtenerCajeros()
        {
            var resultado = new Dictionary<int, string>();

            string query = @"
                SELECT DISTINCT u.id, u.nombre
                  FROM usuario u
                 INNER JOIN corte c ON c.id_usuario = u.id
                 ORDER BY u.nombre;";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado[Convert.ToInt32(reader["id"])] = reader["nombre"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el listado de cajeros: " + ex.Message);
            }

            return resultado;
        }

        // Cierra el turno: guarda lo declarado por el cajero, calcula la diferencia
        // y marca fecha_de_cierre. El WHERE incluye "fecha_de_cierre IS NULL" a
        // propósito, para que un doble clic (o dos ventanas del mismo turno) no
        // vuelva a cerrar -y sobreescribir- un corte que ya se cerró antes.
        public bool CerrarCorte(int idCorte, int idUsuario, decimal montoEsperado, decimal montoReal)
        {
            string query = @"
                UPDATE corte
                   SET fecha_de_cierre = @fecha_cierre,
                       monto_esperado  = @monto_esperado,
                       monto_real      = @monto_real,
                       diferencia      = @diferencia
                 WHERE id = @id_corte
                   AND id_usuario = @id_usuario
                   AND fecha_de_cierre IS NULL;";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@fecha_cierre", DateTime.Now);
                    cmd.Parameters.AddWithValue("@monto_esperado", montoEsperado);
                    cmd.Parameters.AddWithValue("@monto_real", montoReal);
                    cmd.Parameters.AddWithValue("@diferencia", montoReal - montoEsperado);
                    cmd.Parameters.AddWithValue("@id_corte", idCorte);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el cierre de caja: " + ex.Message);
            }
        }
        public DataTable ObtenerCajerosConTurnoAbierto()
        {
            DataTable dt = new DataTable();
            // CORRECCIÓN: Se agrega DISTINCT para evitar nombres duplicados
            string query = @"
        SELECT DISTINCT u.id, u.nombre
        FROM usuario u
        INNER JOIN corte c ON u.id = c.id_usuario
        WHERE c.fecha_de_cierre IS NULL";

            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cajeros con turno abierto: " + ex.Message);
            }
            return dt;
        }
    }

}