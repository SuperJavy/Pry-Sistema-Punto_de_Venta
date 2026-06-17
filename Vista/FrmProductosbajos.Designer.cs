namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmProductosbajos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            dgvProductosBajos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(231, 76, 60);
            label2.Location = new Point(14, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(410, 38);
            label2.TabIndex = 1;
            label2.Text = "Productos Bajos en Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(16, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(786, 28);
            label1.TabIndex = 2;
            label1.Text = "Se mostrará una lista de productos con inventario por debajo de su mínimo configurado.";
            // 
            // dgvProductosBajos
            // 
            dgvProductosBajos.AllowUserToAddRows = false;
            dgvProductosBajos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductosBajos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductosBajos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductosBajos.BackgroundColor = Color.White;
            dgvProductosBajos.BorderStyle = BorderStyle.None;
            dgvProductosBajos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductosBajos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductosBajos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductosBajos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(253, 237, 237);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProductosBajos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProductosBajos.EnableHeadersVisualStyles = false;
            dgvProductosBajos.GridColor = Color.FromArgb(242, 243, 244);
            dgvProductosBajos.Location = new Point(13, 138);
            dgvProductosBajos.Margin = new Padding(3, 4, 3, 4);
            dgvProductosBajos.Name = "dgvProductosBajos";
            dgvProductosBajos.RowHeadersWidth = 30;
            dgvProductosBajos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductosBajos.RowTemplate.Height = 35;
            dgvProductosBajos.Size = new Size(1920, 953);
            dgvProductosBajos.TabIndex = 3;
            // 
            // FrmProductosbajos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1946, 1106);
            Controls.Add(dgvProductosBajos);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmProductosbajos";
            Text = "FrmProductosbajos";
            Load += FrmProductosbajos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductosBajos;
    }
}