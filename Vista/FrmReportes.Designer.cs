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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            pnlHeader = new Panel();
            label10 = new Label();
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
            pnlHeader.BackColor = Color.FromArgb(240, 242, 245);
            pnlHeader.Controls.Add(label10);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1153, 57);
            pnlHeader.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(20, 9);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(123, 36);
            label10.TabIndex = 1;
            label10.Text = "Reportes";
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.FromArgb(236, 240, 241);
            pnlHerramientas.Controls.Add(btnCompras);
            pnlHerramientas.Controls.Add(btnVentas);
            pnlHerramientas.Controls.Add(btnCorte);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.Location = new Point(0, 57);
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
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(585, 13);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(343, 45);
            btnCompras.TabIndex = 2;
            btnCompras.Text = "Historial de compras";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click_1;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.White;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.Silver;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.FromArgb(47, 53, 66);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(258, 13);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(298, 45);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "     Historial de ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = Color.White;
            btnCorte.Cursor = Cursors.Hand;
            btnCorte.FlatAppearance.BorderColor = Color.Silver;
            btnCorte.FlatStyle = FlatStyle.Flat;
            btnCorte.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorte.ForeColor = Color.FromArgb(47, 53, 66);
            btnCorte.Location = new Point(20, 13);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(217, 45);
            btnCorte.TabIndex = 0;
            btnCorte.Text = "💵 Corte Diario";
            btnCorte.UseVisualStyleBackColor = false;
            btnCorte.Click += btnCorte_Click_1;
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.BackColor = Color.White;
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 127);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(1153, 484);
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
        private System.Windows.Forms.Panel pnlHerramientas;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private Label label10;
    }
}