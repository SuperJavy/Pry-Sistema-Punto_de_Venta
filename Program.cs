using Pry_Sistema_Punto_de_Venta;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
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
            try
            {
                ClsConexion conexionBase = new ClsConexion();

                // Obligas al sistema a verificar si necesita construir las tablas
                conexionBase.VerificarYCrearBaseDeDatos();

                // Si todo sale bien, arranca el login
                Application.Run(new FrmLogin());
            }
            catch (Exception ex)
            {
                // Si algo falla, el programa no se cerrará de golpe, sino que te mostrará el error exacto
                MessageBox.Show("Error crítico al inicializar el sistema:\n\n" + ex.Message,
                                "Fallo de Arranque",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}