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


        public Boolean validarusuario(string Nombre, string password)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.abrirConexion())
                {
                    string query = "SELECT ID_rol FROM usuario WHERE Nombre = @Nombre AND password = @password";
                    using (var consulta = new MySqlCommand(query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@Nombre", Nombre);
                        consulta.Parameters.AddWithValue("@password", password);
                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                this.Rol = resultado["ID_rol"].ToString();
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
            finally
            {
                cerrarConexion();
            }
        }
    }
}
