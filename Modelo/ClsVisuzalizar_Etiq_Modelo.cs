using MySqlConnector;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
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

        ECodigodebarras codigob = new ECodigodebarras();
        public DataTable combobox()
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();
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
                ClsConexion conexionBD = new ClsConexion();
                DataTable dtOriginal = new DataTable();

                // 1. Extraemos los textos de la BD
                using (var conexion = conexionBD.abrirConexion())
                {
                    string Query = "SELECT codigo_barras FROM codigo_Barras WHERE id_estado = @id";
                    using (var consulta = new MySqlCommand(Query, conexion))
                    {
                        consulta.Parameters.AddWithValue("@id", id);
                        using (MySqlDataAdapter resultado = new MySqlDataAdapter(consulta))
                        {
                            resultado.Fill(dtOriginal);
                        }
                    }
                }

                // 2. Creamos un DataTable nuevo con las DOS columnas (Texto e Imagen)
                DataTable dtFinal = new DataTable();
                dtFinal.Columns.Add("codigo_barras", typeof(string));
                dtFinal.Columns.Add("imagen", typeof(Image)); // <-- ¡AQUÍ ESTABA EL FALTANTE!

                // 3. Leemos cada fila, dibujamos el código en RAM y lo agregamos
                foreach (DataRow row in dtOriginal.Rows)
                {
                    string codigo = row["codigo_barras"].ToString();

                    Image imgReal = imgcodeb(codigo);

                    dtFinal.Rows.Add(codigo, imgReal);
                }

                return dtFinal;
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
            ClsConexion conexionBD = new ClsConexion();
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
        public Image imgcodeb(string c)
        {
            try
            {
                return codigob.imgcodeb(c);
            }
            catch (Exception e)
            {
                throw new Exception("Error al extraer la imagen" + e.Message);
            }

        }
    }
}
