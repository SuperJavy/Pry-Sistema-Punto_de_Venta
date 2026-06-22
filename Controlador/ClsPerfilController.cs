using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsPerfilController
    {

        Modelo.ClsPerfilModelo perfilModelo = new Modelo.ClsPerfilModelo();
        public DataTable ObtenerPerfil(string usuario)
        {
            return perfilModelo.ObtenerPerfil(usuario);
        }

        public void Actualizarpassword(string usuario, string nuevoPassword, FrmPerfil vista)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(nuevoPassword))
            {
                throw new ArgumentException("El nombre de usuario y la nueva contraseña no pueden estar vacíos.");
            }

            try
            {
                bool esvalido = perfilModelo.Actualizarpassword(usuario, nuevoPassword);

                if (esvalido)
                {
                    vista.notificarUsuario("Los datos fueron actualizados correctamente", false);
                }
                else
                {
                    vista.notificarUsuario("Eror al intentar actualizar los datos", true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la contraseña: " + ex.Message);
            }
        }
    }
}
