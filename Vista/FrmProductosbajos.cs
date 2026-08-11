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
    public partial class  FrmProductosbajos : Form
    {
        ClsInventarioController ProductB = new ClsInventarioController();
        public FrmProductosbajos()
        {
            InitializeComponent();
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

        private void FrmProductosbajos_Load(object sender, EventArgs e)
        {
            DataTable dt = ProductB.CargarProductosBajos(this);

            if (dt == null || dt.Rows.Count == 0)
            {
                dgvProductosBajos.DataSource = null;
                return;
            }

            dgvProductosBajos.DataSource = dt;
            dgvProductosBajos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductosBajos.Columns["codigo_de_barras"].HeaderText = "Código de Barras";
            dgvProductosBajos.Columns["nombre"].HeaderText = "Producto";
            dgvProductosBajos.Columns["stock"].HeaderText = "Existencias";
            dgvProductosBajos.Columns["stock_minimo"].HeaderText = "Stock Mínimo";

            // 1. APLICAMOS EL FORMATO INTELIGENTE A LAS COLUMNAS
            dgvProductosBajos.Columns["stock"].DefaultCellStyle.Format = "0.###";
            dgvProductosBajos.Columns["stock_minimo"].DefaultCellStyle.Format = "0.###";

            // 2. CORREGIMOS LA CONVERSIÓN PARA QUE ACEPTE KILOS/GRANEL
            foreach (DataGridViewRow fila in dgvProductosBajos.Rows)
            {
                // Cambiamos ToInt32 por ToDecimal para evitar caídas con productos a granel
                decimal stock = Convert.ToDecimal(fila.Cells["stock"].Value);
                if (stock <= 0)
                {
                    fila.DefaultCellStyle.BackColor = Color.Salmon; // Color de alerta
                }
            }
        }
        
    }
}
