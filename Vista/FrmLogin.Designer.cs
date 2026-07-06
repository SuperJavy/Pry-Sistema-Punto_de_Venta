namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmLogin
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
            panel1 = new Panel();
            pcbMostrar = new PictureBox();
            lblOlvidaste = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnIniciar = new Button();
            txtUsuario = new TextBox();
            txtpassword = new TextBox();
            ptxLogin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pcbMostrar);
            panel1.Controls.Add(lblOlvidaste);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtpassword);
            panel1.Location = new Point(97, 340);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 380);
            panel1.TabIndex = 1;
            // 
            // pcbMostrar
            // 
            pcbMostrar.Image = Properties.Resources.ojo;
            pcbMostrar.Location = new Point(403, 128);
            pcbMostrar.Name = "pcbMostrar";
            pcbMostrar.Size = new Size(45, 29);
            pcbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMostrar.TabIndex = 12;
            pcbMostrar.TabStop = false;
            pcbMostrar.MouseDown += pcbMostrar_MouseDown;
            pcbMostrar.MouseUp += pcbMostrar_MouseUp;
            // 
            // lblOlvidaste
            // 
            lblOlvidaste.ActiveLinkColor = Color.FromArgb(29, 78, 216);
            lblOlvidaste.AutoSize = true;
            lblOlvidaste.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOlvidaste.LinkBehavior = LinkBehavior.HoverUnderline;
            lblOlvidaste.LinkColor = Color.FromArgb(100, 116, 139);
            lblOlvidaste.Location = new Point(143, 303);
            lblOlvidaste.Name = "lblOlvidaste";
            lblOlvidaste.Size = new Size(228, 25);
            lblOlvidaste.TabIndex = 11;
            lblOlvidaste.TabStop = true;
            lblOlvidaste.Text = "¿Olvidaste tu contraseña?";
            lblOlvidaste.VisitedLinkColor = Color.FromArgb(100, 116, 139);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.candado;
            pictureBox3.Location = new Point(61, 128);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.correo;
            pictureBox2.Location = new Point(61, 49);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(37, 99, 235);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(81, 233);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(356, 48);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INICIAR SESIÓN";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(15, 23, 42);
            txtUsuario.Location = new Point(101, 49);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su Usuario";
            txtUsuario.Size = new Size(356, 39);
            txtUsuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtpassword.Location = new Point(101, 124);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.MaxLength = 8;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Ingrese su contraseña";
            txtpassword.Size = new Size(356, 39);
            txtpassword.TabIndex = 3;
            txtpassword.KeyDown += txtpassword_KeyDown;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // ptxLogin
            // 
            ptxLogin.Image = Properties.Resources.punto_de_venta3;
            ptxLogin.Location = new Point(178, 28);
            ptxLogin.Margin = new Padding(3, 4, 3, 4);
            ptxLogin.Name = "ptxLogin";
            ptxLogin.Size = new Size(386, 280);
            ptxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            ptxLogin.TabIndex = 0;
            ptxLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(723, 790);
            Controls.Add(panel1);
            Controls.Add(ptxLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso al Sistema";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox ptxLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lblOlvidaste;
        private PictureBox pcbMostrar;
    }
}