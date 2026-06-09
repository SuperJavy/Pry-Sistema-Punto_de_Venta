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
                string consulta = @"SELECT 
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

    }
}
