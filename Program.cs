using Pry_Sistema_Punto_de_Venta;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Pry_Sistema_Punto_de_Venta
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Cambia "Form1" por el nombre real de tu formulario de inicio
            Application.Run(new FrmLogin());
        }
    }
}