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
    public partial class FrmPedirPeso : Form
    {
        // Esta propiedad es la que leerá tu controlador
        public decimal PesoIngresado { get; private set; }

        public FrmPedirPeso(string nombreDelProducto)
        {
            InitializeComponent();

            // Mostramos el nombre del producto en el título gigante
            lblNombreProducto.Text = nombreDelProducto;

            // Seleccionamos el texto "0.00" para que al teclear se borre automáticamente
            txtPeso.SelectAll();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Intentamos convertir lo que escribió a decimal
            if (decimal.TryParse(txtPeso.Text, out decimal pesoConvertido) && pesoConvertido > 0)
            {
                PesoIngresado = pesoConvertido;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor a cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                txtPeso.SelectAll();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmPedirPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true; // Evita el sonido de "Ding"
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancelar_Click(sender, e);
            }
        }

        // Esta protección evita que el cajero escriba letras en la cantidad
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, la tecla de borrar y UN SOLO punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si ya hay un punto decimal, no permitir otro
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
