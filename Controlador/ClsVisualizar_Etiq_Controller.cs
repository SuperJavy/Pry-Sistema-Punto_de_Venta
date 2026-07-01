using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsVisualizar_Etiq_Controller
    {
        ClsVisuzalizar_Etiq_Modelo modelo = new ClsVisuzalizar_Etiq_Modelo();

        public DataTable cargarcombobox(FrmVisualizar_Etiquetas vista)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = modelo.combobox();
            }
            catch (Exception ex)
            {
                {
                    vista.notificarUsuario("error en la conexion" + ex.Message, true);
                }
            }

            return dt;
        }

        public DataTable extraercode(int id, FrmVisualizar_Etiquetas vista)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = modelo.FiltrarDGV(id);

                if (dt == null || dt.Rows.Count == 0)
                {
                    vista.notificarUsuario("No se encontraron etiquetas para el filtro seleccionado.", false);
                }
            }
            catch (Exception ex)
            {
                // Le concatenamos el ex.Message por si necesitas rastrear si fue error de red, contraseña, etc.
                vista.notificarUsuario("Error al extraer de la BD: " + ex.Message, true);
            }

            return dt;
        }


        public void ProcesarImpresionUnica(DataGridViewCell celdaActual, FrmVisualizar_Etiquetas vista)
        {
            if (celdaActual == null)
            {
                vista.notificarUsuario("Por favor, selecciona un código de barras de la lista primero.", true);
                return;
            }

            DataGridViewRow fila = celdaActual.OwningRow;

            string codigo = fila.Cells["codigo_barras"].Value.ToString();
            Image img = null;

            // 🛠️ CONVERSIÓN SEGURA: De arreglo de bytes a objeto Image
            var valorCelda = fila.Cells["img_codigoDeBarras"].Value;
            if (valorCelda != DBNull.Value && valorCelda != null)
            {
                byte[] bytesImagen = (byte[])valorCelda;
                using (MemoryStream ms = new MemoryStream(bytesImagen))
                {
                    img = Image.FromStream(ms);
                }
            }

            // Enviamos los datos limpios a la simulación de la vista
            vista.EjecutarImpresionDirecta(codigo, img);
        }

        public void ProcesarImpresionPorLote(DataGridViewRowCollection filas, FrmVisualizar_Etiquetas vista)
        {
            if (filas.Count == 0)
            {
                vista.notificarUsuario("No hay etiquetas cargadas para mandar a imprimir.", true);
                return;
            }

            int totalEnviados = 0;

            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["codigo_barras"].Value != null)
                {
                    string codigo = fila.Cells["codigo_barras"].Value.ToString();
                    Image img = null;

                    // 🛠️ CONVERSIÓN SEGURA EN LOTE
                    var valorCelda = fila.Cells["img_codigoDeBarras"].Value;
                    if (valorCelda != DBNull.Value && valorCelda != null)
                    {
                        byte[] bytesImagen = (byte[])valorCelda;
                        using (MemoryStream ms = new MemoryStream(bytesImagen))
                        {
                            img = Image.FromStream(ms);
                        }
                    }

                    vista.EjecutarImpresionDirecta(codigo, img);
                    totalEnviados++;
                }
            }

            vista.notificarUsuario($"Simulación completada: Se procesaron {totalEnviados} etiquetas en lote.", false);
        }
    }
}

