namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 45);
            this.panel1.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Compra de Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 123;
            this.label7.Text = "Codigo del producto :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(179, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(460, 29);
            this.textBox3.TabIndex = 124;
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregarproducto.BackColor = System.Drawing.Color.White;
            this.btnagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnagregarproducto.Location = new System.Drawing.Point(655, 61);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(266, 35);
            this.btnagregarproducto.TabIndex = 125;
            this.btnagregarproducto.Text = "ENTER - Agregar";
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnbuscar.Location = new System.Drawing.Point(16, 112);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(150, 35);
            this.btnbuscar.TabIndex = 108;
            this.btnbuscar.Text = "F10 Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.White;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnborrar.Location = new System.Drawing.Point(179, 112);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(150, 35);
            this.btnborrar.TabIndex = 109;
            this.btnborrar.Text = "DEL Borrar Art.";
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(905, 195);
            this.dataGridView1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(485, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 47);
            this.button2.TabIndex = 111;
            this.button2.Text = "F12 Comprar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.textBox2.Location = new System.Drawing.Point(672, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 47);
            this.textBox2.TabIndex = 110;
            this.textBox2.Text = "$0.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 104;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 440);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}