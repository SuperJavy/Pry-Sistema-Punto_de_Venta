using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsLoginModelo:clsConexion
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public static int UsuarioActual { get; set; }


        public Boolean validarusuario(string Nickname, string password)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.abrirConexion())
                {

                    string query = "SELECT id, id_rol FROM usuario WHERE nickname = @Nickname AND password = @password";
                    using (var consulta = new MySqlCommand(query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@Nickname", Nickname);
                        consulta.Parameters.AddWithValue("@password", password);
                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                UsuarioActual = Convert.ToInt32(resultado["id"]);
                                this.Rol = resultado["id_rol"].ToString();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }
           
        }

        public bool Validarpassword(string passwordIngresado)
        {
            // Buscamos si existe CUALQUIER usuario con rol 1 y esa contraseña
            string query = "SELECT COUNT(*) FROM usuario WHERE id_rol = 1 AND password = @password";

            using (var conexion = abrirConexion())
            {
                using (var consulta = new MySqlCommand(query, conexion))
                {
                    consulta.Parameters.AddWithValue("@password", passwordIngresado);
                    int count = Convert.ToInt32(consulta.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
