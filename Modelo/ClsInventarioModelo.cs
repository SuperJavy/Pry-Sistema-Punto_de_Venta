using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsInventarioModelo:clsConexion
    {
        public DataTable ObtenerProductosBajos()
        {
            DataTable dt = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    // Filtramos los productos con stock crítico
                    string query = "SELECT p.codigo_de_barras,p.nombre,p.stock,p.stock_minimo,c.nombre AS categoria " +
                        "FROM productos p INNER JOIN categoria c ON p.id_categoria = c.id WHERE p.stock <= p.stock_minimo;";
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
            // La consulta se mantiene limpia y orientada a datos
            string filtro = (string.IsNullOrEmpty(categoriaId) || categoriaId == "0")
                            ? "" : " WHERE id_categoria = @catId";

            string query = $@"SELECT IFNULL(SUM(costo * stock), 0) AS TotalCosto, 
                             IFNULL(SUM(stock), 0) AS TotalCantidad 
                      FROM productos {filtro}";

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

                clsConexion conexionBD = new clsConexion();
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
                throw new Exception("Error al extraer Categorias" + e.Message);
            }
        }

        public DataTable ObtenerDetalleProductos(string categoriaId)
        {
            DataTable dt = new DataTable();
            string filtro = (categoriaId == "0") ? "" : " WHERE id_categoria = @catId";

            // Usamos ALIAS para definir cómo se llamarán las columnas en el Grid
            string query = $@"SELECT 
                        codigo_de_barras AS 'Código de Barras', 
                        nombre AS 'Producto', 
                        stock AS 'Existencias', 
                        costo AS 'Costo Unitario' 
                      FROM productos {filtro}";

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
