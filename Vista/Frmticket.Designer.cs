namespace Pry_Sistema_Punto_de_Venta.vista
{
    partial class Frmticket : Form
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
            lblTitulo = new Label();
            pnlContenedorPrincipal = new TableLayoutPanel();
            pnlIzquierdoLogo = new Panel();
            lblInfoLogo = new Label();
            picLogo = new PictureBox();
            btnCargarLogo = new Button();
            btnQuitarLogo = new Button();
            pnlDerechoCampos = new Panel();
            lblNombreNegocio = new Label();
            txtNombreNegocio = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblRfc = new Label();
            txtRfc = new TextBox();
            lblMensajeFinal = new Label();
            txtMensajeFinal = new TextBox();
            pnlAcciones = new FlowLayoutPanel();
            btnGuardar = new Button();
            btnVisualizar = new Button();
            btnCancelar = new Button();
            pnlContenedorPrincipal.SuspendLayout();
            pnlIzquierdoLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlDerechoCampos.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(329, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Configuración de Ticket";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedorPrincipal.ColumnCount = 2;
            pnlContenedorPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlContenedorPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlContenedorPrincipal.Controls.Add(pnlIzquierdoLogo, 0, 0);
            pnlContenedorPrincipal.Controls.Add(pnlDerechoCampos, 1, 0);
            pnlContenedorPrincipal.Location = new Point(30, 80);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.RowCount = 1;
            pnlContenedorPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlContenedorPrincipal.Size = new Size(850, 560);
            pnlContenedorPrincipal.TabIndex = 1;
            // 
            // pnlIzquierdoLogo
            // 
            pnlIzquierdoLogo.Controls.Add(lblInfoLogo);
            pnlIzquierdoLogo.Controls.Add(picLogo);
            pnlIzquierdoLogo.Controls.Add(btnCargarLogo);
            pnlIzquierdoLogo.Controls.Add(btnQuitarLogo);
            pnlIzquierdoLogo.Dock = DockStyle.Fill;
            pnlIzquierdoLogo.Location = new Point(3, 3);
            pnlIzquierdoLogo.Name = "pnlIzquierdoLogo";
            pnlIzquierdoLogo.Size = new Size(334, 554);
            pnlIzquierdoLogo.TabIndex = 0;
            // 
            // lblInfoLogo
            // 
            lblInfoLogo.AutoSize = true;
            lblInfoLogo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblInfoLogo.ForeColor = Color.FromArgb(127, 140, 141);
            lblInfoLogo.Location = new Point(3, 10);
            lblInfoLogo.Name = "lblInfoLogo";
            lblInfoLogo.Size = new Size(163, 28);
            lblInfoLogo.TabIndex = 0;
            lblInfoLogo.Text = "Logo del Ticket :";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picLogo.BackColor = Color.FromArgb(242, 244, 245);
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(3, 41);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(318, 160);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // btnCargarLogo
            // 
            btnCargarLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCargarLogo.BackColor = Color.FromArgb(52, 152, 219);
            btnCargarLogo.Cursor = Cursors.Hand;
            btnCargarLogo.FlatAppearance.BorderSize = 0;
            btnCargarLogo.FlatStyle = FlatStyle.Flat;
            btnCargarLogo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCargarLogo.ForeColor = Color.White;
            btnCargarLogo.Location = new Point(3, 215);
            btnCargarLogo.Name = "btnCargarLogo";
            btnCargarLogo.Size = new Size(318, 40);
            btnCargarLogo.TabIndex = 2;
            btnCargarLogo.Text = "Cargar Logo";
            btnCargarLogo.UseVisualStyleBackColor = false;
            btnCargarLogo.Click += btnCargarLogo_Click;
            // 
            // btnQuitarLogo
            // 
            btnQuitarLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQuitarLogo.BackColor = Color.FromArgb(231, 76, 60);
            btnQuitarLogo.Cursor = Cursors.Hand;
            btnQuitarLogo.FlatAppearance.BorderSize = 0;
            btnQuitarLogo.FlatStyle = FlatStyle.Flat;
            btnQuitarLogo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnQuitarLogo.ForeColor = Color.White;
            btnQuitarLogo.Location = new Point(3, 265);
            btnQuitarLogo.Name = "btnQuitarLogo";
            btnQuitarLogo.Size = new Size(318, 40);
            btnQuitarLogo.TabIndex = 3;
            btnQuitarLogo.Text = "Quitar Logo";
            btnQuitarLogo.UseVisualStyleBackColor = false;
            btnQuitarLogo.Click += btnQuitarLogo_Click;
            // 
            // pnlDerechoCampos
            // 
            pnlDerechoCampos.Controls.Add(lblNombreNegocio);
            pnlDerechoCampos.Controls.Add(txtNombreNegocio);
            pnlDerechoCampos.Controls.Add(lblTelefono);
            pnlDerechoCampos.Controls.Add(txtTelefono);
            pnlDerechoCampos.Controls.Add(lblDireccion);
            pnlDerechoCampos.Controls.Add(txtDireccion);
            pnlDerechoCampos.Controls.Add(lblRfc);
            pnlDerechoCampos.Controls.Add(txtRfc);
            pnlDerechoCampos.Controls.Add(lblMensajeFinal);
            pnlDerechoCampos.Controls.Add(txtMensajeFinal);
            pnlDerechoCampos.Dock = DockStyle.Fill;
            pnlDerechoCampos.Location = new Point(343, 3);
            pnlDerechoCampos.Name = "pnlDerechoCampos";
            pnlDerechoCampos.Size = new Size(504, 554);
            pnlDerechoCampos.TabIndex = 1;
            // 
            // lblNombreNegocio
            // 
            lblNombreNegocio.AutoSize = true;
            lblNombreNegocio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNombreNegocio.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombreNegocio.Location = new Point(15, 10);
            lblNombreNegocio.Name = "lblNombreNegocio";
            lblNombreNegocio.Size = new Size(211, 28);
            lblNombreNegocio.TabIndex = 0;
            lblNombreNegocio.Text = "Nombre del negocio :";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreNegocio.Font = new Font("Segoe UI", 11F);
            txtNombreNegocio.Location = new Point(15, 38);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(470, 37);
            txtNombreNegocio.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(127, 140, 141);
            lblTelefono.Location = new Point(15, 85);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(102, 28);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono :";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(15, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(470, 37);
            txtTelefono.TabIndex = 3;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(127, 140, 141);
            lblDireccion.Location = new Point(15, 160);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(107, 28);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección :";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(15, 188);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(470, 37);
            txtDireccion.TabIndex = 5;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // lblRfc
            // 
            lblRfc.AutoSize = true;
            lblRfc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRfc.ForeColor = Color.FromArgb(127, 140, 141);
            lblRfc.Location = new Point(15, 235);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(57, 28);
            lblRfc.TabIndex = 6;
            lblRfc.Text = "RFC :";
            // 
            // txtRfc
            // 
            txtRfc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRfc.Font = new Font("Segoe UI", 11F);
            txtRfc.Location = new Point(15, 263);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(470, 37);
            txtRfc.TabIndex = 7;
            txtRfc.KeyPress += txtRfc_KeyPress;
            // 
            // lblMensajeFinal
            // 
            lblMensajeFinal.AutoSize = true;
            lblMensajeFinal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMensajeFinal.ForeColor = Color.FromArgb(127, 140, 141);
            lblMensajeFinal.Location = new Point(15, 310);
            lblMensajeFinal.Name = "lblMensajeFinal";
            lblMensajeFinal.Size = new Size(147, 28);
            lblMensajeFinal.TabIndex = 8;
            lblMensajeFinal.Text = "Mensaje Final :";
            // 
            // txtMensajeFinal
            // 
            txtMensajeFinal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMensajeFinal.Font = new Font("Segoe UI", 11F);
            txtMensajeFinal.Location = new Point(15, 338);
            txtMensajeFinal.Multiline = true;
            txtMensajeFinal.Name = "txtMensajeFinal";
            txtMensajeFinal.Size = new Size(470, 190);
            txtMensajeFinal.TabIndex = 9;
            // 
            // pnlAcciones
            // 
            pnlAcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlAcciones.Controls.Add(btnGuardar);
            pnlAcciones.Controls.Add(btnVisualizar);
            pnlAcciones.Controls.Add(btnCancelar);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.Location = new Point(400, 655);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(480, 55);
            pnlAcciones.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(327, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.FromArgb(155, 89, 182);
            btnVisualizar.Cursor = Cursors.Hand;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(171, 3);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(150, 45);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Visualizar Ticket";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(15, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Frmticket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(910, 730);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlContenedorPrincipal);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Frmticket";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configuración de Ticket";
            WindowState = FormWindowState.Maximized;
            Load += Frmticket_Load;
            pnlContenedorPrincipal.ResumeLayout(false);
            pnlIzquierdoLogo.ResumeLayout(false);
            pnlIzquierdoLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlDerechoCampos.ResumeLayout(false);
            pnlDerechoCampos.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel pnlContenedorPrincipal;
        private System.Windows.Forms.Panel pnlIzquierdoLogo;
        private System.Windows.Forms.Label lblInfoLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCargarLogo;
        private System.Windows.Forms.Button btnQuitarLogo;
        private System.Windows.Forms.Panel pnlDerechoCampos;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label lblMensajeFinal;
        private System.Windows.Forms.TextBox txtMensajeFinal;
        private System.Windows.Forms.FlowLayoutPanel pnlAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVisualizar; // DECLARADO
    }
}