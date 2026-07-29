namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmInventario
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
            panel2 = new Panel();
            label10 = new Label();
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            eDITARToolStripMenuItem = new ToolStripMenuItem();
            pnlinventario = new Panel();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 242, 245);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(label10);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1153, 90);
            panel2.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(89, 21);
            label10.TabIndex = 1;
            label10.Text = "Inventario";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, eDITARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 45);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1153, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = Properties.Resources.disminucion;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(244, 41);
            nuevoToolStripMenuItem.Text = "Productos bajos en inventario";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // eDITARToolStripMenuItem
            // 
            eDITARToolStripMenuItem.Image = Properties.Resources.editar;
            eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            eDITARToolStripMenuItem.Size = new Size(187, 41);
            eDITARToolStripMenuItem.Text = "Reporte de Inventario";
            eDITARToolStripMenuItem.Click += eDITARToolStripMenuItem_Click;
            // 
            // pnlinventario
            // 
            pnlinventario.BackColor = Color.White;
            pnlinventario.Dock = DockStyle.Fill;
            pnlinventario.Location = new Point(0, 90);
            pnlinventario.Name = "pnlinventario";
            pnlinventario.Size = new Size(1153, 521);
            pnlinventario.TabIndex = 80;
            pnlinventario.Paint += pnlinventario_Paint;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1153, 611);
            Controls.Add(pnlinventario);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInventario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.Panel pnlinventario;
        private System.Windows.Forms.Label label10;
    }
}