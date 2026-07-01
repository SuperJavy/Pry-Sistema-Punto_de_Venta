namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmGernerador_CodBarras
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
            txtCodigo = new TextBox();
            btnGenerar = new Button();
            picCodigoBarras = new PictureBox();
            lblTitulo = new Label();
            panelHeader = new Panel();
            tableLayoutPanelControles = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUsarcode = new Button();
            ((System.ComponentModel.ISupportInitialize)picCodigoBarras).BeginInit();
            panelHeader.SuspendLayout();
            tableLayoutPanelControles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Dock = DockStyle.Fill;
            txtCodigo.Font = new Font("Segoe UI", 14F);
            txtCodigo.Location = new Point(3, 10);
            txtCodigo.Margin = new Padding(3, 10, 15, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(573, 45);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerar
            // 
            btnGenerar.Dock = DockStyle.Fill;
            btnGenerar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerar.Location = new Point(594, 5);
            btnGenerar.Margin = new Padding(3, 5, 3, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(191, 60);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar Código\r\n";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // picCodigoBarras
            // 
            picCodigoBarras.BorderStyle = BorderStyle.FixedSingle;
            picCodigoBarras.Location = new Point(57, 210);
            picCodigoBarras.Margin = new Padding(4, 5, 4, 5);
            picCodigoBarras.Name = "picCodigoBarras";
            picCodigoBarras.Size = new Size(788, 215);
            picCodigoBarras.SizeMode = PictureBoxSizeMode.CenterImage;
            picCodigoBarras.TabIndex = 2;
            picCodigoBarras.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(29, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(378, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Código Numérico del Producto:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(891, 80);
            panelHeader.TabIndex = 0;
            // 
            // tableLayoutPanelControles
            // 
            tableLayoutPanelControles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelControles.ColumnCount = 2;
            tableLayoutPanelControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelControles.Controls.Add(txtCodigo, 0, 0);
            tableLayoutPanelControles.Controls.Add(btnGenerar, 1, 0);
            tableLayoutPanelControles.Location = new Point(57, 110);
            tableLayoutPanelControles.Name = "tableLayoutPanelControles";
            tableLayoutPanelControles.RowCount = 1;
            tableLayoutPanelControles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelControles.Size = new Size(788, 70);
            tableLayoutPanelControles.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnUsarcode, 1, 0);
            tableLayoutPanel1.Location = new Point(57, 423);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(788, 45);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnUsarcode
            // 
            btnUsarcode.Dock = DockStyle.Fill;
            btnUsarcode.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUsarcode.Location = new Point(594, 5);
            btnUsarcode.Margin = new Padding(3, 5, 3, 5);
            btnUsarcode.Name = "btnUsarcode";
            btnUsarcode.Size = new Size(191, 35);
            btnUsarcode.TabIndex = 1;
            btnUsarcode.Text = "Usar codigo";
            btnUsarcode.UseVisualStyleBackColor = true;
            btnUsarcode.Click += btnUsarcode_Click;
            // 
            // FrmGernerador_CodBarras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 480);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelHeader);
            Controls.Add(tableLayoutPanelControles);
            Controls.Add(picCodigoBarras);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(600, 400);
            Name = "FrmGernerador_CodBarras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo - Generador de Códigos de Barras";
            ((System.ComponentModel.ISupportInitialize)picCodigoBarras).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelControles.ResumeLayout(false);
            tableLayoutPanelControles.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PictureBox picCodigoBarras;
        private System.Windows.Forms.Label lblTitulo;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelControles; // Control añadido para administrar el espacio del botón y texto
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUsarcode;
    }
}