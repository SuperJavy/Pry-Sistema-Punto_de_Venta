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
            Pry_Sistema_Punto_de_Venta.Modelo.ClsConfiguracion.CargarConfiguracion();
            bool arrancarLogin = false;

            // Este ciclo intentará conectar. Si falla, abre la configuración. 
            // Si el usuario guarda nuevos datos, el ciclo vuelve a intentar conectar.
            while (true)
            {
                try
                {
                    ClsConexion conexionBase = new ClsConexion();

                    // Intentamos verificar y construir las tablas
                    conexionBase.VerificarYCrearBaseDeDatos();

                    // Si la línea de arriba no lanzó error, ¡la conexión fue un éxito!
                    arrancarLogin = true;
                    break; // Rompemos el ciclo infinito
                }
                catch (Exception ex)
                {
                    // Ocurrió un error. Le avisamos al usuario.
                    MessageBox.Show("No se pudo conectar a la base de datos o el archivo de configuración es inválido.\n\nDetalle: " + ex.Message,
                                    "Fallo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Abrimos tu nueva ventana de configuración (que crearemos en el Paso 2)
                    using (FrmDatosConexion frmConfig = new FrmDatosConexion())
                    {
                        // Si el usuario da clic en la X roja para cerrar o cancelar, salimos del ciclo y el programa muere.
                        if (frmConfig.ShowDialog() != DialogResult.OK)
                        {
                            break;
                        }
                        // Si el usuario dio clic en "Guardar" (DialogResult.OK), 
                        // el ciclo 'while' volverá a empezar automáticamente para probar los nuevos datos.
                    }
                }
            }

            // Si salimos del ciclo y la conexión fue exitosa, abrimos el Login.
            if (arrancarLogin)
            {
                Application.Run(new FrmLogin());
            }
        }
    }
}