using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsCajonDinero
    {
        // Importamos las librerías nativas de Windows para comunicarnos directo con el puerto
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        public static void AbrirCajon(string nombreImpresora)
        {
            IntPtr hPrinter = new IntPtr(0);

            // Este es el código universal (ESC/POS) que entienden las impresoras térmicas
            // para mandar el pulso eléctrico y botar el cajón de dinero.
            byte[] codigoApertura = new byte[] { 27, 112, 0, 25, 250 };

            try
            {
                if (OpenPrinter(nombreImpresora.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    int bytesEscritos = 0;
                    IntPtr punteroBytes = Marshal.AllocCoTaskMem(codigoApertura.Length);
                    Marshal.Copy(codigoApertura, 0, punteroBytes, codigoApertura.Length);

                    // Enviamos la orden de bytes crudos a la impresora
                    WritePrinter(hPrinter, punteroBytes, codigoApertura.Length, out bytesEscritos);

                    // Liberamos la memoria y cerramos la conexión
                    Marshal.FreeCoTaskMem(punteroBytes);
                    ClosePrinter(hPrinter);
                }
            }
            catch (Exception)
            {
                // Se atrapa en silencio para no interrumpir el flujo de venta del cajero
                // en caso de que haya problemas físicos con la impresora o el cable.
            }
        }
    }
}
