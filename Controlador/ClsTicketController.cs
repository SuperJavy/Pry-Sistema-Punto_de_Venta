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

        public void registrarConfiguracion(string rutaLogo, string nombre, string telefono, string direccion, string rfc, string mensaje, Frmticket vista)
        {
            try
            {
                string nombreArchivoFinal = null;

                // Si el usuario seleccionó un nuevo logo, lo guardamos con el Gestor
                if (!string.IsNullOrWhiteSpace(rutaLogo))
                {
                    string extImagen = System.IO.Path.GetExtension(rutaLogo);
                    nombreArchivoFinal = "logo_ticket" + extImagen; // Nombre estático para que siempre se sobreescriba

                    bool fotoGuardada = ClsGestorArchivos.GuardarImagen(rutaLogo, @"Logos\", nombreArchivoFinal);
                    if (!fotoGuardada)
                    {
                        vista.notificarUsuario("Advertencia: No se pudo actualizar el logo físico en el servidor.", true);
                        nombreArchivoFinal = null;
                    }
                }

                // Empaquetamos los datos. OJO: Cambiaremos la propiedad 'Logo' en tu entidad para que sea string (Paso 3)
                clsTicketModelo datosTicket = new clsTicketModelo
                {
                    NombreArchivoLogo = nombreArchivoFinal, // <-- Nueva propiedad de texto
                    NombreNegocio = nombre,
                    Telefono = telefono,
                    Direccion = direccion,
                    RFC = rfc,
                    MensajeFinal = mensaje
                };

                bool exito = modeloTicket.guardarConfiguracion(datosTicket);

                if (exito) vista.notificarUsuario("Configuración del ticket guardada correctamente.", false);
                else vista.notificarUsuario("No se pudo guardar la configuración en la base de datos.", true);
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error al registrar la configuración: " + ex.Message, true);
            }
        }


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

            // Fuentes fijas para el tamaño de 58mm
            Font fuenteNormal = new Font("Arial", 8);
            Font fuenteNegrita = new Font("Arial", 8, FontStyle.Bold);
            Font fuenteTitulo = new Font("Arial", 11, FontStyle.Bold);
            Brush brocha = Brushes.Black;

            // Dimensiones fijas estrictas para 58mm (aprox 2 pulgadas)
            // Se dibujará igual en la térmica o en la esquina superior izquierda de la impresora normal
            int margenIzquierdo = 5;
            int anchoTicket = 175; // Límite estricto de dibujo para 58mm
            int limiteDerecho = margenIzquierdo + anchoTicket - 15;
            int y = 20;

            StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat formatoDerecha = new StringFormat { Alignment = StringAlignment.Far };

            // --- CABECERA Y LOGO ---
            if (configActual.Logo != null)
            {
                // Tamaño fijo del logo para 58mm
                int logoAncho = 80;
                int logoAlto = 80;
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

            // Línea separadora adaptada a los 190 de ancho
            gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
            y += 20;

            // --- DETALLE DE PRODUCTOS ---
            gfx.DrawString("Cant.   Producto", fuenteNegrita, brocha, margenIzquierdo, y);
            // CORREGIDO: Usamos limiteDerecho
            gfx.DrawString("Importe", fuenteNegrita, brocha, limiteDerecho, y, formatoDerecha);
            y += 20;

            if (ventaActual.detalleVenta != null)
            {
                foreach (var item in ventaActual.detalleVenta)
                {
                    string nombreProd = item.Producto.nombre;

                    if (nombreProd.Length > 12) // Truncamos a 12 caracteres
                    {
                        nombreProd = nombreProd.Substring(0, 12) + "...";
                    }

                    gfx.DrawString($"{item.Cantidad}x   {nombreProd}", fuenteNormal, brocha, margenIzquierdo, y);
                    // CORREGIDO: Usamos limiteDerecho
                    gfx.DrawString($"${item.Importe:F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                    y += 15;
                }
            }

            gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
            y += 20;

            // --- TOTALES ---
            // CORREGIDO: Usamos limiteDerecho en todos los totales
            gfx.DrawString($"TOTAL: ${ventaActual.total:F2}", fuenteTitulo, brocha, limiteDerecho, y, formatoDerecha);
            y += 25;
            gfx.DrawString($"Efectivo: ${ventaActual.efectivo:F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
            y += 15;
            gfx.DrawString($"Cambio: ${ventaActual.cambio:F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
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

            this.configActual = modeloTicket.obtenerConfiguracion();

            if (this.configActual == null)
            {
                MessageBox.Show("Aún no se ha configurado el formato del ticket.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument documento = new PrintDocument();

            // --- SOLUCIÓN AL BLOQUEO ---
            // Oculta el cuadro de diálogo de impresión para que no colisionen los trabajos
            documento.PrintController = new System.Drawing.Printing.StandardPrintController();

            documento.DocumentName = "Ticket_Corte_Caja";

            if (!string.IsNullOrEmpty(nombreImpresora))
            {
                documento.PrinterSettings.PrinterName = nombreImpresora;
            }

            if (esTermica)
            {
                // --- SOLUCIÓN A LA INFORMACIÓN RECORTADA ---
                // Aumentamos el alto de 350 a 600 para que quepan todos los textos
                // Y ajustamos el ancho a 228 (los 58mm)
                documento.DefaultPageSettings.PaperSize = new PaperSize("Custom", 228, 600);
                documento.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            }
            else
            {
                // ... (Mantén tu código de PaperKind.Letter intacto aquí)
            }

            documento.PrintPage += new PrintPageEventHandler(GenerarCuerpoTicketCorte);

            try
            {
                documento.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de hardware: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarCuerpoTicketCorte(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics gfx = e.Graphics;
                Font fuenteNormal = new Font("Arial", 8);
                Font fuenteNegrita = new Font("Arial", 8, FontStyle.Bold);
                Font fuenteTitulo = new Font("Arial", 11, FontStyle.Bold);
                Brush brocha = Brushes.Black;

                int margenIzquierdo = 5;
                int anchoTicket = 175;
                int limiteDerecho = margenIzquierdo + anchoTicket - 15;
                int y = 20;

                StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat formatoDerecha = new StringFormat { Alignment = StringAlignment.Far };

                // Función segura para extraer datos (evita que el ticket se cancele si falta un dato)
                decimal ObtenerDato(string llave)
                {
                    if (corteActual != null && corteActual.ContainsKey(llave))
                        return corteActual[llave];
                    return 0m;
                }

                // --- CABECERA Y LOGO ---
                if (configActual.Logo != null)
                {
                    int logoAncho = 80;
                    int logoAlto = 80;
                    int logoX = margenIzquierdo + ((anchoTicket - logoAncho) / 2);
                    gfx.DrawImage(configActual.Logo, logoX, y, logoAncho, logoAlto);
                    y += logoAlto + 10;
                }

                // Usamos "??" para evitar errores si en la BD no guardaron nombre o dirección
                string nombreNegocio = configActual.NombreNegocio ?? "Negocio";
                gfx.DrawString(nombreNegocio, fuenteTitulo, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 25;

                gfx.DrawString("CORTE DE CAJA", fuenteTitulo, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 25;

                gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, brocha, margenIzquierdo, y);
                y += 15;

                string idCajero = cajeroCorte ?? "Desconocido";
                gfx.DrawString("Cajero ID: " + idCajero, fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                // --- DETALLES DEL CORTE ---
                gfx.DrawString("Fondo Inicial:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"${ObtenerDato("FondoInicial"):F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Ventas Efectivo:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"+ ${ObtenerDato("VentasEfectivo"):F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Salidas:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString($"- ${ObtenerDato("Salidas"):F2}", fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 20;

                gfx.DrawString(new string('-', anchoTicket / 5), fuenteNormal, brocha, margenIzquierdo, y);
                y += 20;

                // --- RESULTADOS FINALES ---
                gfx.DrawString("TOTAL ESPERADO:", fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteMontoEsperado:F2}", fuenteNegrita, brocha, limiteDerecho, y, formatoDerecha);
                y += 20;

                gfx.DrawString("TOTAL CONTADO:", fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteMontoReal:F2}", fuenteNegrita, brocha, limiteDerecho, y, formatoDerecha);
                y += 20;

                string textoDiferencia = corteDiferencia < 0 ? "FALTANTE:" : (corteDiferencia > 0 ? "SOBRANTE:" : "DIFERENCIA:");
                gfx.DrawString(textoDiferencia, fuenteNegrita, brocha, margenIzquierdo, y);
                gfx.DrawString($"${corteDiferencia:F2}", fuenteNegrita, brocha, limiteDerecho, y, formatoDerecha);
                y += 30;

                // --- ESTADÍSTICAS ---
                gfx.DrawString("ESTADÍSTICAS", fuenteNegrita, brocha, margenIzquierdo + (anchoTicket / 2), y, formatoCentro);
                y += 20;

                gfx.DrawString("Tickets Generados:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(ObtenerDato("TotalTickets").ToString(), fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Art. Vendidos:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(ObtenerDato("ArticulosVendidos").ToString(), fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 15;

                gfx.DrawString("Art. Cancelados:", fuenteNormal, brocha, margenIzquierdo, y);
                gfx.DrawString(ObtenerDato("ArticulosCancelados").ToString(), fuenteNormal, brocha, limiteDerecho, y, formatoDerecha);
                y += 30;

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                // SI OCURRE UN ERROR, AHORA SÍ LO VEREMOS
                MessageBox.Show("Error al dibujar el ticket: " + ex.Message, "Error Gráfico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}