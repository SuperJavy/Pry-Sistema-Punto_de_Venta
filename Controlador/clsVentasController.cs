using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.vista;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{


    public class clsVentasController
    {
        clsVentasModelo modelo = new clsVentasModelo();

        
        private ventas venta = new ventas();

        public void procesarBusqueda(string codigo, FrmVentas vista)
        {
            if (string.IsNullOrEmpty(codigo)) return;

            Producto producto = modelo.buscarProducto(codigo);



            if (producto != null)
            {
                agregarProducto(producto);
                vista.actualizarTabla(venta.detalleVenta);

                vista.mostrarTotal(venta.total);
            }
            else { MessageBox.Show("El producto no existe en la base de datos."); }
        }

        private void  agregarProducto(Producto producto)
        {
            var existe = venta.detalleVenta.FirstOrDefault(x => x.Producto.codigo_de_barras == producto.codigo_de_barras);

            if (existe != null) existe.Cantidad++;
            else {
                venta.detalleVenta.Add(
                    new detalleVenta
                    {
                        Producto = producto,
                        Cantidad = 1,
                        PrecioUnitario = producto.precio
                    }
               
                );
            }
        }
      

        public decimal obtenerCambios(decimal pago)
        {
            
            return venta.calcaularCambio(pago);
        }
        public decimal obtenerTotal()
        {
            return venta.total;
        }
    }
}
