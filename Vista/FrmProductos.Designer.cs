namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmProductos
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
            panel1 = new Panel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            eDITARToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            pnlproductos = new Panel();
            gestorDeEtiquetasToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 242, 245);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 80);
            panel1.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 53, 66);
            label2.Location = new Point(12, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 0;
            label2.Text = "Productos";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, eDITARToolStripMenuItem, eliminarToolStripMenuItem, categoriasToolStripMenuItem, gestorDeEtiquetasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.ForeColor = Color.FromArgb(47, 53, 66);
            nuevoToolStripMenuItem.Image = Properties.Resources.agregar_producto;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(117, 34);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // eDITARToolStripMenuItem
            // 
            eDITARToolStripMenuItem.ForeColor = Color.FromArgb(47, 53, 66);
            eDITARToolStripMenuItem.Image = Properties.Resources.editar;
            eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            eDITARToolStripMenuItem.Size = new Size(145, 34);
            eDITARToolStripMenuItem.Text = "Modificar";
            eDITARToolStripMenuItem.Click += eDITARToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.ForeColor = Color.FromArgb(47, 53, 66);
            eliminarToolStripMenuItem.Image = Properties.Resources.borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(135, 34);
            eliminarToolStripMenuItem.Text = "Eliminar ";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.ForeColor = Color.FromArgb(47, 53, 66);
            categoriasToolStripMenuItem.Image = Properties.Resources.opciones;
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(156, 34);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // pnlproductos
            // 
            pnlproductos.BackColor = Color.White;
            pnlproductos.Dock = DockStyle.Fill;
            pnlproductos.Location = new Point(0, 80);
            pnlproductos.Margin = new Padding(4, 5, 4, 5);
            pnlproductos.Name = "pnlproductos";
            pnlproductos.Size = new Size(1428, 660);
            pnlproductos.TabIndex = 75;
            pnlproductos.Paint += pnlproductos_Paint;
            // 
            // gestorDeEtiquetasToolStripMenuItem
            // 
            gestorDeEtiquetasToolStripMenuItem.ForeColor = Color.FromArgb(47, 53, 66);
            gestorDeEtiquetasToolStripMenuItem.Name = "gestorDeEtiquetasToolStripMenuItem";
            gestorDeEtiquetasToolStripMenuItem.Size = new Size(217, 34);
            gestorDeEtiquetasToolStripMenuItem.Text = "Gestor de Etiquetas";
            gestorDeEtiquetasToolStripMenuItem.Click += gestorDeEtiquetasToolStripMenuItem_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 740);
            Controls.Add(pnlproductos);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProductos";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel pnlproductos;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem gestorDeEtiquetasToolStripMenuItem;
    }
}