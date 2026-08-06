namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmConfiguracionImpresora
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
            lblInstrucciones = new Label();
            cmbImpresoras = new ComboBox();
            chkEsTermica = new CheckBox();
            btnGuardarImpresora = new Button();
            btnCancelar = new Button();
            lblAvisoLocal = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(47, 53, 66);
            lblTitulo.Location = new Point(50, 46);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(452, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Configuración de Impresora";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstrucciones.Location = new Point(54, 150);
            lblInstrucciones.Margin = new Padding(6, 0, 6, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(485, 31);
            lblInstrucciones.TabIndex = 1;
            lblInstrucciones.Text = "Seleccione la impresora conectada a esta caja:";
            // 
            // cmbImpresoras
            // 
            cmbImpresoras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbImpresoras.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbImpresoras.FormattingEnabled = true;
            cmbImpresoras.Location = new Point(60, 208);
            cmbImpresoras.Margin = new Padding(6, 7, 6, 7);
            cmbImpresoras.Name = "cmbImpresoras";
            cmbImpresoras.Size = new Size(736, 39);
            cmbImpresoras.TabIndex = 2;
            // 
            // chkEsTermica
            // 
            chkEsTermica.AutoSize = true;
            chkEsTermica.Cursor = Cursors.Hand;
            chkEsTermica.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEsTermica.Location = new Point(60, 312);
            chkEsTermica.Margin = new Padding(6, 7, 6, 7);
            chkEsTermica.Name = "chkEsTermica";
            chkEsTermica.Size = new Size(582, 36);
            chkEsTermica.TabIndex = 3;
            chkEsTermica.Text = "Es impresora de tickets (Rollo térmico para recibos)";
            chkEsTermica.UseVisualStyleBackColor = true;
            // 
            // btnGuardarImpresora
            // 
            btnGuardarImpresora.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardarImpresora.Cursor = Cursors.Hand;
            btnGuardarImpresora.FlatAppearance.BorderSize = 0;
            btnGuardarImpresora.FlatStyle = FlatStyle.Flat;
            btnGuardarImpresora.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarImpresora.ForeColor = Color.White;
            btnGuardarImpresora.Location = new Point(480, 485);
            btnGuardarImpresora.Margin = new Padding(6, 7, 6, 7);
            btnGuardarImpresora.Name = "btnGuardarImpresora";
            btnGuardarImpresora.Size = new Size(320, 81);
            btnGuardarImpresora.TabIndex = 4;
            btnGuardarImpresora.Text = "Guardar";
            btnGuardarImpresora.UseVisualStyleBackColor = false;
            btnGuardarImpresora.Click += btnGuardarImpresora_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(47, 53, 66);
            btnCancelar.Location = new Point(240, 485);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 81);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAvisoLocal
            // 
            lblAvisoLocal.AutoSize = true;
            lblAvisoLocal.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvisoLocal.ForeColor = SystemColors.ControlDarkDark;
            lblAvisoLocal.Location = new Point(54, 392);
            lblAvisoLocal.Margin = new Padding(6, 0, 6, 0);
            lblAvisoLocal.Name = "lblAvisoLocal";
            lblAvisoLocal.Size = new Size(622, 28);
            lblAvisoLocal.TabIndex = 6;
            lblAvisoLocal.Text = "* Esta configuración solo afecta a los tickets que se cobren en esta PC.";
            // 
            // FrmConfiguracionImpresora
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 625);
            Controls.Add(lblAvisoLocal);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarImpresora);
            Controls.Add(chkEsTermica);
            Controls.Add(cmbImpresoras);
            Controls.Add(lblInstrucciones);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfiguracionImpresora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dispositivos e Impresoras";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.ComboBox cmbImpresoras;
        private System.Windows.Forms.CheckBox chkEsTermica;
        private System.Windows.Forms.Button btnGuardarImpresora;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAvisoLocal;
    }
}