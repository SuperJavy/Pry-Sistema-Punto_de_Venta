namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmReportes
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlHerramientas = new Panel();
            btnCompras = new Button();
            btnVentas = new Button();
            btnCorte = new Button();
            pnlContenedorPrincipal = new Panel();
            pnlHeader.SuspendLayout();
            pnlHerramientas.SuspendLayout();
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
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(20, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes";
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.FromArgb(236, 240, 241);
            pnlHerramientas.Controls.Add(btnCompras);
            pnlHerramientas.Controls.Add(btnVentas);
            pnlHerramientas.Controls.Add(btnCorte);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.Location = new Point(0, 50);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Padding = new Padding(10);
            pnlHerramientas.Size = new Size(1153, 70);
            pnlHerramientas.TabIndex = 1;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.White;
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderColor = Color.Silver;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 11F);
            btnCompras.ForeColor = Color.FromArgb(47, 53, 66);
            btnCompras.Location = new Point(380, 13);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(160, 45);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "\U0001f6d2 Compras";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click_1;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.White;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.Silver;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11F);
            btnVentas.ForeColor = Color.FromArgb(47, 53, 66);
            btnVentas.Location = new Point(200, 13);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(160, 45);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "📊 Historial Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = Color.White;
            btnCorte.Cursor = Cursors.Hand;
            btnCorte.FlatAppearance.BorderColor = Color.Silver;
            btnCorte.FlatStyle = FlatStyle.Flat;
            btnCorte.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCorte.ForeColor = Color.FromArgb(47, 53, 66);
            btnCorte.Location = new Point(20, 13);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(160, 45);
            btnCorte.TabIndex = 0;
            btnCorte.Text = "💵 Corte Diario";
            btnCorte.UseVisualStyleBackColor = false;
            btnCorte.Click += btnCorte_Click_1;
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.BackColor = Color.White;
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 120);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(1153, 491);
            pnlContenedorPrincipal.TabIndex = 2;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1153, 611);
            Controls.Add(pnlContenedorPrincipal);
            Controls.Add(pnlHerramientas);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlHerramientas;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
    }
}