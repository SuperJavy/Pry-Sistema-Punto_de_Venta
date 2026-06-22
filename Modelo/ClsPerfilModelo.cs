using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System.Data;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsPerfilModelo : clsConexion
    {

        encryptado encryptador = new encryptado();
        public DataTable ObtenerPerfil(string usuario)
        {
            DataTable dtPerfil = new DataTable();
            try
            {
                clsConexion ConexionBd = new clsConexion();
                using (var conexion = ConexionBd.abrirConexion())
                {
                    string Query = "SELECT nombre, apellido_paterno, nickname, correo, telefono FROM usuario WHERE BINARY nickname = @usuario;";
                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        using (var resultado = consulta.ExecuteReader())
                        {

                            dtPerfil.Load(resultado);

                        }
                    }
                }
                return dtPerfil;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el perfil: " + ex.Message);
            }
        }

        public bool Actualizarpassword(string usuario, string nuevoPassword)
        {

            try
            {
                clsConexion ConexionBd = new clsConexion();
                using (var conexion = ConexionBd.abrirConexion())
                {
                    string pass= encryptador.EncryptPassword(nuevoPassword);
                    string Query = "UPDATE usuario SET password = @nuevoPassword WHERE nickname = @usuario;";
                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@nuevoPassword", pass);
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
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
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la contraseña: " + ex.Message);
            }
        }
    }
}