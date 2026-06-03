using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsUsuarioModelo: clsConexion
    {
        public bool registrarUsuario(string nombre, string apellidoP, string apellidoM, string direcion, string telefono, string password, int id_rol)
        {
            string consulta = "insert into usuario (`nombre`, `Apellido_paterno`, `apellido_materno`, `direccion`, `telefono`, `password`, `ID_rol` )value(@nombre, @paterno, @materno, @direccion, @telefono, @password, @id_rol)";

            try
            {
                MySqlConnection con = abrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@paterno", apellidoP);
                    cmd.Parameters.AddWithValue("@materno", apellidoM);
                    cmd.Parameters.AddWithValue("@direccion", direcion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@id_rol", id_rol); 

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error en UsuarioDAO: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }
        public DataTable obtenerRoles()
        { 
            DataTable dt = new DataTable();
            string consulta = "SELECT ID_rol, nombre_rol FROM rol";
            try
            {
                MySqlConnection con = abrirConexion();
                
                    using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                return dt;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener roles: " + ex.Message);
            }
            finally { cerrarConexion(); }

        }

    }
}
