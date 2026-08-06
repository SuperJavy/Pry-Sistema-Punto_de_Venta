using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    internal class Compra
    {
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }

        public DateTime fecha { get; set; }
        public List<DetalleCompra> detalleCompra { set; get; } = new List<DetalleCompra>();
        public decimal total
        {
            get
            {
                return detalleCompra.Sum(x => x.subtotalCompra);
            }
        }
    }
}