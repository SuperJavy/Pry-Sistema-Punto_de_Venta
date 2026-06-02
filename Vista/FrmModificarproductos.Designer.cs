namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmModoficar
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
            label10 = new Label();
            panelHeader = new Panel();
            tableLayoutPanelPrincipal = new TableLayoutPanel(); // Contenedor responsivo principal
            panelDerecho = new Panel(); // Contenedor para alinear verticalmente Stock, Imagen y Botón
            groupBoxDatos = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            labelNombre = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            groupBoxStock = new GroupBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            groupBoxImagen = new GroupBox();
            pictureBoxProducto = new PictureBox();
            btnSeleccionarImagen = new Button();
            button1 = new Button();
            panelHeader.SuspendLayout();
            tableLayoutPanelPrincipal.SuspendLayout();
            panelDerecho.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBoxStock.SuspendLayout();
            groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(27, 29);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(249, 32);
            label10.TabIndex = 0;
            label10.Text = "Modificar Productos";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1445, 80);
            panelHeader.TabIndex = 100;
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.ColumnCount = 2;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F)); // 55% para Datos Generales
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F)); // 45% para Stock, Imagen y Botón
            tableLayoutPanelPrincipal.Controls.Add(groupBoxDatos, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelDerecho, 1, 0);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(0, 80);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.Padding = new Padding(20);
            tableLayoutPanelPrincipal.RowCount = 1;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Size = new Size(1445, 845);
            tableLayoutPanelPrincipal.TabIndex = 104;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(button1);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(795, 23);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(627, 799);
            panelDerecho.TabIndex = 105;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Controls.Add(textBox1);
            groupBoxDatos.Controls.Add(labelNombre);
            groupBoxDatos.Controls.Add(textBox3);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(textBox2);
            groupBoxDatos.Controls.Add(label5);
            groupBoxDatos.Controls.Add(checkBox1);
            groupBoxDatos.Controls.Add(checkBox2);
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(textBox4);
            groupBoxDatos.Controls.Add(label3);
            groupBoxDatos.Controls.Add(numericUpDown1);
            groupBoxDatos.Controls.Add(label6);
            groupBoxDatos.Controls.Add(textBox5);
            groupBoxDatos.Controls.Add(label7);
            groupBoxDatos.Controls.Add(textBox6);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxDatos.Location = new Point(23, 23);
            groupBoxDatos.Margin = new Padding(3, 3, 20, 3);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(749, 799);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " DATOS GENERALES DEL PRODUCTO ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(267, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 37);
            textBox1.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(25, 115);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(230, 30);
            labelNombre.TabIndex = 20;
            labelNombre.Text = "Nombre del Producto :";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(267, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 37);
            textBox3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 185);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(267, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 37);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 260);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 8;
            label5.Text = "Se vende :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(267, 258);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 34);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Por Unidad";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11F);
            checkBox2.ForeColor = Color.Black;
            checkBox2.Location = new Point(467, 258);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(122, 34);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "A Granel";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 335);
            label4.Name = "label4";
            label4.Size = new Size(146, 30);
            label4.TabIndex = 6;
            label4.Text = "Precio Costo :";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(267, 330);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(445, 37);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 415);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 4;
            label3.Text = "% Ganancia :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.Location = new Point(267, 411);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(167, 37);
            numericUpDown1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 204, 113);
            label6.Location = new Point(25, 495);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 13;
            label6.Text = "Precio Venta :";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = Color.FromArgb(245, 246, 250);
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox5.ForeColor = Color.FromArgb(46, 204, 113);
            textBox5.Location = new Point(267, 490);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(445, 37);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 575);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 11;
            label7.Text = "Categoría :";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(267, 570);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(445, 37);
            textBox6.TabIndex = 8;
            // 
            // groupBoxStock
            // 
            groupBoxStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStock.Controls.Add(label8);
            groupBoxStock.Controls.Add(textBox7);
            groupBoxStock.Controls.Add(label9);
            groupBoxStock.Controls.Add(textBox8);
            groupBoxStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxStock.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxStock.Location = new Point(3, 0);
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Size = new Size(621, 185);
            groupBoxStock.TabIndex = 102;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = " INVENTARIO / EXISTENCIAS ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 50);
            label8.Name = "label8";
            label8.Size = new Size(62, 30);
            label8.TabIndex = 15;
            label8.Text = "Hay :";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 11F);
            textBox7.Location = new Point(233, 45);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(355, 37);
            textBox7.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 115);
            label9.Name = "label9";
            label9.Size = new Size(98, 30);
            label9.TabIndex = 16;
            label9.Text = "Mínimo :";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Font = new Font("Segoe UI", 11F);
            textBox8.Location = new Point(233, 110);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(355, 37);
            textBox8.TabIndex = 18;
            // 
            // groupBoxImagen
            // 
            groupBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxImagen.Controls.Add(pictureBoxProducto);
            groupBoxImagen.Controls.Add(btnSeleccionarImagen);
            groupBoxImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxImagen.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxImagen.Location = new Point(3, 200);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Size = new Size(621, 469);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxProducto.BackColor = Color.FromArgb(245, 246, 250);
            pictureBoxProducto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProducto.Location = new Point(33, 40);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(555, 345);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducto.TabIndex = 0;
            pictureBoxProducto.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSeleccionarImagen.BackColor = Color.FromArgb(52, 152, 219);
            btnSeleccionarImagen.Cursor = Cursors.Hand;
            btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSeleccionarImagen.ForeColor = Color.White;
            btnSeleccionarImagen.Location = new Point(33, 400);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(555, 50);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Cambiar Imagen...";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(46, 204, 113); // Cambiado a verde para denotar éxito/actualización exitosa
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 685);
            button1.Name = "button1";
            button1.Size = new Size(621, 106);
            button1.TabIndex = 98;
            button1.Text = "Actualizar este Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmModoficar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 925);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmModoficar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModoficar";
            Load += FrmModoficar_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelPrincipal.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBoxStock.ResumeLayout(false);
            groupBoxStock.PerformLayout();
            groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal; // Agregado
        private System.Windows.Forms.Panel panelDerecho; // Agregado
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.Button btnSeleccionarImagen;
    }
}