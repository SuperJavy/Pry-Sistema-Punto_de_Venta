namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmAlertaEliminar
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
            btnIniciar = new Button();
            txtpassword = new TextBox();
            label1 = new Label();
            btnbuscarproduct = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnbuscarproduct);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(btnIniciar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 357);
            panel1.TabIndex = 4;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(96, 396);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(347, 48);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar ";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = SystemColors.WindowText;
            txtpassword.Location = new Point(142, 144);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Ingrese codigo del producto";
            txtpassword.Size = new Size(356, 35);
            txtpassword.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 59);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 14;
            label1.Text = "Eliminar producto.";
            // 
            // btnbuscarproduct
            // 
            btnbuscarproduct.Location = new Point(255, 208);
            btnbuscarproduct.Name = "btnbuscarproduct";
            btnbuscarproduct.Size = new Size(132, 46);
            btnbuscarproduct.TabIndex = 15;
            btnbuscarproduct.Text = "Buscar.";
            btnbuscarproduct.UseVisualStyleBackColor = true;
            // 
            // FrmAlertaEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 357);
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmAlertaEliminar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAlertaEliminar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnIniciar;
        private Button btnbuscarproduct;
        private Label label1;
        private TextBox txtpassword;
    }
}