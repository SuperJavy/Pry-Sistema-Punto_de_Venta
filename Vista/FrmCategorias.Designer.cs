namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmCategorias
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
            label10 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            txtNombreCategoria = new TextBox();
            btnGuardarCategoria = new Button();
            button1 = new Button();
            btnventasdia = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panelHeader = new Panel();
            groupBoxFormulario = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(32, 35);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 38);
            label10.TabIndex = 0;
            label10.Text = "Categorías";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(172, 166);
            textBox3.Margin = new Padding(6, 7, 6, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(712, 42);
            textBox3.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(74, 85, 104);
            label7.Location = new Point(32, 173);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 36);
            label7.TabIndex = 101;
            label7.Text = "Buscar :";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Font = new Font("Segoe UI", 11F);
            txtNombreCategoria.Location = new Point(220, 97);
            txtNombreCategoria.Margin = new Padding(6, 7, 6, 7);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(946, 42);
            txtNombreCategoria.TabIndex = 108;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardarCategoria.Cursor = Cursors.Hand;
            btnGuardarCategoria.FlatAppearance.BorderSize = 0;
            btnGuardarCategoria.FlatStyle = FlatStyle.Flat;
            btnGuardarCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.Location = new Point(220, 220);
            btnGuardarCategoria.Margin = new Padding(6, 7, 6, 7);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(950, 92);
            btnGuardarCategoria.TabIndex = 109;
            btnGuardarCategoria.Text = "Guardar Categoría";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(149, 165, 166);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1830, 157);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(280, 80);
            button1.TabIndex = 106;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnventasdia
            // 
            btnventasdia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnventasdia.BackColor = Color.FromArgb(52, 152, 219);
            btnventasdia.Cursor = Cursors.Hand;
            btnventasdia.FlatAppearance.BorderSize = 0;
            btnventasdia.FlatStyle = FlatStyle.Flat;
            btnventasdia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnventasdia.ForeColor = Color.White;
            btnventasdia.Location = new Point(1480, 157);
            btnventasdia.Margin = new Padding(6, 7, 6, 7);
            btnventasdia.Name = "btnventasdia";
            btnventasdia.Size = new Size(320, 80);
            btnventasdia.TabIndex = 105;
            btnventasdia.Text = "Nueva Categoría";
            btnventasdia.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 104);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 110;
            label1.Text = "Nombre :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(245, 246, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 265);
            dataGridView1.Margin = new Padding(6, 7, 6, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(848, 785);
            dataGridView1.TabIndex = 111;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 7, 6, 7);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2218, 96);
            panelHeader.TabIndex = 112;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFormulario.Controls.Add(label1);
            groupBoxFormulario.Controls.Add(txtNombreCategoria);
            groupBoxFormulario.Controls.Add(btnGuardarCategoria);
            groupBoxFormulario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFormulario.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxFormulario.Location = new Point(940, 265);
            groupBoxFormulario.Margin = new Padding(6, 7, 6, 7);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Padding = new Padding(6, 7, 6, 7);
            groupBoxFormulario.Size = new Size(1230, 404);
            groupBoxFormulario.TabIndex = 113;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = " ADMINISTRACIÓN DE CATEGORÍA ";
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2218, 1110);
            Controls.Add(groupBoxFormulario);
            Controls.Add(dataGridView1);
            Controls.Add(btnventasdia);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnventasdia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxFormulario;
    }
}