namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmVistaPreviaTicket
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
            pnlPapelTicket = new Panel();
            picPreviaLogo = new PictureBox();
            lblPreviaNombre = new Label();
            lblPreviaDireccion = new Label();
            lblPreviaTelefono = new Label();
            lblPreviaRfc = new Label();
            lblSeparador1 = new Label();
            lblContenidoMuestra = new Label();
            lblSeparador2 = new Label();
            lblPreviaMensaje = new Label();
            btnCerrar = new Button();
            pnlPapelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreviaLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlPapelTicket
            // 
            pnlPapelTicket.BackColor = Color.White;
            pnlPapelTicket.BorderStyle = BorderStyle.FixedSingle;
            pnlPapelTicket.Controls.Add(picPreviaLogo);
            pnlPapelTicket.Controls.Add(lblPreviaNombre);
            pnlPapelTicket.Controls.Add(lblPreviaDireccion);
            pnlPapelTicket.Controls.Add(lblPreviaTelefono);
            pnlPapelTicket.Controls.Add(lblPreviaRfc);
            pnlPapelTicket.Controls.Add(lblSeparador1);
            pnlPapelTicket.Controls.Add(lblContenidoMuestra);
            pnlPapelTicket.Controls.Add(lblSeparador2);
            pnlPapelTicket.Controls.Add(lblPreviaMensaje);
            pnlPapelTicket.Location = new Point(20, 20);
            pnlPapelTicket.Name = "pnlPapelTicket";
            pnlPapelTicket.Size = new Size(360, 500);
            pnlPapelTicket.TabIndex = 0;
            // 
            // picPreviaLogo
            // 
            picPreviaLogo.Location = new Point(135, 15);
            picPreviaLogo.Name = "picPreviaLogo";
            picPreviaLogo.Size = new Size(90, 60);
            picPreviaLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picPreviaLogo.TabIndex = 0;
            picPreviaLogo.TabStop = false;
            // 
            // lblPreviaNombre
            // 
            lblPreviaNombre.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblPreviaNombre.Location = new Point(10, 90);
            lblPreviaNombre.Name = "lblPreviaNombre";
            lblPreviaNombre.Size = new Size(338, 28);
            lblPreviaNombre.TabIndex = 1;
            lblPreviaNombre.Text = "NOMBRE NEGOCIO";
            lblPreviaNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPreviaDireccion
            // 
            lblPreviaDireccion.Font = new Font("Consolas", 9F);
            lblPreviaDireccion.Location = new Point(10, 125);
            lblPreviaDireccion.Name = "lblPreviaDireccion";
            lblPreviaDireccion.Size = new Size(338, 45);
            lblPreviaDireccion.TabIndex = 2;
            lblPreviaDireccion.Text = "Dirección";
            lblPreviaDireccion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPreviaTelefono
            // 
            lblPreviaTelefono.Font = new Font("Consolas", 9F);
            lblPreviaTelefono.Location = new Point(10, 175);
            lblPreviaTelefono.Name = "lblPreviaTelefono";
            lblPreviaTelefono.Size = new Size(338, 22);
            lblPreviaTelefono.TabIndex = 3;
            lblPreviaTelefono.Text = "Teléfono";
            lblPreviaTelefono.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPreviaRfc
            // 
            lblPreviaRfc.Font = new Font("Consolas", 9F);
            lblPreviaRfc.Location = new Point(10, 202);
            lblPreviaRfc.Name = "lblPreviaRfc";
            lblPreviaRfc.Size = new Size(338, 22);
            lblPreviaRfc.TabIndex = 4;
            lblPreviaRfc.Text = "RFC";
            lblPreviaRfc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSeparador1
            // 
            lblSeparador1.Font = new Font("Consolas", 9F);
            lblSeparador1.Location = new Point(10, 230);
            lblSeparador1.Name = "lblSeparador1";
            lblSeparador1.Size = new Size(338, 18);
            lblSeparador1.TabIndex = 5;
            lblSeparador1.Text = "================================";
            lblSeparador1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblContenidoMuestra
            // 
            lblContenidoMuestra.Font = new Font("Consolas", 9F);
            lblContenidoMuestra.Location = new Point(10, 255);
            lblContenidoMuestra.Name = "lblContenidoMuestra";
            lblContenidoMuestra.Size = new Size(338, 60);
            lblContenidoMuestra.TabIndex = 6;
            lblContenidoMuestra.Text = "1 X PRODUCTO DE PRUEBA   $150.00\r\n\r\nTOTAL:                  $150.00";
            // 
            // lblSeparador2
            // 
            lblSeparador2.Font = new Font("Consolas", 9F);
            lblSeparador2.Location = new Point(10, 325);
            lblSeparador2.Name = "lblSeparador2";
            lblSeparador2.Size = new Size(338, 18);
            lblSeparador2.TabIndex = 7;
            lblSeparador2.Text = "================================";
            lblSeparador2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPreviaMensaje
            // 
            lblPreviaMensaje.Font = new Font("Consolas", 9.5F, FontStyle.Italic);
            lblPreviaMensaje.Location = new Point(10, 355);
            lblPreviaMensaje.Name = "lblPreviaMensaje";
            lblPreviaMensaje.Size = new Size(338, 130);
            lblPreviaMensaje.TabIndex = 8;
            lblPreviaMensaje.Text = "Mensaje Final";
            lblPreviaMensaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(149, 165, 166);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(125, 535);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar Vista";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmVistaPreviaTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(400, 595);
            Controls.Add(btnCerrar);
            Controls.Add(pnlPapelTicket);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmVistaPreviaTicket";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vista Previa de Impresión";
            pnlPapelTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPreviaLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlPapelTicket;
        private System.Windows.Forms.PictureBox picPreviaLogo;
        private System.Windows.Forms.Label lblPreviaNombre;
        private System.Windows.Forms.Label lblPreviaDireccion;
        private System.Windows.Forms.Label lblPreviaTelefono;
        private System.Windows.Forms.Label lblPreviaRfc;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblContenidoMuestra;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Label lblPreviaMensaje;
        private System.Windows.Forms.Button btnCerrar;
    }
}