using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsComprasModelo : ClsConexion
    {
        private const int ID_PROVEEDOR_TEMPORAL = 1;
        public Producto buscarProducto(string codigo)
        {
            Producto producto = null;
            try
            {
                abrirConexion();
                // Se agregó p.porcentaje a la consulta
                string consulta = @"
            SELECT p.id,
                   IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_de_barras,
                   p.nombre,
                   p.costo AS Costo,
                   IFNULL(p.porcentaje, 0) AS Porcentaje,
                   p.stock,
                   t.nombre AS Tipo
            FROM productos p
            LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
            LEFT JOIN tipo_venta t ON p.id_tipo_venta = t.id
            WHERE p.codigo_de_barras = @codigo OR cb.Codigo_barras = @codigo";

                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                using MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Producto
                    {
                        id_producto = Convert.ToInt32(dr["id"]),
                        codigo_de_barras = dr["codigo_de_barras"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        precio_compra = Convert.ToDecimal(dr["Costo"]),
                        porcentaje = Convert.ToDecimal(dr["Porcentaje"]), // Recuperamos el margen
                        stock = Convert.ToDecimal(dr["stock"]),
                        tipoVenta = dr["Tipo"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto " + ex.Message, ex);
            }
            finally { cerrarConexion(); }

            return producto;
        }
        public bool procesarCompra(Compra compra, List<DetalleCompra> cancelados, int estado)
        {
            // Quitamos el 'using' para no destruir la conexión global de la clase
            abrirConexion();
            try
            {
                using (MySqlTransaction trans = conexion.BeginTransaction())
                {

                    try
                    {
                        int idCompra = insertarCompra(compra, conexion, trans, estado);
                        compra.IdCompra = idCompra;
                        // Validamos que la lista no sea nula antes de intentar iterarla
                        if (compra.detalleCompra != null && compra.detalleCompra.Count > 0)
                        {
                            insertarDetalleCompra(idCompra, compra.detalleCompra, conexion, trans, 1);
                            actualizarStockCompra(compra.detalleCompra, conexion, trans);
                        }

                        // Validamos que los cancelados existan para no romper la transacción
                        if (cancelados != null && cancelados.Count > 0)
                        {
                            insertarDetalleCompra(idCompra, cancelados, conexion, trans, 3);
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Forzamos el Rollback explícito si algo falla
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {
                            // Si el propio Rollback falla, priorizamos reportar la
                            // excepción original en vez de ocultarla con esta.
                        }
                        throw new Exception("Error al guardar compra: " + ex.Message, ex);
                    }
                }


            }
            finally
            {
                cerrarConexion();
            }
        }

        private int insertarCompra(Compra compra, MySqlConnection con, MySqlTransaction trans, int estado)
        {
            string query = @"
                INSERT INTO compra     
                (         
                    id_usuario,
                    id_proveedor,
                    fecha_de_compra,         
                    total,
                    id_estado
                         
                )     
                VALUES     
                (         
                    @id_usuario,
                    @id_proveedor,
                    @fecha,         
                    @total,
                    @id_estado
                         
                );     
                SELECT LAST_INSERT_ID();";

            using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
            {
                cmd.Parameters.AddWithValue("@id_usuario", compra.IdUsuario);
                cmd.Parameters.AddWithValue("@fecha", compra.fecha);
                cmd.Parameters.AddWithValue("@total", compra.total);

                cmd.Parameters.AddWithValue("@id_proveedor", 1);
                cmd.Parameters.AddWithValue("@id_estado", estado);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void insertarDetalleCompra(int idCompra, List<DetalleCompra> detalles, MySqlConnection con, MySqlTransaction trans, int estado)
        {
            string query = @"
        INSERT INTO detalle_compra     
        (         
            id_compra,         
            id_producto,
            precio,
            cantidad,                  
            subtotal,
            id_estado
        )     
        VALUES     
        (         
            @id_compra,         
            @id_producto,
            @costo_unitario,
            @cantidad,                  
            @subtotal,
            @id_estado
        )";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue("@id_compra", idCompra);
                    cmd.Parameters.AddWithValue("@id_producto", item.producto.id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.Parameters.AddWithValue("@costo_unitario", item.precioCompra);

                    // CORRECCIÓN: Si subtotalCompra ya es el total calculado, pásalo directamente. 
                    // Si no lo es, cambialo a: item.cantidad * item.precioCompra
                    cmd.Parameters.AddWithValue("@subtotal", item.subtotalCompra);

                    cmd.Parameters.AddWithValue("@id_estado", estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void actualizarStockCompra(List<DetalleCompra> detalles, MySqlConnection con, MySqlTransaction trans)
        {

            string query = @"
                            UPDATE productos         
                            SET stock = stock + @cantidad,
                                costo = @nuevo_costo,
                                porcentaje = @porcentaje,
                                precio_venta = @nuevo_costo + (@nuevo_costo * (@porcentaje / 100))
                            WHERE ID = @id_producto";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.Parameters.AddWithValue("@nuevo_costo", item.precioCompra);
                    cmd.Parameters.AddWithValue("@porcentaje", item.porcentajeGanancia);
                    cmd.Parameters.AddWithValue("@id_producto", item.producto.id_producto);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> busquedaAvanzada(string filtro)
        {
            List<Producto> producto = new List<Producto>();

            try
            {
                abrirConexion();
                // CORRECCIÓN: Se agregó IFNULL(p.porcentaje, 0) AS Porcentaje a la consulta SQL
                string consulta = @"
            SELECT p.id,
                   IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_de_barras,
                   p.nombre,
                   p.costo AS Costo,
                   IFNULL(p.porcentaje, 0) AS Porcentaje,
                   p.stock,                          
                   t.nombre AS Tipo         
            FROM productos p
            LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
            LEFT JOIN tipo_venta t ON p.id_tipo_venta = t.id
            WHERE p.nombre LIKE @filtro 
               OR cb.Codigo_barras LIKE @filtro 
               OR p.codigo_de_barras LIKE @filtro";

                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                using MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    producto.Add(
                        new Producto
                        {
                            id_producto = Convert.ToInt32(dr["id"]),
                            codigo_de_barras = dr["codigo_de_barras"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            precio_compra = Convert.ToDecimal(dr["Costo"]),

                            // CORRECCIÓN: Se lee el dato extraído de la base de datos y se asigna al objeto
                            porcentaje = Convert.ToDecimal(dr["Porcentaje"]),

                            stock = Convert.ToDecimal(dr["stock"]),
                            tipoVenta = dr["Tipo"].ToString()
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto para compra: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return producto;
        }
    }
}
