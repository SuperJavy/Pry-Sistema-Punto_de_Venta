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
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private clsCategoriasController categoria = new clsCategoriasController();

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            categoria.agregarCategoria(txtNombreCategoria.Text, this);


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
            DataTable dt = categoria.CargarDTGcat(this);

            // Verificamos que el DataTable no sea nulo y tenga datos
            if (dt != null)
            {
                dgvMostrarcategorias.DataSource = dt;

                if (dgvMostrarcategorias.Columns.Contains("Id"))
                {
                    dgvMostrarcategorias.Columns["Id"].Visible = false;
                }


                dgvMostrarcategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarcategorias.ReadOnly = true; // Que el usuario no pueda editar la lista
                dgvMostrarcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
