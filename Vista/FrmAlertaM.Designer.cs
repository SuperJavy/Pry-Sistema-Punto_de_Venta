namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmAlertaM
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
            btnacceder = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnacceder
            // 
            btnacceder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnacceder.BackColor = Color.FromArgb(52, 152, 219);
            btnacceder.Cursor = Cursors.Hand;
            btnacceder.FlatAppearance.BorderSize = 0;
            btnacceder.FlatStyle = FlatStyle.Flat;
            btnacceder.Font = new Font("Microsoft Sans Serif", 12F);
            btnacceder.ForeColor = Color.White;
            btnacceder.Location = new Point(210, 132);
            btnacceder.Margin = new Padding(0);
            btnacceder.Name = "btnacceder";
            btnacceder.Size = new Size(301, 77);
            btnacceder.TabIndex = 74;
            btnacceder.Text = "\r\nBuscar\r\n";
            btnacceder.TextAlign = ContentAlignment.TopCenter;
            btnacceder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnacceder.UseVisualStyleBackColor = false;
            btnacceder.Click += btnacceder_Click_1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.ForeColor = Color.FromArgb(47, 53, 66);
            textBox3.Location = new Point(178, 78);
            textBox3.Margin = new Padding(5, 6, 5, 6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ingrese el código del producto ";
            textBox3.Size = new Size(344, 35);
            textBox3.TabIndex = 73;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.FromArgb(47, 53, 66);
            label1.Location = new Point(210, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 72;
            label1.Text = "Modificar Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAlertaM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 249);
            Controls.Add(btnacceder);
            Controls.Add(textBox3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlertaM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Producto para Modificar";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnacceder;
        private TextBox textBox3;
        private Label label1;
    }
}