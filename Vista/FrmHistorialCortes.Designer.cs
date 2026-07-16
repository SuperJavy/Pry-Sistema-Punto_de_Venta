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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.pnlRolAdmin = new System.Windows.Forms.Panel();
            this.lblRolAdmin = new System.Windows.Forms.Label();

            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();

            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblCajero = new System.Windows.Forms.Label();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLimpiar = new System.Windows.Forms.LinkLabel();

            this.tlpMetricas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMetrica1 = new System.Windows.Forms.Panel();
            this.lblM1Titulo = new System.Windows.Forms.Label();
            this.lblM1Valor = new System.Windows.Forms.Label();
            this.pnlMetrica2 = new System.Windows.Forms.Panel();
            this.lblM2Titulo = new System.Windows.Forms.Label();
            this.lblM2Valor = new System.Windows.Forms.Label();
            this.pnlMetrica3 = new System.Windows.Forms.Panel();
            this.lblM3Titulo = new System.Windows.Forms.Label();
            this.lblM3Valor = new System.Windows.Forms.Label();

            this.dgvHistorialCortes = new System.Windows.Forms.DataGridView();

            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.lblDetalleFondoLabel = new System.Windows.Forms.Label();
            this.lblDetalleFondoVal = new System.Windows.Forms.Label();
            this.lblDetalleEsperadoLabel = new System.Windows.Forms.Label();
            this.lblDetalleEsperadoVal = new System.Windows.Forms.Label();
            this.lblDetalleDiferenciaLabel = new System.Windows.Forms.Label();
            this.lblDetalleDiferenciaVal = new System.Windows.Forms.Label();
            this.btnReimprimir = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlRolAdmin.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpMetricas.SuspendLayout();
            this.pnlMetrica1.SuspendLayout();
            this.pnlMetrica2.SuspendLayout();
            this.pnlMetrica3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCortes)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            this.SuspendLayout();

            // 
            // Formulario Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialCortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTituloPrincipal);
            this.pnlHeader.Controls.Add(this.pnlRolAdmin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 65);
            this.pnlHeader.TabIndex = 0;

            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTituloPrincipal.Location = new System.Drawing.Point(20, 15);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Text = "Historial de cortes";

            this.pnlRolAdmin.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.pnlRolAdmin.BackColor = System.Drawing.Color.FromArgb(230, 241, 251);
            this.pnlRolAdmin.Controls.Add(this.lblRolAdmin);
            this.pnlRolAdmin.Location = new System.Drawing.Point(790, 18);
            this.pnlRolAdmin.Name = "pnlRolAdmin";
            this.pnlRolAdmin.Size = new System.Drawing.Size(140, 30);
            this.pnlRolAdmin.TabIndex = 1;

            this.lblRolAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRolAdmin.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.lblRolAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblRolAdmin.Name = "lblRolAdmin";
            this.lblRolAdmin.Text = "Administrador";
            this.lblRolAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // tlpPrincipal (Contenedor Responsivo)
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlFiltros, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpMetricas, 0, 1);
            this.tlpPrincipal.Controls.Add(this.dgvHistorialCortes, 0, 2);
            this.tlpPrincipal.Controls.Add(this.pnlDetalle, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 65);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // El grid toma todo el espacio restante
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpPrincipal.Size = new System.Drawing.Size(950, 635);
            this.tlpPrincipal.TabIndex = 2;

            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.lblCajero);
            this.pnlFiltros.Controls.Add(this.cmbCajero);
            this.pnlFiltros.Controls.Add(this.lblEstado);
            this.pnlFiltros.Controls.Add(this.cmbEstado);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.lblLimpiar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 10);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(910, 60);
            this.pnlFiltros.TabIndex = 0;

            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblDesde.Location = new System.Drawing.Point(0, 5);
            this.lblDesde.Text = "Desde";

            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(0, 22);
            this.dtpDesde.Size = new System.Drawing.Size(120, 25);

            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblHasta.Location = new System.Drawing.Point(135, 5);
            this.lblHasta.Text = "Hasta";

            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(135, 22);
            this.dtpHasta.Size = new System.Drawing.Size(120, 25);

            this.lblCajero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCajero.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblCajero.Location = new System.Drawing.Point(270, 5);
            this.lblCajero.Text = "Cajero";

            this.cmbCajero.Location = new System.Drawing.Point(270, 22);
            this.cmbCajero.Size = new System.Drawing.Size(130, 25);
            this.cmbCajero.Text = "Todos";

            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblEstado.Location = new System.Drawing.Point(415, 5);
            this.lblEstado.Text = "Estado";

            this.cmbEstado.Location = new System.Drawing.Point(415, 22);
            this.cmbEstado.Size = new System.Drawing.Size(110, 25);
            this.cmbEstado.Text = "Todos";

            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(540, 20);
            this.btnBuscar.Size = new System.Drawing.Size(90, 28);
            this.btnBuscar.Text = "Buscar";

            this.lblLimpiar.LinkColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblLimpiar.Location = new System.Drawing.Point(645, 26);
            this.lblLimpiar.Size = new System.Drawing.Size(100, 20);
            this.lblLimpiar.Text = "Limpiar filtros";

            // 
            // tlpMetricas (Responsivo - 3 Columnas)
            // 
            this.tlpMetricas.ColumnCount = 3;
            this.tlpMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMetricas.Controls.Add(this.pnlMetrica1, 0, 0);
            this.tlpMetricas.Controls.Add(this.pnlMetrica2, 1, 0);
            this.tlpMetricas.Controls.Add(this.pnlMetrica3, 2, 0);
            this.tlpMetricas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMetricas.Location = new System.Drawing.Point(20, 70);
            this.tlpMetricas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpMetricas.Name = "tlpMetricas";
            this.tlpMetricas.RowCount = 1;
            this.tlpMetricas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMetricas.Size = new System.Drawing.Size(910, 65);
            this.tlpMetricas.TabIndex = 1;

            // 
            // pnlMetrica1
            // 
            this.pnlMetrica1.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlMetrica1.Controls.Add(this.lblM1Titulo);
            this.pnlMetrica1.Controls.Add(this.lblM1Valor);
            this.pnlMetrica1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetrica1.Location = new System.Drawing.Point(0, 0);
            this.pnlMetrica1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlMetrica1.Name = "pnlMetrica1";

            this.lblM1Titulo.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblM1Titulo.Location = new System.Drawing.Point(12, 10);
            this.lblM1Titulo.Text = "Cortes en periodo";

            this.lblM1Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblM1Valor.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblM1Valor.Location = new System.Drawing.Point(12, 28);
            this.lblM1Valor.Text = "24";

            // 
            // pnlMetrica2
            // 
            this.pnlMetrica2.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlMetrica2.Controls.Add(this.lblM2Titulo);
            this.pnlMetrica2.Controls.Add(this.lblM2Valor);
            this.pnlMetrica2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetrica2.Location = new System.Drawing.Point(303, 0);
            this.pnlMetrica2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlMetrica2.Name = "pnlMetrica2";

            this.lblM2Titulo.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblM2Titulo.Location = new System.Drawing.Point(12, 10);
            this.lblM2Titulo.Text = "Diferencia total";

            this.lblM2Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblM2Valor.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblM2Valor.Location = new System.Drawing.Point(12, 28);
            this.lblM2Valor.Text = "-$62.30";

            // 
            // pnlMetrica3
            // 
            this.pnlMetrica3.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlMetrica3.Controls.Add(this.lblM3Titulo);
            this.pnlMetrica3.Controls.Add(this.lblM3Valor);
            this.pnlMetrica3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetrica3.Location = new System.Drawing.Point(606, 0);
            this.pnlMetrica3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMetrica3.Name = "pnlMetrica3";

            this.lblM3Titulo.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblM3Titulo.Location = new System.Drawing.Point(12, 10);
            this.lblM3Titulo.Text = "Con faltante";

            this.lblM3Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblM3Valor.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblM3Valor.Location = new System.Drawing.Point(12, 28);
            this.lblM3Valor.Text = "3";

            // 
            // dgvHistorialCortes
            // 
            this.dgvHistorialCortes.AllowUserToAddRows = false;
            this.dgvHistorialCortes.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialCortes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvHistorialCortes.ColumnHeadersHeight = 34;
            this.dgvHistorialCortes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialCortes.Location = new System.Drawing.Point(20, 145);
            this.dgvHistorialCortes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.dgvHistorialCortes.Name = "dgvHistorialCortes";
            this.dgvHistorialCortes.RowHeadersVisible = false;
            this.dgvHistorialCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCortes.TabIndex = 2;

            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlDetalle.Controls.Add(this.lblDetalleTitulo);
            this.pnlDetalle.Controls.Add(this.lblDetalleFondoLabel);
            this.pnlDetalle.Controls.Add(this.lblDetalleFondoVal);
            this.pnlDetalle.Controls.Add(this.lblDetalleEsperadoLabel);
            this.pnlDetalle.Controls.Add(this.lblDetalleEsperadoVal);
            this.pnlDetalle.Controls.Add(this.lblDetalleDiferenciaLabel);
            this.pnlDetalle.Controls.Add(this.lblDetalleDiferenciaVal);
            this.pnlDetalle.Controls.Add(this.btnReimprimir);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(20, 455);
            this.pnlDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.TabIndex = 3;

            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetalleTitulo.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblDetalleTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblDetalleTitulo.Text = "Detalle del Corte";

            this.lblDetalleFondoLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblDetalleFondoLabel.Location = new System.Drawing.Point(15, 50);
            this.lblDetalleFondoLabel.Text = "Fondo inicial";

            this.lblDetalleFondoVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetalleFondoVal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblDetalleFondoVal.Location = new System.Drawing.Point(15, 70);
            this.lblDetalleFondoVal.Text = "$0.00";

            this.lblDetalleEsperadoLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblDetalleEsperadoLabel.Location = new System.Drawing.Point(180, 50);
            this.lblDetalleEsperadoLabel.Text = "Total esperado";

            this.lblDetalleEsperadoVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetalleEsperadoVal.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblDetalleEsperadoVal.Location = new System.Drawing.Point(180, 70);
            this.lblDetalleEsperadoVal.Text = "$0.00";

            this.lblDetalleDiferenciaLabel.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblDetalleDiferenciaLabel.Location = new System.Drawing.Point(350, 50);
            this.lblDetalleDiferenciaLabel.Text = "Diferencia";

            this.lblDetalleDiferenciaVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetalleDiferenciaVal.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblDetalleDiferenciaVal.Location = new System.Drawing.Point(350, 70);
            this.lblDetalleDiferenciaVal.Text = "$0.00";

            this.btnReimprimir.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnReimprimir.BackColor = System.Drawing.Color.White;
            this.btnReimprimir.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnReimprimir.Location = new System.Drawing.Point(760, 95);
            this.btnReimprimir.Size = new System.Drawing.Size(130, 35);
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.UseVisualStyleBackColor = false;

            // 
            // ENSAMBLAJE FINAL
            // 
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlRolAdmin.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.tlpMetricas.ResumeLayout(false);
            this.pnlMetrica1.ResumeLayout(false);
            this.pnlMetrica2.ResumeLayout(false);
            this.pnlMetrica3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCortes)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnReimprimir;
    }
}