using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsComprasController
    {
        ClsComprasModelo modelo = new ClsComprasModelo();
        Compra compra = new Compra(); 
        public Producto buscarProducto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return null;

            return modelo.buscarProducto(codigo);

            
        }
        public void agregarProducto(Producto productos, decimal nuevaCantidad, decimal precioCompra, FrmCompra vista)
        {

            var existe = compra.detalleCompra.FirstOrDefault(
                x=>x.producto.codigo_de_barras==productos.codigo_de_barras);
            if (existe != null)
            {
                existe.cantidad += nuevaCantidad;
                existe.precioCompra = precioCompra;
            }
            else
            {
                compra.detalleCompra.Add(
                    
                    new DetalleCompra
                    { 
                        producto = productos,
                        cantidad =nuevaCantidad,
                        precioCompra = precioCompra
                    }
                    );
            }
            vista.actualizarTabla(compra.detalleCompra);
            vista.mostrarTotal(compra.total);
        }

        public void procesarEntradaCompra(Producto producto, string cantidadTexto, string costoTexto, FrmCompra vista)
        {
            if (producto == null)
            {
                vista.notificarUsuario("Primero busque o escanee un producto válido.", true);
                return;
            }

            if (!decimal.TryParse(cantidadTexto, out decimal cantidad) || cantidad <= 0)
            {
                vista.notificarUsuario("Por favor, ingrese una cantidad válida mayor a cero.", true);
                return;
            }

            if (!decimal.TryParse(costoTexto, out decimal costoCompra) || costoCompra < 0)
            {
                vista.notificarUsuario("Por favor, ingrese un costo de compra válido.", true);
                return;
            }
            agregarProducto(producto, cantidad, costoCompra, vista);
            vista.limpiarCamposEdicion();
        }


        public bool guardarCompra(FrmCompra vista)
        {
            if (compra.detalleCompra.Count==0)
            {
                vista.notificarUsuario("No se pueden guardar compras sin artículos en la lista.", true);
                return false;
            }
            compra.IdUsuario = ClsLoginModelo.UsuarioActual;
            compra.fecha = DateTime.Now;

            bool exito = modelo.procesarCompra(compra);

            if (exito)
            {
                MessageBox.Show("Compra guardada correctamente","Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
            else
            {
                throw new Exception("La compra no pudo ser gurdada correctamente");
            }

            return exito;
        }

        public void limpiarCarrito(FrmCompra vista)
        {
            compra = new Compra();
            vista.actualizarTabla(compra.detalleCompra);
            vista.mostrarTotal(compra.total);
            vista.limpiarCamposEdicion();
        }

        public void eliminarProducto(int indice, FrmCompra vista)
        {
            if (indice >= 0 && indice < compra.detalleCompra.Count)
            {
                compra.detalleCompra.RemoveAt(indice);
                vista.actualizarTabla(compra.detalleCompra);
                vista.mostrarTotal(compra.total);
            }
        }
        public List<Producto> busquedaAvanzada(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                return new List<Producto>();
            }
            return modelo.busquedaAvanzada(filtro); 
        }

    }
}
