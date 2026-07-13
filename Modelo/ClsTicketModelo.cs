using System;
using System.Drawing;
using System.IO;
using MySqlConnector;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsTicketModelo : ClsConexion
    {
        // Propiedades para mover los datos
        public Image Logo { get; set; }
        public string NombreNegocio { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string RFC { get; set; }
        public string MensajeFinal { get; set; }

        // Método para INSERTAR o ACTUALIZAR en la Base de Datos
        public bool guardarConfiguracion(clsTicketModelo datosTicket)
        {
            string consulta = @"INSERT INTO configuracion_ticket (id, logo, nombre, telefono, direccion, rfc, mensaje_final) 
                        VALUES (1, @logo, @nombre, @telefono, @direccion, @rfc, @mensaje)
                        ON DUPLICATE KEY UPDATE 
                        logo = @logo, nombre = @nombre, telefono = @telefono, 
                        direccion = @direccion, rfc = @rfc, mensaje_final = @mensaje";
            ;

            try
            {
                MySqlConnection con = abrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@logo", imagenABytes(datosTicket.Logo));
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
            finally
            {
                cerrarConexion();
            }
        }

        // Método para CONSULTAR los datos guardados
        public clsTicketModelo obtenerConfiguracion()
        {
            string consulta = "SELECT logo, nombre, telefono, direccion, rfc, mensaje_final FROM configuracion_ticket WHERE id = 1";
            try
            {
                MySqlConnection con = abrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            clsTicketModelo config = new clsTicketModelo();
                            config.NombreNegocio = dr["nombre"].ToString();
                            config.Telefono = dr["telefono"].ToString();
                            config.Direccion = dr["direccion"].ToString();
                            config.RFC = dr["rfc"].ToString();
                            config.MensajeFinal = dr["mensaje_final"].ToString();

                            if (dr["logo"] != DBNull.Value)
                            {
                                config.Logo = bytesAImagen((byte[])dr["logo"]);
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
            finally
            {
                cerrarConexion();
            }
        }

        // Convertidores útiles (Imágenes <--> Bytes)
        private byte[] imagenABytes(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image bytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}    
