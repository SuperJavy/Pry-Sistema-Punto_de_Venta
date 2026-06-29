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
            this.pnlCorteIzquierda = new System.Windows.Forms.Panel();
            this.lblTituloFisico = new System.Windows.Forms.Label();
            this.lblFondoTexto = new System.Windows.Forms.Label();
            this.lblFondoValor = new System.Windows.Forms.Label();
            this.lblVentasEfectivoTexto = new System.Windows.Forms.Label();
            this.lblVentasEfectivoValor = new System.Windows.Forms.Label();
            this.lblSalidasTexto = new System.Windows.Forms.Label();
            this.lblSalidasValor = new System.Windows.Forms.Label();
            this.lblTotalCajonTexto = new System.Windows.Forms.Label();
            this.lblTotalCajonValor = new System.Windows.Forms.Label();
            this.pnlCorteDerecha = new System.Windows.Forms.Panel();
            this.lblTituloDesglose = new System.Windows.Forms.Label();
            this.lblTicketsTexto = new System.Windows.Forms.Label();
            this.lblTicketsValor = new System.Windows.Forms.Label();
            this.lblArticulosTexto = new System.Windows.Forms.Label();
            this.lblArticulosValor = new System.Windows.Forms.Label();
            this.lblCanceladosTexto = new System.Windows.Forms.Label();
            this.lblCanceladosValor = new System.Windows.Forms.Label();
            this.lblTotalVentasTexto = new System.Windows.Forms.Label();
            this.lblTotalVentasValor = new System.Windows.Forms.Label();
            this.pnlCorteIzquierda.SuspendLayout();
            this.pnlCorteDerecha.SuspendLayout();
            this.SuspendLayout();

            // pnlCorteIzquierda
            this.pnlCorteIzquierda.BackColor = System.Drawing.Color.White;
            this.pnlCorteIzquierda.Controls.Add(this.lblTituloFisico);
            this.pnlCorteIzquierda.Controls.Add(this.lblFondoTexto);
            this.pnlCorteIzquierda.Controls.Add(this.lblFondoValor);
            this.pnlCorteIzquierda.Controls.Add(this.lblVentasEfectivoTexto);
            this.pnlCorteIzquierda.Controls.Add(this.lblVentasEfectivoValor);
            this.pnlCorteIzquierda.Controls.Add(this.lblSalidasTexto);
            this.pnlCorteIzquierda.Controls.Add(this.lblSalidasValor);
            this.pnlCorteIzquierda.Controls.Add(this.lblTotalCajonTexto);
            this.pnlCorteIzquierda.Controls.Add(this.lblTotalCajonValor);
            this.pnlCorteIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCorteIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnlCorteIzquierda.Name = "pnlCorteIzquierda";
            this.pnlCorteIzquierda.Size = new System.Drawing.Size(500, 500);

            // lblTituloFisico
            this.lblTituloFisico.AutoSize = true;
            this.lblTituloFisico.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloFisico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTituloFisico.Location = new System.Drawing.Point(40, 40);
            this.lblTituloFisico.Text = "💵 Dinero Físico en Caja";

            // Etiquetas de Valores - Izquierda
            this.lblFondoTexto.AutoSize = true; this.lblFondoTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblFondoTexto.Location = new System.Drawing.Point(80, 110); this.lblFondoTexto.Text = "Fondo de Caja Inicial";
            this.lblFondoValor.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblFondoValor.Location = new System.Drawing.Point(300, 110); this.lblFondoValor.Text = "$ 0.00"; this.lblFondoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVentasEfectivoTexto.AutoSize = true; this.lblVentasEfectivoTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblVentasEfectivoTexto.Location = new System.Drawing.Point(80, 150); this.lblVentasEfectivoTexto.Text = "Ventas en Efectivo";
            this.lblVentasEfectivoValor.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblVentasEfectivoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113))))); this.lblVentasEfectivoValor.Location = new System.Drawing.Point(300, 150); this.lblVentasEfectivoValor.Text = "+ $ 0.00"; this.lblVentasEfectivoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSalidasTexto.AutoSize = true; this.lblSalidasTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblSalidasTexto.Location = new System.Drawing.Point(80, 190); this.lblSalidasTexto.Text = "Salidas o Retiros";
            this.lblSalidasValor.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblSalidasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60))))); this.lblSalidasValor.Location = new System.Drawing.Point(300, 190); this.lblSalidasValor.Text = "- $ 0.00"; this.lblSalidasValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalCajonTexto.AutoSize = true; this.lblTotalCajonTexto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblTotalCajonTexto.Location = new System.Drawing.Point(80, 260); this.lblTotalCajonTexto.Text = "Total en Cajón";
            this.lblTotalCajonValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold); this.lblTotalCajonValor.Location = new System.Drawing.Point(250, 255); this.lblTotalCajonValor.Text = "$ 0.00"; this.lblTotalCajonValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // pnlCorteDerecha
            this.pnlCorteDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlCorteDerecha.Controls.Add(this.lblTituloDesglose);
            this.pnlCorteDerecha.Controls.Add(this.lblTicketsTexto);
            this.pnlCorteDerecha.Controls.Add(this.lblTicketsValor);
            this.pnlCorteDerecha.Controls.Add(this.lblArticulosTexto);
            this.pnlCorteDerecha.Controls.Add(this.lblArticulosValor);
            this.pnlCorteDerecha.Controls.Add(this.lblCanceladosTexto);
            this.pnlCorteDerecha.Controls.Add(this.lblCanceladosValor);
            this.pnlCorteDerecha.Controls.Add(this.lblTotalVentasTexto);
            this.pnlCorteDerecha.Controls.Add(this.lblTotalVentasValor);
            this.pnlCorteDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorteDerecha.Location = new System.Drawing.Point(500, 0);
            this.pnlCorteDerecha.Name = "pnlCorteDerecha";

            // lblTituloDesglose
            this.lblTituloDesglose.AutoSize = true;
            this.lblTituloDesglose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloDesglose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloDesglose.Location = new System.Drawing.Point(40, 40);
            this.lblTituloDesglose.Text = "📈 Resumen de Operaciones";

            // Etiquetas de Valores - Derecha
            this.lblTicketsTexto.AutoSize = true; this.lblTicketsTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblTicketsTexto.Location = new System.Drawing.Point(80, 110); this.lblTicketsTexto.Text = "Ventas Realizadas (Tickets)";
            this.lblTicketsValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTicketsValor.Location = new System.Drawing.Point(350, 110); this.lblTicketsValor.Text = "0"; this.lblTicketsValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArticulosTexto.AutoSize = true; this.lblArticulosTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblArticulosTexto.Location = new System.Drawing.Point(80, 150); this.lblArticulosTexto.Text = "Artículos Vendidos";
            this.lblArticulosValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblArticulosValor.Location = new System.Drawing.Point(350, 150); this.lblArticulosValor.Text = "0"; this.lblArticulosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCanceladosTexto.AutoSize = true; this.lblCanceladosTexto.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblCanceladosTexto.Location = new System.Drawing.Point(80, 190); this.lblCanceladosTexto.Text = "Artículos Cancelados";
            this.lblCanceladosValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblCanceladosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60))))); this.lblCanceladosValor.Location = new System.Drawing.Point(350, 190); this.lblCanceladosValor.Text = "0"; this.lblCanceladosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalVentasTexto.AutoSize = true; this.lblTotalVentasTexto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblTotalVentasTexto.Location = new System.Drawing.Point(80, 260); this.lblTotalVentasTexto.Text = "Total de Ventas";
            this.lblTotalVentasValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold); this.lblTotalVentasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185))))); this.lblTotalVentasValor.Location = new System.Drawing.Point(300, 255); this.lblTotalVentasValor.Text = "$ 0.00"; this.lblTotalVentasValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // FrmCorteCaja
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 500);
            this.Controls.Add(this.pnlCorteDerecha);
            this.Controls.Add(this.pnlCorteIzquierda);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCorteCaja";
            this.pnlCorteIzquierda.ResumeLayout(false);
            this.pnlCorteIzquierda.PerformLayout();
            this.pnlCorteDerecha.ResumeLayout(false);
            this.pnlCorteDerecha.PerformLayout();
            this.ResumeLayout(false);
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
    }
}