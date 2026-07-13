using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsCorteDiarioController
    {

        private ClsCorteDiarioModelo modeloCorte = new ClsCorteDiarioModelo();

        public Dictionary<string, decimal> ObtenerCorteDinamico(int idUsuario)
        {
            try
            {
                return modeloCorte.ConsultarTotalesTurnoActivo(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo en el controlador del corte: " + ex.Message);
            }
        }
        public bool RegistrarCierreCaja(int idUsuario, decimal montoEsperado, decimal montoReal)
{
            try
            {
                // Calculamos la diferencia: 
                // Si es negativo = Falta dinero en caja. 
                // Si es positivo = Sobra dinero en caja.
                decimal diferencia = montoReal - montoEsperado;

                return modeloCorte.CerrarTurnoActivo(idUsuario, montoEsperado, montoReal, diferencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo en el controlador al intentar cerrar el turno: " + ex.Message);
            }
        }
    }
}
