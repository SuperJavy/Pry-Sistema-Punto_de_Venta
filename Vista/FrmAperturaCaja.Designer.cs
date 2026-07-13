namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmAperturaCaja
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
            lblTitulo = new Label();
            lblInstruccion = new Label();
            txtFondoCaja = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(142, 67);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(397, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Apertura de Turno - Caja";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruccion.Location = new Point(145, 163);
            lblInstruccion.Margin = new Padding(5, 0, 5, 0);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(339, 25);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Ingrese el fondo de efectivo inicial ($):";
            // 
            // txtFondoCaja
            // 
            txtFondoCaja.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFondoCaja.Location = new Point(150, 221);
            txtFondoCaja.Margin = new Padding(5, 6, 5, 6);
            txtFondoCaja.Name = "txtFondoCaja";
            txtFondoCaja.Size = new Size(367, 39);
            txtFondoCaja.TabIndex = 2;
            txtFondoCaja.Text = "0.00";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SeaGreen;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(150, 323);
            btnAceptar.Margin = new Padding(5, 6, 5, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(370, 77);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Abrir Caja (Aceptar)";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmAperturaCaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 490);
            Controls.Add(btnAceptar);
            Controls.Add(txtFondoCaja);
            Controls.Add(lblInstruccion);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAperturaCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Turno";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtFondoCaja;
        private System.Windows.Forms.Button btnAceptar;
    }
}