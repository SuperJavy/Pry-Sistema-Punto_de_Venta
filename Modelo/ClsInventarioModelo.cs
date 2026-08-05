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
        private static bool EsFiltroVacio(string categoriaId)
        {
            return string.IsNullOrEmpty(categoriaId) || categoriaId == "0";
        }
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
            bool sinFiltro = EsFiltroVacio(categoriaId);
            string filtro = sinFiltro ? "" : " WHERE p.id_categoria = @catId";


            string query = $@"
                SELECT 
                    IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS 'Código de Barras', 
                    p.nombre AS 'Producto', 
                    p.stock AS 'Stock Registrado', 
                    (IFNULL(compras.total, 0) - IFNULL(ventas.total, 0)) AS 'Stock Teórico',
                    (p.stock - (IFNULL(compras.total, 0) - IFNULL(ventas.total, 0))) AS 'Desfase',
                    p.costo AS 'Costo Unitario' 
                FROM productos p 
                LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                LEFT JOIN (
                    SELECT id_producto, SUM(cantidad) AS total
                    FROM detalle_compra
                    WHERE IFNULL(id_estado, 1) = 1
                    GROUP BY id_producto
                ) compras ON compras.id_producto = p.id
                LEFT JOIN (
                    SELECT id_producto, SUM(cantidad) AS total
                    FROM detalle_venta
                    WHERE IFNULL(id_estado, 1) = 1
                    GROUP BY id_producto
                ) ventas ON ventas.id_producto = p.id
                {filtro}";

            using (var conexion = abrirConexion())
            using (var cmd = new MySqlCommand(query, conexion))
            {
                if (!sinFiltro) cmd.Parameters.AddWithValue("@catId", categoriaId);
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
