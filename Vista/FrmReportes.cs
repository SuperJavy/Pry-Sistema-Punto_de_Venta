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

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmReportes : Form
    {
        ClsPrincipal principal = new ClsPrincipal();

        public FrmReportes()
        {
            InitializeComponent();
        }

     

        private void ResaltarBoton(Button botonActivo)
        {
            btnCorte.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnCompras.BackColor = Color.White;
            botonActivo.BackColor = Color.FromArgb(236, 240, 241); // Gris claro al seleccionar
        }

        private void btnCorte_Click_1(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmCorteCaja(), pnlContenedorPrincipal);
            ResaltarBoton(btnCorte);
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmHistorialVentas(), pnlContenedorPrincipal);
            ResaltarBoton(btnVentas);
        }

        private void btnCompras_Click_1(object sender, EventArgs e)
        {
            principal.agregaralcontenedor(new FrmHistorialCompras(), pnlContenedorPrincipal);
            ResaltarBoton(btnCompras);
        }
    }
}
