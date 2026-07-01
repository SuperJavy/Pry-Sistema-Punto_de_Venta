namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmHistorialCompras
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlFiltros = new Panel();
            btnGenerar = new Button();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblInstruccion = new Label();
            pnlTotales = new Panel();
            lblTotalInvertido = new Label();
            lblTituloInvertido = new Label();
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
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblInstruccion);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1150, 80);
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
            btnGenerar.Location = new Point(970, 20);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(160, 45);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "🔍 Buscar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.Gray;
            lblHasta.Location = new Point(780, 10);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(71, 28);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpHasta.Font = new Font("Segoe UI", 12F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(770, 32);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(177, 39);
            dtpHasta.TabIndex = 2;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.Gray;
            lblDesde.Location = new Point(582, 10);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(75, 28);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDesde.Font = new Font("Segoe UI", 12F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(569, 32);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(180, 39);
            dtpDesde.TabIndex = 4;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(44, 62, 80);
            lblInstruccion.Location = new Point(20, 25);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(291, 38);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Historial de Compras";
            // 
            // pnlTotales
            // 
            pnlTotales.BackColor = Color.FromArgb(44, 62, 80);
            pnlTotales.Controls.Add(lblTotalInvertido);
            pnlTotales.Controls.Add(lblTituloInvertido);
            pnlTotales.Dock = DockStyle.Bottom;
            pnlTotales.Location = new Point(0, 389);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(1150, 111);
            pnlTotales.TabIndex = 1;
            // 
            // lblTotalInvertido
            // 
            lblTotalInvertido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalInvertido.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalInvertido.ForeColor = Color.FromArgb(230, 126, 34);
            lblTotalInvertido.Location = new Point(698, 15);
            lblTotalInvertido.Name = "lblTotalInvertido";
            lblTotalInvertido.Size = new Size(440, 87);
            lblTotalInvertido.TabIndex = 0;
            lblTotalInvertido.Text = "$ 0.00";
            lblTotalInvertido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloInvertido
            // 
            lblTituloInvertido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloInvertido.AutoSize = true;
            lblTituloInvertido.Font = new Font("Segoe UI", 12F);
            lblTituloInvertido.ForeColor = Color.White;
            lblTituloInvertido.Location = new Point(460, 35);
            lblTituloInvertido.Name = "lblTituloInvertido";
            lblTituloInvertido.Size = new Size(210, 32);
            lblTituloInvertido.TabIndex = 1;
            lblTituloInvertido.Text = "TOTAL INVERTIDO:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.FromArgb(245, 246, 250);
            pnlGridContainer.Controls.Add(dtgResultados);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 80);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(1150, 309);
            pnlGridContainer.TabIndex = 0;
            // 
            // dtgResultados
            // 
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResultados.BackgroundColor = Color.White;
            dtgResultados.BorderStyle = BorderStyle.None;
            dtgResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgResultados.ColumnHeadersHeight = 45;
            dtgResultados.Dock = DockStyle.Fill;
            dtgResultados.EnableHeadersVisualStyles = false;
            dtgResultados.Location = new Point(20, 20);
            dtgResultados.Name = "dtgResultados";
            dtgResultados.RowHeadersWidth = 72;
            dtgResultados.RowTemplate.Height = 40;
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResultados.Size = new Size(1110, 269);
            dtgResultados.TabIndex = 0;
            // 
            // FrmHistorialCompras
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1150, 500);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlTotales);
            Controls.Add(pnlFiltros);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorialCompras";
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
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblTotalInvertido;
        private System.Windows.Forms.Label lblTituloInvertido;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dtgResultados;
    }
}