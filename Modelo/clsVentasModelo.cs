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
    internal class clsVentasModelo : clsConexion
    {
        
        public Producto buscarProducto(string codigo)
        {
            Producto producto = null;

            try
            {
                abrirConexion();
                string consulta = @"SELECT P.ID,
                        p.Codigo_de_barras,
                        p.nombre,
                        p.Venta AS Precio,
                        p.Stock,
                        p.Ruta_imagen AS Imagen,
                        p.Tipo_venta AS Tipo
                    FROM productos p
                    WHERE p.Codigo_de_barras = @codigo";


                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Producto
                    {
                        id_producto = Convert.ToInt32(dr["Id"]),
                        codigo_de_barras = dr["Codigo_de_barras"].ToString(),
                        nombre = dr["Nombre"].ToString(),
                        precio = Convert.ToDecimal(dr["Precio"]),
                        stock = Convert.ToDecimal(dr["stock"]),
                        imagen = dr["Imagen"].ToString(),
                        tipoVenta = dr["Tipo"].ToString()
                    };


                    
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto " + ex.Message);
            }
            finally {cerrarConexion();}

            return producto;
        }

        public List<Producto> buscarProductoAv(string filtro)
        {
            List<Producto> producto = new List<Producto>();

            try
            {
                abrirConexion();
                string consulta = @"SELECT p.ID,
                    p.Codigo_de_barras,
                    p.nombre,
                    p.Venta AS Precio,
                    p.Stock,
                    p.Ruta_imagen AS Imagen,
                    p.Tipo_venta AS Tipo
                FROM productos p
                WHERE p.nombre LIKE @filtro";

                using MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue ( "@filtro", "%" + filtro + "%");
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    producto.Add(
                        new Producto
                        {
                            id_producto = Convert.ToInt32(dr["ID"]),
                            codigo_de_barras = dr["Codigo_de_barras"].ToString(),
                            nombre = dr["Nombre"].ToString(),
                            precio = Convert.ToDecimal(dr["Precio"]),
                            stock = Convert.ToDecimal(dr["Stock"]),
                            imagen = dr["Imagen"].ToString(),
                            tipoVenta = dr["Tipo"].ToString()
                        }
                    );
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto " + ex.Message);
            }
            finally { cerrarConexion(); }
            return producto;
        }
        public bool ProcesarVenta(ventas venta) {

            using (MySqlConnection con = abrirConexion())
            {
                using (MySqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int idVenta = insertarVenta(venta, con,trans);

                        insertarDetalle(idVenta,venta.detalleVenta, con, trans);

                        actualizarStock(venta.detalleVenta, con, trans);

                        trans.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    { throw new Exception("Error al realizar el proscedimiento "+ex.Message); }
                }
            
            }
        
        }
        private int insertarVenta(ventas venta, MySqlConnection con, MySqlTransaction trans)
        {
      
            string query = @"
        INSERT INTO venta
        (
            Id_usuario,
            fecha,
            total,
            efectivo,
            cambio
        )
        VALUES
        (
            @id_usuario,
            @fecha_hora,
            @total,
            @efectivo,
            @cambio
        );

        SELECT LAST_INSERT_ID();";

            using (MySqlCommand cmd =
                new MySqlCommand(query, con, trans))
            {
                cmd.Parameters.AddWithValue(
                    "@id_usuario",
                    "1");

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

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }

        }
        private void insertarDetalle(int idVenta, List<detalleVenta> detalles, MySqlConnection con, MySqlTransaction trans)
        {
           
            string query = @"
        INSERT INTO detalle_venta
        (
            Id_venta,
            Id_producto,
            Cantidad,
            Precio_unitario,
            Subtotal
        )
        VALUES
        (
            @id_venta,
            @id_producto,
            @cantidad,
            @precio_unitario,
            @subtotal
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
