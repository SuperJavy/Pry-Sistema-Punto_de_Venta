using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pry_Sistema_Punto_de_Venta.Vista;
using Pry_Sistema_Punto_de_Venta.Modelo;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsPrincipalController
    {
        ClsPrincipalModelo modelo = new ClsPrincipalModelo();

        public void verificarrol(string rolusuario, FrmPrincipal frmPrincipal)
        {
            string rolAsignado = modelo.Asignarrol(rolusuario);
            Otorgarpermisos(rolAsignado, frmPrincipal);
        }
        public void Otorgarpermisos(string rolusuario, FrmPrincipal frmPrincipal)
        {
            switch (rolusuario)
            {
                case "Administrador":
                    frmPrincipal.mnsVentas.Enabled = true;
                    frmPrincipal.mnsProductos.Enabled = true;
                    frmPrincipal.mnsCompra.Enabled = true;
                    frmPrincipal.mnsInventario.Enabled = true;
                    frmPrincipal.mnsConfiguraciones.Enabled = true;
                    break;
                case "Cajero":
                    frmPrincipal.mnsVentas.Enabled = true;
                    frmPrincipal.mnsProductos.Enabled = false;
                    frmPrincipal.mnsCompra.Enabled = false;
                    frmPrincipal.mnsInventario.Enabled = false;
                    frmPrincipal.mnsConfiguraciones.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
