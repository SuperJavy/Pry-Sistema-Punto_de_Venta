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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }
        private void FrmCompra_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnAgregarproducto_Click(sender, e);
                    break;

                case Keys.F10:
                    btnBuscar_Click(sender, e);
                    break;

                case Keys.Delete:
                    btnBorrar_Click(sender, e);
                    break;
                case Keys.F12:btnComprar_Click(sender, e);
                    break;
            }
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
