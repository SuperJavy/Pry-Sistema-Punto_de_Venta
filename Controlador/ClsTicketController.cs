using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.vista;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsTicketController
    {
        private clsTicketModelo modeloTicket = new clsTicketModelo();

        public void registrarConfiguracion(System.Drawing.Image logo, string nombre, string telefono, string direccion, string rfc, string mensaje, Frmticket vista)
        {
            // 1. Validaciones idénticas a tu lógica de categorías
            if (string.IsNullOrWhiteSpace(nombre))
            {
                vista.notificarUsuario("El nombre del negocio no puede estar vacío.", true);
                return;
            }

            if (string.IsNullOrWhiteSpace(rfc))
            {
                vista.notificarUsuario("El RFC del negocio es obligatorio.", true);
                return;
            }

            try
            {
                // 2. Empaquetamos los datos ya limpios con Trim() hacia el modelo
                clsTicketModelo datosAGuardar = new clsTicketModelo
                {
                    Logo = logo,
                    NombreNegocio = nombre.Trim(),
                    Telefono = telefono.Trim(),
                    Direccion = direccion.Trim(),
                    RFC = rfc.Trim(),
                    MensajeFinal = mensaje.Trim()
                };

                bool resultado = modeloTicket.guardarConfiguracion(datosAGuardar);

                if (resultado)
                {
                    vista.notificarUsuario("¡Configuración del ticket guardada de forma exitosa!", false);
                    vista.Close();
                }
                else
                {
                    vista.notificarUsuario("No se realizaron cambios en la configuración.", true);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("No se pudo registrar la configuración en el sistema: " + ex.Message, true);
            }
        }

        /// Flujo de Regreso: Recupera la configuración actual del ticket desde la base de datos.
      
        public clsTicketModelo cargarConfiguracion()
        {
            try
            {
                return modeloTicket.obtenerConfiguracion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos desde el controlador: " + ex.Message);
            }
        }
    }
}