using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
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
    public partial class FrmVisualizar_Etiquetas : Form
    {
        ClsVisualizar_Etiq_Controller controller = new ClsVisualizar_Etiq_Controller();
        public FrmVisualizar_Etiquetas()
        {
            InitializeComponent();
            DataTable dt = controller.cargarcombobox(this);
            Cargarcombo(dt);
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

        public void Cargarcombo(DataTable dtestados)
        {
            if (dtestados != null && dtestados.Rows.Count > 0)
            {
                cmbEstados.DataSource = null; // Limpia 

                // 2. Asignación de miembros 
                cmbEstados.DisplayMember = "estado";
                cmbEstados.ValueMember = "id";

                // 3. Asignación del origen de datos
                cmbEstados.DataSource = dtestados;
            }
            else
            {
                cmbEstados.DataSource = null;
            }

        }

        public void CargarDGV(int id)
        {
            DataTable dt = controller.extraercode(id, this);
            dgvEtiquetas.DataSource = dt;

            if (dt != null && dt.Rows.Count > 0)
            {
                if (dgvEtiquetas.Columns.Contains("codigo_barras"))
                    dgvEtiquetas.Columns["codigo_barras"].HeaderText = "Código de Barras";

                if (dgvEtiquetas.Columns.Contains("img_codigoDeBarras"))
                    dgvEtiquetas.Columns["img_codigoDeBarras"].HeaderText = "Imagen del Código de Barras";

                dgvEtiquetas.ReadOnly = true; // Bloquea que escriban en las celdas
                dgvEtiquetas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstados.SelectedValue != null)
            {
                if (cmbEstados.SelectedValue != null && !(cmbEstados.SelectedValue is System.Data.DataRowView))
                {
                    int idEstado = Convert.ToInt32(cmbEstados.SelectedValue);
                    CargarDGV(idEstado);
                }
            }
        }
    }
}
