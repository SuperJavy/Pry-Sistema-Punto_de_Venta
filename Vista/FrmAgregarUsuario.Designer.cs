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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();

            // COMPONENTES DEL COMBOBOX DE ROL
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();
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
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(44, 360);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(144, 23);
            this.lblNombreUsuario.TabIndex = 14;
            this.lblNombreUsuario.Text = "Crear Usuario / Nick :";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(44, 388);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(350, 32);
            this.txtNombreUsuario.TabIndex = 15;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblRol.Location = new System.Drawing.Point(44, 445); // Fila 5 (Izquierda)
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(142, 23);
            this.lblRol.TabIndex = 18;
            this.lblRol.Text = "Rol de Usuario :";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Evita que escriban texto libre
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(44, 473);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(350, 33);
            this.cmbRol.TabIndex = 19;
            // 
            // lblDireccion
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
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCorreo.Location = new System.Drawing.Point(440, 275);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(159, 23);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo Electrónico :";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCorreo.Location = new System.Drawing.Point(440, 303);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(350, 32);
            this.txtCorreo.TabIndex = 17;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblContrasena.Location = new System.Drawing.Point(440, 360); // Fila 4 (Derecha)
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(106, 23);
            this.lblContrasena.TabIndex = 11;
            this.lblContrasena.Text = "Contraseña :";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.Location = new System.Drawing.Point(440, 388);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(350, 32);
            this.txtContrasena.TabIndex = 12;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(44, 550); // Ajustado al fondo para dar espacio a la nueva fila
            this.BtnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(746, 45);
            this.BtnAgregarUsuario.TabIndex = 13;
            this.BtnAgregarUsuario.Text = "Guardar Usuario";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // FrmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 640); // Incrementado de 550 a 640 para espacio óptimo del Combo
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.BtnAgregarUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;

        // NUEVAS DECLARACIONES
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
    }
}