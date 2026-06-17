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
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoVenta = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
            colTipo = new DataGridViewTextBoxColumn();
            btnReporteventas = new Button();
            btnBorrar = new Button();
            btnBuscar = new Button();
            txtTotal = new TextBox();
            btnCobrar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            txtCodigoBusq = new TextBox();
            btnagregarproducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgVenta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1662, 112);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 101;
            // 
            // dtgVenta
            // 
            dtgVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVenta.BackgroundColor = Color.FromArgb(245, 246, 250);
            dtgVenta.BorderStyle = BorderStyle.None;
            dtgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVenta.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colTipoVenta, colCantidad, colPrecio, colImporte, colImagen, colTipo });
            dtgVenta.Location = new Point(28, 280);
            dtgVenta.Margin = new Padding(5);
            dtgVenta.Name = "dtgVenta";
            dtgVenta.ReadOnly = true;
            dtgVenta.RowHeadersWidth = 51;
            dtgVenta.RowTemplate.Height = 70;
            dtgVenta.Size = new Size(1577, 341);
            dtgVenta.TabIndex = 116;
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCodigo.HeaderText = "Código de Barras";
            colCodigo.MinimumWidth = 9;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 212;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.FillWeight = 40F;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 9;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTipoVenta
            // 
            colTipoVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTipoVenta.HeaderText = "Tipo de Venta";
            colTipoVenta.MinimumWidth = 9;
            colTipoVenta.Name = "colTipoVenta";
            colTipoVenta.ReadOnly = true;
            colTipoVenta.Width = 167;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 9;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 137;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 9;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 111;
            // 
            // colImporte
            // 
            colImporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImporte.HeaderText = "Importe Total";
            colImporte.MinimumWidth = 9;
            colImporte.Name = "colImporte";
            colImporte.ReadOnly = true;
            colImporte.Width = 163;
            // 
            // colImagen
            // 
            colImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colImagen.FillWeight = 25F;
            colImagen.HeaderText = "Imagen";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImagen.MinimumWidth = 9;
            colImagen.Name = "colImagen";
            colImagen.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 9;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 94;
            // 
            // btnReporteventas
            // 
            btnReporteventas.Font = new Font("Segoe UI", 9.5F);
            btnReporteventas.Image = Properties.Resources.beneficio_financiero;
            btnReporteventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteventas.Location = new Point(556, 187);
            btnReporteventas.Margin = new Padding(5);
            btnReporteventas.Name = "btnReporteventas";
            btnReporteventas.Padding = new Padding(14, 0, 0, 0);
            btnReporteventas.Size = new Size(280, 61);
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
            btnBorrar.Location = new Point(292, 187);
            btnBorrar.Margin = new Padding(5);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(14, 0, 0, 0);
            btnBorrar.Size = new Size(254, 61);
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
            btnBuscar.Location = new Point(28, 187);
            btnBuscar.Margin = new Padding(5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(14, 0, 0, 0);
            btnBuscar.Size = new Size(254, 61);
            btnBuscar.TabIndex = 119;
            btnBuscar.Text = "    F10 Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTotal.ForeColor = Color.FromArgb(46, 204, 113);
            txtTotal.Location = new Point(1202, 644);
            txtTotal.Margin = new Padding(5);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(400, 82);
            txtTotal.TabIndex = 124;
            txtTotal.Text = "$0.00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.FromArgb(46, 204, 113);
            btnCobrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCobrar.ForeColor = Color.Black;
            btnCobrar.Image = Properties.Resources.ingreso__1_;
            btnCobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobrar.Location = new Point(824, 644);
            btnCobrar.Margin = new Padding(5);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Padding = new Padding(18, 0, 0, 0);
            btnCobrar.Size = new Size(368, 88);
            btnCobrar.TabIndex = 123;
            btnCobrar.Text = "    F12 Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 242, 245);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1633, 61);
            panel1.TabIndex = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(21, 12);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(224, 36);
            label10.TabIndex = 0;
            label10.Text = "Módulo de Venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(47, 53, 66);
            label7.Location = new Point(28, 107);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 32);
            label7.TabIndex = 117;
            label7.Text = "Código del producto :";
            // 
            // txtCodigoBusq
            // 
            txtCodigoBusq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoBusq.Font = new Font("Segoe UI", 13F);
            txtCodigoBusq.Location = new Point(310, 96);
            txtCodigoBusq.Margin = new Padding(5);
            txtCodigoBusq.Name = "txtCodigoBusq";
            txtCodigoBusq.Size = new Size(959, 48);
            txtCodigoBusq.TabIndex = 118;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarproducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnagregarproducto.Image = Properties.Resources.agregar_p16;
            btnagregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregarproducto.Location = new Point(1290, 93);
            btnagregarproducto.Margin = new Padding(5);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Padding = new Padding(14, 0, 0, 0);
            btnagregarproducto.Size = new Size(315, 61);
            btnagregarproducto.TabIndex = 122;
            btnagregarproducto.Text = "  ENTER - Agregar";
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1633, 752);
            Controls.Add(panel1);
            Controls.Add(txtTotal);
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
            Margin = new Padding(5);
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
        private System.Windows.Forms.TextBox txtTotal;
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