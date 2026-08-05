using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public class ventas
    {

        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public decimal efectivo { get; set; }
        public DateTime fecha { get; set; }
        public List<detalleVenta> detalleVenta { set; get; } = new List<detalleVenta>();
        public decimal total
        {
            get
            {
                return detalleVenta.Sum(x => x.Importe);
            }
        }
        public decimal cambio { get { return efectivo - total; } }
        public int id_estado { get; set; }
    }
}
