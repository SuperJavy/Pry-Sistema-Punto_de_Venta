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
    
    public partial class FrmAlertaM : Form
    {
        ClsPrincipal principal = new ClsPrincipal();
        FrmProductos productos;

        public FrmAlertaM(FrmProductos frmProductos)
        {
            InitializeComponent();
            productos = frmProductos;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(
                new FrmModoficar(),
                productos.PnlProductos
            );

            this.Close();
        }
    }

   
}
