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

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmReporteinventario : Form
    {
        ClsInventarioController inventario = new ClsInventarioController();
        public FrmReporteinventario()
        {
            InitializeComponent();
            DataTable dt = inventario.Cargarcategorias(this);
            llenarComboCategorias(dt);
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
        public void ActualizarUI(decimal costo, int cantidad)
        {
            lblCostoInventario.Text = "$" + costo.ToString("N2");
            lblTotalProduct.Text = cantidad.ToString();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategorias.SelectedValue == null || cmbCategorias.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            string idCat = cmbCategorias.SelectedValue.ToString();
            inventario.ObtenerReporte(idCat, this);

            inventario.ActualizarVistaInventario(idCat, this);
        }

        public void llenarComboCategorias(DataTable dtCategoria)
        {
            if (dtCategoria != null)
            {
                // Creamos la opción "Todas" para el filtro
                DataRow filaTodas = dtCategoria.NewRow();
                filaTodas["id"] = 0;
                filaTodas["nombre"] = "Todas";
                dtCategoria.Rows.InsertAt(filaTodas, 0);

                cmbCategorias.DisplayMember = "nombre";
                cmbCategorias.ValueMember = "id";
                cmbCategorias.DataSource = dtCategoria;
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Agrega esto en tu formulario
        public object FuenteDatosGrid
        {
            set { dgvInventario.DataSource = value; }
        }

    }
}
