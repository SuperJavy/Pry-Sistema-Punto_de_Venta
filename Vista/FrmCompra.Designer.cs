namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmCompra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            dtgCompras = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colCostoUnitario = new DataGridViewTextBoxColumn();
            Porcentaje = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            btnBorrar = new Button();
            btnBuscar = new Button();
            txtTotalCompra = new TextBox();
            btnComprar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            txtCodigoProducto = new TextBox();
            btnAgregarproducto = new Button();
            lblCantidad = new Label();
            txtCantidadCompra = new TextBox();
            lblCosto = new Label();
            txtCostoCompra = new TextBox();
            pnlGridContainer = new Panel();
            txtMargenCompra = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCompras).BeginInit();
            panel1.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2328, 158);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 101;
            // 
            // dtgCompras
            // 
            dtgCompras.AllowUserToAddRows = false;
            dtgCompras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dtgCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgCompras.BackgroundColor = Color.White;
            dtgCompras.BorderStyle = BorderStyle.None;
            dtgCompras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgCompras.ColumnHeadersHeight = 40;
            dtgCompras.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colCantidad, colCostoUnitario, Porcentaje, Column1, colImporte });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 237, 237);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgCompras.DefaultCellStyle = dataGridViewCellStyle3;
            dtgCompras.Dock = DockStyle.Fill;
            dtgCompras.EnableHeadersVisualStyles = false;
            dtgCompras.GridColor = Color.FromArgb(242, 243, 244);
            dtgCompras.Location = new Point(0, 0);
            dtgCompras.MultiSelect = false;
            dtgCompras.Name = "dtgCompras";
            dtgCompras.ReadOnly = true;
            dtgCompras.RowHeadersVisible = false;
            dtgCompras.RowHeadersWidth = 51;
            dtgCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgCompras.RowTemplate.Height = 70;
            dtgCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCompras.Size = new Size(1755, 238);
            dtgCompras.TabIndex = 116;
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
            colNombre.FillWeight = 50F;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 9;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
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
            // colCostoUnitario
            // 
            colCostoUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCostoUnitario.HeaderText = "Costo Unit.";
            colCostoUnitario.MinimumWidth = 9;
            colCostoUnitario.Name = "colCostoUnitario";
            colCostoUnitario.ReadOnly = true;
            colCostoUnitario.Width = 189;
            // 
            // Porcentaje
            // 
            Porcentaje.HeaderText = "Porcentaje ganancia";
            Porcentaje.MinimumWidth = 9;
            Porcentaje.Name = "Porcentaje";
            Porcentaje.ReadOnly = true;
            Porcentaje.Width = 175;
            // 
            // Column1
            // 
            Column1.HeaderText = "Precio de venta";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 175;
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
            // txtTotalCompra
            // 
            txtTotalCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotalCompra.BackColor = Color.White;
            txtTotalCompra.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTotalCompra.ForeColor = Color.FromArgb(46, 204, 113);
            txtTotalCompra.Location = new Point(1393, 614);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.ReadOnly = true;
            txtTotalCompra.Size = new Size(400, 82);
            txtTotalCompra.TabIndex = 124;
            txtTotalCompra.Text = "$0.00";
            txtTotalCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComprar.BackColor = Color.FromArgb(46, 204, 113);
            btnComprar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Image = Properties.Resources.ingreso__1_;
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(965, 622);
            btnComprar.Name = "btnComprar";
            btnComprar.Padding = new Padding(24, 0, 0, 0);
            btnComprar.Size = new Size(368, 88);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1832, 90);
            panel1.TabIndex = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(14, 9);
            label10.Name = "label10";
            label10.Size = new Size(300, 38);
            label10.TabIndex = 0;
            label10.Text = "Compra de Productos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(47, 53, 66);
            label7.Location = new Point(18, 145);
            label7.Name = "label7";
            label7.Size = new Size(109, 36);
            label7.TabIndex = 117;
            label7.Text = "Código:";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe UI", 13F);
            txtCodigoProducto.Location = new Point(128, 134);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(342, 48);
            txtCodigoProducto.TabIndex = 118;
            // 
            // btnAgregarproducto
            // 
            btnAgregarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarproducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarproducto.Image = Properties.Resources.agregar_p16;
            btnAgregarproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarproducto.Location = new Point(1540, 131);
            btnAgregarproducto.Name = "btnAgregarproducto";
            btnAgregarproducto.Padding = new Padding(20, 0, 0, 0);
            btnAgregarproducto.Size = new Size(276, 61);
            btnAgregarproducto.TabIndex = 122;
            btnAgregarproducto.Text = "  ENTER - Agregar";
            btnAgregarproducto.UseVisualStyleBackColor = true;
            btnAgregarproducto.Click += btnAgregarproducto_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.FromArgb(47, 53, 66);
            lblCantidad.Location = new Point(501, 145);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(131, 36);
            lblCantidad.TabIndex = 126;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidadCompra
            // 
            txtCantidadCompra.Font = new Font("Segoe UI", 13F);
            txtCantidadCompra.Location = new Point(630, 134);
            txtCantidadCompra.Name = "txtCantidadCompra";
            txtCantidadCompra.Size = new Size(193, 48);
            txtCantidadCompra.TabIndex = 127;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCosto.ForeColor = Color.FromArgb(47, 53, 66);
            lblCosto.Location = new Point(830, 145);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(91, 36);
            lblCosto.TabIndex = 128;
            lblCosto.Text = "Costo:";
            // 
            // txtCostoCompra
            // 
            txtCostoCompra.Font = new Font("Segoe UI", 13F);
            txtCostoCompra.Location = new Point(923, 134);
            txtCostoCompra.Name = "txtCostoCompra";
            txtCostoCompra.Size = new Size(291, 48);
            txtCostoCompra.TabIndex = 129;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGridContainer.Controls.Add(dtgCompras);
            pnlGridContainer.Location = new Point(38, 340);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Size = new Size(1755, 238);
            pnlGridContainer.TabIndex = 130;
            // 
            // txtMargenCompra
            // 
            txtMargenCompra.Font = new Font("Segoe UI", 13F);
            txtMargenCompra.Location = new Point(1477, 134);
            txtMargenCompra.Name = "txtMargenCompra";
            txtMargenCompra.Size = new Size(250, 48);
            txtMargenCompra.TabIndex = 131;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(47, 53, 66);
            label1.Location = new Point(1245, 145);
            label1.Name = "label1";
            label1.Size = new Size(229, 36);
            label1.TabIndex = 132;
            label1.Text = "Margen de venta:";
            // 
            // FrmCompra
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1832, 752);
            Controls.Add(label1);
            Controls.Add(txtMargenCompra);
            Controls.Add(pnlGridContainer);
            Controls.Add(panel1);
            Controls.Add(txtTotalCompra);
            Controls.Add(btnComprar);
            Controls.Add(btnAgregarproducto);
            Controls.Add(txtCostoCompra);
            Controls.Add(lblCosto);
            Controls.Add(txtCantidadCompra);
            Controls.Add(lblCantidad);
            Controls.Add(btnBorrar);
            Controls.Add(txtCodigoProducto);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompra";
            WindowState = FormWindowState.Maximized;
            KeyDown += FrmCompra_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtgCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCostoCompra;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private TextBox txtMargenCompra;
        private Label label1;
        private DataGridViewTextBoxColumn Porcentaje;
        private DataGridViewTextBoxColumn Column1;
    }
}