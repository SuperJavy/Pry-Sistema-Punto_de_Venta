using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsProductController
    {
        ClsProductModelo producto = new ClsProductModelo();

        public void Registrarproductos(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen,string porcentaje, FrmNuevoProductio vista)
        {
            if (string.IsNullOrWhiteSpace(Codigo)|| string.IsNullOrWhiteSpace(Nombre)||string.IsNullOrWhiteSpace(Descripciom)|| string.IsNullOrWhiteSpace(TipVenta)||string.IsNullOrWhiteSpace(Costo)|| string.IsNullOrWhiteSpace(Precioventa)||string.IsNullOrWhiteSpace(Categoria)||string.IsNullOrWhiteSpace(Stockactuaal)||string.IsNullOrWhiteSpace(Stockminimo) || string.IsNullOrWhiteSpace(porcentaje))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos",true);
                return;
            }

            try
            {
                bool esvalido=producto.Insertarproductos(Codigo,Nombre,Descripciom,TipVenta,Costo,Precioventa,Categoria,Stockactuaal,Stockminimo,Imagen,porcentaje);
                if(esvalido )
                {
                    vista.notificarUsuario("Los datos fueron guardados correctamente", false);
                }
                else
                {
                    vista.notificarUsuario("Eror al intentar guardar los datos",true);
                }

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                vista.notificarUsuario("Error en la conexion o Insercion", true);
            }
        }



        public float Calcularprecioventa(string costo, string porcentaje, FrmNuevoProductio vista)
        {
          return  producto.Calpventa(costo, porcentaje);
        }



        public DataTable Cargarcategorias(FrmNuevoProductio vista)
        {
            DataTable dtcategorias = null;
            try
            {
                dtcategorias = producto.Extraercategoria();
                
            }
            catch(Exception e)
            {
                vista.notificarUsuario("Error al cargar las categorias",true);
            }
            return dtcategorias;

        }
        //Empieza codigo de Modificar productos
        public DataTable BuscarPro(string codigodebarras,FrmModoficar vista)
        {
            if (string.IsNullOrWhiteSpace(codigodebarras)) 
            {
                vista.notificarUsuario("Ell campo codio de barras no pueden estar vacío", true);
                
            }

            DataTable dtproducto = null;
            try
            {
                dtproducto = producto.Buscarproduct(codigodebarras);
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar productos"+ e.Message, true);
            }
            return dtproducto;

        }
        public DataTable Cargarcategoriasm(FrmModoficar vista)
        {
            DataTable dtcategorias = null;
            try
            {
                dtcategorias = producto.Extraercategoria();

            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar las categorias", true);
            }
            return dtcategorias;

        }

    }
}
