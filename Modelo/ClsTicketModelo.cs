using System;
using System.Drawing;
using System.IO;
using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Controlador;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    public class clsTicketModelo : ClsConexion
    {
        public Image Logo { get; set; }

        // Esta nueva propiedad guarda el texto que va a la Base de Datos
        public string NombreArchivoLogo { get; set; }

        public string NombreNegocio { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string RFC { get; set; }
        public string MensajeFinal { get; set; }

        public bool guardarConfiguracion(clsTicketModelo datosTicket)
        {
            // Usamos COALESCE como truco: si mandamos NULL en el logo, conserva el que ya tenía
            string consulta = @"INSERT INTO configuracion_ticket (id, logo, nombre, telefono, direccion, rfc, mensaje_final) 
                        VALUES (1, @logo, @nombre, @telefono, @direccion, @rfc, @mensaje)
                        ON DUPLICATE KEY UPDATE 
                        logo = COALESCE(@logo, logo), nombre = @nombre, telefono = @telefono, 
                        direccion = @direccion, rfc = @rfc, mensaje_final = @mensaje";

            try
            {
                using (MySqlConnection con = abrirConexion())
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    if (string.IsNullOrEmpty(datosTicket.NombreArchivoLogo))
                        cmd.Parameters.AddWithValue("@logo", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@logo", datosTicket.NombreArchivoLogo);

                    cmd.Parameters.AddWithValue("@nombre", datosTicket.NombreNegocio);
                    cmd.Parameters.AddWithValue("@telefono", datosTicket.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", datosTicket.Direccion);
                    cmd.Parameters.AddWithValue("@rfc", datosTicket.RFC);
                    cmd.Parameters.AddWithValue("@mensaje", datosTicket.MensajeFinal);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la configuración del ticket: " + ex.Message);
            }
        }

        public clsTicketModelo obtenerConfiguracion()
        {
            string consulta = "SELECT logo, nombre, telefono, direccion, rfc, mensaje_final FROM configuracion_ticket WHERE id = 1";
            try
            {
                using (MySqlConnection con = abrirConexion())
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            clsTicketModelo config = new clsTicketModelo
                            {
                                NombreNegocio = dr["nombre"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Direccion = dr["direccion"].ToString(),
                                RFC = dr["rfc"].ToString(),
                                MensajeFinal = dr["mensaje_final"].ToString()
                            };

                            // LÓGICA NUEVA: Extraemos con el Gestor Central
                            if (dr["logo"] != DBNull.Value && !string.IsNullOrWhiteSpace(dr["logo"].ToString()))
                            {
                                string nombreArchivo = dr["logo"].ToString();
                                config.Logo = ClsGestorArchivos.ExtraerImagen(@"Logos\", nombreArchivo);
                            }
                            else
                            {
                                config.Logo = null;
                            }

                            return config;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la configuración del ticket: " + ex.Message);
            }
        }
    }
}    
