using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class clsCategoriasController
    {
        clsCategoriaModelo categoria = new clsCategoriaModelo();

        public void agregarCategoria(string nombreCategoria) 
        {
            if (nombreCategoria == null)
            {
                MessageBox.Show("El nombre de la categoria no puede quedar vacio", "validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;

            }

            try
            {
                bool exito = categoria.insertarCategoria(nombreCategoria.Trim());

                if (exito)
                {
                    MessageBox.Show("Categoria guardada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("No se pudo guardar la categoria. Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Error al guardar la categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
