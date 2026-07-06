namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            eDITARToolStripMenuItem = new ToolStripMenuItem();
            pnlinventario = new Panel();
            label10 = new Label();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(84, 41, 84, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(2270, 128);
            panel2.TabIndex = 79;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, eDITARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 65);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(118, 14, 0, 14);
            menuStrip1.Size = new Size(2270, 63);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevoToolStripMenuItem.Image = Properties.Resources.disminucion;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(359, 35);
            nuevoToolStripMenuItem.Text = "Productos bajos en inventario";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // eDITARToolStripMenuItem
            // 
            eDITARToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eDITARToolStripMenuItem.Image = Properties.Resources.editar;
            eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            eDITARToolStripMenuItem.Size = new Size(276, 35);
            eDITARToolStripMenuItem.Text = "Reporte de Inventario";
            eDITARToolStripMenuItem.Click += eDITARToolStripMenuItem_Click;
            // 
            // pnlinventario
            // 
            pnlinventario.BackColor = Color.White;
            pnlinventario.Dock = DockStyle.Fill;
            pnlinventario.Location = new Point(0, 128);
            pnlinventario.Margin = new Padding(84, 41, 84, 41);
            pnlinventario.Name = "pnlinventario";
            pnlinventario.Size = new Size(2270, 1162);
            pnlinventario.TabIndex = 80;
            pnlinventario.Paint += pnlinventario_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(23, 18);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(140, 36);
            label10.TabIndex = 1;
            label10.Text = "Inventario";
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(2270, 1290);
            Controls.Add(pnlinventario);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(84, 41, 84, 41);
            Name = "FrmInventario";
            Text = "FrmInventario";
            Load += FrmInventario_Load;
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
        private Label label10;
    }
}