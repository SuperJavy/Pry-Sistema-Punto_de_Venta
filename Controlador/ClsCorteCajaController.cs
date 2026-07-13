using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsCorteCajaController
    {
        private ClsCorteCajaModelo modelo = new ClsCorteCajaModelo();

        public bool RegistrarApertura(int idUsuario, string textoMonto, Form vista)
        {
            if (!decimal.TryParse(textoMonto, out decimal monto) || monto < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad de fondo válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                return modelo.AbrirCaja(idUsuario, monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el fondo de caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
    }
}
