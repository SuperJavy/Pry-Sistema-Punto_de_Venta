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
            txtNombreCategoria = new TextBox();
            btnGuardarCategoria = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            dgvMostrarcategorias = new DataGridView();
            panelHeader = new Panel();
            groupBoxFormulario = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarcategorias).BeginInit();
            panelHeader.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(27, 29);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 0;
            label10.Text = "Categorías";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Font = new Font("Segoe UI", 11F);
            txtNombreCategoria.Location = new Point(183, 81);
            txtNombreCategoria.Margin = new Padding(5, 6, 5, 6);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(789, 37);
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
            btnGuardarCategoria.Location = new Point(596, 183);
            btnGuardarCategoria.Margin = new Padding(5, 6, 5, 6);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(260, 67);
            btnGuardarCategoria.TabIndex = 109;
            btnGuardarCategoria.Text = "Guardar Categoría";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(212, 183);
            btnEliminar.Margin = new Padding(5, 6, 5, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(233, 67);
            btnEliminar.TabIndex = 106;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(42, 87);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 110;
            label1.Text = "Nombre :";
            // 
            // dgvMostrarcategorias
            // 
            dgvMostrarcategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMostrarcategorias.BackgroundColor = Color.FromArgb(245, 246, 250);
            dgvMostrarcategorias.BorderStyle = BorderStyle.None;
            dgvMostrarcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarcategorias.Location = new Point(33, 221);
            dgvMostrarcategorias.Margin = new Padding(5, 6, 5, 6);
            dgvMostrarcategorias.Name = "dgvMostrarcategorias";
            dgvMostrarcategorias.RowHeadersWidth = 62;
            dgvMostrarcategorias.RowTemplate.Height = 28;
            dgvMostrarcategorias.Size = new Size(274, 449);
            dgvMostrarcategorias.TabIndex = 111;
            dgvMostrarcategorias.CellClick += dgvMostrarcategorias_CellClick;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1382, 80);
            panelHeader.TabIndex = 112;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFormulario.Controls.Add(label1);
            groupBoxFormulario.Controls.Add(txtNombreCategoria);
            groupBoxFormulario.Controls.Add(btnGuardarCategoria);
            groupBoxFormulario.Controls.Add(btnEliminar);
            groupBoxFormulario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFormulario.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxFormulario.Location = new Point(317, 221);
            groupBoxFormulario.Margin = new Padding(5, 6, 5, 6);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Padding = new Padding(5, 6, 5, 6);
            groupBoxFormulario.Size = new Size(1025, 337);
            groupBoxFormulario.TabIndex = 113;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = " ADMINISTRACIÓN DE CATEGORÍA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(47, 53, 66);
            label2.Location = new Point(33, 183);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 32);
            label2.TabIndex = 114;
            label2.Text = "Categorias agregadas.";
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 780);
            Controls.Add(label2);
            Controls.Add(groupBoxFormulario);
            Controls.Add(dgvMostrarcategorias);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrarcategorias).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrarcategorias;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxFormulario;
        private Label label2;
    }
}