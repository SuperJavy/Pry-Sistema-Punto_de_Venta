using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsComprasModelo : clsConexion
    {

        public Producto buscarProducto(string codigo)
        {
            Producto producto = null;

            try
            {
                abrirConexion();
                string consulta = @"SELECT p.id,
                        p.codigo_de_barras,
                        p.nombre,
                        p.costo AS Costo,
                        p.stock,
                        p.ruta_imagen AS imagen,
                        p.id_tipo_venta AS Tipo
                    FROM productos p
                    WHERE p.codigo_de_barras = @codigo";


                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Producto
                    {
                        id_producto = Convert.ToInt32(dr["id"]),
                        codigo_de_barras = dr["codigo_de_barras"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        precio_compra = Convert.ToDecimal(dr["Costo"]),
                        stock = Convert.ToDecimal(dr["stock"]),
                        imagen = dr["imagen"].ToString(),
                        tipoVenta = dr["Tipo"].ToString()
                    };

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto " + ex.Message);
            }
            finally { cerrarConexion(); }

            return producto;
        }
        public bool procesarCompra(Compra compra)
        {
            using (MySqlConnection con = abrirConexion())
            {
                using (MySqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int idCompra = insertarCompra(compra, con, trans);
               
                        insertarDetalleCompra(idCompra, compra.detalleCompra, con, trans);
          
                        actualizarStockCompra(compra.detalleCompra, con, trans);

                        
                        trans.Commit();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar compra "+ex.Message);
                    }
                }
            
            }
        
        }

        private int insertarCompra(Compra compra, MySqlConnection con, MySqlTransaction trans)
        {
            string query = @"
                INSERT INTO compra     
                (         
                    id_usuario,
                    id_proveedor,
                    fecha_de_compra,         
                    total                  
                         
                )     
                VALUES     
                (         
                    @id_usuario,
                    @id_proveedor,
                    @fecha,         
                    @total                 
                         
                );     
                SELECT LAST_INSERT_ID();";

            using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
            {
                cmd.Parameters.AddWithValue("@id_usuario", compra.IdUsuario);
                cmd.Parameters.AddWithValue("@fecha", compra.fecha);
                cmd.Parameters.AddWithValue("@total", compra.total);

                cmd.Parameters.AddWithValue("@id_proveedor", 1);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void insertarDetalleCompra(int idCompra, List<DetalleCompra> detalles, MySqlConnection con, MySqlTransaction trans)
        {
            string query = @"
                INSERT INTO detalle_compra     
                (         
                    id_compra,         
                    id_producto,
                    precio,
                    cantidad,                  
                    subtotal     
                )     
                VALUES     
                (         
                    @id_compra,         
                    @id_producto,
                    @costo_unitario,
                    @cantidad,                  
                    @subtotal     
                )";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue("@id_compra", idCompra);
                    cmd.Parameters.AddWithValue("@id_producto", item.producto.id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.Parameters.AddWithValue("@costo_unitario", item.precioCompra);
                    cmd.Parameters.AddWithValue("@subtotal", item.cantidad * item.subtotalCompra);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void actualizarStockCompra(List<DetalleCompra> detalles, MySqlConnection con, MySqlTransaction trans)
        {
   
            string query = @"
                UPDATE productos         
                SET stock = stock + @cantidad,
                    costo = @nuevo_costo
                WHERE ID = @id_producto";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.Parameters.AddWithValue("@nuevo_costo", item.precioCompra);
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
                string consulta = @"
            SELECT 
                p.id,             
                p.codigo_de_barras,             
                p.nombre,             
                p.costo AS Costo,             
                p.stock,             
                p.ruta_imagen AS Imagen,             
                p.id_tipo_venta AS Tipo         
            FROM productos p         
            WHERE p.nombre LIKE @filtro OR p.codigo_de_barras LIKE @filtro";

                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                // Es buena práctica poner el DataReader dentro de un using para liberar memoria
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
                            stock = Convert.ToDecimal(dr["stock"]),
                            imagen = dr["Imagen"].ToString(),
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
