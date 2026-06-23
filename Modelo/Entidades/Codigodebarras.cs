using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.SkiaSharp;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    internal class Codigodebarras
    {

        /// <summary>
        /// Esta función no parará hasta encontrar un número que no exista en la BD.
        /// </summary>
        static string ObtenerNumeroUnicoEInexistente()
        {
            bool yaExiste = true;
            string numeroCandidato = "";

            // El ciclo se repetirá mientrás el número generado SÍ exista en la base de datos
            while (yaExiste)
            {
                numeroCandidato = GenerarNumeroAleatorio();

                // Llamamos a la función que revisa la BD
                yaExiste = ExisteEnBaseDeDatos(numeroCandidato);

                if (yaExiste)
                {
                    Console.WriteLine($"[Aviso] El número {numeroCandidato} ya existía en la BD. Generando otro...");
                }
            }

            // Si salimos del ciclo, significa que yaExiste es 'false', por lo tanto el número es limpio y nuevo
            return numeroCandidato;
        }

        /// <summary>
        /// Genera un número base de 12 dígitos al azar
        /// </summary>
        static string GenerarNumeroAleatorio()
        {
            Random random = new Random();
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                resultado.Append(random.Next(0, 10));
            }

            return resultado.ToString();
        }

        /// <summary>
        /// CONECTA ESTO CON TU BASE DE DATOS.
        /// Debe retornar TRUE si el número ya está registrado, o FALSE si está libre.
        /// </summary>
        static bool ExisteEnBaseDeDatos(string numero)
        {
            // ------------- EJEMPLO DE LÓGICA SIMULADA -------------
            // Aquí adentro harías tu consulta: "SELECT COUNT(*) FROM Productos WHERE Codigo = ..."

            // Simulemos que el número "123456789012" ya está ocupado en tu BD
            if (numero == "123456789012")
            {
                return true;
            }

            return false; // El 99.9% de las veces el azar te dará uno libre (false)
                          // ------------------------------------------------------
        }

        /// <summary>
        /// Dibuja y guarda el código de barras en formato PNG
        /// </summary>
        static void GuardarCodigoBarras(string numeroProducto)
        {
            var generador = new BarcodeWriter
            {
                Format = BarcodeFormat.EAN_13,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 150,
                    Margin = 10,
                    PureBarcode = false
                }
            };

            try
            {
                using (var dibujoEnMemoria = generador.Write(numeroProducto))
                using (var imagenReal = SkiaSharp.SKImage.FromBitmap(dibujoEnMemoria))
                using (var datosImagen = imagenReal.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100))
                using (var archivoFisico = File.OpenWrite($"producto_{numeroProducto}.png"))
                {
                    datosImagen.SaveTo(archivoFisico);
                    Console.WriteLine($"2. Código de barras guardado físicamente: producto_{numeroProducto}.png");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al crear la imagen: " + error.Message);
            }
        }
    }
}
