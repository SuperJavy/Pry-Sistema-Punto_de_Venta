using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsImpresoraTermica
    {
        // Librerías de Windows para imprimir directamente sin el cuadro de diálogo
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool OpenPrinter(string pbstrPrinterName, out IntPtr phPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", ExactSpelling = true)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", ExactSpelling = true)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", ExactSpelling = true)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", ExactSpelling = true)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", ExactSpelling = true)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
        }


        private string lineaTicket = "";

        // Método para agregar texto normal
        public void AgregarLinea(string texto)
        {
            lineaTicket += texto + "\n";
        }

        // Método para cortar el papel
        public void CortarPapel()
        {
            lineaTicket += "\x1B" + "m";
        }

        // Método para disparar la señal de apertura del cajón
        public void AbrirCajon()
        {
            lineaTicket += "\x1B" + "p" + "\x00" + "\x0F" + "\x96";
        }

        // Método final que envía todo a la impresora
        public void Imprimir(string nombreImpresora)
        {
            IntPtr pBytes;
            Int32 dwCount;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            int dwWritten = 0;

            di.pDocName = "TicketVenta";
            di.pDataType = "RAW";

            if (OpenPrinter(nombreImpresora.Normalize(), out hPrinter, IntPtr.Zero))
            {
                if (StartDocPrinter(hPrinter, 1, ref di))
                {
                    if (StartPagePrinter(hPrinter))
                    {
                        // Convertir el string a bytes y enviarlo
                        pBytes = Marshal.StringToCoTaskMemAnsi(lineaTicket);
                        dwCount = lineaTicket.Length;
                        WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        Marshal.FreeCoTaskMem(pBytes);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            lineaTicket = ""; // Limpiar después de imprimir
        }
    
    }
}
