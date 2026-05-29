namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmVentas
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnReporteventas = new Button();
            btnborrar = new Button();
            btnbuscar = new Button();
            textBox1 = new TextBox();
            btncobrar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            btnagregarproducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1425, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 101;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(245, 246, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 240);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1352, 292);
            dataGridView1.TabIndex = 116;
            // 
            // btnReporteventas
            // 
            btnReporteventas.Font = new Font("Segoe UI", 9.5F);
            btnReporteventas.Image = Properties.Resources.beneficio_financiero;
            btnReporteventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteventas.Location = new Point(477, 160);
            btnReporteventas.Margin = new Padding(4, 4, 4, 4);
            btnReporteventas.Name = "btnReporteventas";
            btnReporteventas.Padding = new Padding(12, 0, 0, 0);
            btnReporteventas.Size = new Size(240, 52);
            btnReporteventas.TabIndex = 121;
            btnReporteventas.Text = "    Reporte Ventas";
            btnReporteventas.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Font = new Font("Segoe UI", 9.5F);
            btnborrar.Image = Properties.Resources.borrar;
            btnborrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnborrar.Location = new Point(250, 160);
            btnborrar.Margin = new Padding(4, 4, 4, 4);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(12, 0, 0, 0);
            btnborrar.Size = new Size(218, 52);
            btnborrar.TabIndex = 120;
            btnborrar.Text = "   DEL Borrar Art.";
            btnborrar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Segoe UI", 9.5F);
            btnbuscar.Image = Properties.Resources.busqueda;
            btnbuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscar.Location = new Point(24, 160);
            btnbuscar.Margin = new Padding(4, 4, 4, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(12, 0, 0, 0);
            btnbuscar.Size = new Size(218, 52);
            btnbuscar.TabIndex = 119;
            btnbuscar.Text = "    F10 Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(46, 204, 113);
            textBox1.Location = new Point(1030, 552);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(343, 71);
            textBox1.TabIndex = 124;
            textBox1.Text = "$0.00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btncobrar
            // 
            btncobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncobrar.BackColor = Color.White;
            btncobrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btncobrar.ForeColor = Color.Black;
            btncobrar.Image = Properties.Resources.ingreso__1_;
            btncobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btncobrar.Location = new Point(706, 552);
            btncobrar.Margin = new Padding(4, 4, 4, 4);
            btncobrar.Name = "btncobrar";
            btncobrar.Padding = new Padding(15, 0, 0, 0);
            btncobrar.Size = new Size(315, 75);
            btncobrar.TabIndex = 123;
            btncobrar.Text = "   F12 Cobrar";
            btncobrar.UseVisualStyleBackColor = false;
            btncobrar.Click += btncobrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 242, 245);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 52);
            panel1.TabIndex = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(18, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(191, 30);
            label10.TabIndex = 0;
            label10.Text = "Módulo de Venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(47, 53, 66);
            label7.Location = new Point(24, 92);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(216, 28);
            label7.TabIndex = 117;
            label7.Text = "Código del producto :";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(266, 82);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(823, 42);
            textBox3.TabIndex = 118;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarproducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnagregarproducto.Image = Properties.Resources.agregar_p16;
            btnagregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregarproducto.Location = new Point(1106, 80);
            btnagregarproducto.Margin = new Padding(4, 4, 4, 4);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Padding = new Padding(12, 0, 0, 0);
            btnagregarproducto.Size = new Size(270, 52);
            btnagregarproducto.TabIndex = 122;
            btnagregarproducto.Text = "  ENTER - Agregar";
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1400, 645);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(btncobrar);
            Controls.Add(btnagregarproducto);
            Controls.Add(btnReporteventas);
            Controls.Add(btnborrar);
            Controls.Add(textBox3);
            Controls.Add(btnbuscar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReporteventas;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnagregarproducto;
    }
}