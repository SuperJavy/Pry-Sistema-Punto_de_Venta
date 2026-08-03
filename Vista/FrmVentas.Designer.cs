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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            dtgVenta = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoVenta = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
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
            label3.Location = new Point(1425, 96);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 101;
            // 
            // dtgVenta
            // 
            dtgVenta.AllowUserToAddRows = false;
            dtgVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dtgVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVenta.BackgroundColor = Color.White;
            dtgVenta.BorderStyle = BorderStyle.None;
            dtgVenta.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgVenta.ColumnHeadersHeight = 40;
            dtgVenta.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colTipoVenta, colCantidad, colPrecio, colImporte, colImagen });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 237, 237);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgVenta.DefaultCellStyle = dataGridViewCellStyle3;
            dtgVenta.EnableHeadersVisualStyles = false;
            dtgVenta.GridColor = Color.FromArgb(242, 243, 244);
            dtgVenta.Location = new Point(38, 340);
            dtgVenta.MultiSelect = false;
            dtgVenta.Name = "dtgVenta";
            dtgVenta.ReadOnly = true;
            dtgVenta.RowHeadersVisible = false;
            dtgVenta.RowHeadersWidth = 51;
            dtgVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgVenta.RowTemplate.Height = 70;
            dtgVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgVenta.Size = new Size(1324, 180);
            dtgVenta.TabIndex = 116;
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCodigo.HeaderText = "Código de Barras";
            colCodigo.MinimumWidth = 9;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 261;
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
            colTipoVenta.Width = 221;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 9;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 163;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 9;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 129;
            // 
            // colImporte
            // 
            colImporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImporte.HeaderText = "Importe Total";
            colImporte.MinimumWidth = 9;
            colImporte.Name = "colImporte";
            colImporte.ReadOnly = true;
            colImporte.Width = 220;
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
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Image = Properties.Resources.borrar;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(307, 227);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Padding = new Padding(20, 0, 0, 0);
            btnBorrar.Size = new Size(254, 61);
            btnBorrar.TabIndex = 120;
            btnBorrar.Text = "    DEL Borrar Art.";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Image = Properties.Resources.busqueda;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(38, 227);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(20, 0, 0, 0);
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
            txtTotal.Location = new Point(962, 550);
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
            btnCobrar.Location = new Point(534, 531);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Padding = new Padding(24, 0, 0, 0);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 90);
            panel1.TabIndex = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(14, 9);
            label10.Name = "label10";
            label10.Size = new Size(243, 38);
            label10.TabIndex = 0;
            label10.Text = "Módulo de Venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(47, 53, 66);
            label7.Location = new Point(18, 145);
            label7.Name = "label7";
            label7.Size = new Size(272, 36);
            label7.TabIndex = 117;
            label7.Text = "Código del producto:";
            // 
            // txtCodigoBusq
            // 
            txtCodigoBusq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoBusq.Font = new Font("Segoe UI", 13F);
            txtCodigoBusq.Location = new Point(288, 134);
            txtCodigoBusq.Name = "txtCodigoBusq";
            txtCodigoBusq.Size = new Size(755, 48);
            txtCodigoBusq.TabIndex = 118;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarproducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarproducto.Image = Properties.Resources.agregar_p16;
            btnagregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregarproducto.Location = new Point(1089, 131);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Padding = new Padding(20, 0, 0, 0);
            btnagregarproducto.Size = new Size(271, 61);
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
            ClientSize = new Size(1400, 645);
            Controls.Add(panel1);
            Controls.Add(txtTotal);
            Controls.Add(btnCobrar);
            Controls.Add(btnagregarproducto);
            Controls.Add(btnBorrar);
            Controls.Add(txtCodigoBusq);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(dtgVenta);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBusq;
        private System.Windows.Forms.Button btnagregarproducto;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipoVenta;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colImporte;
        private DataGridViewImageColumn colImagen;
    }
}