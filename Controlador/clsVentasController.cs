using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System.Data;
using System.IO; // CRÍTICO: Para usar File.Exists()
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{


    public class clsVentasController
    {
        clsVentasModelo modelo = new clsVentasModelo();
        private ClsLoginModelo login = new ClsLoginModelo();
        private List<Producto> resultadosBusqueda = new();
        private ventas venta = new ventas();
        public List<detalleVenta> productoCancelados = new List<detalleVenta>();


        public Producto procesarBusqueda(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return null;
            return modelo.buscarProducto(codigo);
        }
        public bool agregarProducto(Producto producto, decimal cantidadFinal, out string mensajeError)
        {
            mensajeError = "";
            var existe = venta.detalleVenta.FirstOrDefault(x => x.Producto.codigo_de_barras == producto.codigo_de_barras);

            decimal cantidadAcumulada = (existe != null ? existe.Cantidad : 0) + cantidadFinal;

            if (cantidadAcumulada > producto.stock)
            {
                mensajeError = $"Stock insuficiente. Solo hay {producto.stock} disponibles en inventario.";
                return false; 
            }

         
            if (existe != null)
            {
                existe.Cantidad += cantidadFinal;
                existe.Importe = existe.Cantidad * existe.PrecioUnitario;
            }
            else
            {
                venta.detalleVenta.Add(
                    new detalleVenta
                    {
                        Producto = producto,
                        Cantidad = cantidadFinal,
                        PrecioUnitario = producto.precio,
                        Importe = cantidadFinal * producto.precio
                    }
                );
            }
            GuardarRespaldoJson();
            return true; 
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
        public bool guardarVenta(FrmVentaproductos vistaCobro, int idUsuarioActual)
        {
            venta.IdUsuario = login.UsuarioActual;
            venta.fecha = DateTime.Now;
            venta.IdUsuario = idUsuarioActual;

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
        public void eliminarProducto(int indice, FrmVentas vista)
        {

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
        public List<Producto> busquedaAvanzada(string filtro)
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
            if (indice >= 0 && indice < venta.detalleVenta.Count)
            {
                var item = venta.detalleVenta[indice];

                if (cantidadExtra > 0 && (item.Cantidad + cantidadExtra) > item.Producto.stock)
                {
                    MessageBox.Show($"Stock insuficiente. Solo hay {item.Producto.stock} disponibles en inventario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                item.Cantidad += cantidadExtra;

                if (item.Cantidad <= 0)
                {
                    eliminarProducto(indice, vista);
                    return;
                }

                item.Importe = item.Cantidad * item.PrecioUnitario;

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
        public void recuperarVentaPendiente(FrmVentas vista, int idUsuario)
        {
            if (File.Exists(rutaRespaldo))
            {
                try
                {
                    List<Itemrespaldo> respaldo = ClsRespaldo.recuperar(rutaRespaldo);

                    if (respaldo != null && respaldo.Count > 0)
                    {
                        var respuesta = MessageBox.Show(
                            "Se detectó una venta interrumpida por un cierre inesperado, ¿Desea recuperarla?",
                            "Sistema de respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                            );

                        if (respuesta == DialogResult.Yes)
                        {
                            foreach (var item in respaldo)
                            {
                                Producto prod = modelo.buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {                                 
                                    string msjError;
                                    bool agregado = agregarProducto(prod, item.cantidad, out msjError);

                                    if (!agregado)
                                    {
                                        MessageBox.Show($"No se pudo recuperar completamente '{prod.nombre}': {msjError}", "Aviso de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            vista.actualizarTabla(venta.detalleVenta);
                            vista.mostrarTotal(venta.total);
                        }
                        else
                        {
                            List<detalleVenta> listaAuditada = new List<detalleVenta>();
                            foreach (var item in respaldo)
                            {
                                Producto prod = modelo.buscarProducto(item.codigoBarras);
                                if (prod != null)
                                {
                                    listaAuditada.Add(new detalleVenta
                                    {
                                        Producto = prod,
                                        Cantidad = item.cantidad,
                                        PrecioUnitario = prod.precio,
                                        Importe = item.cantidad * prod.precio
                                    });
                                }
                            }
                            if (listaAuditada.Count > 0)
                            {
                                ventas ventaCancelada = new ventas
                                {
                                    IdUsuario = idUsuario,
                                    fecha = DateTime.Now,
                                    efectivo = 0,
                                    detalleVenta = new List<detalleVenta>()
                                };
                                modelo.ProcesarVenta(ventaCancelada, listaAuditada, 3);
                            }
                            eliminarRespaldo();
                            MessageBox.Show("La venta interrumpida ha sido descartada con éxito", "Venta descartada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo de respaldo está corrupto. Consulte con soporte técnico. Detalle: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public ventas ObtenerVentaActual()
        {
            return venta;
        }
    }


}
