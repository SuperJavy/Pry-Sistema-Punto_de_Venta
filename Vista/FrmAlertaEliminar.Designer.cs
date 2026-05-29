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
            this.btnacceder = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.SystemColors.Control;
            this.btnacceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.Image = global::Pry_Sistema_Punto_de_Venta.Properties.Resources.comprobado;
            this.btnacceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacceder.Location = new System.Drawing.Point(178, 179);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Padding = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.btnacceder.Size = new System.Drawing.Size(470, 36);
            this.btnacceder.TabIndex = 74;
            this.btnacceder.Text = "Acceder";
            this.btnacceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacceder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(178, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(470, 38);
            this.textBox3.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 72;
            this.label1.Text = "Eliminar Productos";
            // 
            // FrmAlertaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 258);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlertaEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAlertaEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}