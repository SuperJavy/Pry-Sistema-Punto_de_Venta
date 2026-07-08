using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //...................................

        // Asegúrate de que el método en tu Controlador tenga exactamente estos 3 argumentos en el paréntesis:
        // 1. IMPRIMIR UNA SOLA FILA SELECCIONADA
        public void ProcesarImpresionUnica(DataGridViewCell celdaActual, int idEstadoActual, FrmVisualizar_Etiquetas vista)
        {
            DataGridViewRow fila = celdaActual.OwningRow;

           
            string codigo = fila.Cells["Codigo_barras"].Value.ToString();
            Image imagenCodigo = modelo.imgcodeb(codigo);
            // 1. Mandas a imprimir
            vista.EjecutarImpresionDirecta(codigo, imagenCodigo);

            modelo.ActualizarEstadoEtiqueta(codigo, 1);

            // 3. Refrescas la tabla con el método de tu vista
            vista.CargarDGV(idEstadoActual);
        }

        // 2. IMPRIMIR TODAS LAS FILAS DE LA TABLA (POR LOTE)
        public void ProcesarImpresionPorLote(DataGridViewRowCollection filas, int idEstadoActual, FrmVisualizar_Etiquetas vista)
        {
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Codigo_barras"].Value != null)
                {
                    string codigo = fila.Cells["Codigo_barras"].Value.ToString();

                    Image imagenCodigo = modelo.imgcodeb(codigo);
                    // Imprime cada una
                    vista.EjecutarImpresionDirecta(codigo, imagenCodigo);

                    // Actualiza cada una a estado 1 (Completado) usando tu variable 'modelo'
                    modelo.ActualizarEstadoEtiqueta(codigo, 1);
                }
            }

            // Al terminar el bucle, refrescas la pantalla una sola vez
            vista.CargarDGV(idEstadoActual);
        }
    }
}

