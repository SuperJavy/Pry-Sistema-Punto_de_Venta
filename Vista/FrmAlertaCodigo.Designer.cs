namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmAlertaCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertaCodigo));
            panel1 = new Panel();
            pcbMostrar = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            txtpassword = new TextBox();
            btnIniciar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pcbMostrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(btnIniciar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 451);
            panel1.TabIndex = 0;
            // 
            // pcbMostrar
            // 
            pcbMostrar.BackgroundImage = (Image)resources.GetObject("pcbMostrar.BackgroundImage");
            pcbMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            pcbMostrar.Cursor = Cursors.Hand;
            pcbMostrar.FlatAppearance.BorderSize = 0;
            pcbMostrar.FlatStyle = FlatStyle.Flat;
            pcbMostrar.Location = new Point(587, 188);
            pcbMostrar.Margin = new Padding(5, 6, 5, 6);
            pcbMostrar.Name = "pcbMostrar";
            pcbMostrar.Size = new Size(60, 70);
            pcbMostrar.TabIndex = 1;
            pcbMostrar.UseVisualStyleBackColor = true;
            pcbMostrar.MouseDown += pcbMostrar_MouseDown;
            pcbMostrar.MouseUp += pcbMostrar_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(50, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(563, 45);
            label1.TabIndex = 0;
            label1.Text = "🔒 Confirmación de Administrador";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.candado;
            pictureBox3.Location = new Point(19, 188);
            pictureBox3.Margin = new Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11F);
            txtpassword.Location = new Point(84, 200);
            txtpassword.Margin = new Padding(5, 6, 5, 6);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Ingrese la contraseña del administrador";
            txtpassword.Size = new Size(477, 42);
            txtpassword.TabIndex = 3;
            txtpassword.KeyDown += txtpassword_KeyDown;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(34, 197, 94);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(199, 304);
            btnIniciar.Margin = new Padding(5, 6, 5, 6);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(257, 84);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Confirmar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // FrmAlertaCodigo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(696, 451);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlertaCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmación de Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private Button pcbMostrar;
        private PictureBox pictureBox3;
        private TextBox txtpassword;
        private Label label1;
    }
}