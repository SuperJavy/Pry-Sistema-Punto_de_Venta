using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsInventarioModelo : ClsConexion
    {
        public DataTable ObtenerProductosBajos()
        {
            DataTable dt = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    string query = @"
                        SELECT IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_de_barras,
                               p.nombre,
                               p.stock,
                               p.stock_minimo,
                               c.nombre AS categoria 
                        FROM productos p 
                        INNER JOIN categoria c ON p.id_categoria = c.id 
                        LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                        WHERE p.stock <= p.stock_minimo;";
                    using (var consulta = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter respuesta = new MySqlDataAdapter(consulta))
                        {
                            respuesta.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error al consultar productos bajos: " + e.Message);
            }
        }

        public DataTable ObtenerEstadisticas(string categoriaId)
        {
            DataTable dt = new DataTable();
            string filtro = (string.IsNullOrEmpty(categoriaId) || categoriaId == "0")
                    ? "" : " WHERE p.id_categoria = @catId";

            string query = $@"
                SELECT IFNULL(SUM(p.costo * p.stock), 0) AS TotalCosto, 
                       IFNULL(COUNT(p.id), 0) AS TotalCantidad 
                FROM productos p 
                {filtro}";
            using (var conexion = abrirConexion())
            using (var cmd = new MySqlCommand(query, conexion))
            {
                if (!string.IsNullOrEmpty(filtro))
                    cmd.Parameters.AddWithValue("@catId", categoriaId);

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable Extraercategoria()
        {
            DataTable dt = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    string query = "SELECT id,nombre FROM categoria";
                    using (var Consulta = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter respuest = new MySqlDataAdapter(Consulta))
                        {
                            respuest.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error al extraer Categorias: " + e.Message);
            }
        }

        // MÉTODO DE AUDITORÍA: Calcula Stock Teórico y Desfase mediante el historial puro de base de datos
        public DataTable ObtenerDetalleProductosConAuditoria(string categoriaId)
        {
            DataTable dt = new DataTable();
            string filtro = (categoriaId == "0") ? "" : " WHERE p.id_categoria = @catId";

            string query = $@"
                SELECT 
                    IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS 'Código de Barras', 
                    p.nombre AS 'Producto', 
                    p.stock AS 'Stock Registrado', 
                    
                    -- Stock Teórico (Historial de Compras menos Ventas)
                    (
                        COALESCE((SELECT SUM(dc.cantidad) FROM detalle_compra dc WHERE dc.id_producto = p.id AND IFNULL(dc.id_estado, 1) = 1), 0) 
                        - 
                        COALESCE((SELECT SUM(dv.cantidad) FROM detalle_venta dv WHERE dv.id_producto = p.id AND IFNULL(dv.id_estado, 1) = 1), 0)
                    ) AS 'Stock Teórico',
                    
                    -- Desfase (Diferencia entre lo registrado en BD y el cálculo matemático)
                    p.stock - (
                        COALESCE((SELECT SUM(dc.cantidad) FROM detalle_compra dc WHERE dc.id_producto = p.id AND IFNULL(dc.id_estado, 1) = 1), 0) 
                        - 
                        COALESCE((SELECT SUM(dv.cantidad) FROM detalle_venta dv WHERE dv.id_producto = p.id AND IFNULL(dv.id_estado, 1) = 1), 0)
                    ) AS 'Desfase',
                    
                    p.costo AS 'Costo Unitario' 
                FROM productos p 
                LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                {filtro}";

            using (var conexion = abrirConexion())
            using (var cmd = new MySqlCommand(query, conexion))
            {
                if (categoriaId != "0") cmd.Parameters.AddWithValue("@catId", categoriaId);
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
