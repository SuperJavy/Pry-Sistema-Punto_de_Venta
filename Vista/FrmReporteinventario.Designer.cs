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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(359, 45);
            label2.TabIndex = 18;
            label2.Text = "Reporte de Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 70);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 17;
            label1.Text = "Costo de Inventario";
            // 
            // lblCostoInventario
            // 
            lblCostoInventario.AutoSize = true;
            lblCostoInventario.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCostoInventario.ForeColor = Color.FromArgb(46, 204, 113);
            lblCostoInventario.Location = new Point(14, 100);
            lblCostoInventario.Name = "lblCostoInventario";
            lblCostoInventario.Size = new Size(148, 62);
            lblCostoInventario.TabIndex = 16;
            lblCostoInventario.Text = "$0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 70);
            label4.Name = "label4";
            label4.Size = new Size(156, 30);
            label4.TabIndex = 15;
            label4.Text = "Total productos";
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.AutoSize = true;
            lblTotalProduct.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalProduct.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalProduct.Location = new Point(300, 100);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(54, 62);
            lblTotalProduct.TabIndex = 14;
            lblTotalProduct.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 180);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 13;
            label6.Text = "Categoría:";
            // 
            // cmbCategorias
            // 
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.Location = new Point(136, 177);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(200, 38);
            cmbCategorias.TabIndex = 12;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 249);
            dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 245, 251);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.GridColor = Color.FromArgb(235, 237, 239);
            dgvInventario.Location = new Point(14, 230);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 30;
            dgvInventario.RowTemplate.Height = 35;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(970, 350);
            dgvInventario.TabIndex = 11;
            // 
            // FrmReporteinventario
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
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