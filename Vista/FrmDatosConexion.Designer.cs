namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmDatosConexion
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
            lblServidor = new Label();
            txtServidor = new TextBox();
            lblBaseDatos = new Label();
            txtBaseDatos = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEstadoConexion = new Label();
            btnProbarConexion = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.Location = new Point(34, 30);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(346, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Configuración de Conexión";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(34, 120);
            lblServidor.Margin = new Padding(5, 0, 5, 0);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(93, 30);
            lblServidor.TabIndex = 1;
            lblServidor.Text = "Servidor:";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(257, 114);
            txtServidor.Margin = new Padding(5, 6, 5, 6);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(391, 35);
            txtServidor.TabIndex = 2;
            // 
            // lblBaseDatos
            // 
            lblBaseDatos.AutoSize = true;
            lblBaseDatos.Location = new Point(34, 190);
            lblBaseDatos.Margin = new Padding(5, 0, 5, 0);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(147, 30);
            lblBaseDatos.TabIndex = 3;
            lblBaseDatos.Text = "Base de datos:";
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(257, 184);
            txtBaseDatos.Margin = new Padding(5, 6, 5, 6);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(391, 35);
            txtBaseDatos.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(34, 260);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 30);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(257, 254);
            txtUsuario.Margin = new Padding(5, 6, 5, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(391, 35);
            txtUsuario.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(34, 330);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 30);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(257, 324);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(391, 35);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.Location = new Point(34, 400);
            lblEstadoConexion.Margin = new Padding(5, 0, 5, 0);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(617, 80);
            lblEstadoConexion.TabIndex = 9;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(257, 500);
            btnProbarConexion.Margin = new Padding(5, 6, 5, 6);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(189, 60);
            btnProbarConexion.TabIndex = 10;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(463, 500);
            btnGuardar.Margin = new Padding(5, 6, 5, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(189, 60);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmDatosConexion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 620);
            Controls.Add(btnGuardar);
            Controls.Add(btnProbarConexion);
            Controls.Add(lblEstadoConexion);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtBaseDatos);
            Controls.Add(lblBaseDatos);
            Controls.Add(txtServidor);
            Controls.Add(lblServidor);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDatosConexion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configuración de conexión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnGuardar;
    }
}