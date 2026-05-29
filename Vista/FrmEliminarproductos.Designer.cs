namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmEliminarproductos
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
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();

            // 1. El contenedor principal de los datos (Para que crezca en todas direcciones)
            this.groupBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            // 2. Las cajas de texto dentro del contenedor (Para que se estiren a lo ancho)
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            // 3. El botón de eliminar (Para que se quede siempre abajo a la derecha)
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(867, 50);
            this.panelHeader.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(16, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Eliminar Productos";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.textBox1);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.textBox2);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.checkBox1);
            this.groupBoxDatos.Controls.Add(this.checkBox2);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.textBox4);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.numericUpDown1);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.textBox5);
            this.groupBoxDatos.Controls.Add(this.label7);
            this.groupBoxDatos.Controls.Add(this.textBox6);
            this.groupBoxDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.groupBoxDatos.Location = new System.Drawing.Point(21, 74);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(460, 380);
            this.groupBoxDatos.TabIndex = 101;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = " DETALLES DEL PRODUCTO A REMOVER ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Código de barras :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox1.Location = new System.Drawing.Point(160, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 27);
            this.textBox1.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Descripción :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2.Location = new System.Drawing.Point(160, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 27);
            this.textBox2.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Se vende :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(160, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 24);
            this.checkBox1.TabIndex = 106;
            this.checkBox1.Text = "Por Unidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(280, 126);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 24);
            this.checkBox2.TabIndex = 107;
            this.checkBox2.Text = "A Granel";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Precio Costo :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox4.Location = new System.Drawing.Point(160, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 27);
            this.textBox4.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Ganancia :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(160, 220);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown1.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(15, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "Precio Venta :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.textBox5.Location = new System.Drawing.Point(160, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 27);
            this.textBox5.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "Categoría :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox6.Location = new System.Drawing.Point(160, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(275, 27);
            this.textBox6.TabIndex = 109;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 55);
            this.button1.TabIndex = 97;
            this.button1.Text = "Eliminar este Producto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmEliminarproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarproductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEliminarproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxDatos;
    }
}
