namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmCorteCaja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCorteIzquierda = new Panel();
            lblTituloFisico = new Label();
            lblFondoTexto = new Label();
            lblFondoValor = new Label();
            lblVentasEfectivoTexto = new Label();
            lblVentasEfectivoValor = new Label();
            lblSalidasTexto = new Label();
            lblSalidasValor = new Label();
            lblTotalCajonTexto = new Label();
            lblTotalCajonValor = new Label();
            pnlCorteDerecha = new Panel();
            lblTituloDesglose = new Label();
            lblTicketsTexto = new Label();
            lblTicketsValor = new Label();
            lblArticulosTexto = new Label();
            lblArticulosValor = new Label();
            lblCanceladosTexto = new Label();
            lblCanceladosValor = new Label();
            lblTotalVentasTexto = new Label();
            lblTotalVentasValor = new Label();
            pnlInferior = new Panel();
            btnRealizarCorte = new Button();
            pnlCorteIzquierda.SuspendLayout();
            pnlCorteDerecha.SuspendLayout();
            pnlInferior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCorteIzquierda
            // 
            pnlCorteIzquierda.BackColor = Color.White;
            pnlCorteIzquierda.Controls.Add(lblTituloFisico);
            pnlCorteIzquierda.Controls.Add(lblFondoTexto);
            pnlCorteIzquierda.Controls.Add(lblFondoValor);
            pnlCorteIzquierda.Controls.Add(lblVentasEfectivoTexto);
            pnlCorteIzquierda.Controls.Add(lblVentasEfectivoValor);
            pnlCorteIzquierda.Controls.Add(lblSalidasTexto);
            pnlCorteIzquierda.Controls.Add(lblSalidasValor);
            pnlCorteIzquierda.Controls.Add(lblTotalCajonTexto);
            pnlCorteIzquierda.Controls.Add(lblTotalCajonValor);
            pnlCorteIzquierda.Dock = DockStyle.Left;
            pnlCorteIzquierda.Location = new Point(0, 0);
            pnlCorteIzquierda.Name = "pnlCorteIzquierda";
            pnlCorteIzquierda.Size = new Size(500, 500);
            pnlCorteIzquierda.TabIndex = 1;
            // 
            // lblTituloFisico
            // 
            lblTituloFisico.AutoSize = true;
            lblTituloFisico.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloFisico.ForeColor = Color.FromArgb(41, 128, 185);
            lblTituloFisico.Location = new Point(40, 40);
            lblTituloFisico.Name = "lblTituloFisico";
            lblTituloFisico.Size = new Size(386, 45);
            lblTituloFisico.TabIndex = 0;
            lblTituloFisico.Text = "💵 Dinero Físico en Caja";
            // 
            // lblFondoTexto
            // 
            lblFondoTexto.AutoSize = true;
            lblFondoTexto.Font = new Font("Segoe UI", 12F);
            lblFondoTexto.Location = new Point(80, 110);
            lblFondoTexto.Name = "lblFondoTexto";
            lblFondoTexto.Size = new Size(236, 32);
            lblFondoTexto.TabIndex = 1;
            lblFondoTexto.Text = "Fondo de Caja Inicial";
            // 
            // lblFondoValor
            // 
            lblFondoValor.Font = new Font("Segoe UI", 12F);
            lblFondoValor.Location = new Point(326, 110);
            lblFondoValor.Name = "lblFondoValor";
            lblFondoValor.Size = new Size(120, 32);
            lblFondoValor.TabIndex = 2;
            lblFondoValor.Text = "$ 0.00";
            lblFondoValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasEfectivoTexto
            // 
            lblVentasEfectivoTexto.AutoSize = true;
            lblVentasEfectivoTexto.Font = new Font("Segoe UI", 12F);
            lblVentasEfectivoTexto.Location = new Point(80, 150);
            lblVentasEfectivoTexto.Name = "lblVentasEfectivoTexto";
            lblVentasEfectivoTexto.Size = new Size(209, 32);
            lblVentasEfectivoTexto.TabIndex = 3;
            lblVentasEfectivoTexto.Text = "Ventas en Efectivo";
            // 
            // lblVentasEfectivoValor
            // 
            lblVentasEfectivoValor.Font = new Font("Segoe UI", 12F);
            lblVentasEfectivoValor.ForeColor = Color.FromArgb(46, 204, 113);
            lblVentasEfectivoValor.Location = new Point(326, 150);
            lblVentasEfectivoValor.Name = "lblVentasEfectivoValor";
            lblVentasEfectivoValor.Size = new Size(120, 32);
            lblVentasEfectivoValor.TabIndex = 4;
            lblVentasEfectivoValor.Text = "+ $ 0.00";
            lblVentasEfectivoValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSalidasTexto
            // 
            lblSalidasTexto.AutoSize = true;
            lblSalidasTexto.Font = new Font("Segoe UI", 12F);
            lblSalidasTexto.Location = new Point(80, 190);
            lblSalidasTexto.Name = "lblSalidasTexto";
            lblSalidasTexto.Size = new Size(187, 32);
            lblSalidasTexto.TabIndex = 5;
            lblSalidasTexto.Text = "Salidas o Retiros";
            // 
            // lblSalidasValor
            // 
            lblSalidasValor.Font = new Font("Segoe UI", 12F);
            lblSalidasValor.ForeColor = Color.FromArgb(231, 76, 60);
            lblSalidasValor.Location = new Point(326, 190);
            lblSalidasValor.Name = "lblSalidasValor";
            lblSalidasValor.Size = new Size(120, 32);
            lblSalidasValor.TabIndex = 6;
            lblSalidasValor.Text = "- $ 0.00";
            lblSalidasValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalCajonTexto
            // 
            lblTotalCajonTexto.AutoSize = true;
            lblTotalCajonTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalCajonTexto.Location = new Point(80, 260);
            lblTotalCajonTexto.Name = "lblTotalCajonTexto";
            lblTotalCajonTexto.Size = new Size(233, 45);
            lblTotalCajonTexto.TabIndex = 7;
            lblTotalCajonTexto.Text = "Total en Cajón";
            // 
            // lblTotalCajonValor
            // 
            lblTotalCajonValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCajonValor.Location = new Point(296, 250);
            lblTotalCajonValor.Name = "lblTotalCajonValor";
            lblTotalCajonValor.Size = new Size(150, 50);
            lblTotalCajonValor.TabIndex = 8;
            lblTotalCajonValor.Text = "$ 0.00";
            lblTotalCajonValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlCorteDerecha
            // 
            pnlCorteDerecha.BackColor = Color.FromArgb(245, 246, 250);
            pnlCorteDerecha.Controls.Add(lblTituloDesglose);
            pnlCorteDerecha.Controls.Add(lblTicketsTexto);
            pnlCorteDerecha.Controls.Add(lblTicketsValor);
            pnlCorteDerecha.Controls.Add(lblArticulosTexto);
            pnlCorteDerecha.Controls.Add(lblArticulosValor);
            pnlCorteDerecha.Controls.Add(lblCanceladosTexto);
            pnlCorteDerecha.Controls.Add(lblCanceladosValor);
            pnlCorteDerecha.Controls.Add(lblTotalVentasTexto);
            pnlCorteDerecha.Controls.Add(lblTotalVentasValor);
            pnlCorteDerecha.Dock = DockStyle.Fill;
            pnlCorteDerecha.Location = new Point(500, 0);
            pnlCorteDerecha.Name = "pnlCorteDerecha";
            pnlCorteDerecha.Size = new Size(650, 500);
            pnlCorteDerecha.TabIndex = 0;
            // 
            // lblTituloDesglose
            // 
            lblTituloDesglose.AutoSize = true;
            lblTituloDesglose.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloDesglose.ForeColor = Color.FromArgb(44, 62, 80);
            lblTituloDesglose.Location = new Point(40, 40);
            lblTituloDesglose.Name = "lblTituloDesglose";
            lblTituloDesglose.Size = new Size(449, 45);
            lblTituloDesglose.TabIndex = 0;
            lblTituloDesglose.Text = "📈 Resumen de Operaciones";
            // 
            // lblTicketsTexto
            // 
            lblTicketsTexto.AutoSize = true;
            lblTicketsTexto.Font = new Font("Segoe UI", 12F);
            lblTicketsTexto.Location = new Point(80, 110);
            lblTicketsTexto.Name = "lblTicketsTexto";
            lblTicketsTexto.Size = new Size(294, 32);
            lblTicketsTexto.TabIndex = 1;
            lblTicketsTexto.Text = "Ventas Realizadas (Tickets)";
            // 
            // lblTicketsValor
            // 
            lblTicketsValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTicketsValor.Location = new Point(350, 110);
            lblTicketsValor.Name = "lblTicketsValor";
            lblTicketsValor.Size = new Size(100, 32);
            lblTicketsValor.TabIndex = 2;
            lblTicketsValor.Text = "0";
            lblTicketsValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblArticulosTexto
            // 
            lblArticulosTexto.AutoSize = true;
            lblArticulosTexto.Font = new Font("Segoe UI", 12F);
            lblArticulosTexto.Location = new Point(80, 150);
            lblArticulosTexto.Name = "lblArticulosTexto";
            lblArticulosTexto.Size = new Size(211, 32);
            lblArticulosTexto.TabIndex = 3;
            lblArticulosTexto.Text = "Artículos Vendidos";
            // 
            // lblArticulosValor
            // 
            lblArticulosValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblArticulosValor.Location = new Point(350, 150);
            lblArticulosValor.Name = "lblArticulosValor";
            lblArticulosValor.Size = new Size(100, 32);
            lblArticulosValor.TabIndex = 4;
            lblArticulosValor.Text = "0";
            lblArticulosValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCanceladosTexto
            // 
            lblCanceladosTexto.AutoSize = true;
            lblCanceladosTexto.Font = new Font("Segoe UI", 12F);
            lblCanceladosTexto.Location = new Point(80, 190);
            lblCanceladosTexto.Name = "lblCanceladosTexto";
            lblCanceladosTexto.Size = new Size(234, 32);
            lblCanceladosTexto.TabIndex = 5;
            lblCanceladosTexto.Text = "Artículos Cancelados";
            // 
            // lblCanceladosValor
            // 
            lblCanceladosValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCanceladosValor.ForeColor = Color.FromArgb(231, 76, 60);
            lblCanceladosValor.Location = new Point(350, 190);
            lblCanceladosValor.Name = "lblCanceladosValor";
            lblCanceladosValor.Size = new Size(100, 32);
            lblCanceladosValor.TabIndex = 6;
            lblCanceladosValor.Text = "0";
            lblCanceladosValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalVentasTexto
            // 
            lblTotalVentasTexto.AutoSize = true;
            lblTotalVentasTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalVentasTexto.Location = new Point(80, 260);
            lblTotalVentasTexto.Name = "lblTotalVentasTexto";
            lblTotalVentasTexto.Size = new Size(247, 45);
            lblTotalVentasTexto.TabIndex = 7;
            lblTotalVentasTexto.Text = "Total de Ventas";
            // 
            // lblTotalVentasValor
            // 
            lblTotalVentasValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalVentasValor.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalVentasValor.Location = new Point(275, 250);
            lblTotalVentasValor.Name = "lblTotalVentasValor";
            lblTotalVentasValor.Size = new Size(175, 50);
            lblTotalVentasValor.TabIndex = 8;
            lblTotalVentasValor.Text = "$ 0.00";
            lblTotalVentasValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.WhiteSmoke;
            pnlInferior.Controls.Add(btnRealizarCorte);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 500);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1150, 80);
            pnlInferior.TabIndex = 2;
            // 
            // btnRealizarCorte
            // 
            btnRealizarCorte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRealizarCorte.BackColor = Color.SeaGreen;
            btnRealizarCorte.Cursor = Cursors.Hand;
            btnRealizarCorte.FlatAppearance.BorderSize = 0;
            btnRealizarCorte.FlatStyle = FlatStyle.Flat;
            btnRealizarCorte.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRealizarCorte.ForeColor = Color.White;
            btnRealizarCorte.Location = new Point(762, 15);
            btnRealizarCorte.Name = "btnRealizarCorte";
            btnRealizarCorte.Size = new Size(358, 50);
            btnRealizarCorte.TabIndex = 0;
            btnRealizarCorte.Text = "🔒 Realizar Corte y Cerrar";
            btnRealizarCorte.UseVisualStyleBackColor = false;
            btnRealizarCorte.Click += btnRealizarCorte_Click;
            // 
            // FrmCorteCaja
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1150, 580);
            Controls.Add(pnlCorteDerecha);
            Controls.Add(pnlCorteIzquierda);
            Controls.Add(pnlInferior);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCorteCaja";
            pnlCorteIzquierda.ResumeLayout(false);
            pnlCorteIzquierda.PerformLayout();
            pnlCorteDerecha.ResumeLayout(false);
            pnlCorteDerecha.PerformLayout();
            pnlInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCorteIzquierda;
        private System.Windows.Forms.Label lblTituloFisico;
        private System.Windows.Forms.Label lblFondoTexto;
        private System.Windows.Forms.Label lblFondoValor;
        private System.Windows.Forms.Label lblVentasEfectivoTexto;
        private System.Windows.Forms.Label lblVentasEfectivoValor;
        private System.Windows.Forms.Label lblSalidasTexto;
        private System.Windows.Forms.Label lblSalidasValor;
        private System.Windows.Forms.Label lblTotalCajonTexto;
        private System.Windows.Forms.Label lblTotalCajonValor;
        private System.Windows.Forms.Panel pnlCorteDerecha;
        private System.Windows.Forms.Label lblTituloDesglose;
        private System.Windows.Forms.Label lblTicketsTexto;
        private System.Windows.Forms.Label lblTicketsValor;
        private System.Windows.Forms.Label lblArticulosTexto;
        private System.Windows.Forms.Label lblArticulosValor;
        private System.Windows.Forms.Label lblCanceladosTexto;
        private System.Windows.Forms.Label lblCanceladosValor;
        private System.Windows.Forms.Label lblTotalVentasTexto;
        private System.Windows.Forms.Label lblTotalVentasValor;

        // Nuevos componentes añadidos
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnRealizarCorte;
    }
}