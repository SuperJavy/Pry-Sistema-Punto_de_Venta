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
    public partial class FrmVistaPreviaTicket : Form
    {
        public FrmVistaPreviaTicket(Image logo, string nombre, string telefono, string direccion, string rfc, string mensaje)
        {
            InitializeComponent();

            // Mapeamos el logo
            if (logo != null) { picPreviaLogo.Image = logo; picPreviaLogo.Visible = true; }
            else { picPreviaLogo.Visible = false; }

            // Mapeamos los strings y les damos formato por si vienen vacíos
            lblPreviaNombre.Text = string.IsNullOrWhiteSpace(nombre) ? "NOMBRE DEL NEGOCIO" : nombre.ToUpper();
            lblPreviaDireccion.Text = string.IsNullOrWhiteSpace(direccion) ? "Dirección del Establecimiento" : direccion;
            lblPreviaTelefono.Text = string.IsNullOrWhiteSpace(telefono) ? "Tel: 000-000-0000" : "Tel: " + telefono;
            lblPreviaRfc.Text = string.IsNullOrWhiteSpace(rfc) ? "RFC: XAXX010101000" : "RFC: " + rfc.ToUpper();
            lblPreviaMensaje.Text = string.IsNullOrWhiteSpace(mensaje) ? "¡Gracias por su compra!" : mensaje;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //pendiente programar el ticket de la compra que aparescan los productos 
    }
}
