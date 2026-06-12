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

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmNuevoProductio : Form
    {
        ClsProductController controlador = new ClsProductController();
        public FrmNuevoProductio()
        {
            InitializeComponent();
            DataTable dt = controlador.Cargarcategorias(this);
            llenarComboRoles(dt);
        }
        public void notificarUsuario(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarproducto_Click(object sender, EventArgs e)
        {
            int tipoventa = 0;
            if (chkUnidad.Checked)
            {
                tipoventa = 1;
            }
            else if (chkGranel.Checked)
            {
                tipoventa = 2;
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un tipo de venta");
            }
            controlador.Registrarproductos(txtCodigo.Text, txtNombrep.Text, txtDescripcion.Text,
                tipoventa.ToString(), txtCosto.Text, txtPrecioventa.Text, cbxCategoria.SelectedValue.ToString(), txtStockactual.Text, txtStockminimo.Text, pcbImagen.Image,nudPorcentaje.Value.ToString(), this);
        }

        private void nudGanancia_ValueChanged(object sender, EventArgs e)
        {
            float preciov = controlador.Calcularprecioventa(txtCosto.Text, nudPorcentaje.Value.ToString(), this);
            txtPrecioventa.Text = preciov.ToString();


        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
            buscador.Title = "Seleccionar Logo del Negocio";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                pcbImagen.Image = Image.FromFile(buscador.FileName);
            }
        }
        public void llenarComboRoles(DataTable dtCategoria)
        {
            if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            {
                cbxCategoria.DataSource = null; // Limpia 

                // 2. Asignación de miembros 
                cbxCategoria.DisplayMember = "Nombre";
                cbxCategoria.ValueMember = "Id";

                // 3. Asignación del origen de datos
                cbxCategoria.DataSource = dtCategoria;
            }
            else
            {
                // Opcional: Limpiar el combo si no hay datos
                cbxCategoria.DataSource = null;
            }
        }

        private void txtNombrep_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false; // Deja pasar el carácter
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Deja pasar el espacio
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Deja borrar texto
            }
            else
            {
                e.Handled = true; // "Atrapa" el evento y lo cancela
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false; // Deja pasar el carácter
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Deja pasar el espacio
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Deja borrar texto
            }
            else
            {
                e.Handled = true; // "Atrapa" el evento y lo cancela
            }

        }

        private void txtPrecioventa_TextChanged(object sender, EventArgs e)
        {
            txtPrecioventa.ReadOnly = true;
        }

    }
}