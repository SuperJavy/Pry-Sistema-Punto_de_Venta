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
    public partial class FrmAlerta : Form
    {
        ClsPrincipal principal; 
        FrmProductos productos;
        private string botonPresionado;
        public FrmAlerta(FrmProductos frmProductos,string boton)
        {
            InitializeComponent();
            principal = new ClsPrincipal();
            productos = frmProductos;
            this.botonPresionado = boton;
        }
        private void btnbuscarproduct_Click(object sender, EventArgs e)
        {
            // Primero cerramos esta ventanita pequeña
            this.Close();

            // EL IF: Aquí decide qué ventana abrir usando la palabra guardada
            if (botonPresionado == "Modificar")
            {
                principal.agregaralcontenedor(new FrmModoficar(),productos.PnlProducto);

            }
            else if (botonPresionado == "Eliminar")
            {
               principal.agregaralcontenedor(new FrmEliminarproductos(), productos.PnlProducto);

            }
        }
    }
}
