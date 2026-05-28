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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            FrmVentaproductos Vproduct = new FrmVentaproductos();
            Vproduct.Show();
        }
    }
}
