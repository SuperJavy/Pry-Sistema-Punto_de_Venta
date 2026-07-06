using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                    vista.notificarUsuario("Eror al guardar la categoria!", true);
                }
            }
            catch (Exception ex) 
            {
                vista.notificarUsuario("No se pudo registrar la categoria en el sistema" + ex.Message, true); 
            }
        }


        public DataTable CargarDTGcat(FrmCategorias vista)
        {
            DataTable dtcategorias = null;
            try
            {
                dtcategorias = categoria.Mostrarcategorias();

            }
            catch
            {
                vista.notificarUsuario("Error al cargar las categorias", true);
            }
            return dtcategorias;
        }

        public void Deletecategory(string Nombre, FrmCategorias vista)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                vista.notificarUsuario("El campo no puede ir vacio", false);
            }
            try
            {

                bool resultado = categoria.Deletecategoria(Nombre);

                if (resultado)
                {
                    vista.notificarUsuario("Categoria Eliminada de forma exitosa!", false);
                    vista.limpiarPantalla();
                }
                else
                {
                    vista.notificarUsuario("Error al eliminar la categoria!", false);
                }

            }
            catch(Exception e)
            {
                vista.notificarUsuario("Error enla conexion o eliminacion", true);
            }


        }

    }
    
}
