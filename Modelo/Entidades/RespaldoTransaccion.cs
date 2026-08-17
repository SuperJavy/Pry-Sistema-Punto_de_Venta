using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    public class RespaldoTransaccion
    {
        public int IdUsuarioDuenio { get; set; }
        public List<Itemrespaldo> Articulos { get; set; }
    }
}
