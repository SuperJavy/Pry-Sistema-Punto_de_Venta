using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsVisuzalizar_Etiq_Modelo
    {
        public DataTable combobox()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                DataTable dt = new DataTable();

                using (var conexion = conexionBD.abrirConexion())
                {
                    string Query = "SELECT id,estado FROM estado WHERE estado != 'cancelada'";

                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        using (MySqlDataAdapter respuesta = new MySqlDataAdapter(consulta))
                        {
                            respuesta.Fill(dt);
                        }
                    }

                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta"+ ex.Message);
            }
        }

        public DataTable FiltrarDGV(int id)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                DataTable dt = new DataTable();

                using (var conexion = conexionBD.abrirConexion())
                {
                    string Query = "SELECT codigo_barras, img_codigoDeBarras FROM codigo_Barras WHERE id_estado = @id";
                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@id",id);

                        using (MySqlDataAdapter resultado = new MySqlDataAdapter(consulta))
                        {
                            resultado.Fill(dt);
                        }
                    }
                }
                return dt;

            }
            catch (Exception e)
            {
                throw new Exception("Error en la consulta " + e.Message);
            }

          
        }

        //empieza codigo de  eiquetas campos de estado
        public void ActualizarEstadoEtiqueta(string codigo, int nuevoEstado)
        {
            // El QUERY directo y sin rodeos
            string query = "UPDATE codigo_Barras SET id_estado = @nuevoEstado WHERE Codigo_barras = @codigo;";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.abrirConexion())
                {

                    using (MySqlCommand consulta = new MySqlCommand(query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        consulta.Parameters.AddWithValue("@codigo", codigo);

                        consulta.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores simple en consola para no interrumpir el flujo
                Console.WriteLine("Error al actualizar estado: " + ex.Message);
            }
        }
    }
}
