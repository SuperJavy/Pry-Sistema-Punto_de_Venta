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
            label2 = new Label();
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
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(72, 35, 72, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1946, 76);
            panel2.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(72, 0, 72, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 0;
            label2.Text = "Inventario";
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, eDITARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(101, 12, 0, 12);
            menuStrip1.Size = new Size(1946, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevoToolStripMenuItem.Image = Properties.Resources.disminucion;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(312, 32);
            nuevoToolStripMenuItem.Text = "Productos bajos en inventario";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // eDITARToolStripMenuItem
            // 
            eDITARToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eDITARToolStripMenuItem.Image = Properties.Resources.editar;
            eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            eDITARToolStripMenuItem.Size = new Size(241, 32);
            eDITARToolStripMenuItem.Text = "Reporte de Inventario";
            eDITARToolStripMenuItem.Click += eDITARToolStripMenuItem_Click;
            // 
            // pnlinventario
            // 
            pnlinventario.BackColor = Color.White;
            pnlinventario.Dock = DockStyle.Fill;
            pnlinventario.Location = new Point(0, 76);
            pnlinventario.Margin = new Padding(72, 35, 72, 35);
            pnlinventario.Name = "pnlinventario";
            pnlinventario.Size = new Size(1946, 1030);
            pnlinventario.TabIndex = 80;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1946, 1106);
            Controls.Add(pnlinventario);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(72, 35, 72, 35);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.Panel pnlinventario;
    }
}