namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmReportes
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlLineaSeparadora = new Panel();
            pnlHerramientas = new Panel();
            btnImprimir = new Button();
            btnGenerar = new Button();
            btnInventario = new Button();
            btnCompras = new Button();
            btnVentas = new Button();
            btnCorte = new Button();
            pnlFiltros = new Panel();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblInstruccion = new Label();
            pnlGridContainer = new Panel();
            dtgResultados = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlHerramientas.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgResultados).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1084, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(47, 53, 66);
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(284, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Módulo de Reportes";
            // 
            // pnlLineaSeparadora
            // 
            pnlLineaSeparadora.BackColor = Color.Silver;
            pnlLineaSeparadora.Dock = DockStyle.Top;
            pnlLineaSeparadora.Location = new Point(0, 50);
            pnlLineaSeparadora.Name = "pnlLineaSeparadora";
            pnlLineaSeparadora.Size = new Size(1084, 1);
            pnlLineaSeparadora.TabIndex = 1;
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.White;
            pnlHerramientas.Controls.Add(btnImprimir);
            pnlHerramientas.Controls.Add(btnGenerar);
            pnlHerramientas.Controls.Add(btnInventario);
            pnlHerramientas.Controls.Add(btnCompras);
            pnlHerramientas.Controls.Add(btnVentas);
            pnlHerramientas.Controls.Add(btnCorte);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.Location = new Point(0, 51);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Size = new Size(1084, 70);
            pnlHerramientas.TabIndex = 2;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.BackColor = Color.White;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderColor = Color.Silver;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(900, 15);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(160, 40);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "🖨️ Imprimir / PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.White;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderColor = Color.Silver;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.Black;
            btnGenerar.Location = new Point(740, 15);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 40);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "🔍 Buscar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.White;
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderColor = Color.Silver;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10F);
            btnInventario.ForeColor = Color.Black;
            btnInventario.Location = new Point(530, 15);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(160, 40);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "📦 Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.White;
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderColor = Color.Silver;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 10F);
            btnCompras.ForeColor = Color.Black;
            btnCompras.Location = new Point(360, 15);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(160, 40);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "\U0001f6d2 Compras";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.White;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.Silver;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(190, 15);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(160, 40);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "📊 Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = Color.White;
            btnCorte.Cursor = Cursors.Hand;
            btnCorte.FlatAppearance.BorderColor = Color.Silver;
            btnCorte.FlatStyle = FlatStyle.Flat;
            btnCorte.Font = new Font("Segoe UI", 10F);
            btnCorte.ForeColor = Color.Black;
            btnCorte.Location = new Point(20, 15);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(160, 40);
            btnCorte.TabIndex = 0;
            btnCorte.Text = "💵 Corte de Caja";
            btnCorte.UseVisualStyleBackColor = false;
            btnCorte.Click += btnCorte_Click;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblInstruccion);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 121);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1084, 60);
            pnlFiltros.TabIndex = 3;
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F);
            lblHasta.ForeColor = Color.Black;
            lblHasta.Location = new Point(861, 22);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(78, 32);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpHasta.Font = new Font("Segoe UI", 10.8F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(945, 15);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(115, 41);
            dtpHasta.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F);
            lblDesde.ForeColor = Color.Black;
            lblDesde.Location = new Point(648, 21);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(86, 32);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDesde.Font = new Font("Segoe UI", 10.8F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(740, 15);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(130, 41);
            dtpDesde.TabIndex = 2;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.Black;
            lblInstruccion.Location = new Point(20, 18);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(257, 36);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Corte de Caja Diario";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.FromArgb(245, 246, 250);
            pnlGridContainer.Controls.Add(dtgResultados);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 181);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(1084, 430);
            pnlGridContainer.TabIndex = 4;
            // 
            // dtgResultados
            // 
            dtgResultados.AllowUserToAddRows = false;
            dtgResultados.AllowUserToDeleteRows = false;
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResultados.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dtgResultados.Dock = DockStyle.Fill;
            dtgResultados.Location = new Point(20, 20);
            dtgResultados.Name = "dtgResultados";
            dtgResultados.ReadOnly = true;
            dtgResultados.RowHeadersVisible = false;
            dtgResultados.RowHeadersWidth = 51;
            dtgResultados.RowTemplate.Height = 35;
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResultados.Size = new Size(1044, 390);
            dtgResultados.TabIndex = 0;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1084, 611);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFiltros);
            Controls.Add(pnlHerramientas);
            Controls.Add(pnlLineaSeparadora);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 500);
            Name = "FrmReportes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgResultados).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlLineaSeparadora;
        private System.Windows.Forms.Panel pnlHerramientas;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dtgResultados;
    }
}