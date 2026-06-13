using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.vista;
using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{


    public class clsVentasController
    {
        clsVentasModelo modelo = new clsVentasModelo();
        private List<Producto> resultadosBusqueda = new();
        private ventas venta = new ventas();


        public void procesarBusqueda(string codigo, FrmVentas vista)
        {
            if (string.IsNullOrEmpty(codigo)) return;

            Producto producto = modelo.buscarProducto(codigo);



            if (producto != null)
            {
                agregarProducto(producto, vista);
                
            }
            else { MessageBox.Show("El producto no existe en la base de datos."); }
        }

        public void agregarProducto(Producto producto, FrmVentas vista)
        {
            var existe = venta.detalleVenta
          .FirstOrDefault(x =>
              x.Producto.codigo_de_barras ==
              producto.codigo_de_barras);

            if (existe != null)
                existe.Cantidad++;
            else
            {
                venta.detalleVenta.Add(
                    new detalleVenta
                    {
                        Producto = producto,
                        Cantidad = 1,
                        PrecioUnitario = producto.precio
                    });
            }

            vista.actualizarTabla(venta.detalleVenta);
            vista.mostrarTotal(venta.total);
        }
        public decimal obtenerCambio(decimal pago)
        {
            venta.efectivo = pago;
            return venta.cambio;        
        }
        public decimal obtenerTotal()
        {
            return venta.total;
        }
        public bool guardarVenta(FrmVentaproductos vistaCobro)
        {
            venta.IdUsuario = ClsLoginModelo.UsuarioActual;
            venta.fecha = DateTime.Now;
            
            foreach (var item in venta.detalleVenta)
            {
                if (item.Cantidad > item.Producto.stock)
                {
                    vistaCobro.NotificarUsuario($"Stock insuficiente para {item.Producto.nombre}", true);
                    return false;
                }
            }

            
            bool exito = modelo.ProcesarVenta(venta);
            
            if (exito)
            {
                vistaCobro.NotificarUsuario("¡El ticket se cobró y guardó correctamente!", false);
                vistaCobro.cerrarVentana();

              
            }
            else
            {
                vistaCobro.NotificarUsuario("Hubo un error en la base de datos al intentar guardar.", true);
            }

            return exito;
        }
        public void eliminarProducto(int indice, FrmVentas vista) {

            if (indice >= 0 && indice < venta.detalleVenta.Count)
            {
                venta.detalleVenta.RemoveAt(indice);

                vista.actualizarTabla(venta.detalleVenta);

                vista.mostrarTotal(venta.total);
            }
        }

        public void busquedaAvanzada(string filtro, FrmBuscarProducto vista)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                resultadosBusqueda.Clear();
                vista.actualizarLista(resultadosBusqueda);
                return;
            }

            resultadosBusqueda = modelo.buscarProductoAv(filtro);

            vista.actualizarLista(resultadosBusqueda);
        }
        public Producto ObtenerProductoBusqueda(int indice)
        {
            if (indice < 0 || indice >= resultadosBusqueda.Count)
                return null;

            return resultadosBusqueda[indice];
        }
        public void LimpiarVenta(FrmVentas vista)
        {
            venta = new ventas();

            vista.actualizarTabla(venta.detalleVenta);
            vista.mostrarTotal(venta.total);
        }
        public bool TieneProductos()
        {
            return venta.detalleVenta.Count > 0;
        }
    }
}
