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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlLineaSeparadora = new Panel();
            pnlHerramientas = new Panel();
            btnGenerar = new Button();
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
            pnlHeader.Size = new Size(1153, 50);
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
            pnlLineaSeparadora.Size = new Size(1153, 1);
            pnlLineaSeparadora.TabIndex = 1;
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.White;
            pnlHerramientas.Controls.Add(btnGenerar);
            pnlHerramientas.Controls.Add(btnCompras);
            pnlHerramientas.Controls.Add(btnVentas);
            pnlHerramientas.Controls.Add(btnCorte);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.Location = new Point(0, 51);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Size = new Size(1153, 70);
            pnlHerramientas.TabIndex = 2;
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
            btnGenerar.Location = new Point(930, 15);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(199, 40);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "🔍 Buscar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.White;
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderColor = Color.Silver;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 10F);
            btnCompras.ForeColor = Color.Black;
            btnCompras.Location = new Point(431, 15);
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
            btnVentas.Location = new Point(256, 15);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(160, 40);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "📊 Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
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
            btnCorte.Size = new Size(230, 40);
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
            pnlFiltros.Size = new Size(1153, 60);
            pnlFiltros.TabIndex = 3;
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F);
            lblHasta.ForeColor = Color.Black;
            lblHasta.Location = new Point(900, 21);
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
            dtpHasta.Location = new Point(984, 13);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(157, 41);
            dtpHasta.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F);
            lblDesde.ForeColor = Color.Black;
            lblDesde.Location = new Point(639, 21);
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
            dtpDesde.Location = new Point(731, 13);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(163, 41);
            dtpDesde.TabIndex = 2;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.Black;
            lblInstruccion.Location = new Point(20, 13);
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
            pnlGridContainer.Size = new Size(1153, 430);
            pnlGridContainer.TabIndex = 4;
            // 
            // dtgResultados
            // 
            dtgResultados.AllowUserToAddRows = false;
            dtgResultados.AllowUserToDeleteRows = false;
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResultados.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgResultados.DefaultCellStyle = dataGridViewCellStyle4;
            dtgResultados.Dock = DockStyle.Fill;
            dtgResultados.Location = new Point(20, 20);
            dtgResultados.Name = "dtgResultados";
            dtgResultados.ReadOnly = true;
            dtgResultados.RowHeadersVisible = false;
            dtgResultados.RowHeadersWidth = 51;
            dtgResultados.RowTemplate.Height = 35;
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResultados.Size = new Size(1113, 390);
            dtgResultados.TabIndex = 0;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1153, 611);
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
        private System.Windows.Forms.Button btnGenerar;
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