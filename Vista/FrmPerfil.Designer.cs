namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmPerfil
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
            pnlCardPerfil = new Panel();
            pcbMostrar = new PictureBox();
            btnGuardarContrasena = new Button();
            btnCerrarSesion = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtPassword = new TextBox();
            pnlCardPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMostrar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(60, 46);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 51);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mi Perfil de Usuario";
            // 
            // pnlCardPerfil
            // 
            pnlCardPerfil.BackColor = Color.White;
            pnlCardPerfil.BorderStyle = BorderStyle.Fixed3D;
            pnlCardPerfil.Controls.Add(pcbMostrar);
            pnlCardPerfil.Controls.Add(btnGuardarContrasena);
            pnlCardPerfil.Controls.Add(btnCerrarSesion);
            pnlCardPerfil.Controls.Add(txtTelefono);
            pnlCardPerfil.Controls.Add(lblTelefono);
            pnlCardPerfil.Controls.Add(txtCorreo);
            pnlCardPerfil.Controls.Add(lblCorreo);
            pnlCardPerfil.Controls.Add(lblContrasena);
            pnlCardPerfil.Controls.Add(txtUsuario);
            pnlCardPerfil.Controls.Add(lblUsuario);
            pnlCardPerfil.Controls.Add(txtApellido);
            pnlCardPerfil.Controls.Add(lblApellido);
            pnlCardPerfil.Controls.Add(txtNombre);
            pnlCardPerfil.Controls.Add(lblNombre);
            pnlCardPerfil.Controls.Add(txtPassword);
            pnlCardPerfil.Location = new Point(67, 134);
            pnlCardPerfil.Margin = new Padding(5, 5, 5, 5);
            pnlCardPerfil.Name = "pnlCardPerfil";
            pnlCardPerfil.Size = new Size(1288, 719);
            pnlCardPerfil.TabIndex = 1;
            // 
            // pcbMostrar
            // 
            pcbMostrar.Image = Properties.Resources.ojo;
            pcbMostrar.Location = new Point(1151, 215);
            pcbMostrar.Margin = new Padding(4, 4, 4, 4);
            pcbMostrar.Name = "pcbMostrar";
            pcbMostrar.Size = new Size(48, 44);
            pcbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMostrar.TabIndex = 14;
            pcbMostrar.TabStop = false;
            pcbMostrar.MouseDown += pcbMostrar_MouseDown;
            pcbMostrar.MouseUp += pcbMostrar_MouseUp;
            // 
            // btnGuardarContrasena
            // 
            btnGuardarContrasena.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardarContrasena.Cursor = Cursors.Hand;
            btnGuardarContrasena.FlatAppearance.BorderSize = 0;
            btnGuardarContrasena.FlatStyle = FlatStyle.Flat;
            btnGuardarContrasena.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarContrasena.ForeColor = Color.White;
            btnGuardarContrasena.Location = new Point(660, 593);
            btnGuardarContrasena.Margin = new Padding(5, 5, 5, 5);
            btnGuardarContrasena.Name = "btnGuardarContrasena";
            btnGuardarContrasena.Size = new Size(540, 67);
            btnGuardarContrasena.TabIndex = 9;
            btnGuardarContrasena.Text = "Actualizar Contraseña";
            btnGuardarContrasena.UseVisualStyleBackColor = false;
            btnGuardarContrasena.Click += btnGuardarContrasena_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(60, 593);
            btnCerrarSesion.Margin = new Padding(5, 5, 5, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(540, 67);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(245, 247, 250);
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(660, 335);
            txtTelefono.Margin = new Padding(5, 5, 5, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(538, 42);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(127, 140, 141);
            lblTelefono.Location = new Point(660, 293);
            lblTelefono.Margin = new Padding(5, 0, 5, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 32);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono :";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(245, 247, 250);
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.Location = new Point(60, 335);
            txtCorreo.Margin = new Padding(5, 5, 5, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(538, 42);
            txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(127, 140, 141);
            lblCorreo.Location = new Point(60, 293);
            lblCorreo.Margin = new Padding(5, 0, 5, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(227, 32);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo Electrónico :";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(44, 62, 80);
            lblContrasena.Location = new Point(660, 173);
            lblContrasena.Margin = new Padding(5, 0, 5, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(301, 32);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña (Modificable) :";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(245, 247, 250);
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(60, 92);
            txtUsuario.Margin = new Padding(5, 5, 5, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(538, 42);
            txtUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(127, 140, 141);
            lblUsuario.Location = new Point(60, 50);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(110, 32);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario :";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(245, 247, 250);
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(60, 215);
            txtApellido.Margin = new Padding(5, 5, 5, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(538, 42);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(127, 140, 141);
            lblApellido.Location = new Point(60, 173);
            lblApellido.Margin = new Padding(5, 0, 5, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(126, 32);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellidos :";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 247, 250);
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(660, 92);
            txtNombre.Margin = new Padding(5, 5, 5, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(538, 42);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombre.Location = new Point(660, 50);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(116, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(660, 215);
            txtPassword.Margin = new Padding(5, 5, 5, 5);
            txtPassword.MaxLength = 8;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(538, 42);
            txtPassword.TabIndex = 5;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1426, 900);
            Controls.Add(pnlCardPerfil);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Perfil";
            pnlCardPerfil.ResumeLayout(false);
            pnlCardPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCardPerfil;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblCorreo;

        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;

        // COMPONENTES DE ACCIÓN ACTUALIZADOS
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnGuardarContrasena;
        private TextBox txtCorreo;
        private PictureBox pcbMostrar;
    }
}