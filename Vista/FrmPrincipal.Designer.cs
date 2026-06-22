namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlcontenedor = new Panel();
            panel1 = new Panel();
            pcbPerfil = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            mnsVentas = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            mnsProductos = new ToolStripMenuItem();
            mnsCompra = new ToolStripMenuItem();
            mnsInventario = new ToolStripMenuItem();
            mnsReportes = new ToolStripMenuItem();
            mnsConfiguraciones = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlcontenedor
            // 
            pnlcontenedor.BackColor = Color.White;
            pnlcontenedor.Dock = DockStyle.Fill;
            pnlcontenedor.Location = new Point(0, 98);
            pnlcontenedor.Margin = new Padding(3, 2, 3, 2);
            pnlcontenedor.Name = "pnlcontenedor";
            pnlcontenedor.Size = new Size(1301, 442);
            pnlcontenedor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pcbPerfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.AliceBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 98);
            panel1.TabIndex = 2;
            // 
            // pcbPerfil
            // 
            pcbPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbPerfil.Image = Properties.Resources.cuenta;
            pcbPerfil.Location = new Point(1198, 12);
            pcbPerfil.Name = "pcbPerfil";
            pcbPerfil.Size = new Size(78, 40);
            pcbPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPerfil.TabIndex = 5;
            pcbPerfil.TabStop = false;
            pcbPerfil.Click += pcbPerfil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(107, 18);
            label1.Name = "label1";
            label1.Size = new Size(480, 40);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Punto de Venta";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, mnsVentas, mnsProductos, mnsCompra, mnsInventario, mnsReportes, mnsConfiguraciones });
            menuStrip1.Location = new Point(0, 59);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(1301, 39);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(16, 35);
            // 
            // mnsVentas
            // 
            mnsVentas.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem });
            mnsVentas.Image = (Image)resources.GetObject("mnsVentas.Image");
            mnsVentas.Name = "mnsVentas";
            mnsVentas.Size = new Size(128, 35);
            mnsVentas.Text = "Ventas";
            mnsVentas.Click += mnsVentas_Click_1;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(196, 40);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // mnsProductos
            // 
            mnsProductos.Image = (Image)resources.GetObject("mnsProductos.Image");
            mnsProductos.Name = "mnsProductos";
            mnsProductos.Size = new Size(166, 35);
            mnsProductos.Text = "Productos";
            mnsProductos.Click += mnsProductos_Click;
            // 
            // mnsCompra
            // 
            mnsCompra.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsCompra.Image = (Image)resources.GetObject("mnsCompra.Image");
            mnsCompra.Name = "mnsCompra";
            mnsCompra.Size = new Size(151, 35);
            mnsCompra.Text = "Compras";
            mnsCompra.Click += mnsCompra_Click;
            // 
            // mnsInventario
            // 
            mnsInventario.Image = (Image)resources.GetObject("mnsInventario.Image");
            mnsInventario.Name = "mnsInventario";
            mnsInventario.Size = new Size(166, 35);
            mnsInventario.Text = "Inventario";
            mnsInventario.Click += mnsInventario_Click;
            // 
            // mnsReportes
            // 
            mnsReportes.Image = (Image)resources.GetObject("mnsReportes.Image");
            mnsReportes.Name = "mnsReportes";
            mnsReportes.Size = new Size(153, 35);
            mnsReportes.Text = "Reportes";
            mnsReportes.Click += mnsReportes_Click;
            // 
            // mnsConfiguraciones
            // 
            mnsConfiguraciones.Image = Properties.Resources.configuraciones;
            mnsConfiguraciones.Name = "mnsConfiguraciones";
            mnsConfiguraciones.Size = new Size(235, 35);
            mnsConfiguraciones.Text = "Configuraciones";
            mnsConfiguraciones.Click += mnsConfiguraciones_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1301, 540);
            Controls.Add(pnlcontenedor);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrincipal";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de ⁯Punto de Venta";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmPrincipal_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlcontenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnsInventario;
        public System.Windows.Forms.ToolStripMenuItem mnsProductos;
        public System.Windows.Forms.ToolStripMenuItem mnsCompra;
        public System.Windows.Forms.ToolStripMenuItem mnsConfiguraciones;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem mnsVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem mnsReportes;
        private PictureBox pcbPerfil;
    }
}

