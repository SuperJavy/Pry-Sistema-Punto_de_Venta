using Pry_Sistema_Punto_de_Venta.vista;
using Pry_Sistema_Punto_de_Venta.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmConfiguraciones : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        public FrmConfiguraciones()
        {
            InitializeComponent();
        }

        private void lblagregrausuarios_Click(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmAgregarUsuario(),pnlConfiguraciones);
        }

        private void lblEditarticket_Click(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new Frmticket(), pnlConfiguraciones);
        }
    }
}
