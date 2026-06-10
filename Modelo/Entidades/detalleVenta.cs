using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public class detalleVenta
    {

        public Producto Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Importe
        {
            get { return Cantidad * PrecioUnitario; }
        }

        

    }
}
