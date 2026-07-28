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
            menuStrip1 = new MenuStrip();
            corteDiarioToolStripMenuItem = new ToolStripMenuItem();
            historialDeVentasToolStripMenuItem = new ToolStripMenuItem();
            historialDeComprasToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            pnlContenedorPrincipal = new Panel();
            pnlHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(240, 242, 245);
            pnlHeader.Controls.Add(menuStrip1);
            pnlHeader.Controls.Add(label10);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1153, 90);
            pnlHeader.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { corteDiarioToolStripMenuItem, historialDeVentasToolStripMenuItem, historialDeComprasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 45);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1153, 45);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // corteDiarioToolStripMenuItem
            // 
            corteDiarioToolStripMenuItem.Image = Properties.Resources.disco_flexible;
            corteDiarioToolStripMenuItem.Name = "corteDiarioToolStripMenuItem";
            corteDiarioToolStripMenuItem.Size = new Size(130, 41);
            corteDiarioToolStripMenuItem.Text = "Corte diario";
            corteDiarioToolStripMenuItem.Click += corteDiarioToolStripMenuItem_Click_1;
            // 
            // historialDeVentasToolStripMenuItem
            // 
            historialDeVentasToolStripMenuItem.Image = Properties.Resources.icons8_ventas_totales_48;
            historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            historialDeVentasToolStripMenuItem.Size = new Size(170, 41);
            historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            historialDeVentasToolStripMenuItem.Click += historialDeVentasToolStripMenuItem_Click_1;
            // 
            // historialDeComprasToolStripMenuItem
            // 
            historialDeComprasToolStripMenuItem.Image = Properties.Resources.ingreso__1_;
            historialDeComprasToolStripMenuItem.Name = "historialDeComprasToolStripMenuItem";
            historialDeComprasToolStripMenuItem.Size = new Size(180, 41);
            historialDeComprasToolStripMenuItem.Text = "Historial de compras";
            historialDeComprasToolStripMenuItem.Click += historialDeComprasToolStripMenuItem_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(78, 21);
            label10.TabIndex = 1;
            label10.Text = "Reportes";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.BackColor = Color.White;
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 90);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(1153, 521);
            pnlContenedorPrincipal.TabIndex = 2;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1153, 611);
            Controls.Add(pnlContenedorPrincipal);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem corteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeComprasToolStripMenuItem;
    }
}