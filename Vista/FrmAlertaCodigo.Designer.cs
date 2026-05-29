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
            btnMostrar = new Button();
            pictureBox3 = new PictureBox();
            txtpassword = new TextBox();
            btnIniciar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(btnIniciar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 275);
            panel1.TabIndex = 3;
            // 
            // btnMostrar
            // 
            btnMostrar.BackgroundImage = (Image)resources.GetObject("btnMostrar.BackgroundImage");
            btnMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMostrar.Location = new Point(488, 100);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(48, 35);
            btnMostrar.TabIndex = 15;
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.candado;
            pictureBox3.Location = new Point(86, 100);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = SystemColors.WindowText;
            txtpassword.Location = new Point(126, 100);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Ingrese su contraseña";
            txtpassword.Size = new Size(356, 35);
            txtpassword.TabIndex = 13;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(238, 175);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(132, 46);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar ";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 36);
            label1.Name = "label1";
            label1.Size = new Size(349, 32);
            label1.TabIndex = 16;
            label1.Text = "Contraseña de confirmacion.";
            // 
            // FrmAlertaCodigo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 275);
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmAlertaCodigo";
            Text = "Alerta de codigo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private Button btnMostrar;
        private PictureBox pictureBox3;
        private TextBox txtpassword;
        private Label label1;
    }
}