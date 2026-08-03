namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmRecuperarPassword
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
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnEnviarCodigo = new Button();
            panelRestablecer = new Panel();
            lblInstrucciones = new Label();
            btnRestablecer = new Button();
            txtConfirmarPass = new TextBox();
            lblConfirmarPass = new Label();
            txtNuevaPass = new TextBox();
            lblNuevaPass = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            panelRestablecer.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(68, 58);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(515, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperación de Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(70, 180);
            lblCorreo.Margin = new Padding(6, 0, 6, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(361, 37);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Ingresa tu correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(78, 242);
            txtCorreo.Margin = new Padding(6, 7, 6, 7);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(646, 45);
            txtCorreo.TabIndex = 2;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(0, 122, 204);
            btnEnviarCodigo.Cursor = Cursors.Hand;
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Flat;
            btnEnviarCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(78, 346);
            btnEnviarCodigo.Margin = new Padding(6, 7, 6, 7);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(650, 92);
            btnEnviarCodigo.TabIndex = 3;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // panelRestablecer
            // 
            panelRestablecer.Controls.Add(lblInstrucciones);
            panelRestablecer.Controls.Add(btnRestablecer);
            panelRestablecer.Controls.Add(txtConfirmarPass);
            panelRestablecer.Controls.Add(lblConfirmarPass);
            panelRestablecer.Controls.Add(txtNuevaPass);
            panelRestablecer.Controls.Add(lblNuevaPass);
            panelRestablecer.Controls.Add(txtCodigo);
            panelRestablecer.Controls.Add(lblCodigo);
            panelRestablecer.Location = new Point(46, 485);
            panelRestablecer.Margin = new Padding(6, 7, 6, 7);
            panelRestablecer.Name = "panelRestablecer";
            panelRestablecer.Size = new Size(720, 715);
            panelRestablecer.TabIndex = 4;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstrucciones.ForeColor = Color.DimGray;
            lblInstrucciones.Location = new Point(26, 23);
            lblInstrucciones.Margin = new Padding(6, 0, 6, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(513, 31);
            lblInstrucciones.TabIndex = 11;
            lblInstrucciones.Text = "Revisa tu bandeja de entrada e ingresa los datos:";
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = Color.FromArgb(46, 204, 113);
            btnRestablecer.Cursor = Cursors.Hand;
            btnRestablecer.FlatAppearance.BorderSize = 0;
            btnRestablecer.FlatStyle = FlatStyle.Flat;
            btnRestablecer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestablecer.ForeColor = Color.White;
            btnRestablecer.Location = new Point(32, 577);
            btnRestablecer.Margin = new Padding(6, 7, 6, 7);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(650, 92);
            btnRestablecer.TabIndex = 10;
            btnRestablecer.Text = "Guardar Nueva Contraseña";
            btnRestablecer.UseVisualStyleBackColor = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // txtConfirmarPass
            // 
            txtConfirmarPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarPass.Location = new Point(32, 462);
            txtConfirmarPass.Margin = new Padding(6, 7, 6, 7);
            txtConfirmarPass.Name = "txtConfirmarPass";
            txtConfirmarPass.PasswordChar = '*';
            txtConfirmarPass.Size = new Size(646, 45);
            txtConfirmarPass.TabIndex = 9;
            // 
            // lblConfirmarPass
            // 
            lblConfirmarPass.AutoSize = true;
            lblConfirmarPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarPass.Location = new Point(24, 404);
            lblConfirmarPass.Margin = new Padding(6, 0, 6, 0);
            lblConfirmarPass.Name = "lblConfirmarPass";
            lblConfirmarPass.Size = new Size(277, 37);
            lblConfirmarPass.TabIndex = 8;
            lblConfirmarPass.Text = "Confirmar contraseña:";
            // 
            // txtNuevaPass
            // 
            txtNuevaPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuevaPass.Location = new Point(32, 312);
            txtNuevaPass.Margin = new Padding(6, 7, 6, 7);
            txtNuevaPass.Name = "txtNuevaPass";
            txtNuevaPass.PasswordChar = '*';
            txtNuevaPass.Size = new Size(646, 45);
            txtNuevaPass.TabIndex = 7;
            // 
            // lblNuevaPass
            // 
            lblNuevaPass.AutoSize = true;
            lblNuevaPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaPass.Location = new Point(24, 254);
            lblNuevaPass.Margin = new Padding(6, 0, 6, 0);
            lblNuevaPass.Name = "lblNuevaPass";
            lblNuevaPass.Size = new Size(235, 37);
            lblNuevaPass.TabIndex = 6;
            lblNuevaPass.Text = "Nueva contraseña:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(32, 150);
            txtCodigo.Margin = new Padding(6, 7, 6, 7);
            txtCodigo.MaxLength = 6;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(288, 52);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(24, 92);
            lblCodigo.Margin = new Padding(6, 0, 6, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(276, 37);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Código de 6 dígitos:";
            // 
            // FrmRecuperarPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 1258);
            Controls.Add(panelRestablecer);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecuperarPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar Acceso";
            panelRestablecer.ResumeLayout(false);
            panelRestablecer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Panel panelRestablecer;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label lblInstrucciones;


    }
}