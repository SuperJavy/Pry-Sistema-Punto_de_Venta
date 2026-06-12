using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsProductModelo : clsConexion
    {
        //empieza codigo de regitrar productos
        public Boolean Insertarproductos(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen, string porcentaje)
        {
            try
            {
                clsConexion ConexionBd = new clsConexion();
                using (var Conexion = ConexionBd.abrirConexion())
                {
                    string query = @"INSERT INTO Productos
                                (Codigo_de_barras, nombre, Descripcion, Tipo_venta_id, Costo, Venta, Categoria_id, Stock, Stock_minimo, Ruta_imagen, Porcentaje)
                                VALUES
                                (@Codigo_de_barras, @nombre, @Descripcion, @Tipo_venta_id, @Costo, @Venta, @Categoria_id, @Stock, @Stock_minimo, @Ruta_imagen, @Porcentaje)";
                    using (var Consulta = new MySqlCommand(query, Conexion))
                    {
                        Consulta.Parameters.AddWithValue("@Codigo_de_barras", Codigo);
                        Consulta.Parameters.AddWithValue("@nombre", Nombre);
                        Consulta.Parameters.AddWithValue("@Descripcion", Descripciom);
                        Consulta.Parameters.AddWithValue("@Tipo_venta_id", int.Parse(TipVenta));
                        Consulta.Parameters.AddWithValue("@Costo", float.Parse(Costo));//float
                        Consulta.Parameters.AddWithValue("@Venta", float.Parse(Precioventa));//float
                        Consulta.Parameters.AddWithValue("@Categoria_id", int.Parse(Categoria));
                        Consulta.Parameters.AddWithValue("@Stock", int.Parse(Stockactuaal));
                        Consulta.Parameters.AddWithValue("@Stock_minimo", int.Parse(Stockminimo));
                        Consulta.Parameters.AddWithValue("@Ruta_imagen", imagenABytes(Imagen));
                        Consulta.Parameters.AddWithValue("@Porcentaje", int.Parse(porcentaje));

                        using (var resultad = Consulta.ExecuteReader())
                        {
                            if (resultad.Read())
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }

                    }
                }
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al registrar productos" + Ex.Message);
            }
        }
        // Convertidores útiles (Imágenes <--> Bytes)
        private byte[] imagenABytes(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }


        public float Calpventa(string costo, string porcentaje)
        {
            float c = float.Parse(costo);
            float p = int.Parse(porcentaje);

            return c + (c * p / 100);
        }

        public DataTable Extraercategoria()
        {
            DataTable dt = new DataTable();
            try
            {

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    string query = "SELECT Id,Nombre FROM categoria";
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
        //termina codigo de resgitrar productos

        //comienza codigo de actualiza

        public DataTable Buscarproduct(string codigobarras)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {

                    string Query = "SELECT  Codigo_de_barras, nombre, Descripcion," +
                        " Categoria_id, Tipo_venta_id, Costo, Porcentaje," +
                        " Venta, Stock,Stock_minimo,Ruta_imagen FROM productos WHERE Codigo_de_barras = @Codigobarras";
                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@Codigobarras", codigobarras);
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
                throw new Exception("Error extraer Producto" + e.Message);
            }
        }
        public Boolean Actualizarproductos(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen, string porcentaje)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using(var conexion = conexionBD.abrirConexion())
                {
                    string Query = "UPDATE productos SET nombre = @Nombre,Descripcion = @Descripcion,Categoria_id = @Categoria_id," +
                        "Tipo_venta_id = @Tipo_venta_id,Costo = @Costo,Porcentaje = @Porcentaje," +
                        "Venta = @Venta,Stock = @Stock,Stock_minimo = @Stock_minimo,Ruta_imagen = @Ruta_imagen WHERE Codigo_de_barras = @Codigo_de_barras";
                    using (var Consulta = new MySqlCommand(Query,conexion))
                    {
                        Consulta.Parameters.AddWithValue("@Codigo_de_barras", Codigo);
                        Consulta.Parameters.AddWithValue("@nombre", Nombre);
                        Consulta.Parameters.AddWithValue("@Descripcion", Descripciom);
                        Consulta.Parameters.AddWithValue("@Tipo_venta_id", int.Parse(TipVenta));
                        Consulta.Parameters.AddWithValue("@Costo", float.Parse(Costo));//float
                        Consulta.Parameters.AddWithValue("@Venta", float.Parse(Precioventa));//float
                        Consulta.Parameters.AddWithValue("@Categoria_id", int.Parse(Categoria));
                        Consulta.Parameters.AddWithValue("@Stock", int.Parse(Stockactuaal));
                        Consulta.Parameters.AddWithValue("@Stock_minimo", int.Parse(Stockminimo));
                        Consulta.Parameters.AddWithValue("@Ruta_imagen", imagenABytes(Imagen));
                        Consulta.Parameters.AddWithValue("@Porcentaje", int.Parse(porcentaje));

                        using (var resultad = Consulta.ExecuteReader())
                        {
                            if (resultad.Read())
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }

                    }
                }

            }
            catch(Exception e)
            {
                throw new Exception("Error al Actualizar productos" + e.Message);
            }

        }
        //termina codigo de actualizar 


        //empieza codigo de eliminar...
        public Boolean EliminarProducto(string codigobarras)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                  
                    string Query = "DELETE FROM productos WHERE Codigo_de_barras = @Codigobarras";

                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@Codigobarras", codigobarras);

                        int filasAfectadas = consulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Producto: " + e.Message);
            }
        }


    }
}
