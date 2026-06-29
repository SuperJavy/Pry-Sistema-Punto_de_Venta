using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    }
}
