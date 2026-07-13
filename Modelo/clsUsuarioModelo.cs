using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsUsuarioModelo: ClsConexion
    {
        public bool registrarUsuario(string nombre, string apellidoP, string apellidoM, string nickname, string direcion, string telefono, string correo,string password, int id_rol)
        {
            string consulta = "insert into usuario (`nombre`, `apellido_paterno`, `apellido_materno`, `nickname`, `direccion`, `correo`,`telefono`, `password`, `Id_rol` ) VALUES (@nombre, @paterno, @materno, @nickname,@direccion, @correo ,@telefono, @password, @id_rol)";

            try
            {
                MySqlConnection con = abrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@paterno", apellidoP);
                    cmd.Parameters.AddWithValue("@materno", apellidoM);
                    cmd.Parameters.AddWithValue("@nickname", nickname);
                    cmd.Parameters.AddWithValue("@direccion", direcion);
                    cmd.Parameters.AddWithValue("@correo", correo);
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

            String consulta = "SELECT id, Rol FROM rol";

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
                throw new Exception("Error en Usuario: " + ex.Message);
            }
            finally { cerrarConexion(); }

        }
    }
}
