namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmAgregarUsuario
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
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblContrasena = new Label();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtPassword = new TextBox();
            BtnAgregarUsuario = new Button();
            cmbRol = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(40, 30);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(336, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Nuevo Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombre.Location = new Point(44, 105);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre :";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblApellidoPaterno.ForeColor = Color.FromArgb(127, 140, 141);
            lblApellidoPaterno.Location = new Point(44, 190);
            lblApellidoPaterno.Margin = new Padding(4, 0, 4, 0);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(174, 28);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido Paterno :";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblApellidoMaterno.ForeColor = Color.FromArgb(127, 140, 141);
            lblApellidoMaterno.Location = new Point(44, 275);
            lblApellidoMaterno.Margin = new Padding(4, 0, 4, 0);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(181, 28);
            lblApellidoMaterno.TabIndex = 5;
            lblApellidoMaterno.Text = "Apellido Materno :";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(127, 140, 141);
            lblDireccion.Location = new Point(440, 105);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(107, 28);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección :";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(127, 140, 141);
            lblTelefono.Location = new Point(440, 190);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(102, 28);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono :";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(127, 140, 141);
            lblContrasena.Location = new Point(440, 275);
            lblContrasena.Margin = new Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(125, 28);
            lblContrasena.TabIndex = 11;
            lblContrasena.Text = "Contraseña :";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(44, 133);
            txtNombre.Margin = new Padding(4, 6, 4, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(350, 37);
            txtNombre.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 11F);
            txtApellidoPaterno.Location = new Point(44, 218);
            txtApellidoPaterno.Margin = new Padding(4, 6, 4, 6);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(350, 37);
            txtApellidoPaterno.TabIndex = 4;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 11F);
            txtApellidoMaterno.Location = new Point(44, 303);
            txtApellidoMaterno.Margin = new Padding(4, 6, 4, 6);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(350, 37);
            txtApellidoMaterno.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(440, 133);
            txtDireccion.Margin = new Padding(4, 6, 4, 6);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(350, 37);
            txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(440, 218);
            txtTelefono.Margin = new Padding(4, 6, 4, 6);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(350, 37);
            txtTelefono.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(440, 303);
            txtPassword.Margin = new Padding(4, 6, 4, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 37);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.BackColor = Color.FromArgb(46, 204, 113);
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 0;
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnAgregarUsuario.ForeColor = Color.White;
            BtnAgregarUsuario.Location = new Point(43, 470);
            BtnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(746, 45);
            BtnAgregarUsuario.TabIndex = 13;
            BtnAgregarUsuario.Text = "Guardar Usuario";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(44, 380);
            cmbRol.Margin = new Padding(2, 2, 2, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(350, 33);
            cmbRol.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(127, 140, 141);
            label1.Location = new Point(44, 350);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 15;
            label1.Text = "Seleccionar Rol :";
            // 
            // FrmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(849, 558);
            Controls.Add(label1);
            Controls.Add(cmbRol);
            Controls.Add(BtnAgregarUsuario);
            Controls.Add(txtPassword);
            Controls.Add(lblContrasena);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmAgregarUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Usuario";
            Load += FrmAgregarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private ComboBox cmbRol;
        private Label label1;
    }
}