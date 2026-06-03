using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsCategoriaModelo: clsConexion
    {
        public Boolean insertarCategoria(string nombreCategoria) 
        {
            String consulta = "INSERT INTO categoria (Nombre) value (@nombre)";

            try
            {
                MySqlConnection con = abrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, con)) 
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreCategoria);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" Error al guardar la categoria " + ex.Message);
            }
            finally 
            {
                cerrarConexion();     
            }
        }

    }
}
