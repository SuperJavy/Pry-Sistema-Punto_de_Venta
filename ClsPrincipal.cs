using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta
{
    internal class ClsPrincipal
    {
        public void agregaralcontenedor(Form formulario, Panel panel)
        {
            //Verificar si el panel ya tiene un formulario
            if (panel.Tag != null)
            {
                Form formularioActual = (Form)panel.Tag;

                formularioActual.Close();
                formularioActual.Dispose();
            }

            //Limpiar panel
            panel.Controls.Clear();

            //Configurar formulario hijo
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            //Agregar formulario al panel
            panel.Controls.Add(formulario);

            //Guardar formulario en el Tag del panel
            panel.Tag = formulario;

            formulario.Show();
        }
    

    }
}
