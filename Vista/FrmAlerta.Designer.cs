namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmAlerta
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
            btnbuscarproduct = new Button();
            label1 = new Label();
            txtpassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnbuscarproduct);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtpassword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 249);
            panel1.TabIndex = 4;
            // 
            // btnbuscarproduct
            // 
            btnbuscarproduct.Anchor = AnchorStyles.Top;
            btnbuscarproduct.BackColor = Color.FromArgb(52, 152, 219);
            btnbuscarproduct.Cursor = Cursors.Hand;
            btnbuscarproduct.FlatAppearance.BorderSize = 0;
            btnbuscarproduct.FlatStyle = FlatStyle.Flat;
            btnbuscarproduct.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscarproduct.ForeColor = Color.White;
            btnbuscarproduct.Location = new Point(255, 165);
            btnbuscarproduct.Name = "btnbuscarproduct";
            btnbuscarproduct.Size = new Size(132, 40);
            btnbuscarproduct.TabIndex = 15;
            btnbuscarproduct.Text = "Buscar";
            btnbuscarproduct.UseVisualStyleBackColor = false;
            btnbuscarproduct.Click += btnbuscarproduct_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(47, 53, 66);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(630, 37);
            label1.TabIndex = 14;
            label1.Text = "Buscar Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(47, 53, 66);
            txtpassword.Location = new Point(142, 110);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Ingrese código del producto";
            txtpassword.Size = new Size(335, 39);
            txtpassword.TabIndex = 13;
            // 
            // FrmAlerta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 249);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlerta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Acción";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnbuscarproduct;
        private Label label1;
        private TextBox txtpassword;
    }
}