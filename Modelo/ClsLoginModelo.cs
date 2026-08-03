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
    internal class ClsLoginModelo:ClsConexion
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public  int UsuarioActual { get; set; }
        encryptado md5 = new encryptado();

        public Boolean validarusuario(string Nickname, string password)
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();

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

        // Agrega esto dentro de ClsLoginModelo.cs
        public bool ExisteCorreo(string correo)
        {
            string query = "SELECT COUNT(*) FROM usuario WHERE correo = @correo";
            using (var conexion = abrirConexion())
            {
                using (var consulta = new MySqlCommand(query, conexion))
                {
                    consulta.Parameters.AddWithValue("@correo", correo);
                    int count = Convert.ToInt32(consulta.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void GuardarTokenRecuperacion(string correo, string token, DateTime expiracion)
        {
            string query = "UPDATE usuario SET token_recuperacion = @token, fecha_expiracion_token = @expiracion WHERE correo = @correo";
            using (var conexion = abrirConexion())
            {
                using (var consulta = new MySqlCommand(query, conexion))
                {
                    consulta.Parameters.AddWithValue("@token", token);
                    consulta.Parameters.AddWithValue("@expiracion", expiracion);
                    consulta.Parameters.AddWithValue("@correo", correo);
                    consulta.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarYActualizarPassword(string correo, string tokenIngresado, string nuevaPassword)
        {
            // CAMBIO: Reemplazamos NOW() de MySQL por el parámetro @fechaActual de C#
            string queryValidacion = "SELECT COUNT(*) FROM usuario WHERE correo = @correo AND token_recuperacion = @token AND fecha_expiracion_token > @fechaActual";

            using (var conexion = abrirConexion())
            {
                using (var consulta = new MySqlCommand(queryValidacion, conexion))
                {
                    consulta.Parameters.AddWithValue("@correo", correo);
                    consulta.Parameters.AddWithValue("@token", tokenIngresado);
                    // Pasamos la hora exacta en la que se está haciendo clic en el botón
                    consulta.Parameters.AddWithValue("@fechaActual", DateTime.Now);

                    int valido = Convert.ToInt32(consulta.ExecuteScalar());

                    if (valido == 0) return false; // Token inválido o expirado
                }

                // Si es válido, actualizamos la contraseña y limpiamos el token
                string queryUpdate = "UPDATE usuario SET password = @password, token_recuperacion = NULL, fecha_expiracion_token = NULL WHERE correo = @correo";
                using (var updateCommand = new MySqlCommand(queryUpdate, conexion))
                {
                    string passEncriptada = md5.EncryptPassword(nuevaPassword);
                    updateCommand.Parameters.AddWithValue("@password", passEncriptada);
                    updateCommand.Parameters.AddWithValue("@correo", correo);
                    updateCommand.ExecuteNonQuery();
                }
                return true;
            }
        }
    }
}
