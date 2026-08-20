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
            catch (Exception)
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
            if (string.IsNullOrEmpty(code)) { vista.notificarUsuario("Campo no puede ir vacio", true); return; }

            try
            {
                // Ya no pasamos ningún archivo, solo le mandamos el texto del código al modelo
                // (Nota: Tendrás que quitar el segundo parámetro en tu modelo y tu comando SQL)
                bool esvalido = producto.InsercodeB(code);
                if (esvalido) vista.notificarUsuario("Los datos se guardaron correctamente", false);
                else vista.notificarUsuario("No se pudieron guardar los datos", true);
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al guardar en BD o conexion: " + ex.Message, true);
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
                vista.notificarUsuario("Error al generar la imagen del código de barras: " + e.Message, true);

            }
            return img;
        }
        public bool Registrarproductos(string Codigo, string Nombre, string Descripciom, string TipVenta, string Categoria, string Stockactuaal, string Stockminimo, string RutaImagenOrigen, FrmNuevoProducto vista)
        {
            if (string.IsNullOrWhiteSpace(Codigo) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripciom) || string.IsNullOrWhiteSpace(TipVenta) || string.IsNullOrWhiteSpace(Categoria) || string.IsNullOrWhiteSpace(Stockactuaal) || string.IsNullOrWhiteSpace(Stockminimo))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos", true);
                return false;
            }

            string nombreArchivoFinal = "default.png";

            if (!string.IsNullOrWhiteSpace(RutaImagenOrigen))
            {
                string extImagen = System.IO.Path.GetExtension(RutaImagenOrigen);
                nombreArchivoFinal = Codigo + extImagen;

                // MAGIA: El Gestor hace el trabajo
                bool fotoGuardada = ClsGestorArchivos.GuardarImagen(RutaImagenOrigen, @"Productos\", nombreArchivoFinal);
                if (!fotoGuardada)
                {
                    vista.notificarUsuario("Aviso: El producto se guardará, pero hubo un error de red al subir la imagen.", true);
                    nombreArchivoFinal = "default.png";
                }
            }
            else
            {
                nombreArchivoFinal = Codigo + "_default.png";
                int.TryParse(Categoria, out int idCategoria);
                Image imgDefault = imagenPorCategoria(idCategoria);

                // Truco: Guardamos el recurso en un archivo temporal para que el Gestor lo pueda procesar
                string rutaTemp = System.IO.Path.Combine(System.IO.Path.GetTempPath(), nombreArchivoFinal);
                imgDefault.Save(rutaTemp, System.Drawing.Imaging.ImageFormat.Png);

                ClsGestorArchivos.GuardarImagen(rutaTemp, @"Productos\", nombreArchivoFinal);

                if (System.IO.File.Exists(rutaTemp)) System.IO.File.Delete(rutaTemp); // Limpiamos la basura
            }

            try
            {
                bool esvalido = producto.Insertarproductos(Codigo, Nombre, Descripciom, TipVenta, Categoria, Stockactuaal, Stockminimo, nombreArchivoFinal);
                if (esvalido)
                {
                    vista.notificarUsuario("Los datos fueron guardados correctamente", false);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                vista.notificarUsuario(e.Message, true);
                return false;
            }
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
            catch (Exception)
            {
                vista.notificarUsuario("Error al cargar las categorias", true);
            }
            return dtcategorias;

        }
        public float Calcularprecioventa(string costo, string porcentaje, FrmModoficar vista)
        {
            return producto.Calpventa(costo, porcentaje);
        }
        // Cambiamos 'void' por 'bool'
        public bool Actualizarproduc(string Codigo, string Nombre, string Descripciom, string TipVenta, string Costo, string Precioventa, string Categoria, string Stockactuaal, string Stockminimo, string RutaImagenOrigen, string porcentaje, FrmModoficar vista)
        {
            if (string.IsNullOrWhiteSpace(Codigo) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripciom) || string.IsNullOrWhiteSpace(TipVenta) || string.IsNullOrWhiteSpace(Costo) || string.IsNullOrWhiteSpace(Precioventa) || string.IsNullOrWhiteSpace(Categoria) || string.IsNullOrWhiteSpace(Stockactuaal) || string.IsNullOrWhiteSpace(Stockminimo) || string.IsNullOrWhiteSpace(porcentaje))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos", true);
                return false;
            }

            string nombreArchivoFinal = null;

            if (!string.IsNullOrWhiteSpace(RutaImagenOrigen))
            {
                string extImagen = System.IO.Path.GetExtension(RutaImagenOrigen);
                nombreArchivoFinal = Codigo + extImagen;

                bool fotoGuardada = ClsGestorArchivos.GuardarImagen(RutaImagenOrigen, @"Productos\", nombreArchivoFinal);
                if (!fotoGuardada)
                {
                    vista.notificarUsuario("Advertencia: No se pudo actualizar la imagen física en el servidor.", true);
                    nombreArchivoFinal = null;
                }
            }

            try
            {
                bool esvalido = producto.Actualizarproductos(Codigo, Nombre, Descripciom, TipVenta, Costo, Precioventa, Categoria, Stockactuaal, Stockminimo, nombreArchivoFinal, porcentaje);
                if (esvalido)
                {
                    vista.notificarUsuario("Los datos fueron actualizados correctamente", false);
                    return true;
                }
                else
                {
                    vista.notificarUsuario("Error al intentar actualizar los datos", true);
                    return false;
                }
            }
            catch (Exception E)
            {
                vista.notificarUsuario("Error en la conexion o Actualizacion: " + E.Message, true);
                return false;
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
                case 3: return Properties.Resources.cat_bebidas;
                case 5: return Properties.Resources.cat_Limpieza;
                case 4: return Properties.Resources.cat_Lacteos;
                case 6: return Properties.Resources.cat_Dulces;
                case 7: return Properties.Resources.cat_higiene_Personal;
                case 8: return Properties.Resources.cat_Cocina;


                default:
                    Random rnd = new Random();
                    int opcionAleatoria = rnd.Next(1, 6);

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

