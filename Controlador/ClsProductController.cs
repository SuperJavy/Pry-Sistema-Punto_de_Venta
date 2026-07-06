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

        public string generarcode(FrmGernerador_CodBarras vista)
        {
            string code = "";
            try
            {
                code = producto.codigodebarras();


            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al generar el codigo de barras", true);
            }
            return code;
        }
        public void Existentecode(string code, FrmGernerador_CodBarras vista)
        {
            if (string.IsNullOrEmpty(code))
            {
                vista.notificarUsuario("El campo código de barras no puede ir vacío", true);
                return;
            }

            try
            {
                bool existeEnBD = producto.Comsultarcode(code);

                if (existeEnBD)
                {
                    vista.notificarUsuario("Código duplicado en el sistema.", true);
                    vista.limpiarcaja();
                }
                else
                {
                    vista.notificarUsuario("Código válido y disponible", false);
                }
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error en la consulta o conexión: " + e.Message, true);
            }
        }
        public void InsertCodeBD(string code, Image img, FrmGernerador_CodBarras vista)
        {
            if (string.IsNullOrEmpty(code) || img == null) { vista.notificarUsuario("Campo no puede ir vacio", true); return; }
            bool esvalido = producto.InsercodeB(code, img);
            try
            {
                if (esvalido)
                {
                    vista.notificarUsuario("Los datos se guardaron correctamente", false);
                }
                else
                {
                    vista.notificarUsuario("LOs datos se guardaron correctamente", true);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al guardar en BD o conexion", true);
            }
        }

        public Image imgec(string c, FrmGernerador_CodBarras vista)
        {
            Image img = null;
            try
            {
                img = producto.imgcodeb(c);
            }
            catch (Exception e)
            {
                vista.notificarUsuario("", true);

            }
            return img;
        }
        public void Registrarproductos(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen, string porcentaje, FrmNuevoProducto vista)
        {
            if (string.IsNullOrWhiteSpace(Codigo) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripciom) || string.IsNullOrWhiteSpace(TipVenta) || string.IsNullOrWhiteSpace(Costo) || string.IsNullOrWhiteSpace(Precioventa) || string.IsNullOrWhiteSpace(Categoria) || string.IsNullOrWhiteSpace(Stockactuaal) || string.IsNullOrWhiteSpace(Stockminimo) || string.IsNullOrWhiteSpace(porcentaje))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos", true);
                return;
            }

            if (Imagen == null)
            {
                if (int.TryParse(Categoria, out int idCategoria))
                {
                    Imagen = imagenPorCategoria(idCategoria);
                }
                else
                {
                    Imagen = imagenPorCategoria(0);
                }
            }


            try
            {
                bool esvalido = producto.Insertarproductos(Codigo, Nombre, Descripciom, TipVenta, Costo, Precioventa, Categoria, Stockactuaal, Stockminimo, Imagen, porcentaje);
                if (esvalido)
                {
                    vista.notificarUsuario("Los datos fueron guardados correctamente", false);
                }

            }
            catch (Exception E)
            {

                vista.notificarUsuario("Producto Duplicado ", true);
            }
        }



        public float Calcularprecioventa(string costo, string porcentaje, FrmNuevoProducto vista)
        {
            return producto.Calpventa(costo, porcentaje);
        }



        public DataTable Cargarcategorias(FrmNuevoProducto vista)
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
        //Empieza codigo de Modificar productos
        public DataTable BuscarPro(string codigodebarras, FrmModoficar vista)
        {
            if (string.IsNullOrWhiteSpace(codigodebarras))
            {
                vista.notificarUsuario("El campo código de barras no puede estar vacío", true);
                return null;
            }

            DataTable dtproducto = null;
            try
            {
                dtproducto = producto.Buscarproduct(codigodebarras);

                if (dtproducto != null && dtproducto.Rows.Count == 0)
                {
                    vista.notificarUsuario("No se encontró ningún producto con ese código de barras.", true);
                }
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar productos: " + e.Message, true);
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

        public float Calcularprecioventa(string costo, string porcentaje, FrmModoficar vista)
        {
            return producto.Calpventa(costo, porcentaje);
        }

        public void Actualizarproduc(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, Image Imagen, string porcentaje, FrmModoficar vista)
        {

            if (string.IsNullOrWhiteSpace(Codigo) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripciom) || string.IsNullOrWhiteSpace(TipVenta) || string.IsNullOrWhiteSpace(Costo) || string.IsNullOrWhiteSpace(Precioventa) || string.IsNullOrWhiteSpace(Categoria) || string.IsNullOrWhiteSpace(Stockactuaal) || string.IsNullOrWhiteSpace(Stockminimo) || string.IsNullOrWhiteSpace(porcentaje))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos", true);
                return;
            }

            try
            {
                bool esvalido = producto.Actualizarproductos(Codigo, Nombre, Descripciom, TipVenta, Costo, Precioventa, Categoria, Stockactuaal, Stockminimo, Imagen, porcentaje);
                if (esvalido)
                {
                    vista.notificarUsuario("Los datos fueron actualizados correctamente", false);
                }
                else
                {
                    vista.notificarUsuario("Eror al intentar actualizar los datos", true);
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                vista.notificarUsuario("Error en la conexion o Actualizacion", true);
            }


        }
        //termina codigo de actualizar

        //empeiza codigo de eliminar produto
        public DataTable BuscarProEliminar(string codigodebarras, FrmEliminarproductos vista)
        {
            if (string.IsNullOrWhiteSpace(codigodebarras))
            {
                vista.notificarUsuario("El campo código de barras no puede estar vacío", true);
                return null;
            }

            DataTable dtproducto = null;
            try
            {
                dtproducto = producto.Buscarproduct(codigodebarras);

                if (dtproducto != null && dtproducto.Rows.Count == 0)
                {
                    vista.notificarUsuario("No se encontró ningún producto con ese código de barras.", true);
                }
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al cargar productos: " + e.Message, true);
            }
            return dtproducto;

        }
        public DataTable Cargarcatego(FrmEliminarproductos vista)
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
        public float Calcularpreciov(string costo, string porcentaje, FrmEliminarproductos vista)
        {
            return producto.Calpventa(costo, porcentaje);
        }
        public void Eliminarproduct(string codigodebarras, FrmEliminarproductos vista)
        {
            if (string.IsNullOrWhiteSpace(codigodebarras))
            {
                vista.notificarUsuario("El campo código de barras no puede estar vacío", true);
                return;
            }

            try
            {
                bool eliminado = producto.EliminarProducto(codigodebarras);

                if (eliminado)
                {
                    vista.notificarUsuario("Producto eliminado correctamente.", false);
                }
                else
                {
                    vista.notificarUsuario("No existe ningún producto con ese código de barras.", true);
                }
            }
            catch (Exception e)
            {
                vista.notificarUsuario("Error al eliminar el producto: " + e.Message, true);
            }


        }

        private Image imagenPorCategoria(int idCategoria)
        {
            switch (idCategoria)
            {

                case 1: return Properties.Resources.cat_Farmacos;
                case 9: return Properties.Resources.cat_bebidas;
                case 11: return Properties.Resources.cat_Limpieza;
                case 15: return Properties.Resources.cat_Lacteos;
                case 19: return Properties.Resources.cat_Dulces;
                case 20: return Properties.Resources.cat_higiene_Personal;
                case 21: return Properties.Resources.cat_Cocina;


                default:
                    Random rnd = new Random();
                    int opcionAleatoria = rnd.Next(1, 4);

                    switch (opcionAleatoria)
                    {
                        case 1: return Properties.Resources.generico_1;
                        case 2: return Properties.Resources.generico_2;
                        case 3: return Properties.Resources.generico_3;
                        case 4: return Properties.Resources.generico_4;
                        case 5: return Properties.Resources.generico_5;
                        default: return Properties.Resources.generico_1;
                    }

            }
        }
        

    }

}

