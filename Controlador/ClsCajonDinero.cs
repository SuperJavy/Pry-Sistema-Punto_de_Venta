using System;
using System.Runtime.InteropServices;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsCajonDinero
    {
        // 1. Estructura obligatoria para decirle a Windows cómo tratar los bytes
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
        }
        

        // 2. Importaciones de la API de Windows
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        public static void AbrirCajon(string nombreImpresora)
        {
            IntPtr hPrinter = new IntPtr(0);

            // Código universal (ESC/POS) para mandar el pulso eléctrico
            byte[] codigoApertura = new byte[] { 27, 112, 0, 25, 250 };

            try
            {
                if (OpenPrinter(nombreImpresora.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Preparamos el "Documento" en blanco
                    DOCINFOA di = new DOCINFOA();
                    di.pDocName = "Apertura de Cajon"; // Nombre que verás si abres la cola de impresión
                    di.pDataType = "RAW"; // CRÍTICO: Indica que enviaremos comandos directos

                    // Iniciamos el flujo correcto de Windows
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        if (StartPagePrinter(hPrinter))
                        {
                            int bytesEscritos = 0;
                            IntPtr punteroBytes = Marshal.AllocCoTaskMem(codigoApertura.Length);
                            Marshal.Copy(codigoApertura, 0, punteroBytes, codigoApertura.Length);

                            // Ahora sí, escribimos los bytes
                            WritePrinter(hPrinter, punteroBytes, codigoApertura.Length, out bytesEscritos);

                            Marshal.FreeCoTaskMem(punteroBytes);
                            EndPagePrinter(hPrinter); // Cerramos página
                        }
                        EndDocPrinter(hPrinter); // Cerramos documento
                    }
                    ClosePrinter(hPrinter); // Cerramos puerto
                }
            }
            catch (Exception)
            {
                // Silencioso para no romper la venta
            }
        }
    }
}