namespace Pry_Sistema_Punto_de_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlCardLogin = new Panel();
            lnkOlvidePassword = new LinkLabel();
            btnMostrar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnIniciar = new Button();
            txtUsuario = new TextBox();
            txtpassword = new TextBox();
            ptxLogin = new PictureBox();
            pnlCardLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxLogin).BeginInit();
            SuspendLayout();
            // 
            // pnlCardLogin
            // 
            pnlCardLogin.BackColor = Color.White;
            pnlCardLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlCardLogin.Controls.Add(lnkOlvidePassword);
            pnlCardLogin.Controls.Add(btnMostrar);
            pnlCardLogin.Controls.Add(pictureBox3);
            pnlCardLogin.Controls.Add(pictureBox2);
            pnlCardLogin.Controls.Add(btnIniciar);
            pnlCardLogin.Controls.Add(txtUsuario);
            pnlCardLogin.Controls.Add(txtpassword);
            pnlCardLogin.Location = new Point(117, 320);
            pnlCardLogin.Margin = new Padding(4, 5, 4, 5);
            pnlCardLogin.Name = "pnlCardLogin";
            pnlCardLogin.Size = new Size(634, 460);
            pnlCardLogin.TabIndex = 1;
            // 
            // lnkOlvidePassword
            // 
            lnkOlvidePassword.ActiveLinkColor = Color.FromArgb(41, 128, 185);
            lnkOlvidePassword.AutoSize = true;
            lnkOlvidePassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkOlvidePassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkOlvidePassword.LinkColor = Color.FromArgb(127, 140, 141);
            lnkOlvidePassword.Location = new Point(216, 400);
            lnkOlvidePassword.Name = "lnkOlvidePassword";
            lnkOlvidePassword.Size = new Size(244, 28);
            lnkOlvidePassword.TabIndex = 11;
            lnkOlvidePassword.TabStop = true;
            lnkOlvidePassword.Text = "¿Olvidaste tu contraseña?";
            lnkOlvidePassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.White;
            btnMostrar.BackgroundImage = (Image)resources.GetObject("btnMostrar.BackgroundImage");
            btnMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMostrar.Cursor = Cursors.Hand;
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Location = new Point(495, 151);
            btnMostrar.Margin = new Padding(4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(42, 36);
            btnMostrar.TabIndex = 10;
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.candado;
            pictureBox3.Location = new Point(64, 150);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.correo;
            pictureBox2.Location = new Point(64, 55);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(52, 152, 219);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(112, 302);
            btnIniciar.Margin = new Padding(4, 5, 4, 5);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(427, 58);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(248, 249, 250);
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(44, 62, 80);
            txtUsuario.Location = new Point(112, 55);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su Usuario";
            txtUsuario.Size = new Size(426, 39);
            txtUsuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(248, 249, 250);
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(44, 62, 80);
            txtpassword.Location = new Point(112, 150);
            txtpassword.Margin = new Padding(4, 5, 4, 5);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.PlaceholderText = "Ingrese su contraseña";
            txtpassword.Size = new Size(426, 39);
            txtpassword.TabIndex = 3;
            // 
            // ptxLogin
            // 
            ptxLogin.Image = Properties.Resources.punto_de_venta3;
            ptxLogin.Location = new Point(241, 34);
            ptxLogin.Margin = new Padding(4, 5, 4, 5);
            ptxLogin.Name = "ptxLogin";
            ptxLogin.Size = new Size(416, 255);
            ptxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            ptxLogin.TabIndex = 0;
            ptxLogin.TabStop = false;
            ptxLogin.UseWaitCursor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(868, 830);
            Controls.Add(pnlCardLogin);
            Controls.Add(ptxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso al Sistema";
            pnlCardLogin.ResumeLayout(false);
            pnlCardLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxLogin).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxLogin;
        private System.Windows.Forms.Panel pnlCardLogin;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.LinkLabel lnkOlvidePassword;
    }
}