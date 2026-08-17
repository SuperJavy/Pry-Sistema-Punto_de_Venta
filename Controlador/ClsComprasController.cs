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
        public int idUsuarioActualGlobal { get; set; }
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
                decimal cantidadTotal = existe.cantidad + nuevaCantidad;
                decimal costoPonderado = ((existe.cantidad * existe.precioCompra) + (nuevaCantidad * precioCompra)) / cantidadTotal;
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
                int folio = compra.IdCompra;
                vista.notificarUsuario("Compra guardada correctamente (Folio #" + folio + ")", false);

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
            if (compra.detalleCompra == null || compra.detalleCompra.Count == 0)
            {
                eliminarRespaldo();
                return;
            }

            var listaArticulos = compra.detalleCompra.Select(d => new Itemrespaldo
            {
                codigoBarras = d.producto.codigo_de_barras,
                cantidad = d.cantidad,
                costo = d.precioCompra,
                porcentaje = d.porcentajeGanancia
            }).ToList();

            // CREAMOS EL CONTENEDOR CON EL DUEÑO Y LOS ARTÍCULOS
            RespaldoTransaccion respaldoCompleto = new RespaldoTransaccion
            {
                IdUsuarioDuenio = this.idUsuarioActualGlobal,
                Articulos = listaArticulos
            };

            ClsRespaldo.guardarRespaldo(rutaRespaldo, respaldoCompleto);
        }
        public void eliminarRespaldo()
        {
            ClsRespaldo.eliminarRespaldo(rutaRespaldo);
        }
        public void recuperarCompraPendiente(FrmCompra vista, int idUsuarioActual)
        {
            // Guardamos el id del usuario que entró en la variable global
            this.idUsuarioActualGlobal = idUsuarioActual;

            if (File.Exists(rutaRespaldo))
            {
                try
                {
                    // RECUPERAMOS EL OBJETO CONTENEDOR
                    RespaldoTransaccion respaldoBD = ClsRespaldo.recuperar(rutaRespaldo);

                    if (respaldoBD != null && respaldoBD.Articulos != null && respaldoBD.Articulos.Count > 0)
                    {
                        // 1. ¿ES EL MISMO USUARIO QUE LA DEJÓ A MEDIAS?
                        if (respaldoBD.IdUsuarioDuenio == idUsuarioActual)
                        {
                            bool deseaRecuperar = vista.confirmarPregunta(
                                "Se detectó una captura de compra interrumpida por un cierre inesperado, ¿Desea recuperarla?",
                                "Sistema de respaldo");

                            if (deseaRecuperar)
                            {
                                List<string> noEncontrados = new List<string>();
                                foreach (var item in respaldoBD.Articulos)
                                {
                                    Producto prod = buscarProducto(item.codigoBarras);
                                    if (prod != null)
                                    {
                                        agregarProducto(prod, item.cantidad, item.costo, item.porcentaje, vista);
                                    }
                                    else
                                    {
                                        noEncontrados.Add(item.codigoBarras);
                                    }
                                }
                                if (noEncontrados.Count > 0)
                                {
                                    vista.notificarUsuario(
                                        "No se pudieron recuperar " + noEncontrados.Count +
                                        " artículo(s) porque ya no existen en el catálogo: " +
                                        string.Join(", ", noEncontrados), true);
                                }
                            }
                            else
                            {
                                // El mismo dueño decidió NO recuperarla, se le audita a él.
                                cancelarRespaldoSilencioso(respaldoBD.Articulos, idUsuarioActual);
                                vista.notificarUsuario("La captura de mercancía interrumpida ha sido descartada con éxito", false);
                            }
                        }
                        // 2. ¡ES OTRO USUARIO! (Alguien más entró a la caja)
                        else
                        {
                            // Cancelamos la compra silenciosamente, pero A NOMBRE DEL DUEÑO ORIGINAL
                            cancelarRespaldoSilencioso(respaldoBD.Articulos, respaldoBD.IdUsuarioDuenio);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo de respaldo de compras está corrupto. Detalle: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    eliminarRespaldo();
                }
            }
        }
        private void cancelarRespaldoSilencioso(List<Itemrespaldo> articulos, int idDuenioAuditoria)
        {
            List<DetalleCompra> listaAuditada = new List<DetalleCompra>();
            foreach (var item in articulos)
            {
                Producto prod = buscarProducto(item.codigoBarras);
                if (prod != null)
                {
                    listaAuditada.Add(new DetalleCompra
                    {
                        producto = prod,
                        cantidad = item.cantidad,
                        precioCompra = item.costo,
                        porcentajeGanancia = item.porcentaje
                    });
                }
            }

            if (listaAuditada.Count > 0)
            {
                Compra compraCancelada = new Compra
                {
                    IdUsuario = idDuenioAuditoria, // ID DEL DUEÑO REAL
                    fecha = DateTime.Now,
                    detalleCompra = new List<DetalleCompra>()
                };
                modelo.procesarCompra(compraCancelada, listaAuditada, 3); // Estado 3 = Cancelada
            }

            eliminarRespaldo();
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
