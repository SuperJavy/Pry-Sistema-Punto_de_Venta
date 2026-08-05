using Pry_Sistema_Punto_de_Venta.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo;
namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmReportes : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        int usuarioActual;
        string rolUsuarioActual;
        public FrmReportes(int idUsuario, string rol)
        {
            InitializeComponent();
            usuarioActual = idUsuario;
            rolUsuarioActual = rol;
        }

        private void ResaltarBoton(ToolStripMenuItem itemActivo)
        {
            corteDiarioToolStripMenuItem.BackColor = Color.White;
            historialDeVentasToolStripMenuItem.BackColor = Color.White;
            historialDeComprasToolStripMenuItem.BackColor = Color.White;
            itemActivo.BackColor = Color.FromArgb(236, 240, 241);
        }

        private void corteDiarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResaltarBoton(corteDiarioToolStripMenuItem);
            principal.agregaralcontenedor(new FrmCorteCaja(usuarioActual, rolUsuarioActual), pnlContenedorPrincipal);

        }

        private void historialDeVentasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResaltarBoton(historialDeVentasToolStripMenuItem);
            principal.agregaralcontenedor(new FrmHistorialVentas(), pnlContenedorPrincipal);
        }

        private void historialDeComprasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResaltarBoton(historialDeComprasToolStripMenuItem);
            principal.agregaralcontenedor(new FrmHistorialCompras(), pnlContenedorPrincipal);
        }
    }
}
