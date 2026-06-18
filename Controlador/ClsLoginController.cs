using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsLoginController
    {
        private ClsLoginModelo ModeloLogin = new ClsLoginModelo();

        public string ROl { get; set; }
        public ClsLoginController()
        {             ROl = ModeloLogin.Rol;
        }

        public void validarcampos(string Nickname, string Password, FrmLogin vista)
        {

            try
            {
                bool esValido = ModeloLogin.validarusuario(Nickname.Trim(), Password.Trim());

                if (esValido)
                {
                    // AQUÍ ESTÁ EL CAMBIO: Asignamos el valor directamente del modelo
                    this.ROl = ModeloLogin.Rol;
                    vista.notificarUsuario("Bienvenido, " + Nickname, false);
                }
                else
                {
                    vista.notificarUsuario("Usuario o contraseña incorrectos", true);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error: " + ex.Message, true);
            }
        }

        public bool Validaradmin(string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("La contraseña no puede estar vacía.");
                }

                return ModeloLogin.Validarpassword(password);

            }
            catch (Exception e)
            {
                throw new Exception("" + e.Message);
            }
        }
    }
}
