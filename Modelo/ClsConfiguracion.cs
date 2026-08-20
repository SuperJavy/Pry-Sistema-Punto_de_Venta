 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsConfiguracion
    {
        public static string ModoArchivos { get; private set; } = "LOCAL";
        public static string RutaGuardado { get; private set; } = @"C:\PuntoDeVenta\Imagenes\";
        public static string RutaLectura { get; private set; } = @"C:\PuntoDeVenta\Imagenes\";
        public static string FtpUsuario { get; private set; } = "";
        public static string FtpPassword { get; private set; } = "";

        public static void CargarConfiguracion()
        {
            string rutaXml = Path.Combine(Application.StartupPath, "config_Conexion.xml");

            if (File.Exists(rutaXml))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(rutaXml);

                    ModoArchivos = doc.SelectSingleNode("//ModoArchivos")?.InnerText ?? "LOCAL";
                    RutaGuardado = doc.SelectSingleNode("//RutaGuardado")?.InnerText ?? @"C:\PuntoDeVenta\Imagenes\";
                    RutaLectura = doc.SelectSingleNode("//RutaLectura")?.InnerText ?? @"C:\PuntoDeVenta\Imagenes\";
                    FtpUsuario = doc.SelectSingleNode("//FtpUsuario")?.InnerText ?? "";
                    FtpPassword = doc.SelectSingleNode("//FtpPassword")?.InnerText ?? "";
                }
                catch (Exception)
                {
                    // Si falla, se queda con los valores LOCAL por defecto
                }
            }
        }
    }
}
