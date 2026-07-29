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
        private ClsLoginModelo login = new ClsLoginModelo();
        Compra compra = new Compra();
        public List<DetalleCompra> compraCancelada = new List<DetalleCompra>();
        public Producto buscarProducto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return null;

            return modelo.buscarProducto(codigo);


        }
        public void agregarProducto(Producto productos, decimal nuevaCantidad, decimal precioCompra, decimal margen, FrmCompra vista)
        {
            var existe = compra.detalleCompra.FirstOrDefault(
                    x => x.producto.codigo_de_barras == productos.codigo_de_barras);

            if (existe != null)
            {
                existe.cantidad += nuevaCantidad;
                existe.precioCompra = precioCompra;
                existe.porcentajeGanancia = margen; // Actualiza el margen en el carrito
            }
            else
            {
                compra.detalleCompra.Add(
                    new DetalleCompra
                    {
                        producto = productos,
                        cantidad = nuevaCantidad,
                        precioCompra = precioCompra,
                        porcentajeGanancia = margen // Guarda el margen nuevo
                    }
                );
            }
            vista.actualizarTabla(compra.detalleCompra);
            vista.mostrarTotal(compra.total);
            GuardarRespaldoJson();
        }
        
        public bool guardarCompra(FrmCompra vista, int idUsuario)
        {
            if (compra.detalleCompra.Count == 0)
            {
                vista.notificarUsuario("No se pueden guardar compras sin artículos en la lista.", true);
                return false;
            }
            compra.IdUsuario = idUsuario;
            compra.fecha = DateTime.Now;

            bool exito;
            try
            {
                exito = modelo.procesarCompra(compra, compraCancelada, 1);
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al guardar la compra: " + ex.Message, true);
                return false;
            }

            if (exito)
            {
                vista.notificarUsuario("Compra guardada correctamente", false);

                // Reiniciar carrito y respaldo para evitar duplicados en la siguiente compra
                compra = new Compra();
                compraCancelada = new List<DetalleCompra>();

                vista.actualizarTabla(compra.detalleCompra);
                vista.mostrarTotal(compra.total);
                eliminarRespaldo();
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
                                    // CORRECCIÓN: Ahora pasamos prod.porcentaje en lugar de un 0 manual
                                    agregarProducto(prod, item.cantidad, prod.precio_compra, prod.porcentaje, vista);
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
                                        precioCompra = prod.precio_compra,
                                        // CORRECCIÓN: Asignamos el porcentaje de la BD a la auditoría
                                        porcentajeGanancia = prod.porcentaje
                                    };
                                    listaAuditada.Add(detalle);
                                }
                            }

                            if (listaAuditada.Count > 0)
                            {
                                Compra compraCancelada = new Compra
                                {
                                    IdUsuario = login.UsuarioActual,
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
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo de respaldo de compras está corrupto. Detalle: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void VerificarYProcesarEntrada(string codigo, string cantidadTexto, string costoTexto, string margenTexto, FrmCompra vista)
        {
            if (string.IsNullOrEmpty(codigo)) return;

            // 1. El controlador consulta al Modelo
            Producto producto = modelo.buscarProducto(codigo);

            // 2. Regla de negocio: Si el modelo devuelve nulo, le ordenamos a la Vista abrir el registro
            if (producto == null)
            {
                vista.ConfirmarRegistroNuevoProducto();
                return;
            }

            // 3. Validaciones matemáticas estrictas en el Controlador
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

            if (!decimal.TryParse(margenTexto, out decimal margen) || margen < 0)
            {
                vista.notificarUsuario("Por favor, ingrese un margen de ganancia válido (Ej. 30).", true);
                return;
            }

            // 4. Si pasa todos los filtros, delegamos al método interno de agregar al carrito
            agregarProducto(producto, cantidad, costoCompra, margen, vista);
            vista.limpiarCamposEdicion();
        }
        public decimal CalcularPrecioDeVenta(decimal costoCompra, decimal porcentajeGanancia)
        {
            return costoCompra + (costoCompra * (porcentajeGanancia / 100));
        }

    }
}
