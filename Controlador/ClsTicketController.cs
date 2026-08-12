using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using Pry_Sistema_Punto_de_Venta.vista;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    public class ClsTicketController
    {
        // Instancia del modelo para acceder a la base de datos
        private clsTicketModelo modeloTicket = new clsTicketModelo();

        // Variables globales para la impresión
        private ventas ventaActual;
        private clsTicketModelo configActual;
        private bool esTermica;

        // ====================================================================
        // 1. MÉTODOS PARA LA CONFIGURACIÓN DEL TICKET (Conecta Frmticket con clsTicketModelo)
        // ====================================================================

        public clsTicketModelo cargarConfiguracion()
        {
            try
            {
                // Extrae los datos de la BD a través del modelo
                return modeloTicket.obtenerConfiguracion();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void registrarConfiguracion(Image logo, string nombre, string telefono, string direccion, string rfc, string mensaje, Frmticket vista)
        {
            try
            {
                // Empaquetamos los datos recibidos de la vista en el objeto del modelo
                clsTicketModelo datosTicket = new clsTicketModelo
                {
                    Logo = logo,
                    NombreNegocio = nombre,
                    Telefono = telefono,
                    Direccion = direccion,
                    RFC = rfc,
                    MensajeFinal = mensaje
                };

                // Enviamos a guardar a la base de datos
                bool exito = modeloTicket.guardarConfiguracion(datosTicket);

                if (exito)
                {
                    vista.notificarUsuario("Configuración del ticket guardada correctamente.", false);
                }
                else
                {
                    vista.notificarUsuario("No se pudo guardar la configuración en la base de datos.", true);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al registrar la configuración: " + ex.Message, true);
            }
        }


        // ====================================================================
        // 2. MÉTODOS PARA LA IMPRESIÓN DEL TICKET (Conecta FrmVentaproductos con el Hardware)
        // ====================================================================

        public void ImprimirTicketVenta(ventas venta, string nombreImpresora, bool impresoraTermica)
        {
            this.ventaActual = venta;
            this.esTermica = impresoraTermica;

            // Traemos la configuración guardada (Logo, Nombre, etc.)
            this.configActual = modeloTicket.obtenerConfiguracion();

            if (this.configActual == null)
            {
                MessageBox.Show("Aún no se ha configurado el formato del ticket. Vaya a configuración de ticket primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configuramos el documento para el Spooler de Windows
            PrintDocument documento = new PrintDocument();

            // ¡NUEVA LÍNEA PARA DESTRABAR LA BROTHER! Le damos un título al trabajo de impresión
            documento.DocumentName = "Ticket_Punto_Venta";

            if (!string.IsNullOrEmpty(nombreImpresora))
            {
                documento.PrinterSettings.PrinterName = nombreImpresora;
            }

            // ====================================================================
            // ¡AQUÍ ESTÁ LA SOLUCIÓN DEL ATASCO DE LA BROTHER!
            // Forzamos el tamaño del papel dependiendo de la impresora
            // ====================================================================
            if (esTermica)
            {
                // 1. Calculamos el alto dinámico para la térmica
                int altoTicket = 350;
                if (ventaActual.detalleVenta != null)
                {
                    altoTicket += (ventaActual.detalleVenta.Count * 15);
                }
                documento.DefaultPageSettings.PaperSize = new PaperSize("Custom", 228, 700);
                documento.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            }
            else
            {
                // 2. Forzamos tamaño Carta (Letter) para impresoras normales (Brother)
                foreach (PaperSize paperSize in documento.PrinterSettings.PaperSizes)
                {
                    // Si en tu país usas A4, cambia PaperKind.Letter por PaperKind.A4
                    if (paperSize.Kind == PaperKind.Letter)
                    {
                        documento.DefaultPageSettings.PaperSize = paperSize;
                        break;
                    }
                }
                // Márgenes estándar para que la impresora normal no corte los bordes
                documento.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            }
            // ====================================================================

            documento.PrintPage += new PrintPageEventHandler(GenerarCuerpoTicket);

            try
            {
                documento.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de comunicación con la impresora: " + ex.Message, "Error de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lógica de dibujo dinámico (Se adapta a Normal o Térmica)
        private void GenerarCuerpoTicket(object sender, PrintPageEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Font fuenteNormal = new Font("Arial", 9);
            Font fuenteNegrita = new Font("Arial", 9, FontStyle.Bold);
            Font fuenteTitulo = new Font("Arial", 12, FontStyle.Bold);
            Brush brocha = Brushes.Black;

            // Ajuste dinámico de dimensiones
            int margenIzquierdo = esTermica ? 5 : 50;
            int anchoTicket = esTermica ? 190 : 315;
            int y = 20;

            StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat formatoDerecha = new StringFormat { Alignment = StringAlignment.Far };

            // --- CABECERA Y LOGO ---
            if (configActual.Logo != null)
            {
                // Reduce un poco el tamaño del logo para la térmica
                int logoAncho = esTermica ? 80 : 150;
                int logoAlto = esTermica ? 80 : 150;
                int logoX = margenIzquierdo + ((anchoTicket - logoAncho) / 2);
                gfx.DrawImage(configActual.Logo, logoX, y, logoAncho, logoAlto);
                y += logoAlto + 10;
            }

            gfx.DrawString(configActual.NombreNegocio, fuenteTitulo, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
            y += 25;
            gfx.DrawString("RFC: " + configActual.RFC, fuenteNormal, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
            y += 15;
            gfx.DrawString("Tel: " + configActual.Telefono, fuenteNormal, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
            y += 15;
            gfx.DrawString("Dir: " + configActual.Direccion, fuenteNormal, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
            y += 20;

            gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
            y += 20;

            // --- DETALLE DE PRODUCTOS ---
            gfx.DrawString("Cant.   Producto", fuenteNegrita, brocha, margenIzquierdo, y);
            gfx.DrawString("Importe", fuenteNegrita, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
            y += 20;

            if (ventaActual.detalleVenta != null)
            {
                foreach (var item in ventaActual.detalleVenta)
                {
                    string nombreProd = item.Producto.nombre;
                    // Truncar para evitar desbordamiento en térmicas
                    if (esTermica && nombreProd.Length > 16)
                    {
                        nombreProd = nombreProd.Substring(0, 16) + "...";
                    }

                    gfx.DrawString($"{item.Cantidad}x   {nombreProd}", fuenteNormal, brocha, margenIzquierdo, y);
                    gfx.DrawString($"${item.Importe:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                    y += 15;
                }
            }

            gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
            y += 20;

            // --- TOTALES ---
            gfx.DrawString($"TOTAL: ${ventaActual.total:F2}", fuenteTitulo, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
            y += 25;
            gfx.DrawString($"Efectivo: ${ventaActual.efectivo:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
            y += 15;
            gfx.DrawString($"Cambio: ${ventaActual.cambio:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
            y += 30;

            // --- MENSAJE FINAL ---
            Rectangle rectMensaje = new Rectangle(margenIzquierdo, y, anchoTicket, 60);
            gfx.DrawString(configActual.MensajeFinal, fuenteNormal, brocha, rectMensaje, formatoCentro);

            e.HasMorePages = false;
        }
    
        // ====================================================================
        // 3. MÉTODOS PARA LA IMPRESIÓN DEL TICKET DE CORTE DE CAJA
        // ====================================================================

        // Variables exclusivas para el ticket de corte
            private Dictionary<string, decimal> corteActual;
            private decimal corteMontoEsperado;
            private decimal corteMontoReal;
            private decimal corteDiferencia;
            private string cajeroCorte;

            public void ImprimirTicketCorte(Dictionary<string, decimal> datosCorte, decimal montoEsperado, decimal montoReal, decimal diferencia, string cajero, string nombreImpresora, bool impresoraTermica)
            {
                this.corteActual = datosCorte;
                this.corteMontoEsperado = montoEsperado;
                this.corteMontoReal = montoReal;
                this.corteDiferencia = diferencia;
                this.cajeroCorte = cajero;
                this.esTermica = impresoraTermica;

                // Traemos la configuración guardada (Logo, Nombre, etc.)
                this.configActual = modeloTicket.obtenerConfiguracion();

                if (this.configActual == null)
                {
                    MessageBox.Show("Aún no se ha configurado el formato del ticket. Vaya a configuración de ticket primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PrintDocument documento = new PrintDocument();
                documento.DocumentName = "Ticket_Corte_Caja";

                if (!string.IsNullOrEmpty(nombreImpresora))
                {
                    documento.PrinterSettings.PrinterName = nombreImpresora;
                }

                if (esTermica)
                {
                        // Tamaño de papel para ticket de corte (Alto fijo razonable)
                    documento.DefaultPageSettings.PaperSize = new PaperSize("Custom", 228, 450); // Aumenté el alto un poco por si acaso
                    documento.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                }
                else
                {
                    foreach (PaperSize paperSize in documento.PrinterSettings.PaperSizes)
                    {
                        if (paperSize.Kind == PaperKind.Letter)
                        {
                            documento.DefaultPageSettings.PaperSize = paperSize;
                            break;
                        }
                    }
                    documento.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
                }

                documento.PrintPage += new PrintPageEventHandler(GenerarCuerpoTicketCorte);

                try
                {
                    documento.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de comunicación con la impresora: " + ex.Message, "Error de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void GenerarCuerpoTicketCorte(object sender, PrintPageEventArgs e)
            {
                Graphics gfx = e.Graphics;
                Font fuenteNormal = new Font("Arial", 9);
                Font fuenteNegrita = new Font("Arial", 9, FontStyle.Bold);
                Font fuenteTitulo = new Font("Arial", 12, FontStyle.Bold);
                Brush brocha = Brushes.Black;

                int margenIzquierdo = esTermica ? 5 : 50;
                int anchoTicket = esTermica ? 190 : 315;
                int y = 20;

            StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat formatoDerecha = new StringFormat { Alignment = StringAlignment.Far };

                // --- CABECERA Y LOGO ---
                if (configActual.Logo != null)
                {
                    // Reduce un poco el tamaño del logo para la térmica
                    int logoAncho = esTermica ? 80 : 150;
                    int logoAlto = esTermica ? 80 : 150;
                    int logoX = margenIzquierdo + ((anchoTicket - logoAncho) / 2);
                    gfx.DrawImage(configActual.Logo, logoX, y, logoAncho, logoAlto);
                    y += logoAlto + 10;
                }

            gfx.DrawString(configActual.NombreNegocio, fuenteTitulo, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 25;
                gfx.DrawString("CORTE DE CAJA", fuenteTitulo, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 25;
                gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, brocha, margenIzquierdo, y);
                y += 15;
                gfx.DrawString("Cajero ID: " + cajeroCorte, fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                // --- DETALLES DEL CORTE ---
                gfx.DrawString("Fondo Inicial:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteActual["FondoInicial"]:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Ventas Efectivo:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"+ ${corteActual["VentasEfectivo"]:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Salidas:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"- ${corteActual["Salidas"]:F2}", fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 20;

                gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                // --- RESULTADOS FINALES ---
                gfx.DrawString("TOTAL ESPERADO:", fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteMontoEsperado:F2}", fuenteNegrita, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 20;

                gfx.DrawString("TOTAL CONTADO:", fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteMontoReal:F2}", fuenteNegrita, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 20;

                string textoDiferencia = corteDiferencia < 0 ? "FALTANTE:" : (corteDiferencia > 0 ? "SOBRANTE:" : "DIFERENCIA:");
                gfx.DrawString(textoDiferencia, fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteDiferencia:F2}", fuenteNegrita, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 30;

                // --- ESTADÍSTICAS ---
                gfx.DrawString("ESTADÍSTICAS DEL TURNO", fuenteNegrita, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 20;
                gfx.DrawString("Tickets Generados:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(corteActual["TotalTickets"].ToString(), fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 15;
                gfx.DrawString("Artículos Vendidos:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(corteActual["ArticulosVendidos"].ToString(), fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 15;
                gfx.DrawString("Artículos Cancelados:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(corteActual["ArticulosCancelados"].ToString(), fuenteNormal, brocha, margenIzquierdo + anchoTicket, y, formatoDerecha);
                y += 30;

                Rectangle rectMensaje = new Rectangle(margenIzquierdo, y, anchoTicket, 60);
                gfx.DrawString("Turno Cerrado Correctamente", fuenteNormal, brocha, rectMensaje, formatoCentro);

                e.HasMorePages = false;
            }
    }
}