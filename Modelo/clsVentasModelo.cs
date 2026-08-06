using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pry_Sistema_Punto_de_Venta.Modelo.Entidades.Producto;



namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsVentasModelo :  ClsConexion
    {

        public Producto buscarProducto(string codigo)
        {
            Producto producto = null;

            try
            {
                abrirConexion();

                // Consulta adaptada para buscar y devolver el código desde cualquiera de las dos tablas
                string consulta = @"
            SELECT p.id,
                   IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_de_barras,
                   p.nombre,
                   p.precio_venta AS precio,
                   p.stock,
                   p.ruta_imagen AS imagen,
                   t.nombre AS Tipo
            FROM productos p
            INNER JOIN tipo_venta t ON p.id_tipo_venta = t.id
            LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
            WHERE (p.codigo_de_barras = @codigo OR cb.Codigo_barras = @codigo) AND (p.id_estado != 3 OR p.id_estado IS NULL)";

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
                        precio = Convert.ToDecimal(dr["precio"]),
                        stock = Convert.ToDecimal(dr["stock"]),
                        tipoVenta = dr["Tipo"].ToString()
                    };

                    if (dr["imagen"] != DBNull.Value)
                    {
                        try
                        {
                            byte[] imagenBytes = (byte[])dr["imagen"];
                            producto.imagen = BytesAImagen(imagenBytes);
                        }
                        catch
                        {
                            producto.imagen = null;
                        }
                    }
                    else
                    {
                        producto.imagen = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return producto;
        }
        private Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                return new Bitmap(img); // Creamos un clon en memoria independiente del stream
            }
        }

        public List<Producto> buscarProductoAv(string filtro)
        {
            List<Producto> producto = new List<Producto>();

            try
            {
                abrirConexion();

                // 1. Agregamos IFNULL en el SELECT
                // 2. Agregamos la búsqueda por código en el WHERE
                string consulta = @"
                                SELECT p.id,
                           IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_de_barras,
                           p.nombre,
                           p.precio_venta AS Precio, 
                           p.stock,
                           p.ruta_imagen AS Imagen, 
                           t.nombre AS Tipo
                    FROM productos p
                    LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                    LEFT JOIN tipo_venta t ON p.id_tipo_venta = t.id
                    WHERE (p.nombre LIKE @filtro OR cb.Codigo_barras LIKE @filtro OR p.codigo_de_barras LIKE @filtro)
                      AND (p.id_estado != 3 OR p.id_estado IS NULL)";

                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Producto prodTemporal = new Producto
                    {
                        id_producto = Convert.ToInt32(dr["id"]),
                        // Ahora dr["codigo_de_barras"] siempre tendrá valor, nunca estará vacío
                        codigo_de_barras = dr["codigo_de_barras"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        precio = Convert.ToDecimal(dr["Precio"]),
                        stock = Convert.ToDecimal(dr["stock"]),
                        tipoVenta = dr["Tipo"].ToString()
                    };

                    if (dr["Imagen"] != DBNull.Value)
                    {
                        try
                        {
                            byte[] imagenBytes = (byte[])dr["Imagen"];
                            prodTemporal.imagen = BytesAImagen(imagenBytes);
                        }
                        catch
                        {
                            prodTemporal.imagen = null;
                        }
                    }
                    else
                    {
                        prodTemporal.imagen = null;
                    }

                    producto.Add(prodTemporal);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto " + ex.Message);
            }
            finally { cerrarConexion(); }

            return producto;
        }  
        public bool ProcesarVenta(ventas venta, List<detalleVenta> cancelados, int estado) {

            using (MySqlConnection con = abrirConexion())
            {
                using (MySqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int idVenta = insertarVenta(venta, con,trans, estado);
                        insertarDetalle(idVenta,venta.detalleVenta, con, trans, 1);
                        insertarDetalle(idVenta, cancelados, con, trans, 3);
                        actualizarStock(venta.detalleVenta, con, trans);

                        trans.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    { throw new Exception("Error al realizar el proscedimiento "+ex.Message); }
                }
            
            }
        
        }
        private int insertarVenta(ventas venta, MySqlConnection con, MySqlTransaction trans, int estado)
        {
      
            string query = @"
        INSERT INTO venta
        (
            id_usuario,
            fecha,
            total,
            efectivo,
            cambio,
            id_estado
        )
        VALUES
        (
            @id_usuario,
            @fecha_hora,
            @total,
            @efectivo,
            @cambio,
            @id_estado
        );

        SELECT LAST_INSERT_ID();";

            using (MySqlCommand cmd =
                new MySqlCommand(query, con, trans))
            {
                cmd.Parameters.AddWithValue(
                    "@id_usuario",
                    venta.IdUsuario);

                cmd.Parameters.AddWithValue(
                    "@fecha_hora",
                    venta.fecha);

                cmd.Parameters.AddWithValue(
                    "@total",
                    venta.total);

                cmd.Parameters.AddWithValue(
                    "@efectivo",
                    venta.efectivo);

                cmd.Parameters.AddWithValue(
                    "@cambio",
                    venta.cambio);
                cmd.Parameters.AddWithValue(
                    "@id_estado",
                    estado
                    );

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }

        }
        private void insertarDetalle(int idVenta, List<detalleVenta> detalles, MySqlConnection con, MySqlTransaction trans, int estado )
        {
           
            string query = @"
        INSERT INTO detalle_venta
        (
            id_venta,
            id_producto,
            cantidad,
            precio_unitario,
            subtotal,
            id_estado
        )
        VALUES
        (
            @id_venta,
            @id_producto,
            @cantidad,
            @precio_unitario,
            @subtotal,
            @id_estado
        )";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd =
                    new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue(
                        "@id_venta",
                        idVenta);

                    cmd.Parameters.AddWithValue(
                        "@id_producto",
                        item.Producto.id_producto);

                    cmd.Parameters.AddWithValue(
                        "@cantidad",
                        item.Cantidad);

                    cmd.Parameters.AddWithValue(
                        "@precio_unitario",
                        item.PrecioUnitario);

                    cmd.Parameters.AddWithValue(
                        "@subtotal",
                        item.Importe);
                    cmd.Parameters.AddWithValue(
                        "@id_estado",
                        estado
                        );

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void actualizarStock(List<detalleVenta> detalles, MySqlConnection con, MySqlTransaction trans)
        {
            string query = @"
            UPDATE productos
            SET stock = stock - @cantidad
            WHERE ID = @id_producto";

            foreach (var item in detalles)
            {
                using (MySqlCommand cmd =
                    new MySqlCommand(query, con, trans))
                {
                    cmd.Parameters.AddWithValue(
                        "@cantidad",
                        item.Cantidad);

                    cmd.Parameters.AddWithValue(
                        "@id_producto",
                        item.Producto.id_producto);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
