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
using System.IO;
using System.Text.Json;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{


    public class clsVentasController
    {
        clsVentasModelo modelo = new clsVentasModelo();
        private List<Producto> resultadosBusqueda = new();
        private ventas venta = new ventas();
        public List<detalleVenta> productoCancelados = new List<detalleVenta>();


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

            decimal cantidadFinal = 1;

            if (producto.tipoVenta.ToLower() == "a granel")
            {
                FrmPedirPeso frmpeso = new FrmPedirPeso(producto.nombre);

                if (frmpeso.ShowDialog() == DialogResult.OK)
                {
                    cantidadFinal = frmpeso.PesoIngresado;
                }
                else
                { return; }
            }


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
                        Cantidad = cantidadFinal,
                        PrecioUnitario = producto.precio
                    });
            }

            vista.actualizarTabla(venta.detalleVenta);
            vista.mostrarTotal(venta.total);
            GuardarRespaldoJson();
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

            
            bool exito = modelo.ProcesarVenta(venta, productoCancelados, 1);
            
            if (exito)
            {
                vistaCobro.NotificarUsuario("¡El ticket se cobró y guardó correctamente!", false);
                vistaCobro.cerrarVentana();
                eliminarRespaldo();

              
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
                detalleVenta itemCancelado = venta.detalleVenta[indice];
                productoCancelados.Add(itemCancelado);

                venta.detalleVenta.RemoveAt(indice);

                vista.actualizarTabla(venta.detalleVenta);

                vista.mostrarTotal(venta.total);
                GuardarRespaldoJson();
            }
        }
        public List<Producto>busquedaAvanzada(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                return new List<Producto>();
            }
            return modelo.buscarProductoAv(filtro);
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
            eliminarRespaldo();
        }
        public bool TieneProductos()
        {
            return venta.detalleVenta.Count > 0;
        }
        public void ModificarCantidad(int indice, decimal cantidadExtra, FrmVentas vista)
        {
            if (indice >= 0 && indice <venta.detalleVenta.Count)
            {
                venta.detalleVenta[indice].Cantidad += cantidadExtra;

                if (venta.detalleVenta[indice].Cantidad <= 0)
                {
                    eliminarProducto(indice, vista); 
                    return;
                }



                vista.actualizarTabla(venta.detalleVenta);
                vista.mostrarTotal(venta.total);
                GuardarRespaldoJson();
            }
        }


        private readonly string rutaRespaldo = "venta_respaldo.json";
        public void GuardarRespaldoJson() 
        {
            if (venta.detalleVenta == null) return;

            var datos = venta.detalleVenta.Select(d => new Itemrespaldo
            {
                codigoBarras = d.Producto.codigo_de_barras,
                cantidad = d.Cantidad

            }).ToList();

            ClsRespaldo.guardarRespaldo(rutaRespaldo, datos);
        }
        public void eliminarRespaldo() 
        {
            ClsRespaldo.eliminarRespaldo(rutaRespaldo);
        }
        public void recuperarVentaPendiente(FrmVentas vista)
        {
            if (File.Exists(rutaRespaldo))
            {
                try
                {

                    List<Itemrespaldo> respaldo = ClsRespaldo.recuperar(rutaRespaldo);

                    if (respaldo!=null && respaldo.Count>0)
                    {
                        var respuesta = MessageBox.Show(
                            "Se detecto una venta interrumpida por un cierre inesperado, ¿Desea recuperarla?",
                            "Sistema de respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                            );
                        if (respuesta == DialogResult.Yes)
                        {
                            foreach (var item in respaldo)
                            {
                                Producto prod = modelo.buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {
                                    agregarProducto(prod, vista);
                                    ModificarCantidad(venta.detalleVenta.Count - 1, item.cantidad - 1, vista);
                                }
                            }

                        }
                        else
                        {
                            List<detalleVenta> listaAuditada = new List<detalleVenta>();
                            foreach (var item in respaldo)
                            {
                                Producto prod = modelo.buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {
                                    detalleVenta detalle = new detalleVenta
                                    {

                                        Producto = prod,
                                        Cantidad = item.cantidad,
                                        PrecioUnitario = prod.precio,
                                        Importe = prod.importe
                                    };
                                    listaAuditada.Add(detalle);
                                }

                            }
                            if (listaAuditada.Count > 0)
                            {
                                ventas ventaCancelada = new ventas
                                {
                                    IdUsuario = ClsLoginModelo.UsuarioActual,
                                    fecha = DateTime.Now,
                                    total = 0,
                                    efectivo = 0,
                                    cambio = 0,
                                    detalleVenta = new List<detalleVenta>()
                                };
                                modelo.ProcesarVenta(ventaCancelada, listaAuditada, 3);
                            }
                            eliminarRespaldo();
                            MessageBox.Show("La venta interrumpida ha sido descartada con exito", "Venta descartada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch { eliminarRespaldo();}
            }
        }
    }

    
}
