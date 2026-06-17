namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmReporteinventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            label2 = new Label();
            label1 = new Label();
            lblCostoInventario = new Label();
            label4 = new Label();
            lblTotalProduct = new Label();
            label6 = new Label();
            cmbCategorias = new ComboBox();
            dgvInventario = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();

            // Configuración general del Formulario para permitir redimensionar
            FormBorderStyle = FormBorderStyle.Sizable;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600); // Tamaño inicial más flexible

            // --- ETIQUETAS Y COMBOS (Se mantienen arriba) ---
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Text = "Reporte de Inventario";

            label1.AutoSize = true;
            label1.Location = new Point(14, 70);
            label1.Text = "Costo de Inventario";
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblCostoInventario.AutoSize = true;
            lblCostoInventario.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCostoInventario.ForeColor = Color.FromArgb(46, 204, 113);
            lblCostoInventario.Location = new Point(14, 100);
            lblCostoInventario.Text = "$0.00";

            label4.AutoSize = true;
            label4.Location = new Point(300, 70);
            label4.Text = "Total productos";
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblTotalProduct.AutoSize = true;
            lblTotalProduct.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalProduct.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalProduct.Location = new Point(300, 100);
            lblTotalProduct.Text = "0";

            label6.AutoSize = true;
            label6.Location = new Point(14, 180);
            label6.Text = "Categoría:";

            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.Location = new Point(100, 175);
            cmbCategorias.Size = new Size(200, 35);
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;

            // --- DATAGRIDVIEW RESPONSIVO ---
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            // IMPORTANTE: El Anchor hace que se estire en todas direcciones
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.Location = new Point(14, 230);
            dgvInventario.Size = new Size(970, 350);
            dgvInventario.TabIndex = 11;
            // --- RESTAURACIÓN DE COLORES Y ESTILO ---
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80); // Azul oscuro
            dgvInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dgvInventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // --- BLOQUE DE CONFIGURACIÓN dgvInventario ---
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.RowHeadersVisible = false; // Elimina la columna gris lateral para un look más limpio
                                                     // ---------------------------------------------
            dgvInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 249); // Fila alterna gris claro
            dgvInventario.DefaultCellStyle.BackColor = Color.White;
            dgvInventario.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvInventario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 251); // Azul claro al seleccionar
            dgvInventario.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);

            dgvInventario.GridColor = Color.FromArgb(235, 237, 239);
            dgvInventario.RowHeadersWidth = 30;
            dgvInventario.RowTemplate.Height = 35;
            // Añadir controles
            Controls.Add(dgvInventario);
            Controls.Add(cmbCategorias);
            Controls.Add(label6);
            Controls.Add(lblTotalProduct);
            Controls.Add(label4);
            Controls.Add(lblCostoInventario);
            Controls.Add(label1);
            Controls.Add(label2);

            Name = "FrmReporteinventario";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label lblCostoInventario;
        private Label label4;
        private Label lblTotalProduct;
        private Label label6;
        private ComboBox cmbCategorias;
        private DataGridView dgvInventario;
    }
}