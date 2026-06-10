using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
   
        public class Producto {

            public int id_producto  { get; set; }
            public string codigo_de_barras { get; set; }
            public string nombre { get; set; }
            public decimal precio { get; set; }
            public decimal stock { get; set; }
            public decimal importe { get; set; }
            public string imagen { get; set; }
            public string tipoVenta { get; set; }


        }
        

    
}
