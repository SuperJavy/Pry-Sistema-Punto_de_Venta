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

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmCategorias : Form
    {

        private clsCategoriasController categoria = new clsCategoriasController();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            categoria.agregarCategoria(txtNombreCategoria.Text, this);

            limpiarPantalla();

            ActualizarGrid();
        }
        public void limpiarPantalla()
        {
            txtNombreCategoria.Clear();
            txtNombreCategoria.Focus();
        }

        public void notificarUsuario(string mensaje, bool esError)
        {
            MessageBox.Show(
                mensaje,
                "Punto de Venta",
                MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information
            );
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        public void ActualizarGrid()
        {
            DataTable dt = categoria.CargarDTGcat(this);

            if (dt != null)
            {
                dgvMostrarcategorias.DataSource = dt;

                if (dgvMostrarcategorias.Columns.Contains("Id"))
                {
                    dgvMostrarcategorias.Columns["Id"].Visible = false;
                }

                dgvMostrarcategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgvMostrarcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMostrarcategorias.Rows[e.RowIndex];

                // Pasamos el valor de la celda al TextBox
                // Asegúrate de usar el nombre correcto de tu columna (ej: "nombre")
                txtNombreCategoria.Text = fila.Cells["nombre"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar la categoría: " + txtNombreCategoria.Text + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            // 3. Si el usuario confirma, procedemos con el proceso
            if (resultado == DialogResult.Yes)
            {
                categoria.Deletecategory(txtNombreCategoria.Text, this);

                // 4. Limpiamos y refrescamos la vista
                limpiarPantalla();
                ActualizarGrid();
            }
        }
    }
}
