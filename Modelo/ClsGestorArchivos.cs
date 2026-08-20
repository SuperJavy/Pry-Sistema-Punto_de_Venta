using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    public class ClsGestorArchivos
    {
        public static bool GuardarImagen(string rutaLocalOrigen, string subCarpeta, string nombreArchivoFinal)
        {
            try
            {
                string rutaDestinoBase = ClsConfiguracion.RutaGuardado;

                if (ClsConfiguracion.ModoArchivos.ToUpper() == "LOCAL")
                {
                    string carpetaFinal = Path.Combine(rutaDestinoBase, subCarpeta);
                    if (!Directory.Exists(carpetaFinal))
                        Directory.CreateDirectory(carpetaFinal);

                    string rutaCompleta = Path.Combine(carpetaFinal, nombreArchivoFinal);
                    File.Copy(rutaLocalOrigen, rutaCompleta, true);
                    return true;
                }
                else if (ClsConfiguracion.ModoArchivos.ToUpper() == "NUBE")
                {
                    string urlFtp = rutaDestinoBase + subCarpeta + "/" + nombreArchivoFinal;

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(urlFtp);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(ClsConfiguracion.FtpUsuario, ClsConfiguracion.FtpPassword);

                    byte[] fileContents = File.ReadAllBytes(rutaLocalOrigen);
                    request.ContentLength = fileContents.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(fileContents, 0, fileContents.Length);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static Image ExtraerImagen(string subCarpeta, string nombreArchivo)
        {
            if (string.IsNullOrWhiteSpace(nombreArchivo) || nombreArchivo == "default.png")
                return Properties.Resources.generico_1;

            try
            {
                if (ClsConfiguracion.ModoArchivos.ToUpper() == "LOCAL")
                {
                    string rutaCompleta = Path.Combine(ClsConfiguracion.RutaLectura, subCarpeta, nombreArchivo);
                    if (File.Exists(rutaCompleta))
                    {
                        using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
                        {
                            return Image.FromStream(fs);
                        }
                    }
                }
                else if (ClsConfiguracion.ModoArchivos.ToUpper() == "NUBE")
                {
                    string urlHttp = ClsConfiguracion.RutaLectura + subCarpeta + "/" + nombreArchivo;
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageData = client.DownloadData(urlHttp);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Ignorar error y devolver genérico
            }

            return Properties.Resources.generico_1; // Si falla algo, devuelve genérico
        }
    }
}
