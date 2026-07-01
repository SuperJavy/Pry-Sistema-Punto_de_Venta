namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmConfiguraciones
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
            pnlSidebar = new Panel();
            pnlNavIndicator = new Panel();
            btnEditarTicket = new Button();
            btnAgregarUsuarios = new Button();
            pnlMenuHeader = new Panel();
            lblMenuTitle = new Label();
            pnlTopBar = new Panel();
            lblFormTitle = new Label();
            pnlConfiguraciones = new Panel();
            pnlSidebar.SuspendLayout();
            pnlMenuHeader.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ActiveCaption;
            pnlSidebar.Controls.Add(pnlNavIndicator);
            pnlSidebar.Controls.Add(btnEditarTicket);
            pnlSidebar.Controls.Add(btnAgregarUsuarios);
            pnlSidebar.Controls.Add(pnlMenuHeader);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 1000);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlNavIndicator
            // 
            pnlNavIndicator.BackColor = Color.FromArgb(16, 185, 129);
            pnlNavIndicator.Location = new Point(0, 85);
            pnlNavIndicator.Name = "pnlNavIndicator";
            pnlNavIndicator.Size = new Size(6, 50);
            pnlNavIndicator.TabIndex = 3;
            // 
            // btnEditarTicket
            // 
            btnEditarTicket.Cursor = Cursors.Hand;
            btnEditarTicket.FlatAppearance.BorderSize = 0;
            btnEditarTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 65, 81);
            btnEditarTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 72);
            btnEditarTicket.FlatStyle = FlatStyle.Flat;
            btnEditarTicket.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEditarTicket.ForeColor = Color.White;
            btnEditarTicket.Image = Properties.Resources.boton_editar;
            btnEditarTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarTicket.Location = new Point(3, 235);
            btnEditarTicket.Name = "btnEditarTicket";
            btnEditarTicket.Padding = new Padding(20, 0, 0, 0);
            btnEditarTicket.Size = new Size(233, 70);
            btnEditarTicket.TabIndex = 2;
            btnEditarTicket.Text = "  Editar Ticket";
            btnEditarTicket.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarTicket.UseVisualStyleBackColor = true;
            btnEditarTicket.Click += lblEditarticket_Click;
            // 
            // btnAgregarUsuarios
            // 
            btnAgregarUsuarios.Cursor = Cursors.Hand;
            btnAgregarUsuarios.FlatAppearance.BorderSize = 0;
            btnAgregarUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 65, 81);
            btnAgregarUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 72);
            btnAgregarUsuarios.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuarios.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAgregarUsuarios.ForeColor = Color.FromArgb(243, 244, 246);
            btnAgregarUsuarios.Image = Properties.Resources.agregar_usuario__1_;
            btnAgregarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarUsuarios.Location = new Point(12, 120);
            btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            btnAgregarUsuarios.Padding = new Padding(20, 0, 0, 0);
            btnAgregarUsuarios.Size = new Size(232, 80);
            btnAgregarUsuarios.TabIndex = 1;
            btnAgregarUsuarios.Text = "Agregar Usuarios";
            btnAgregarUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarUsuarios.UseVisualStyleBackColor = true;
            btnAgregarUsuarios.Click += lblagregrausuarios_Click;
            // 
            // pnlMenuHeader
            // 
            pnlMenuHeader.BackColor = SystemColors.ActiveCaption;
            pnlMenuHeader.Controls.Add(lblMenuTitle);
            pnlMenuHeader.Dock = DockStyle.Top;
            pnlMenuHeader.Location = new Point(0, 0);
            pnlMenuHeader.Name = "pnlMenuHeader";
            pnlMenuHeader.Size = new Size(260, 70);
            pnlMenuHeader.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.Black;
            lblMenuTitle.Location = new Point(22, 22);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(178, 32);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "Configuración";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblFormTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1240, 70);
            pnlTopBar.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblFormTitle.Location = new Point(20, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(263, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Configuraciones";
            // 
            // pnlConfiguraciones
            // 
            pnlConfiguraciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConfiguraciones.BackColor = Color.White;
            pnlConfiguraciones.Location = new Point(285, 95);
            pnlConfiguraciones.Name = "pnlConfiguraciones";
            pnlConfiguraciones.Size = new Size(1190, 880);
            pnlConfiguraciones.TabIndex = 2;
            // 
            // FrmConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1500, 1000);
            Controls.Add(pnlConfiguraciones);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguraciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuraciones";
            pnlSidebar.ResumeLayout(false);
            pnlMenuHeader.ResumeLayout(false);
            pnlMenuHeader.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMenuHeader;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Button btnEditarTicket;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlConfiguraciones; // Este reemplaza a tu pnlConfiguraciones original de forma fluida
        private System.Windows.Forms.Panel pnlNavIndicator;
    }
}