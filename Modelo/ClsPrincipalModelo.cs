using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsPrincipalModelo
    {
        public string Asignarrol(string rol)
        {
            switch (rol)
            {
                case "1":
                    return "Administrador";
                    break;

                case "2":
                    return "Cajero"; 
                    break;
                default:
                    return "Rol no asignado";
                    break;
            }
        }
    }
}