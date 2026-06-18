namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmReporteDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMargen = new System.Windows.Forms.Panel();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.pnlMargen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMargen
            // 
            this.pnlMargen.BackColor = System.Drawing.Color.White;
            this.pnlMargen.Controls.Add(this.dtgDetalle);
            this.pnlMargen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMargen.Location = new System.Drawing.Point(0, 0);
            this.pnlMargen.Name = "pnlMargen";
            this.pnlMargen.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMargen.Size = new System.Drawing.Size(632, 403);
            this.pnlMargen.TabIndex = 0;
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dtgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.dtgDetalle.Location = new System.Drawing.Point(20, 20);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersVisible = false;
            this.dtgDetalle.RowHeadersWidth = 51;
            this.dtgDetalle.RowTemplate.Height = 35;
            this.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalle.Size = new System.Drawing.Size(592, 363);
            this.dtgDetalle.TabIndex = 0;
            // 
            // FrmReporteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.pnlMargen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReporteDetalle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Folio";
            this.pnlMargen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMargen;

        // ¡OJO AQUÍ! Es public para que FrmReportes pueda mandarle datos
        public System.Windows.Forms.DataGridView dtgDetalle;
    }
}