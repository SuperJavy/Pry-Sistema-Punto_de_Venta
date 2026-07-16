using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    // CAPA CONTROLADOR: puente entre la Vista (FrmCorteCaja) y el Modelo
    // (ClsCorteCajaModelo). La Vista NUNCA debe instanciar ni conocer al Modelo
    // directamente; siempre pasa por aquí. Esto es lo que permite que, si mañana
    // cambia la consulta SQL o el motor de base de datos, la Vista no se entere.
    internal class ClsCorteCajaController
    {
        private ClsCorteCajaModelo modelo = new ClsCorteCajaModelo();

        // Apertura de turno (fondo de caja inicial).
        public (bool exito, int idCorte, string mensaje) RegistrarApertura(int idUsuario, string textoMonto)
        {
            if (!decimal.TryParse(textoMonto, out decimal monto) || monto < 0)
                return (false, 0, "Por favor, ingrese una cantidad de fondo válida.");

            try
            {
                int idCorte = modelo.AbrirCaja(idUsuario, monto);
                bool exito = idCorte > 0;
                return (exito, idCorte, exito ? "" : "No se pudo registrar la apertura de caja.");
            }
            catch (Exception ex)
            {
                return (false, 0, "Error al registrar el fondo de caja: " + ex.Message);
            }
        }

        // Trae el turno abierto del usuario junto con todos los totales calculados
        // (ventas, salidas, tickets, artículos vendidos/cancelados). Se deja pasar
        // la excepción tal cual hacia la Vista porque FrmCorteCaja ya envuelve esta
        // llamada en su propio try/catch y decide cómo mostrarla al usuario.
        public Dictionary<string, decimal> ObtenerCorteDinamico(int idUsuario)
        {
            return modelo.ObtenerCorteDinamico(idUsuario);
        }

        // Cierra el turno actual con lo declarado por el cajero.
        public bool RegistrarCierreCaja(int idCorte, int idUsuario, decimal montoEsperado, decimal montoReal)
        {
            return modelo.CerrarCorte(idCorte, idUsuario, montoEsperado, montoReal);
        }

        // Usado por el login: si el usuario ya tiene un turno sin cerrar, se retoma
        // esa sesión de caja en vez de exigir una apertura nueva.
        public bool TieneTurnoAbierto(int idUsuario)
        {
            return modelo.TieneTurnoAbierto(idUsuario);
        }

        // Historial de cortes para FrmHistorialCortes. "hasta" se recibe como el día
        // seleccionado por el usuario (sin hora) y aquí se normaliza a exclusivo
        // (+1 día) para que ese día quede incluido completo en el filtro SQL.
        public List<Dictionary<string, object>> ObtenerHistorial(DateTime fechaDesde, DateTime fechaHasta, int idCajero, string estado)
        {
            DateTime hastaExclusiva = fechaHasta.Date.AddDays(1);
            return modelo.ObtenerHistorial(fechaDesde.Date, hastaExclusiva, idCajero, string.IsNullOrWhiteSpace(estado) ? "Todos" : estado);
        }

        // Cajeros disponibles para el combo de filtro del historial.
        public Dictionary<int, string> ObtenerCajeros()
        {
            return modelo.ObtenerCajeros();
        }
    }
}