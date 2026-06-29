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
        public List<DetalleCompra> compraCancelada = new List<DetalleCompra>();
        public Producto buscarProducto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return null;

            return modelo.buscarProducto(codigo);


        }
        public void agregarProducto(Producto productos, decimal nuevaCantidad, decimal precioCompra, FrmCompra vista)
        {

            var existe = compra.detalleCompra.FirstOrDefault(
                x => x.producto.codigo_de_barras == productos.codigo_de_barras);
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
                        cantidad = nuevaCantidad,
                        precioCompra = precioCompra
                    }
                    );
            }
            vista.actualizarTabla(compra.detalleCompra);
            vista.mostrarTotal(compra.total);
            GuardarRespaldoJson();
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
            if (compra.detalleCompra.Count == 0)
            {
                vista.notificarUsuario("No se pueden guardar compras sin artículos en la lista.", true);
                return false;
            }
            compra.IdUsuario = ClsLoginModelo.UsuarioActual;
            compra.fecha = DateTime.Now;

            bool exito = modelo.procesarCompra(compra, compraCancelada, 1);

            if (exito)
            {
                MessageBox.Show("Compra guardada correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                eliminarRespaldo();
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
            eliminarRespaldo();
        }
        public void eliminarProducto(int indice, FrmCompra vista)
        {
            if (indice >= 0 && indice < compra.detalleCompra.Count)
            {

                DetalleCompra itemCancelado = compra.detalleCompra[indice];
                compraCancelada.Add(itemCancelado);


                compra.detalleCompra.RemoveAt(indice);
                vista.actualizarTabla(compra.detalleCompra);
                vista.mostrarTotal(compra.total);
                GuardarRespaldoJson();
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
        private readonly string rutaRespaldo = "compra_respaldo.json";
        public void GuardarRespaldoJson()
        {
            if (compra.detalleCompra == null) return;

            var datos = compra.detalleCompra.Select(d => new Itemrespaldo
            {
                codigoBarras = d.producto.codigo_de_barras,
                cantidad = d.cantidad

            }).ToList();

            ClsRespaldo.guardarRespaldo(rutaRespaldo, datos);
        }
        public void eliminarRespaldo()
        {
            ClsRespaldo.eliminarRespaldo(rutaRespaldo);
        }
        public void recuperarCompraPendiente(FrmCompra vista)
        {
            if (File.Exists(rutaRespaldo))
            {
                try
                {
                    List<Itemrespaldo> respaldo = ClsRespaldo.recuperar(rutaRespaldo);

                    if (respaldo != null && respaldo.Count > 0)
                    {
                        var respuesta = MessageBox.Show(
                            "Se detectó una captura de compra interrumpida por un cierre inesperado, ¿Desea recuperarla?",
                            "Sistema de respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                        );

                        if (respuesta == DialogResult.Yes)
                        {
                            foreach (var item in respaldo)
                            {
                                Producto prod = buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {
                                    agregarProducto(prod, item.cantidad, 0, vista);
                                }
                            }
                        }
                        else
                        {
                            List<DetalleCompra> listaAuditada = new List<DetalleCompra>();
                            foreach (var item in respaldo)
                            {
                                Producto prod = buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {
                                    DetalleCompra detalle = new DetalleCompra
                                    {
                                        producto = prod,
                                        cantidad = item.cantidad,
                                        precioCompra = 0
                                    };
                                    listaAuditada.Add(detalle);
                                }
                            }

                            if (listaAuditada.Count > 0)
                            {
                                Compra compraCancelada = new Compra
                                {
                                    IdUsuario = ClsLoginModelo.UsuarioActual,
                                    fecha = DateTime.Now,
                                    detalleCompra = new List<DetalleCompra>()
                                };
                                modelo.procesarCompra(compraCancelada, listaAuditada, 3);
                            }

                            eliminarRespaldo();
                            MessageBox.Show("La captura de mercancía interrumpida ha sido descartada con éxito", "Compra descartada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch { eliminarRespaldo(); }
            }
        }
    }
}
