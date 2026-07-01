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
    public partial class FrmDetalle : Form
    {
        public FrmDetalle(string tituloVentana, DataTable datosDetalle)
        {
            InitializeComponent();

            this.Text = tituloVentana;
            dtgDetalles.DataSource = datosDetalle;

            dtgDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDetalles.AllowUserToAddRows = false;
            dtgDetalles.ReadOnly = true;
            dtgDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDetalles.RowHeadersVisible = false;
            dtgDetalles.BackgroundColor = Color.White;

            if (dtgDetalles.Columns["Precio Unit."] != null)
                dtgDetalles.Columns["Precio Unit."].DefaultCellStyle.Format = "C2";
            if (dtgDetalles.Columns["Precio Compra"] != null)
                dtgDetalles.Columns["Precio Compra"].DefaultCellStyle.Format = "C2";
            if (dtgDetalles.Columns["Subtotal"] != null)
                dtgDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            dtgDetalles.CellFormatting += dtgDetalles_CellFormatting;
        }

        private void dtgDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgDetalles.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                string estadoArticulo = e.Value.ToString().ToLower();

                if (estadoArticulo == "cancelada" || estadoArticulo == "cancelado")
                {
                    dtgDetalles.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(253, 237, 236); 
                    dtgDetalles.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(192, 57, 43);  
                }
                else
                {

                    dtgDetalles.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dtgDetalles.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(47, 53, 66);
                }
            }
        }
    }
}
