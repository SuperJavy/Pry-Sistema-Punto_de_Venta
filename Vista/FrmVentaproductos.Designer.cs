namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmVentaproductos
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblTotalTexto = new Label();
            lblTotalMonto = new Label();
            lblPagoCon = new Label();
            lblCambioTexto = new Label();
            txtPagoCon = new TextBox();
            lblCambioMonto = new Label();
            pnlAcciones = new Panel();
            btnCancelar = new Button();
            btnCobrarSolo = new Button();
            btnCobrarImprimir = new Button();
            pnlHeader.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ActiveCaption;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(850, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 13);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Procesar Cobro";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(127, 140, 141);
            lblTotalTexto.Location = new Point(50, 87);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(210, 38);
            lblTotalTexto.TabIndex = 1;
            lblTotalTexto.Text = "Total a Cobrar :";
            // 
            // lblTotalMonto
            // 
            lblTotalMonto.AutoSize = true;
            lblTotalMonto.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalMonto.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalMonto.Location = new Point(35, 132);
            lblTotalMonto.Margin = new Padding(4, 0, 4, 0);
            lblTotalMonto.Name = "lblTotalMonto";
            lblTotalMonto.Size = new Size(224, 96);
            lblTotalMonto.TabIndex = 2;
            lblTotalMonto.Text = "$0.00";
            // 
            // lblPagoCon
            // 
            lblPagoCon.AutoSize = true;
            lblPagoCon.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPagoCon.ForeColor = Color.FromArgb(44, 62, 80);
            lblPagoCon.Location = new Point(20, 258);
            lblPagoCon.Margin = new Padding(4, 0, 4, 0);
            lblPagoCon.Name = "lblPagoCon";
            lblPagoCon.Size = new Size(143, 36);
            lblPagoCon.TabIndex = 3;
            lblPagoCon.Text = "Paga con : ";
            // 
            // lblCambioTexto
            // 
            lblCambioTexto.AutoSize = true;
            lblCambioTexto.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblCambioTexto.ForeColor = Color.FromArgb(44, 62, 80);
            lblCambioTexto.Location = new Point(20, 331);
            lblCambioTexto.Margin = new Padding(4, 0, 4, 0);
            lblCambioTexto.Name = "lblCambioTexto";
            lblCambioTexto.Size = new Size(152, 36);
            lblCambioTexto.TabIndex = 5;
            lblCambioTexto.Text = "Su cambio :";
            // 
            // txtPagoCon
            // 
            txtPagoCon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtPagoCon.Location = new Point(182, 258);
            txtPagoCon.Margin = new Padding(4, 5, 4, 5);
            txtPagoCon.Name = "txtPagoCon";
            txtPagoCon.Size = new Size(260, 50);
            txtPagoCon.TabIndex = 4;
            txtPagoCon.Text = "0.00";
            txtPagoCon.TextAlign = HorizontalAlignment.Right;
            txtPagoCon.TextChanged += txtPagoCon_TextChanged;
            // 
            // lblCambioMonto
            // 
            lblCambioMonto.AutoSize = true;
            lblCambioMonto.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCambioMonto.ForeColor = Color.FromArgb(39, 174, 96);
            lblCambioMonto.Location = new Point(200, 320);
            lblCambioMonto.Margin = new Padding(4, 0, 4, 0);
            lblCambioMonto.Name = "lblCambioMonto";
            lblCambioMonto.Size = new Size(153, 65);
            lblCambioMonto.TabIndex = 6;
            lblCambioMonto.Text = "$0.00";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.FromArgb(248, 249, 250);
            pnlAcciones.Controls.Add(btnCancelar);
            pnlAcciones.Controls.Add(btnCobrarSolo);
            pnlAcciones.Controls.Add(btnCobrarImprimir);
            pnlAcciones.Dock = DockStyle.Right;
            pnlAcciones.Location = new Point(480, 65);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(370, 485);
            pnlAcciones.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(30, 350);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(310, 65);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "ESC - Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCobrarSolo
            // 
            btnCobrarSolo.BackColor = Color.FromArgb(52, 152, 219);
            btnCobrarSolo.Cursor = Cursors.Hand;
            btnCobrarSolo.FlatAppearance.BorderSize = 0;
            btnCobrarSolo.FlatStyle = FlatStyle.Flat;
            btnCobrarSolo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCobrarSolo.ForeColor = Color.White;
            btnCobrarSolo.Location = new Point(30, 145);
            btnCobrarSolo.Margin = new Padding(4, 5, 4, 5);
            btnCobrarSolo.Name = "btnCobrarSolo";
            btnCobrarSolo.Size = new Size(310, 65);
            btnCobrarSolo.TabIndex = 1;
            btnCobrarSolo.Text = "F2 - Cobrar S/ Imprimir";
            btnCobrarSolo.UseVisualStyleBackColor = false;
            btnCobrarSolo.Click += btnCobrarSolo_Click;
            // 
            // btnCobrarImprimir
            // 
            btnCobrarImprimir.BackColor = Color.FromArgb(46, 204, 113);
            btnCobrarImprimir.Cursor = Cursors.Hand;
            btnCobrarImprimir.FlatAppearance.BorderSize = 0;
            btnCobrarImprimir.FlatStyle = FlatStyle.Flat;
            btnCobrarImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCobrarImprimir.ForeColor = Color.White;
            btnCobrarImprimir.Location = new Point(30, 45);
            btnCobrarImprimir.Margin = new Padding(4, 5, 4, 5);
            btnCobrarImprimir.Name = "btnCobrarImprimir";
            btnCobrarImprimir.Size = new Size(310, 65);
            btnCobrarImprimir.TabIndex = 0;
            btnCobrarImprimir.Text = "F1 - Cobrar e Imprimir";
            btnCobrarImprimir.UseVisualStyleBackColor = false;
            btnCobrarImprimir.Click += btnCobrarImprimir_Click;
            // 
            // FrmVentaproductos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 550);
            Controls.Add(pnlAcciones);
            Controls.Add(lblCambioMonto);
            Controls.Add(lblCambioTexto);
            Controls.Add(txtPagoCon);
            Controls.Add(lblPagoCon);
            Controls.Add(lblTotalMonto);
            Controls.Add(lblTotalTexto);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVentaproductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta de Producto - Cobrar";
            KeyDown += FrmVentaproductos_KeyDown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.Label lblPagoCon;
        private System.Windows.Forms.TextBox txtPagoCon;
        private System.Windows.Forms.Label lblCambioTexto;
        private System.Windows.Forms.Label lblCambioMonto;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCobrarSolo;
        private System.Windows.Forms.Button btnCobrarImprimir;
    }
}