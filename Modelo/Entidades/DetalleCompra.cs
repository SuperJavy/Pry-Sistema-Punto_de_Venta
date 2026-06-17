using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public class DetalleCompra
    {
        public Producto producto { get; set; }

        public decimal cantidad { get; set; }
        public decimal precioCompra { get; set; }
        public decimal subtotalCompra { get { return cantidad * precioCompra; } }

    }
}
