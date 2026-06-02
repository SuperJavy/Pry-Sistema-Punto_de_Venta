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
    public partial class FrmVentaproductos : Form
    {
        public FrmVentaproductos()
        {
            InitializeComponent();
        }

        private void FrmVentaproductos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnCobrarImprimir.PerformClick();
                    break;
                case Keys.F2:
                    btnCobrarSolo.PerformClick();
                    break;
                case Keys.Escape:
                    btnCancelar.PerformClick();
                    break;
            }
        }

        private void btnCobrarImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
