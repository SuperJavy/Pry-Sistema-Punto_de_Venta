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

        public void validarcampos(string Nombre, string Password, FrmLogin vista)
        {
            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Password))
            {
                vista.notificarUsuario("Los campos no pueden estar vacíos", true);
                return;
            }
            try
            {
                ClsLoginModelo DatosaValidar = new ClsLoginModelo
                {
                    Nombre = Nombre.Trim(),
                    Password = Password.Trim()
                };
                bool esValido = ModeloLogin.validarusuario(DatosaValidar.Nombre, DatosaValidar.Password);
                if (esValido)
                {
                    this.ROl = ModeloLogin.Rol;

                    vista.notificarUsuario("Bienvenido" + Nombre + "Punto de Venta", false);

                }
                else
                {
                    //vista.notificarUsuario($"Incorrecto. Busqué el Usuario: [{Nombre}] y la Contraseña: [{Password}]", true);
                    vista.notificarUsuario("Usuario o contraseña incorrectos", true);
                }


            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error de conexión o consulta: " + ex.Message, true);
            }
        }
    }
}
