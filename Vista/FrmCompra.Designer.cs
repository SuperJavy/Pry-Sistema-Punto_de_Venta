namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmCompra
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
            btnBorrar = new Button();
            btnBuscar = new Button();
            textBox2 = new TextBox();
            btnComprar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            btnAgregarproducto = new Button();

            // Inicialización de las columnas adaptadas a compras
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colCostoUnitario = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
            colTipo = new DataGridViewTextBoxColumn();

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

            // Inyección de las 7 columnas (Sin IVA) organizadas de forma proporcional
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colCodigo,
                colNombre,
                colCantidad,
                colCostoUnitario,
                colImporte,
                colImagen,
                colTipo
            });

            dataGridView1.Location = new Point(24, 240);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 70; // Altura para las imágenes miniaturas
            dataGridView1.Size = new Size(1352, 292);
            dataGridView1.TabIndex = 116;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código de Barras";
            colCodigo.Name = "colCodigo";
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCodigo.Width = 140;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Descripción del Producto";
            colNombre.Name = "colNombre";
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Distribuye el espacio principal
            colNombre.FillWeight = 50F;
            colNombre.Width = 240;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCantidad.Width = 85;
            // 
            // colCostoUnitario
            // 
            colCostoUnitario.HeaderText = "Costo Unit.";
            colCostoUnitario.Name = "colCostoUnitario";
            colCostoUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCostoUnitario.Width = 100;
            // 
            // colImporte
            // 
            colImporte.HeaderText = "Importe Total";
            colImporte.Name = "colImporte";
            colImporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImporte.Width = 110;
            // 
            // colImagen
            // 
            colImagen.HeaderText = "Imagen";
            colImagen.Name = "colImagen";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Rellena la sección lateral
            colImagen.FillWeight = 25F;
            colImagen.Width = 130;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Categoría";
            colTipo.Name = "colTipo";
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTipo.Width = 110;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 9.5F);
            btnBorrar.Image = Properties.Resources.borrar;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(250, 160);
            btnBorrar.Margin = new Padding(4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(12, 0, 0, 0);
            btnBorrar.Size = new Size(218, 52);
            btnBorrar.TabIndex = 120;
            btnBorrar.Text = "    DEL Borrar Art.";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.5F);
            btnBuscar.Image = Properties.Resources.busqueda;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(24, 160);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(12, 0, 0, 0);
            btnBuscar.Size = new Size(218, 52);
            btnBuscar.TabIndex = 119;
            btnBuscar.Text = "    F10 Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(46, 204, 113);
            textBox2.Location = new Point(1030, 552);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(343, 71);
            textBox2.TabIndex = 124;
            textBox2.Text = "$0.00";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComprar.BackColor = Color.FromArgb(46, 204, 113);
            btnComprar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Image = Properties.Resources.ingreso__1_;
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(706, 552);
            btnComprar.Margin = new Padding(4);
            btnComprar.Name = "btnComprar";
            btnComprar.Padding = new Padding(15, 0, 0, 0);
            btnComprar.Size = new Size(315, 75);
            btnComprar.TabIndex = 123;
            btnComprar.Text = "    F12 Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 242, 245);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
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
            label10.Size = new Size(239, 30);
            label10.TabIndex = 0;
            label10.Text = "Compra de Productos";
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
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(823, 42);
            textBox3.TabIndex = 118;
            // 
            // btnAgregarproducto
            // 
            btnAgregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarproducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregarproducto.Image = Properties.Resources.agregar_p16;
            btnAgregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarproducto.Location = new Point(1106, 80);
            btnAgregarproducto.Margin = new Padding(4);
            btnAgregarproducto.Name = "btnAgregarproducto";
            btnAgregarproducto.Padding = new Padding(12, 0, 0, 0);
            btnAgregarproducto.Size = new Size(270, 52);
            btnAgregarproducto.TabIndex = 122;
            btnAgregarproducto.Text = "  ENTER - Agregar";
            btnAgregarproducto.UseVisualStyleBackColor = true;
            btnAgregarproducto.Click += btnAgregarproducto_Click;
            // 
            // FrmCompra
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1400, 645);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(btnComprar);
            Controls.Add(btnAgregarproducto);
            Controls.Add(btnBorrar);
            Controls.Add(textBox3);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "FrmCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompra";
            WindowState = FormWindowState.Maximized;
            KeyDown += FrmCompra_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;

        // Declaración de las columnas del grid (Sin colIVA)
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
    }
}