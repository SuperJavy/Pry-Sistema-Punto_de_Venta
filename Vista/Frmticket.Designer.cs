namespace Pry_Sistema_Punto_de_Venta
{
    partial class Frmticket
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIzquierdoLogo = new System.Windows.Forms.Panel();
            this.lblInfoLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCargarLogo = new System.Windows.Forms.Button();
            this.btnQuitarLogo = new System.Windows.Forms.Button();
            this.pnlDerechoCampos = new System.Windows.Forms.Panel();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblMensajeFinal = new System.Windows.Forms.Label();
            this.txtMensajeFinal = new System.Windows.Forms.TextBox();
            this.pnlAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContenedorPrincipal.SuspendLayout();
            this.pnlIzquierdoLogo.SuspendLayout();
            this.pnlDerechoCampos.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración de Ticket";
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorPrincipal.ColumnCount = 2;
            this.pnlContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlContenedorPrincipal.Controls.Add(this.pnlIzquierdoLogo, 0, 0);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlDerechoCampos, 1, 0);
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(30, 80);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.RowCount = 1;
            this.pnlContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(850, 560);
            this.pnlContenedorPrincipal.TabIndex = 1;
            // 
            // pnlIzquierdoLogo
            // 
            this.pnlIzquierdoLogo.Controls.Add(this.lblInfoLogo);
            this.pnlIzquierdoLogo.Controls.Add(this.picLogo);
            this.pnlIzquierdoLogo.Controls.Add(this.btnCargarLogo);
            this.pnlIzquierdoLogo.Controls.Add(this.btnQuitarLogo);
            this.pnlIzquierdoLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierdoLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlIzquierdoLogo.Name = "pnlIzquierdoLogo";
            this.pnlIzquierdoLogo.Size = new System.Drawing.Size(334, 554);
            this.pnlIzquierdoLogo.TabIndex = 0;
            // 
            // lblInfoLogo
            // 
            this.lblInfoLogo.AutoSize = true;
            this.lblInfoLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblInfoLogo.Location = new System.Drawing.Point(3, 10);
            this.lblInfoLogo.Name = "lblInfoLogo";
            this.lblInfoLogo.Size = new System.Drawing.Size(139, 23);
            this.lblInfoLogo.TabIndex = 0;
            this.lblInfoLogo.Text = "Logo del Ticket :";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(3, 41);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(318, 160);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // RESPONSIVO: Mantiene la proporción del logo sin deformarlo
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnCargarLogo
            // 
            this.btnCargarLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCargarLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarLogo.FlatAppearance.BorderSize = 0;
            this.btnCargarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargarLogo.ForeColor = System.Drawing.Color.White;
            this.btnCargarLogo.Location = new System.Drawing.Point(3, 215);
            this.btnCargarLogo.Name = "btnCargarLogo";
            this.btnCargarLogo.Size = new System.Drawing.Size(318, 40);
            this.btnCargarLogo.TabIndex = 2;
            this.btnCargarLogo.Text = "Cargar Logo";
            this.btnCargarLogo.UseVisualStyleBackColor = false;
            // 
            // btnQuitarLogo
            // 
            this.btnQuitarLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnQuitarLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarLogo.FlatAppearance.BorderSize = 0;
            this.btnQuitarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitarLogo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarLogo.Location = new System.Drawing.Point(3, 265);
            this.btnQuitarLogo.Name = "btnQuitarLogo";
            this.btnQuitarLogo.Size = new System.Drawing.Size(318, 40);
            this.btnQuitarLogo.TabIndex = 3;
            this.btnQuitarLogo.Text = "Quitar Logo";
            this.btnQuitarLogo.UseVisualStyleBackColor = false;
            // 
            // pnlDerechoCampos
            // 
            this.pnlDerechoCampos.Controls.Add(this.lblNombreNegocio);
            this.pnlDerechoCampos.Controls.Add(this.txtNombreNegocio);
            this.pnlDerechoCampos.Controls.Add(this.lblTelefono);
            this.pnlDerechoCampos.Controls.Add(this.txtTelefono);
            this.pnlDerechoCampos.Controls.Add(this.lblDireccion);
            this.pnlDerechoCampos.Controls.Add(this.txtDireccion);
            this.pnlDerechoCampos.Controls.Add(this.lblRfc);
            this.pnlDerechoCampos.Controls.Add(this.txtRfc);
            this.pnlDerechoCampos.Controls.Add(this.lblMensajeFinal);
            this.pnlDerechoCampos.Controls.Add(this.txtMensajeFinal);
            this.pnlDerechoCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerechoCampos.Location = new System.Drawing.Point(343, 3);
            this.pnlDerechoCampos.Name = "pnlDerechoCampos";
            this.pnlDerechoCampos.Size = new System.Drawing.Size(504, 554);
            this.pnlDerechoCampos.TabIndex = 1;
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblNombreNegocio.Location = new System.Drawing.Point(15, 10);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(175, 23);
            this.lblNombreNegocio.TabIndex = 0;
            this.lblNombreNegocio.Text = "Nombre del negocio :";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreNegocio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreNegocio.Location = new System.Drawing.Point(15, 38);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(470, 32);
            this.txtNombreNegocio.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblTelefono.Location = new System.Drawing.Point(15, 85);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(83, 23);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTelefono.Location = new System.Drawing.Point(15, 113);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(470, 32);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblDireccion.Location = new System.Drawing.Point(15, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 23);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDireccion.Location = new System.Drawing.Point(15, 188);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(470, 32);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblRfc.Location = new System.Drawing.Point(15, 235);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(49, 23);
            this.lblRfc.TabIndex = 6;
            this.lblRfc.Text = "RFC :";
            // 
            // txtRfc
            // 
            this.txtRfc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRfc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRfc.Location = new System.Drawing.Point(15, 263);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(470, 32);
            this.txtRfc.TabIndex = 7;
            // 
            // lblMensajeFinal
            // 
            this.lblMensajeFinal.AutoSize = true;
            this.lblMensajeFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMensajeFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblMensajeFinal.Location = new System.Drawing.Point(15, 310);
            this.lblMensajeFinal.Name = "lblMensajeFinal";
            this.lblMensajeFinal.Size = new System.Drawing.Size(121, 23);
            this.lblMensajeFinal.TabIndex = 8;
            this.lblMensajeFinal.Text = "Mensaje Final :";
            // 
            // txtMensajeFinal
            // 
            this.txtMensajeFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensajeFinal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMensajeFinal.Location = new System.Drawing.Point(15, 338);
            this.txtMensajeFinal.Multiline = true; // Permite escribir varias líneas para el agradecimiento del ticket
            this.txtMensajeFinal.Name = "txtMensajeFinal";
            this.txtMensajeFinal.Size = new System.Drawing.Size(470, 190);
            this.txtMensajeFinal.TabIndex = 9;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft; // Alinea los botones a la extrema derecha de la pantalla
            this.pnlAcciones.Location = new System.Drawing.Point(480, 655);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(400, 55);
            this.pnlAcciones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(77, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113))))); // Verde esmeralda de confirmación
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(233, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 45);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // Frmticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 730);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlContenedorPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frmticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración de Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlIzquierdoLogo.ResumeLayout(false);
            this.pnlIzquierdoLogo.PerformLayout();
            this.pnlDerechoCampos.ResumeLayout(false);
            this.pnlDerechoCampos.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}