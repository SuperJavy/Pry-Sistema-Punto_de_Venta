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
            dtgVenta = new DataGridView();
            btnReporteventas = new Button();
            btnBorrar = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            btnCobrar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            txtCodigoBusq = new TextBox();
            btnagregarproducto = new Button();

            // Inicializar las 8 columnas del DataGridView
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoVenta = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
            colTipo = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dtgVenta).BeginInit();
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
            // dtgVenta
            // 
            dtgVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVenta.BackgroundColor = Color.FromArgb(245, 246, 250);
            dtgVenta.BorderStyle = BorderStyle.None;
            dtgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Inserción de las columnas en la rejilla
            dtgVenta.Columns.AddRange(new DataGridViewColumn[] {
                colCodigo,
                colNombre,
                colTipoVenta,
                colCantidad,
                colPrecio,
                colImporte,
                colImagen,
                colTipo
            });

            dtgVenta.Location = new Point(24, 240);
            dtgVenta.Margin = new Padding(4);
            dtgVenta.Name = "dtgVenta";
            dtgVenta.RowHeadersWidth = 51;
            dtgVenta.RowTemplate.Height = 70; // Altura ideal para la propaganda de imagen
            dtgVenta.Size = new Size(1352, 292);
            dtgVenta.TabIndex = 116;

            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código de Barras";
            colCodigo.Name = "colCodigo";
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Se ajusta al tamaño del código largo
            colCodigo.Width = 140;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Toma el espacio sobrante principal
            colNombre.FillWeight = 40F; // Proporción de llenado
            colNombre.Width = 240;
            // 
            // colTipoVenta
            // 
            colTipoVenta.HeaderText = "Tipo de Venta";
            colTipoVenta.Name = "colTipoVenta";
            colTipoVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTipoVenta.Width = 120;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Ajustado justo al texto "Cantidad"
            colCantidad.Width = 85;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.Width = 90;
            // 
            // colImporte
            // 
            colImporte.HeaderText = "Importe Total";
            colImporte.Name = "colImporte";
            colImporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImporte.Width = 100;
            // 
            // colImagen
            // 
            colImagen.HeaderText = "Imagen";
            colImagen.Name = "colImagen";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Llena el resto de la pantalla con la propaganda
            colImagen.FillWeight = 25F; // Proporción de pantalla para la imagen
            colImagen.Width = 130;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTipo.Width = 110;

            // 
            // btnReporteventas
            // 
            btnReporteventas.Font = new Font("Segoe UI", 9.5F);
            btnReporteventas.Image = Properties.Resources.beneficio_financiero;
            btnReporteventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteventas.Location = new Point(477, 160);
            btnReporteventas.Margin = new Padding(4);
            btnReporteventas.Name = "btnReporteventas";
            btnReporteventas.Padding = new Padding(12, 0, 0, 0);
            btnReporteventas.Size = new Size(240, 52);
            btnReporteventas.TabIndex = 121;
            btnReporteventas.Text = "    Reporte Ventas";
            btnReporteventas.UseVisualStyleBackColor = true;
            btnReporteventas.Click += btnReporteventas_Click;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(46, 204, 113);
            textBox1.Location = new Point(1030, 552);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(343, 71);
            textBox1.TabIndex = 124;
            textBox1.Text = "$0.00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.FromArgb(46, 204, 113);
            btnCobrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCobrar.ForeColor = Color.Black;
            btnCobrar.Image = Properties.Resources.ingreso__1_;
            btnCobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobrar.Location = new Point(706, 552);
            btnCobrar.Margin = new Padding(4);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Padding = new Padding(15, 0, 0, 0);
            btnCobrar.Size = new Size(315, 75);
            btnCobrar.TabIndex = 123;
            btnCobrar.Text = "    F12 Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
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
            // txtCodigoBusq
            // 
            txtCodigoBusq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoBusq.Font = new Font("Segoe UI", 13F);
            txtCodigoBusq.Location = new Point(266, 82);
            txtCodigoBusq.Margin = new Padding(4);
            txtCodigoBusq.Name = "txtCodigoBusq";
            txtCodigoBusq.Size = new Size(823, 42);
            txtCodigoBusq.TabIndex = 118;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarproducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnagregarproducto.Image = Properties.Resources.agregar_p16;
            btnagregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregarproducto.Location = new Point(1106, 80);
            btnagregarproducto.Margin = new Padding(4);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Padding = new Padding(12, 0, 0, 0);
            btnagregarproducto.Size = new Size(270, 52);
            btnagregarproducto.TabIndex = 122;
            btnagregarproducto.Text = "  ENTER - Agregar";
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1400, 645);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(btnCobrar);
            Controls.Add(btnagregarproducto);
            Controls.Add(btnReporteventas);
            Controls.Add(btnBorrar);
            Controls.Add(txtCodigoBusq);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(dtgVenta);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentas";
            WindowState = FormWindowState.Maximized;
            KeyDown += FrmVentas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtgVenta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.Button btnReporteventas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBusq;
        private System.Windows.Forms.Button btnagregarproducto;

        // Declaración de las 8 variables de columna
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
    }
}