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
    internal class ClsProductModelo : ClsConexion
    {

        ECodigodebarras codigob = new ECodigodebarras();
        //empieza codigo de regitrar productos
        public string codigodebarras()
        {
            try
            {
                return codigob.ObtenerNumeroUnicoEInexistente();
            }
            catch (Exception e)
            {
                throw new Exception("Error al extraer el código de barras: " + e.Message);
            }
        }
        public Image imgcodeb(string c)
        {
            try
            {
                return codigob.imgcodeb(c);
            }
            catch (Exception e)
            {
                throw new Exception("Error al extraer la imagen" + e.Message);
            }

        }
        public bool Comsultarcode(string code)
        {
            ClsConexion conexionBD = new ClsConexion();

            // Buscamos en AMBAS tablas para asegurar que el código no exista ni como generado ni como manual
            string Query = @"
            SELECT codigo FROM (
                SELECT Codigo_barras AS codigo FROM codigo_Barras
                UNION
                SELECT codigo_de_barras AS codigo FROM productos WHERE codigo_de_barras IS NOT NULL
            ) AS codigos_totales 
            WHERE codigo = @codigo LIMIT 1;";

            try
            {
                using (var conexion = conexionBD.abrirConexion())
                using (var consulta = new MySqlCommand(Query, conexion))
                {
                    consulta.Parameters.AddWithValue("@codigo", code);

                    using (var result = consulta.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            return true; // El código YA EXISTE en alguna de las dos tablas
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al consultar el código en la Base de Datos: " + e.Message);
            }

            return false; // El código está completamente libre
        }
        public bool InsercodeB(string code, Image img)
        {
            try
            {
                return codigob.insertarBD(code, img);

            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar en la Base de Datos " + e.Message);
            }
        }
        public Boolean Insertarproductos(string CodigoIngresado, string Nombre, string Descripciom, string TipVenta, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen)
        {
            try
            {
                ClsConexion ConexionBd = new ClsConexion();
                using (var Conexion = ConexionBd.abrirConexion())
                {
                    // 1. NUEVA BARRERA DE SEGURIDAD: Verificar si el código YA le pertenece a un producto existentee
                    string queryValidacion = @"
                        SELECT COUNT(*) FROM productos p
                        LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                        WHERE IFNULL(cb.Codigo_barras, p.codigo_de_barras) = @codigoValidacion";

                    using (var cmdVal = new MySqlCommand(queryValidacion, Conexion))
                    {
                        cmdVal.Parameters.AddWithValue("@codigoValidacion", CodigoIngresado);   
                        int enUso = Convert.ToInt32(cmdVal.ExecuteScalar());

                        if (enUso > 0)
                        {
                            // Si el código ya tiene dueño, forzamos un error.
                            // Esto enviará la señal al Controlador para que muestre el mensaje de "Producto Duplicado".
                            throw new Exception("El código de barras ya está asignado a otro producto.");
                        }
                    }

                    // 2. Lógica original: Buscar si el código viene del generador de Códigos de Barras
                    int idEncontrado = 0;
                    string queryBusqueda = "SELECT id FROM codigo_Barras WHERE Codigo_barras = @codigo";
                    using (var cmdBusqueda = new MySqlCommand(queryBusqueda, Conexion))
                    {
                        cmdBusqueda.Parameters.AddWithValue("@codigo", CodigoIngresado);
                        object resultado = cmdBusqueda.ExecuteScalar();
                        if (resultado != null)
                        {
                            idEncontrado = Convert.ToInt32(resultado);
                        }
                    }

                    // 3. Inserción del producto
                    string query = @"INSERT INTO productos 
                    (id_codigoBarras, codigo_de_barras, nombre, descripcion, id_tipo_venta, costo, precio_venta, id_categoria, stock, stock_minimo, ruta_imagen, porcentaje) 
                    VALUES 
                    (@Id_codigo_barras, @Codigo_de_barras, @nombre, @Descripcion, @Tipo_venta_id, 0, 0, @Categoria_id, @Stock, @Stock_minimo, @Ruta_imagen, 0)";

                    using (var Consulta = new MySqlCommand(query, Conexion))
                    {
                        if (idEncontrado > 0)
                        {
                            Consulta.Parameters.AddWithValue("@Id_codigo_barras", idEncontrado);
                            Consulta.Parameters.AddWithValue("@Codigo_de_barras", DBNull.Value);
                        }
                        else
                        {
                            Consulta.Parameters.AddWithValue("@Id_codigo_barras", DBNull.Value);
                            Consulta.Parameters.AddWithValue("@Codigo_de_barras", CodigoIngresado);
                        }

                        Consulta.Parameters.AddWithValue("@nombre", Nombre);
                        Consulta.Parameters.AddWithValue("@Descripcion", Descripciom);
                        Consulta.Parameters.AddWithValue("@Tipo_venta_id", int.Parse(TipVenta));
                        Consulta.Parameters.AddWithValue("@Categoria_id", int.Parse(Categoria));
                        Consulta.Parameters.AddWithValue("@Stock", int.Parse(Stockactuaal));
                        Consulta.Parameters.AddWithValue("@Stock_minimo", int.Parse(Stockminimo));
                        Consulta.Parameters.AddWithValue("@Ruta_imagen", imagenABytes(Imagen));

                        int filasAfectadas = Consulta.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (FormatException)
            {
                throw new Exception("Uno o más campos numéricos (tipo de venta, categoría, stock) tiene un formato inválido.");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al registrar productos: " + Ex.Message);
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
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                 
                    string Query = @"
                    SELECT p.codigo_de_barras, p.nombre, p.descripcion,
                           p.id_categoria, p.id_tipo_venta, p.costo, p.porcentaje,
                           p.precio_venta, p.stock, p.stock_minimo, p.Ruta_imagen,
                           IFNULL(cb.Codigo_barras, p.codigo_de_barras) AS codigo_efectivo
                    FROM productos p
                    LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                    WHERE IFNULL(cb.Codigo_barras, p.codigo_de_barras) = @Codigobarras AND (p.id_estado != 3 OR p.id_estado IS NULL)";
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
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                   
                    string Query = @"UPDATE productos p
                    LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                    SET p.nombre = @Nombre, p.Descripcion = @Descripcion, p.id_categoria = @Categoria_id,
                        p.id_tipo_venta = @Tipo_venta_id, p.costo = @Costo, p.porcentaje = @Porcentaje,
                        p.precio_venta = @Venta, p.stock = @Stock, p.stock_minimo = @Stock_minimo,
                        p.ruta_imagen = @Ruta_imagen
                    WHERE IFNULL(cb.Codigo_barras, p.codigo_de_barras) = @Codigo_de_barras";
                    using (var Consulta = new MySqlCommand(Query, conexion))
                    {
                        Consulta.Parameters.AddWithValue("@Codigo_de_barras", Codigo);
                        Consulta.Parameters.AddWithValue("@Nombre", Nombre);
                        Consulta.Parameters.AddWithValue("@Descripcion", Descripciom);
                        Consulta.Parameters.AddWithValue("@Tipo_venta_id", int.Parse(TipVenta));
                        Consulta.Parameters.AddWithValue("@Costo", float.Parse(Costo));//float
                        Consulta.Parameters.AddWithValue("@Venta", float.Parse(Precioventa));//float
                        Consulta.Parameters.AddWithValue("@Categoria_id", int.Parse(Categoria));
                        Consulta.Parameters.AddWithValue("@Stock", int.Parse(Stockactuaal));
                        Consulta.Parameters.AddWithValue("@Stock_minimo", int.Parse(Stockminimo));
                        Consulta.Parameters.AddWithValue("@Ruta_imagen", imagenABytes(Imagen));
                        Consulta.Parameters.AddWithValue("@Porcentaje", int.Parse(porcentaje));

                       
                        int filasAfectadas = Consulta.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }

            }
            catch (FormatException)
            {
                throw new Exception("Uno o más campos numéricos (costo, precio, porcentaje, stock) tiene un formato inválido.");
            }
            catch (Exception e)
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
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    string Query = @"UPDATE productos p
                        LEFT JOIN codigo_Barras cb ON p.id_codigoBarras = cb.id
                        SET p.id_estado = 3
                        WHERE IFNULL(cb.Codigo_barras, p.codigo_de_barras) = @Codigobarras";

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
                throw new Exception("Error al cambiar el estado del Producto: " + e.Message);
            }
        }

    }

}

