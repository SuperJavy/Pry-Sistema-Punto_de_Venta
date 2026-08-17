using System.Text.Json;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public static class ClsRespaldo
    {
        public static void guardarRespaldo(string ruta, RespaldoTransaccion datos)
        {
            try
            {
                //Validamos la lista interna de artículos ('datos.Articulos')
                if (datos == null || datos.Articulos == null || datos.Articulos.Count == 0)
                {
                    eliminarRespaldo(ruta);
                    return;
                }
                string jsonString = JsonSerializer.Serialize(datos);
                File.WriteAllText(ruta, jsonString);
            }
            catch { }
        }

        //retorna el objeto contenedor 'RespaldoTransaccion'
        public static RespaldoTransaccion recuperar(string ruta)
        {
            if (!File.Exists(ruta)) return null;

            try
            {
                string jsonString = File.ReadAllText(ruta);

                // CORRECCIÓN 4: Deserializa el JSON al nuevo formato completo
                return JsonSerializer.Deserialize<RespaldoTransaccion>(jsonString);
            }
            catch
            {
                eliminarRespaldo(ruta);
                return null;
            }
        }

        public static void eliminarRespaldo(string ruta)
        {
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }

    }

    public class Itemrespaldo
    {
        public string codigoBarras { get; set; }
        public decimal cantidad { get; set; }
        public decimal precioCompra { get; set; }
        public decimal costo { get; set; }
        public decimal porcentaje { get; set; }
    }

}
