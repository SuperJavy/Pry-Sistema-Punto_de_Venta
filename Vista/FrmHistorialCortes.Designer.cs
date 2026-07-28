namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmHistorialCortes
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
            pnlHeader = new Panel();
            lblTituloPrincipal = new Label();
            tlpPrincipal = new TableLayoutPanel();
            pnlFiltros = new Panel();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblCajero = new Label();
            cmbCajero = new ComboBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnBuscar = new Button();
            lblLimpiar = new LinkLabel();
            tlpMetricas = new TableLayoutPanel();
            pnlMetrica1 = new Panel();
            lblM1Titulo = new Label();
            lblM1Valor = new Label();
            pnlMetrica2 = new Panel();
            lblM2Titulo = new Label();
            lblM2Valor = new Label();
            pnlMetrica3 = new Panel();
            lblM3Titulo = new Label();
            lblM3Valor = new Label();
            pnlDetalle = new Panel();
            btnReimprimir = new Button();
            lblDetalleTitulo = new Label();
            lblDetalleFondoLabel = new Label();
            lblDetalleFondoVal = new Label();
            lblDetalleEsperadoLabel = new Label();
            lblDetalleEsperadoVal = new Label();
            lblDetalleDiferenciaLabel = new Label();
            lblDetalleDiferenciaVal = new Label();
            dgvHistorialCortes = new DataGridView();
            pnlHeader.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            pnlFiltros.SuspendLayout();
            tlpMetricas.SuspendLayout();
            pnlMetrica1.SuspendLayout();
            pnlMetrica2.SuspendLayout();
            pnlMetrica3.SuspendLayout();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCortes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTituloPrincipal);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1124, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTituloPrincipal.Location = new Point(20, 15);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(349, 51);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Historial de cortes";
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(pnlFiltros, 0, 0);
            tlpPrincipal.Controls.Add(tlpMetricas, 0, 1);
            tlpPrincipal.Controls.Add(pnlDetalle, 0, 3);
            tlpPrincipal.Controls.Add(dgvHistorialCortes, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 65);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(20, 10, 20, 20);
            tlpPrincipal.RowCount = 4;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tlpPrincipal.Size = new Size(1124, 720);
            tlpPrincipal.TabIndex = 2;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblCajero);
            pnlFiltros.Controls.Add(cmbCajero);
            pnlFiltros.Controls.Add(lblEstado);
            pnlFiltros.Controls.Add(cmbEstado);
            pnlFiltros.Controls.Add(btnBuscar);
            pnlFiltros.Controls.Add(lblLimpiar);
            pnlFiltros.Dock = DockStyle.Fill;
            pnlFiltros.Location = new Point(20, 10);
            pnlFiltros.Margin = new Padding(0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1084, 60);
            pnlFiltros.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.FromArgb(127, 140, 141);
            lblDesde.Location = new Point(3, -2);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(131, 23);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(3, 15);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(151, 39);
            dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.FromArgb(127, 140, 141);
            lblHasta.Location = new Point(160, -2);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(131, 23);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(160, 15);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(151, 39);
            dtpHasta.TabIndex = 3;
            // 
            // lblCajero
            // 
            lblCajero.Font = new Font("Segoe UI", 9F);
            lblCajero.ForeColor = Color.FromArgb(127, 140, 141);
            lblCajero.Location = new Point(334, 1);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(100, 23);
            lblCajero.TabIndex = 4;
            lblCajero.Text = "Cajero";
            // 
            // cmbCajero
            // 
            cmbCajero.Location = new Point(334, 18);
            cmbCajero.Name = "cmbCajero";
            cmbCajero.Size = new Size(130, 39);
            cmbCajero.TabIndex = 5;
            cmbCajero.Text = "Todos";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 9F);
            lblEstado.ForeColor = Color.FromArgb(127, 140, 141);
            lblEstado.Location = new Point(486, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.Location = new Point(486, 18);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(110, 39);
            cmbEstado.TabIndex = 7;
            cmbEstado.Text = "Todos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(41, 128, 185);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(657, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(151, 41);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblLimpiar
            // 
            lblLimpiar.LinkColor = Color.FromArgb(41, 128, 185);
            lblLimpiar.Location = new Point(831, 5);
            lblLimpiar.Name = "lblLimpiar";
            lblLimpiar.Size = new Size(151, 41);
            lblLimpiar.TabIndex = 9;
            lblLimpiar.TabStop = true;
            lblLimpiar.Text = "Limpiar filtros";
            // 
            // tlpMetricas
            // 
            tlpMetricas.ColumnCount = 3;
            tlpMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpMetricas.Controls.Add(pnlMetrica1, 0, 0);
            tlpMetricas.Controls.Add(pnlMetrica2, 1, 0);
            tlpMetricas.Controls.Add(pnlMetrica3, 2, 0);
            tlpMetricas.Dock = DockStyle.Fill;
            tlpMetricas.Location = new Point(20, 70);
            tlpMetricas.Margin = new Padding(0, 0, 0, 10);
            tlpMetricas.Name = "tlpMetricas";
            tlpMetricas.RowCount = 1;
            tlpMetricas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMetricas.Size = new Size(1084, 65);
            tlpMetricas.TabIndex = 1;
            // 
            // pnlMetrica1
            // 
            pnlMetrica1.BackColor = Color.FromArgb(245, 246, 250);
            pnlMetrica1.Controls.Add(lblM1Titulo);
            pnlMetrica1.Controls.Add(lblM1Valor);
            pnlMetrica1.Dock = DockStyle.Fill;
            pnlMetrica1.Location = new Point(0, 0);
            pnlMetrica1.Margin = new Padding(0, 0, 10, 0);
            pnlMetrica1.Name = "pnlMetrica1";
            pnlMetrica1.Size = new Size(351, 65);
            pnlMetrica1.TabIndex = 0;
            // 
            // lblM1Titulo
            // 
            lblM1Titulo.ForeColor = Color.FromArgb(127, 140, 141);
            lblM1Titulo.Location = new Point(12, 10);
            lblM1Titulo.Name = "lblM1Titulo";
            lblM1Titulo.Size = new Size(221, 41);
            lblM1Titulo.TabIndex = 0;
            lblM1Titulo.Text = "Cortes en periodo";
            // 
            // lblM1Valor
            // 
            lblM1Valor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblM1Valor.ForeColor = Color.FromArgb(44, 62, 80);
            lblM1Valor.Location = new Point(249, 10);
            lblM1Valor.Name = "lblM1Valor";
            lblM1Valor.Size = new Size(99, 47);
            lblM1Valor.TabIndex = 1;
            lblM1Valor.Text = "24";
            // 
            // pnlMetrica2
            // 
            pnlMetrica2.BackColor = Color.FromArgb(245, 246, 250);
            pnlMetrica2.Controls.Add(lblM2Titulo);
            pnlMetrica2.Controls.Add(lblM2Valor);
            pnlMetrica2.Dock = DockStyle.Fill;
            pnlMetrica2.Location = new Point(361, 0);
            pnlMetrica2.Margin = new Padding(0, 0, 10, 0);
            pnlMetrica2.Name = "pnlMetrica2";
            pnlMetrica2.Size = new Size(351, 65);
            pnlMetrica2.TabIndex = 1;
            // 
            // lblM2Titulo
            // 
            lblM2Titulo.ForeColor = Color.FromArgb(127, 140, 141);
            lblM2Titulo.Location = new Point(12, 10);
            lblM2Titulo.Name = "lblM2Titulo";
            lblM2Titulo.Size = new Size(142, 41);
            lblM2Titulo.TabIndex = 0;
            lblM2Titulo.Text = "Diferencia total";
            // 
            // lblM2Valor
            // 
            lblM2Valor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblM2Valor.ForeColor = Color.FromArgb(231, 76, 60);
            lblM2Valor.Location = new Point(172, 2);
            lblM2Valor.Name = "lblM2Valor";
            lblM2Valor.Size = new Size(179, 55);
            lblM2Valor.TabIndex = 1;
            lblM2Valor.Text = "-$62.30";
            // 
            // pnlMetrica3
            // 
            pnlMetrica3.BackColor = Color.FromArgb(245, 246, 250);
            pnlMetrica3.Controls.Add(lblM3Titulo);
            pnlMetrica3.Controls.Add(lblM3Valor);
            pnlMetrica3.Dock = DockStyle.Fill;
            pnlMetrica3.Location = new Point(722, 0);
            pnlMetrica3.Margin = new Padding(0);
            pnlMetrica3.Name = "pnlMetrica3";
            pnlMetrica3.Size = new Size(362, 65);
            pnlMetrica3.TabIndex = 2;
            // 
            // lblM3Titulo
            // 
            lblM3Titulo.ForeColor = Color.FromArgb(127, 140, 141);
            lblM3Titulo.Location = new Point(12, 10);
            lblM3Titulo.Name = "lblM3Titulo";
            lblM3Titulo.Size = new Size(146, 41);
            lblM3Titulo.TabIndex = 0;
            lblM3Titulo.Text = "Con faltante";
            // 
            // lblM3Valor
            // 
            lblM3Valor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblM3Valor.ForeColor = Color.FromArgb(231, 76, 60);
            lblM3Valor.Location = new Point(185, 2);
            lblM3Valor.Name = "lblM3Valor";
            lblM3Valor.Size = new Size(141, 55);
            lblM3Valor.TabIndex = 1;
            lblM3Valor.Text = "3";
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.FromArgb(245, 246, 250);
            pnlDetalle.Controls.Add(btnReimprimir);
            pnlDetalle.Controls.Add(lblDetalleTitulo);
            pnlDetalle.Controls.Add(lblDetalleFondoLabel);
            pnlDetalle.Controls.Add(lblDetalleFondoVal);
            pnlDetalle.Controls.Add(lblDetalleEsperadoLabel);
            pnlDetalle.Controls.Add(lblDetalleEsperadoVal);
            pnlDetalle.Controls.Add(lblDetalleDiferenciaLabel);
            pnlDetalle.Controls.Add(lblDetalleDiferenciaVal);
            pnlDetalle.Dock = DockStyle.Fill;
            pnlDetalle.Location = new Point(20, 540);
            pnlDetalle.Margin = new Padding(0);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(1084, 160);
            pnlDetalle.TabIndex = 3;
            // 
            // btnReimprimir
            // 
            btnReimprimir.Location = new Point(861, 70);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(168, 40);
            btnReimprimir.TabIndex = 7;
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = true;
            btnReimprimir.Click += btnReimprimir_Click_1;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblDetalleTitulo.Location = new Point(15, 12);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(218, 36);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Detalle del Corte";
            // 
            // lblDetalleFondoLabel
            // 
            lblDetalleFondoLabel.ForeColor = Color.FromArgb(127, 140, 141);
            lblDetalleFondoLabel.Location = new Point(15, 50);
            lblDetalleFondoLabel.Name = "lblDetalleFondoLabel";
            lblDetalleFondoLabel.Size = new Size(100, 43);
            lblDetalleFondoLabel.TabIndex = 1;
            lblDetalleFondoLabel.Text = "Fondo inicial";
            // 
            // lblDetalleFondoVal
            // 
            lblDetalleFondoVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleFondoVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblDetalleFondoVal.Location = new Point(15, 93);
            lblDetalleFondoVal.Name = "lblDetalleFondoVal";
            lblDetalleFondoVal.Size = new Size(100, 39);
            lblDetalleFondoVal.TabIndex = 2;
            lblDetalleFondoVal.Text = "$0.00";
            // 
            // lblDetalleEsperadoLabel
            // 
            lblDetalleEsperadoLabel.ForeColor = Color.FromArgb(127, 140, 141);
            lblDetalleEsperadoLabel.Location = new Point(180, 50);
            lblDetalleEsperadoLabel.Name = "lblDetalleEsperadoLabel";
            lblDetalleEsperadoLabel.Size = new Size(91, 43);
            lblDetalleEsperadoLabel.TabIndex = 3;
            lblDetalleEsperadoLabel.Text = "Total esperado";
            // 
            // lblDetalleEsperadoVal
            // 
            lblDetalleEsperadoVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleEsperadoVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblDetalleEsperadoVal.Location = new Point(180, 93);
            lblDetalleEsperadoVal.Name = "lblDetalleEsperadoVal";
            lblDetalleEsperadoVal.Size = new Size(91, 39);
            lblDetalleEsperadoVal.TabIndex = 4;
            lblDetalleEsperadoVal.Text = "$0.00";
            // 
            // lblDetalleDiferenciaLabel
            // 
            lblDetalleDiferenciaLabel.ForeColor = Color.FromArgb(127, 140, 141);
            lblDetalleDiferenciaLabel.Location = new Point(350, 50);
            lblDetalleDiferenciaLabel.Name = "lblDetalleDiferenciaLabel";
            lblDetalleDiferenciaLabel.Size = new Size(100, 35);
            lblDetalleDiferenciaLabel.TabIndex = 5;
            lblDetalleDiferenciaLabel.Text = "Diferencia";
            // 
            // lblDetalleDiferenciaVal
            // 
            lblDetalleDiferenciaVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleDiferenciaVal.ForeColor = Color.FromArgb(231, 76, 60);
            lblDetalleDiferenciaVal.Location = new Point(350, 93);
            lblDetalleDiferenciaVal.Name = "lblDetalleDiferenciaVal";
            lblDetalleDiferenciaVal.Size = new Size(114, 39);
            lblDetalleDiferenciaVal.TabIndex = 6;
            lblDetalleDiferenciaVal.Text = "$0.00";
            // 
            // dgvHistorialCortes
            // 
            dgvHistorialCortes.AllowUserToAddRows = false;
            dgvHistorialCortes.BackgroundColor = Color.White;
            dgvHistorialCortes.ColumnHeadersHeight = 34;
            dgvHistorialCortes.Dock = DockStyle.Fill;
            dgvHistorialCortes.Location = new Point(20, 145);
            dgvHistorialCortes.Margin = new Padding(0, 0, 0, 15);
            dgvHistorialCortes.Name = "dgvHistorialCortes";
            dgvHistorialCortes.RowHeadersVisible = false;
            dgvHistorialCortes.RowHeadersWidth = 72;
            dgvHistorialCortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialCortes.Size = new Size(1084, 380);
            dgvHistorialCortes.TabIndex = 2;
            // 
            // FrmHistorialCortes
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1124, 785);
            Controls.Add(tlpPrincipal);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorialCortes";
            StartPosition = FormStartPosition.CenterScreen;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            tlpMetricas.ResumeLayout(false);
            pnlMetrica1.ResumeLayout(false);
            pnlMetrica2.ResumeLayout(false);
            pnlMetrica3.ResumeLayout(false);
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCortes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel pnlRolAdmin;
        private System.Windows.Forms.Label lblRolAdmin;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.ComboBox cmbCajero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.LinkLabel lblLimpiar;

        private System.Windows.Forms.TableLayoutPanel tlpMetricas;
        private System.Windows.Forms.Panel pnlMetrica1;
        private System.Windows.Forms.Label lblM1Titulo;
        private System.Windows.Forms.Label lblM1Valor;
        private System.Windows.Forms.Panel pnlMetrica2;
        private System.Windows.Forms.Label lblM2Titulo;
        private System.Windows.Forms.Label lblM2Valor;
        private System.Windows.Forms.Panel pnlMetrica3;
        private System.Windows.Forms.Label lblM3Titulo;
        private System.Windows.Forms.Label lblM3Valor;

        private System.Windows.Forms.DataGridView dgvHistorialCortes;

        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.Label lblDetalleFondoLabel;
        private System.Windows.Forms.Label lblDetalleFondoVal;
        private System.Windows.Forms.Label lblDetalleEsperadoLabel;
        private System.Windows.Forms.Label lblDetalleEsperadoVal;
        private System.Windows.Forms.Label lblDetalleDiferenciaLabel;
        private System.Windows.Forms.Label lblDetalleDiferenciaVal;
        private Button btnReimprimir;
    }
}