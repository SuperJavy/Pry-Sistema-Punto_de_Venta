using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{

    public class Producto
    {

        public int id_producto { get; set; }
        public string codigo_de_barras { get; set; }
        public string nombre { get; set; }
        public decimal precio_compra { get; set; }
        public decimal stock { get; set; }
        public decimal importe { get; set; }
        public Image imagen { get; set; }
        public string tipoVenta { get; set; }
        public decimal porcentaje { get; set; }
        private decimal _precioVentaManual;

        // Propiedad inteligente que realiza el cálculo de ganancia
        public decimal precio
        {
            get
            {
                // Si el dueño estableció un precio de compra y un porcentaje de ganancia mayor a 0, 
                // el sistema calcula el precio de venta final automáticamente.
                if (precio_compra > 0 && porcentaje > 0)
                {
                    decimal ganancia = precio_compra * (porcentaje / 100);
                    return precio_compra + ganancia;
                }

                // Si no usa porcentajes, devuelve el precio que el dueño haya escrito manualmente.
                return _precioVentaManual;
            }
            set
            {
                _precioVentaManual = value;
            }

        }

    }
    
}
