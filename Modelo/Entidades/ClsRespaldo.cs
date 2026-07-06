using Pry_Sistema_Punto_de_Venta.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public static class ClsRespaldo
    {   
        public static void guardarRespaldo(string ruta, List<Itemrespaldo> datos) 
        {
            try
            {
                if (datos == null || datos.Count == 0)
                {
                    eliminarRespaldo(ruta);
                    return;
                }
                string jsonSting = JsonSerializer.Serialize(datos);
                File.WriteAllText(ruta, jsonSting);
            }
            catch { }
        }
        public static List<Itemrespaldo> recuperar(string ruta)
        {
            if (!File.Exists(ruta)) return null;

            try
            {
                string jsonString = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<List<Itemrespaldo>>(jsonString);
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
    }

}
