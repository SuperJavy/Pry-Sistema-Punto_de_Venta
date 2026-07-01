namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmHistorialVentas
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
            pnlFiltros = new Panel();
            btnGenerar = new Button();
            lblEstado = new Label();
            cmbEstadoVenta = new ComboBox();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblInstruccion = new Label();
            pnlTotales = new Panel();
            lblTotalEfectivo = new Label();
            lblTituloEfectivo = new Label();
            pnlGridContainer = new Panel();
            dtgResultados = new DataGridView();
            pnlFiltros.SuspendLayout();
            pnlTotales.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgResultados).BeginInit();
            SuspendLayout();
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(btnGenerar);
            pnlFiltros.Controls.Add(lblEstado);
            pnlFiltros.Controls.Add(cmbEstadoVenta);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblInstruccion);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1168, 80);
            pnlFiltros.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.FromArgb(52, 152, 219);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Image = Properties.Resources.busqueda;
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(1005, 32);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(160, 45);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Buscar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(403, 10);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(97, 32);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstadoVenta
            // 
            cmbEstadoVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbEstadoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoVenta.Font = new Font("Segoe UI", 11.5F);
            cmbEstadoVenta.Items.AddRange(new object[] { "Todas las Ventas", "Solo Completadas", "Solo Canceladas" });
            cmbEstadoVenta.Location = new Point(403, 32);
            cmbEstadoVenta.Name = "cmbEstadoVenta";
            cmbEstadoVenta.Size = new Size(180, 45);
            cmbEstadoVenta.TabIndex = 6;
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.Gray;
            lblHasta.Location = new Point(798, 10);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(85, 32);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpHasta.Font = new Font("Segoe UI", 12F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(801, 32);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(181, 45);
            dtpHasta.TabIndex = 8;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.Gray;
            lblDesde.Location = new Point(618, 10);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(91, 32);
            lblDesde.TabIndex = 9;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDesde.Font = new Font("Segoe UI", 12F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(604, 32);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(177, 45);
            dtpDesde.TabIndex = 10;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(44, 62, 80);
            lblInstruccion.Location = new Point(20, 25);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(311, 45);
            lblInstruccion.TabIndex = 11;
            lblInstruccion.Text = "Historial de Ventas";
            // 
            // pnlTotales
            // 
            pnlTotales.BackColor = Color.FromArgb(44, 62, 80);
            pnlTotales.Controls.Add(lblTotalEfectivo);
            pnlTotales.Controls.Add(lblTituloEfectivo);
            pnlTotales.Dock = DockStyle.Bottom;
            pnlTotales.Location = new Point(0, 477);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(1168, 90);
            pnlTotales.TabIndex = 1;
            // 
            // lblTotalEfectivo
            // 
            lblTotalEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalEfectivo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalEfectivo.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalEfectivo.Location = new Point(711, 0);
            lblTotalEfectivo.Name = "lblTotalEfectivo";
            lblTotalEfectivo.Size = new Size(437, 75);
            lblTotalEfectivo.TabIndex = 0;
            lblTotalEfectivo.Text = "$ 0.00";
            lblTotalEfectivo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloEfectivo
            // 
            lblTituloEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloEfectivo.AutoSize = true;
            lblTituloEfectivo.Font = new Font("Segoe UI", 12F);
            lblTituloEfectivo.ForeColor = Color.White;
            lblTituloEfectivo.Location = new Point(478, 35);
            lblTituloEfectivo.Name = "lblTituloEfectivo";
            lblTituloEfectivo.Size = new Size(238, 38);
            lblTituloEfectivo.TabIndex = 1;
            lblTituloEfectivo.Text = "TOTAL COBRADO:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.FromArgb(245, 246, 250);
            pnlGridContainer.Controls.Add(dtgResultados);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 80);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(1168, 397);
            pnlGridContainer.TabIndex = 0;
            // 
            // dtgResultados
            // 
            dtgResultados.AllowUserToAddRows = false;
            dtgResultados.AllowUserToDeleteRows = false;
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResultados.BackgroundColor = Color.White;
            dtgResultados.BorderStyle = BorderStyle.None;
            dtgResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgResultados.ColumnHeadersHeight = 45;
            dtgResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 53, 66);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dtgResultados.Dock = DockStyle.Fill;
            dtgResultados.EnableHeadersVisualStyles = false;
            dtgResultados.Location = new Point(20, 20);
            dtgResultados.Name = "dtgResultados";
            dtgResultados.ReadOnly = true;
            dtgResultados.RowHeadersVisible = false;
            dtgResultados.RowHeadersWidth = 72;
            dtgResultados.RowTemplate.Height = 40;
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResultados.Size = new Size(1128, 357);
            dtgResultados.TabIndex = 0;
            // 
            // FrmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1168, 567);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlTotales);
            Controls.Add(pnlFiltros);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorialVentas";
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlTotales.ResumeLayout(false);
            pnlTotales.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstadoVenta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblTituloEfectivo;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dtgResultados;
    }
}