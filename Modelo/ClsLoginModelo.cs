using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsLoginModelo:clsConexion
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public static int UsuarioActual { get; set; }
        encryptado md5 = new encryptado();

        public Boolean validarusuario(string Nickname, string password)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.abrirConexion())
                {
                    string pass = md5.EncryptPassword(password); 
                    string query = "SELECT id, id_rol FROM usuario WHERE BINARY nickname = @Nickname AND BINARY password = @password";
                    using (var consulta = new MySqlCommand(query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@Nickname", Nickname);
                        consulta.Parameters.AddWithValue("@password", pass);
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
            string query = "SELECT COUNT(*) FROM usuario WHERE id_rol = 1 AND password = @password";

            using (var conexion = abrirConexion())
            {
                using (var consulta = new MySqlCommand(query, conexion))
                {
                    string pass = md5.EncryptPassword(passwordIngresado);
                    consulta.Parameters.AddWithValue("@password", pass);
                    int count = Convert.ToInt32(consulta.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
