using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;


namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class clsCategoriasController
    {
        clsCategoriaModelo categoria = new clsCategoriaModelo();

        public void agregarCategoria(string nombreCategoria, FrmCategorias vista) 
        {

            if ( string.IsNullOrWhiteSpace(nombreCategoria))
            { 
                vista.notificarUsuario("El nombre de la categoria no puede estar vacio", false);
                return;
            }
            try
            {
                bool resultado = categoria.insertarCategoria(nombreCategoria.Trim());

                if (resultado)
                {
                    vista.notificarUsuario("Categoria guardada de forma exitosa!", false);
                    vista.limpiarPantalla();
                }
                else 
                {

                }
            }
            catch (Exception ex) 
            {
                vista.notificarUsuario("No se pudo registrar la categoria en el sistema" + ex.Message, true); 
            }
        }

    }
    
}
