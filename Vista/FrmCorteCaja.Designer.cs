namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmCorteCaja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            Cajero = new Label();
            cmbCajerosAbiertos = new ComboBox();
            lblTituloPrincipal = new Label();
            lblSubtitulo = new Label();
            btnRealizarCorte = new Button();
            btnVerHistorial = new Button();
            pnlInferior = new Panel();
            btnImprimirCorte = new Button();
            pnlConteo = new Panel();
            lblTituloConteo = new Label();
            lblInstruccionConteo = new Label();
            txtTotalFisico = new TextBox();
            txtObservaciones = new TextBox();
            tlpSuperior = new TableLayoutPanel();
            pnlResumen = new Panel();
            lblResumenDiferenciaTexto = new Label();
            lblTituloResumen = new Label();
            lblResumenEsperadoTexto = new Label();
            lblResumenEsperado = new Label();
            lblTotalContadoResumenTexto = new Label();
            lblTotalContadoResumen = new Label();
            lblResumenDiferencia = new Label();
            pnlAlertaDiferencia = new Panel();
            lblAlertaEstado = new Label();
            pnlInfoSistema = new Panel();
            lblTituloInfo = new Label();
            lblFondoTexto = new Label();
            lblFondoValor = new Label();
            lblVentasEfectivoTexto = new Label();
            lblVentasEfectivoValor = new Label();
            label1 = new Label();
            lblTicketsValor = new Label();
            lblVentasTarjetaTexto = new Label();
            lblArticulosValor = new Label();
            lblTransferenciasTexto = new Label();
            lblCanceladosValor = new Label();
            lblTotalEsperadoInfoTexto = new Label();
            lblTotalEsperadoInfo = new Label();
            lblTotalCajonValor = new Label();
            tlpContenedor = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlInferior.SuspendLayout();
            pnlConteo.SuspendLayout();
            tlpSuperior.SuspendLayout();
            pnlResumen.SuspendLayout();
            pnlAlertaDiferencia.SuspendLayout();
            pnlInfoSistema.SuspendLayout();
            tlpContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(Cajero);
            pnlHeader.Controls.Add(cmbCajerosAbiertos);
            pnlHeader.Controls.Add(lblTituloPrincipal);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1377, 108);
            pnlHeader.TabIndex = 1;
            // 
            // Cajero
            // 
            Cajero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cajero.AutoSize = true;
            Cajero.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cajero.Location = new Point(1047, 42);
            Cajero.Name = "Cajero";
            Cajero.Size = new Size(87, 32);
            Cajero.TabIndex = 3;
            Cajero.Text = "Cajero";
            // 
            // cmbCajerosAbiertos
            // 
            cmbCajerosAbiertos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCajerosAbiertos.FormattingEnabled = true;
            cmbCajerosAbiertos.Location = new Point(1145, 39);
            cmbCajerosAbiertos.Name = "cmbCajerosAbiertos";
            cmbCajerosAbiertos.Size = new Size(212, 39);
            cmbCajerosAbiertos.TabIndex = 2;
            cmbCajerosAbiertos.SelectedIndexChanged += cmbCajerosAbiertos_SelectedIndexChanged_1;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTituloPrincipal.Location = new Point(20, 9);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(255, 51);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Corte de caja";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.FromArgb(127, 140, 141);
            lblSubtitulo.Location = new Point(22, 50);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(570, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Módulo de cierre de turno y declaración de efectivo";
            // 
            // btnRealizarCorte
            // 
            btnRealizarCorte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRealizarCorte.BackColor = Color.White;
            btnRealizarCorte.ForeColor = Color.FromArgb(41, 128, 185);
            btnRealizarCorte.Location = new Point(1078, 13);
            btnRealizarCorte.Name = "btnRealizarCorte";
            btnRealizarCorte.Size = new Size(279, 40);
            btnRealizarCorte.TabIndex = 1;
            btnRealizarCorte.Text = "Guardar y cerrar turno";
            btnRealizarCorte.UseVisualStyleBackColor = false;
            btnRealizarCorte.Click += btnRealizarCorte_Click;
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerHistorial.BackColor = Color.FromArgb(52, 73, 94);
            btnVerHistorial.Cursor = Cursors.Hand;
            btnVerHistorial.FlatAppearance.BorderSize = 0;
            btnVerHistorial.FlatStyle = FlatStyle.Flat;
            btnVerHistorial.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVerHistorial.ForeColor = Color.White;
            btnVerHistorial.Location = new Point(20, 14);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(292, 40);
            btnVerHistorial.TabIndex = 0;
            btnVerHistorial.Text = "📋 Ver Historial";
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.WhiteSmoke;
            pnlInferior.Controls.Add(btnImprimirCorte);
            pnlInferior.Controls.Add(btnVerHistorial);
            pnlInferior.Controls.Add(btnRealizarCorte);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 754);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1377, 74);
            pnlInferior.TabIndex = 2;
            // 
            // btnImprimirCorte
            // 
            btnImprimirCorte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimirCorte.BackColor = Color.White;
            btnImprimirCorte.ForeColor = Color.FromArgb(41, 128, 185);
            btnImprimirCorte.Location = new Point(771, 13);
            btnImprimirCorte.Name = "btnImprimirCorte";
            btnImprimirCorte.Size = new Size(279, 40);
            btnImprimirCorte.TabIndex = 2;
            btnImprimirCorte.Text = "Imprimir corte";
            btnImprimirCorte.UseVisualStyleBackColor = false;
            btnImprimirCorte.Click += btnImprimirCorte_Click;
            // 
            // pnlConteo
            // 
            pnlConteo.BackColor = Color.White;
            pnlConteo.BorderStyle = BorderStyle.FixedSingle;
            pnlConteo.Controls.Add(lblTituloConteo);
            pnlConteo.Controls.Add(lblInstruccionConteo);
            pnlConteo.Controls.Add(txtTotalFisico);
            pnlConteo.Controls.Add(txtObservaciones);
            pnlConteo.Dock = DockStyle.Fill;
            pnlConteo.Location = new Point(20, 423);
            pnlConteo.Margin = new Padding(0, 10, 0, 0);
            pnlConteo.Name = "pnlConteo";
            pnlConteo.Size = new Size(1337, 203);
            pnlConteo.TabIndex = 1;
            // 
            // lblTituloConteo
            // 
            lblTituloConteo.AutoSize = true;
            lblTituloConteo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloConteo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTituloConteo.Location = new Point(15, 15);
            lblTituloConteo.Name = "lblTituloConteo";
            lblTituloConteo.Size = new Size(323, 38);
            lblTituloConteo.TabIndex = 0;
            lblTituloConteo.Text = "Declaración de Efectivo";
            // 
            // lblInstruccionConteo
            // 
            lblInstruccionConteo.AutoSize = true;
            lblInstruccionConteo.ForeColor = Color.FromArgb(44, 62, 80);
            lblInstruccionConteo.Location = new Point(15, 53);
            lblInstruccionConteo.Name = "lblInstruccionConteo";
            lblInstruccionConteo.Size = new Size(449, 32);
            lblInstruccionConteo.TabIndex = 1;
            lblInstruccionConteo.Text = "Ingrese la cantidad total contada en caja:";
            // 
            // txtTotalFisico
            // 
            txtTotalFisico.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtTotalFisico.Location = new Point(15, 85);
            txtTotalFisico.Name = "txtTotalFisico";
            txtTotalFisico.Size = new Size(384, 57);
            txtTotalFisico.TabIndex = 2;
            txtTotalFisico.Text = "0.00";
            txtTotalFisico.TextAlign = HorizontalAlignment.Right;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservaciones.ForeColor = Color.Gray;
            txtObservaciones.Location = new Point(518, 15);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(790, 165);
            txtObservaciones.TabIndex = 3;
            txtObservaciones.Text = "Observaciones (opcional)";
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 2;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSuperior.Controls.Add(pnlResumen, 1, 0);
            tlpSuperior.Controls.Add(pnlInfoSistema, 0, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(20, 20);
            tlpSuperior.Margin = new Padding(0, 0, 0, 10);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1337, 383);
            tlpSuperior.TabIndex = 0;
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.White;
            pnlResumen.BorderStyle = BorderStyle.FixedSingle;
            pnlResumen.Controls.Add(lblResumenDiferenciaTexto);
            pnlResumen.Controls.Add(lblTituloResumen);
            pnlResumen.Controls.Add(lblResumenEsperadoTexto);
            pnlResumen.Controls.Add(lblResumenEsperado);
            pnlResumen.Controls.Add(lblTotalContadoResumenTexto);
            pnlResumen.Controls.Add(lblTotalContadoResumen);
            pnlResumen.Controls.Add(lblResumenDiferencia);
            pnlResumen.Controls.Add(pnlAlertaDiferencia);
            pnlResumen.Dock = DockStyle.Fill;
            pnlResumen.Location = new Point(678, 0);
            pnlResumen.Margin = new Padding(10, 0, 0, 0);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(659, 383);
            pnlResumen.TabIndex = 1;
            // 
            // lblResumenDiferenciaTexto
            // 
            lblResumenDiferenciaTexto.Location = new Point(24, 171);
            lblResumenDiferenciaTexto.Name = "lblResumenDiferenciaTexto";
            lblResumenDiferenciaTexto.Size = new Size(127, 49);
            lblResumenDiferenciaTexto.TabIndex = 5;
            lblResumenDiferenciaTexto.Text = "Diferencia";
            // 
            // lblTituloResumen
            // 
            lblTituloResumen.AutoSize = true;
            lblTituloResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloResumen.ForeColor = Color.FromArgb(41, 128, 185);
            lblTituloResumen.Location = new Point(24, 14);
            lblTituloResumen.Name = "lblTituloResumen";
            lblTituloResumen.Size = new Size(136, 38);
            lblTituloResumen.TabIndex = 0;
            lblTituloResumen.Text = "Resumen";
            // 
            // lblResumenEsperadoTexto
            // 
            lblResumenEsperadoTexto.Location = new Point(24, 76);
            lblResumenEsperadoTexto.Name = "lblResumenEsperadoTexto";
            lblResumenEsperadoTexto.Size = new Size(173, 39);
            lblResumenEsperadoTexto.TabIndex = 1;
            lblResumenEsperadoTexto.Text = "Total esperado";
            // 
            // lblResumenEsperado
            // 
            lblResumenEsperado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResumenEsperado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumenEsperado.Location = new Point(399, 72);
            lblResumenEsperado.Name = "lblResumenEsperado";
            lblResumenEsperado.Size = new Size(151, 39);
            lblResumenEsperado.TabIndex = 2;
            lblResumenEsperado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalContadoResumenTexto
            // 
            lblTotalContadoResumenTexto.Location = new Point(24, 127);
            lblTotalContadoResumenTexto.Name = "lblTotalContadoResumenTexto";
            lblTotalContadoResumenTexto.Size = new Size(184, 29);
            lblTotalContadoResumenTexto.TabIndex = 3;
            lblTotalContadoResumenTexto.Text = "Total declarado";
            // 
            // lblTotalContadoResumen
            // 
            lblTotalContadoResumen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalContadoResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalContadoResumen.Location = new Point(399, 124);
            lblTotalContadoResumen.Name = "lblTotalContadoResumen";
            lblTotalContadoResumen.Size = new Size(151, 36);
            lblTotalContadoResumen.TabIndex = 4;
            lblTotalContadoResumen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResumenDiferencia
            // 
            lblResumenDiferencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResumenDiferencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumenDiferencia.Location = new Point(399, 164);
            lblResumenDiferencia.Name = "lblResumenDiferencia";
            lblResumenDiferencia.Size = new Size(151, 44);
            lblResumenDiferencia.TabIndex = 6;
            lblResumenDiferencia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlAlertaDiferencia
            // 
            pnlAlertaDiferencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlertaDiferencia.Controls.Add(lblAlertaEstado);
            pnlAlertaDiferencia.Location = new Point(24, 241);
            pnlAlertaDiferencia.Name = "pnlAlertaDiferencia";
            pnlAlertaDiferencia.Size = new Size(597, 54);
            pnlAlertaDiferencia.TabIndex = 7;
            pnlAlertaDiferencia.Visible = false;
            // 
            // lblAlertaEstado
            // 
            lblAlertaEstado.Dock = DockStyle.Fill;
            lblAlertaEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertaEstado.Location = new Point(0, 0);
            lblAlertaEstado.Name = "lblAlertaEstado";
            lblAlertaEstado.Size = new Size(597, 54);
            lblAlertaEstado.TabIndex = 8;
            lblAlertaEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfoSistema
            // 
            pnlInfoSistema.BackColor = Color.FromArgb(245, 246, 250);
            pnlInfoSistema.Controls.Add(lblTituloInfo);
            pnlInfoSistema.Controls.Add(lblFondoTexto);
            pnlInfoSistema.Controls.Add(lblFondoValor);
            pnlInfoSistema.Controls.Add(lblVentasEfectivoTexto);
            pnlInfoSistema.Controls.Add(lblVentasEfectivoValor);
            pnlInfoSistema.Controls.Add(label1);
            pnlInfoSistema.Controls.Add(lblTicketsValor);
            pnlInfoSistema.Controls.Add(lblVentasTarjetaTexto);
            pnlInfoSistema.Controls.Add(lblArticulosValor);
            pnlInfoSistema.Controls.Add(lblTransferenciasTexto);
            pnlInfoSistema.Controls.Add(lblCanceladosValor);
            pnlInfoSistema.Controls.Add(lblTotalEsperadoInfoTexto);
            pnlInfoSistema.Controls.Add(lblTotalEsperadoInfo);
            pnlInfoSistema.Controls.Add(lblTotalCajonValor);
            pnlInfoSistema.Dock = DockStyle.Fill;
            pnlInfoSistema.Location = new Point(0, 0);
            pnlInfoSistema.Margin = new Padding(0, 0, 10, 0);
            pnlInfoSistema.Name = "pnlInfoSistema";
            pnlInfoSistema.Size = new Size(658, 383);
            pnlInfoSistema.TabIndex = 0;
            // 
            // lblTituloInfo
            // 
            lblTituloInfo.AutoSize = true;
            lblTituloInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloInfo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTituloInfo.Location = new Point(15, 15);
            lblTituloInfo.Name = "lblTituloInfo";
            lblTituloInfo.Size = new Size(333, 38);
            lblTituloInfo.TabIndex = 0;
            lblTituloInfo.Text = "Información del sistema";
            // 
            // lblFondoTexto
            // 
            lblFondoTexto.Location = new Point(15, 65);
            lblFondoTexto.Name = "lblFondoTexto";
            lblFondoTexto.Size = new Size(200, 30);
            lblFondoTexto.TabIndex = 1;
            lblFondoTexto.Text = "Fondo inicial";
            // 
            // lblFondoValor
            // 
            lblFondoValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFondoValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFondoValor.Location = new Point(470, 65);
            lblFondoValor.Name = "lblFondoValor";
            lblFondoValor.Size = new Size(169, 30);
            lblFondoValor.TabIndex = 2;
            lblFondoValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasEfectivoTexto
            // 
            lblVentasEfectivoTexto.Location = new Point(15, 105);
            lblVentasEfectivoTexto.Name = "lblVentasEfectivoTexto";
            lblVentasEfectivoTexto.Size = new Size(200, 30);
            lblVentasEfectivoTexto.TabIndex = 3;
            lblVentasEfectivoTexto.Text = "Ventas efectivo";
            // 
            // lblVentasEfectivoValor
            // 
            lblVentasEfectivoValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVentasEfectivoValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVentasEfectivoValor.ForeColor = Color.FromArgb(39, 174, 96);
            lblVentasEfectivoValor.Location = new Point(470, 105);
            lblVentasEfectivoValor.Name = "lblVentasEfectivoValor";
            lblVentasEfectivoValor.Size = new Size(169, 30);
            lblVentasEfectivoValor.TabIndex = 4;
            lblVentasEfectivoValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(15, 145);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 5;
            label1.Text = "Total de tickets vendidos";
            // 
            // lblTicketsValor
            // 
            lblTicketsValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTicketsValor.Location = new Point(470, 145);
            lblTicketsValor.Name = "lblTicketsValor";
            lblTicketsValor.Size = new Size(169, 30);
            lblTicketsValor.TabIndex = 6;
            lblTicketsValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasTarjetaTexto
            // 
            lblVentasTarjetaTexto.Location = new Point(15, 185);
            lblVentasTarjetaTexto.Name = "lblVentasTarjetaTexto";
            lblVentasTarjetaTexto.Size = new Size(230, 36);
            lblVentasTarjetaTexto.TabIndex = 7;
            lblVentasTarjetaTexto.Text = "Productos vendidos";
            // 
            // lblArticulosValor
            // 
            lblArticulosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblArticulosValor.Location = new Point(470, 185);
            lblArticulosValor.Name = "lblArticulosValor";
            lblArticulosValor.Size = new Size(169, 30);
            lblArticulosValor.TabIndex = 10;
            lblArticulosValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTransferenciasTexto
            // 
            lblTransferenciasTexto.Location = new Point(15, 225);
            lblTransferenciasTexto.Name = "lblTransferenciasTexto";
            lblTransferenciasTexto.Size = new Size(250, 30);
            lblTransferenciasTexto.TabIndex = 9;
            lblTransferenciasTexto.Text = "Productos cancelados";
            // 
            // lblCanceladosValor
            // 
            lblCanceladosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCanceladosValor.ForeColor = Color.FromArgb(231, 76, 60);
            lblCanceladosValor.Location = new Point(470, 225);
            lblCanceladosValor.Name = "lblCanceladosValor";
            lblCanceladosValor.Size = new Size(169, 30);
            lblCanceladosValor.TabIndex = 11;
            lblCanceladosValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalEsperadoInfoTexto
            // 
            lblTotalEsperadoInfoTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalEsperadoInfoTexto.Location = new Point(15, 285);
            lblTotalEsperadoInfoTexto.Name = "lblTotalEsperadoInfoTexto";
            lblTotalEsperadoInfoTexto.Size = new Size(200, 30);
            lblTotalEsperadoInfoTexto.TabIndex = 12;
            lblTotalEsperadoInfoTexto.Text = "Total esperado";
            // 
            // lblTotalEsperadoInfo
            // 
            lblTotalEsperadoInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalEsperadoInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalEsperadoInfo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalEsperadoInfo.Location = new Point(470, 285);
            lblTotalEsperadoInfo.Name = "lblTotalEsperadoInfo";
            lblTotalEsperadoInfo.Size = new Size(169, 45);
            lblTotalEsperadoInfo.TabIndex = 13;
            lblTotalEsperadoInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalCajonValor
            // 
            lblTotalCajonValor.Location = new Point(470, 285);
            lblTotalCajonValor.Name = "lblTotalCajonValor";
            lblTotalCajonValor.Size = new Size(169, 30);
            lblTotalCajonValor.TabIndex = 8;
            lblTotalCajonValor.Visible = false;
            // 
            // tlpContenedor
            // 
            tlpContenedor.ColumnCount = 1;
            tlpContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenedor.Controls.Add(tlpSuperior, 0, 0);
            tlpContenedor.Controls.Add(pnlConteo, 0, 1);
            tlpContenedor.Dock = DockStyle.Fill;
            tlpContenedor.Location = new Point(0, 108);
            tlpContenedor.Name = "tlpContenedor";
            tlpContenedor.Padding = new Padding(20);
            tlpContenedor.RowCount = 2;
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpContenedor.Size = new Size(1377, 646);
            tlpContenedor.TabIndex = 3;
            // 
            // FrmCorteCaja
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1377, 828);
            Controls.Add(tlpContenedor);
            Controls.Add(pnlHeader);
            Controls.Add(pnlInferior);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCorteCaja";
            StartPosition = FormStartPosition.CenterScreen;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInferior.ResumeLayout(false);
            pnlConteo.ResumeLayout(false);
            pnlConteo.PerformLayout();
            tlpSuperior.ResumeLayout(false);
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            pnlAlertaDiferencia.ResumeLayout(false);
            pnlInfoSistema.ResumeLayout(false);
            pnlInfoSistema.PerformLayout();
            tlpContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnRealizarCorte;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlConteo;
        private System.Windows.Forms.Label lblTituloConteo;
        private System.Windows.Forms.Label lblInstruccionConteo;
        private System.Windows.Forms.TextBox txtTotalFisico;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TableLayoutPanel tlpSuperior;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblResumenDiferenciaTexto;
        private System.Windows.Forms.Label lblTituloResumen;
        private System.Windows.Forms.Label lblResumenEsperadoTexto;
        private System.Windows.Forms.Label lblResumenEsperado;
        private System.Windows.Forms.Label lblTotalContadoResumenTexto;
        private System.Windows.Forms.Label lblTotalContadoResumen;
        private System.Windows.Forms.Label lblResumenDiferencia;
        private System.Windows.Forms.Panel pnlAlertaDiferencia;
        private System.Windows.Forms.Label lblAlertaEstado;
        private System.Windows.Forms.Panel pnlInfoSistema;
        private System.Windows.Forms.Label lblTituloInfo;
        private System.Windows.Forms.Label lblFondoTexto;
        private System.Windows.Forms.Label lblFondoValor;
        private System.Windows.Forms.Label lblVentasEfectivoTexto;
        private System.Windows.Forms.Label lblVentasEfectivoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicketsValor;
        private System.Windows.Forms.Label lblVentasTarjetaTexto;
        private System.Windows.Forms.Label lblTotalEsperadoInfo;
        private System.Windows.Forms.Label lblTotalCajonValor;
        private System.Windows.Forms.Label lblTransferenciasTexto;
        private System.Windows.Forms.Label lblArticulosValor;
        private System.Windows.Forms.Label lblCanceladosValor;
        private System.Windows.Forms.Label lblTotalEsperadoInfoTexto;
        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private Button btnImprimirCorte;
        private ComboBox cmbCajerosAbiertos;
        private Label Cajero;
    }
}