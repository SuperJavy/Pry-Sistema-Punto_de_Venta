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
            txtPassword = new TextBox();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pnlCardPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMostrar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(50, 38);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 45);
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
            pnlCardPerfil.Controls.Add(txtPassword);
            pnlCardPerfil.Controls.Add(lblContrasena);
            pnlCardPerfil.Controls.Add(txtUsuario);
            pnlCardPerfil.Controls.Add(lblUsuario);
            pnlCardPerfil.Controls.Add(txtApellido);
            pnlCardPerfil.Controls.Add(lblApellido);
            pnlCardPerfil.Controls.Add(txtNombre);
            pnlCardPerfil.Controls.Add(lblNombre);
            pnlCardPerfil.Location = new Point(56, 112);
            pnlCardPerfil.Margin = new Padding(4);
            pnlCardPerfil.Name = "pnlCardPerfil";
            pnlCardPerfil.Size = new Size(1074, 600);
            pnlCardPerfil.TabIndex = 1;
            // 
            // pcbMostrar
            // 
            pcbMostrar.Image = Properties.Resources.ojo;
            pcbMostrar.Location = new Point(957, 179);
            pcbMostrar.Name = "pcbMostrar";
            pcbMostrar.Size = new Size(42, 37);
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
            btnGuardarContrasena.Location = new Point(550, 494);
            btnGuardarContrasena.Margin = new Padding(4);
            btnGuardarContrasena.Name = "btnGuardarContrasena";
            btnGuardarContrasena.Size = new Size(450, 56);
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
            btnCerrarSesion.Location = new Point(50, 494);
            btnCerrarSesion.Margin = new Padding(4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(450, 56);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(245, 247, 250);
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(550, 279);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(449, 37);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(127, 140, 141);
            lblTelefono.Location = new Point(550, 244);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(102, 28);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono :";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(245, 247, 250);
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.Location = new Point(50, 279);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(449, 37);
            txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(127, 140, 141);
            lblCorreo.Location = new Point(50, 244);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(189, 28);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo Electrónico :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(550, 179);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(449, 37);
            txtPassword.TabIndex = 5;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(44, 62, 80);
            lblContrasena.Location = new Point(550, 144);
            lblContrasena.Margin = new Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(251, 28);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña (Modificable) :";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(245, 247, 250);
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(50, 77);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(449, 37);
            txtUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(127, 140, 141);
            lblUsuario.Location = new Point(50, 42);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 28);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario :";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(245, 247, 250);
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(50, 179);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(449, 37);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(127, 140, 141);
            lblApellido.Location = new Point(50, 144);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 28);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellidos :";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 247, 250);
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(550, 77);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(449, 37);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombre.Location = new Point(550, 42);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1188, 750);
            Controls.Add(pnlCardPerfil);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
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