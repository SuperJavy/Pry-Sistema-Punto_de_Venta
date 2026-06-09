using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class clsUsuariosController
    {
        clsUsuarioModelo usuario = new clsUsuarioModelo();

        public void registrarUsuario(string nombre, string apellidoP, string apellidoM, string direcion, string telefono, string password, int id_rol, FrmAgregarUsuario vista)
        {
            if (string.IsNullOrEmpty(nombre)|| string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios (*).",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool exito = usuario.registrarUsuario(nombre.Trim(), apellidoP.Trim(), apellidoM.Trim(), direcion.Trim(), telefono.Trim(), password, id_rol);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo registrar al usuario: " + e.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarRoles(FrmAgregarUsuario vista)
        {
            try 
            {
                DataTable dtroles = usuario.obtenerRoles();

                vista.llenarComboRoles(dtroles);
            }
            catch(Exception ex)
            {
                vista.NotificarUsuario("Error al cargar los roles: " + ex.Message, true);
            }
        }
        
    }
}
