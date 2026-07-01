namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmVisualizar_Etiquetas
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
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblFiltrar = new Label();
            cmbEstados = new ComboBox();
            dgvEtiquetas = new DataGridView();
            panelBotones = new TableLayoutPanel();
            btnImprimirTodas = new Button();
            btnImprimirSeleccionadas = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(240, 242, 245);
            panelTop.Controls.Add(lblFiltrar);
            panelTop.Controls.Add(cmbEstados);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(972, 109);
            panelTop.TabIndex = 0;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFiltrar.Location = new Point(31, 34);
            lblFiltrar.Margin = new Padding(4, 0, 4, 0);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(205, 30);
            lblFiltrar.TabIndex = 0;
            lblFiltrar.Text = "Mostrar etiquetas:";
            // 
            // cmbEstados
            // 
            cmbEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstados.Font = new Font("Segoe UI", 11F);
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Location = new Point(244, 26);
            cmbEstados.Margin = new Padding(4, 5, 4, 5);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(399, 38);
            cmbEstados.TabIndex = 1;
            cmbEstados.SelectedIndexChanged += cmbEstados_SelectedIndexChanged;
            // 
            // dgvEtiquetas
            // 
            dgvEtiquetas.AllowUserToAddRows = false;
            dgvEtiquetas.AllowUserToDeleteRows = false;
            dgvEtiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEtiquetas.BackgroundColor = Color.White;
            dgvEtiquetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtiquetas.Dock = DockStyle.Fill;
            dgvEtiquetas.Location = new Point(0, 109);
            dgvEtiquetas.Margin = new Padding(4, 5, 4, 5);
            dgvEtiquetas.MultiSelect = false;
            dgvEtiquetas.Name = "dgvEtiquetas";
            dgvEtiquetas.RowHeadersWidth = 51;
            dgvEtiquetas.RowTemplate.Height = 40;
            dgvEtiquetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtiquetas.Size = new Size(972, 460);
            dgvEtiquetas.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 2;
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelBotones.Controls.Add(btnImprimirTodas, 0, 0);
            panelBotones.Controls.Add(btnImprimirSeleccionadas, 1, 0);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 569);
            panelBotones.Margin = new Padding(4, 5, 4, 5);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(12, 16, 12, 16);
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.Size = new Size(972, 125);
            panelBotones.TabIndex = 2;
            // 
            // btnImprimirTodas
            // 
            btnImprimirTodas.Dock = DockStyle.Fill;
            btnImprimirTodas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnImprimirTodas.Location = new Point(18, 24);
            btnImprimirTodas.Margin = new Padding(6, 8, 6, 8);
            btnImprimirTodas.Name = "btnImprimirTodas";
            btnImprimirTodas.Size = new Size(462, 77);
            btnImprimirTodas.TabIndex = 0;
            btnImprimirTodas.Text = "Imprimir Lote Completo (Sin Imprimir)";
            btnImprimirTodas.UseVisualStyleBackColor = true;
            btnImprimirTodas.Click += btnImprimirTodas_Click;
            // 
            // btnImprimirSeleccionadas
            // 
            btnImprimirSeleccionadas.Dock = DockStyle.Fill;
            btnImprimirSeleccionadas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnImprimirSeleccionadas.Location = new Point(492, 24);
            btnImprimirSeleccionadas.Margin = new Padding(6, 8, 6, 8);
            btnImprimirSeleccionadas.Name = "btnImprimirSeleccionadas";
            btnImprimirSeleccionadas.Size = new Size(462, 77);
            btnImprimirSeleccionadas.TabIndex = 1;
            btnImprimirSeleccionadas.Text = "Imprimir Seleccionados / Específico";
            btnImprimirSeleccionadas.UseVisualStyleBackColor = true;
            btnImprimirSeleccionadas.Click += btnImprimirSeleccionadas_Click;
            // 
            // FrmVisualizar_Etiquetas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 694);
            Controls.Add(dgvEtiquetas);
            Controls.Add(panelBotones);
            Controls.Add(panelTop);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(994, 750);
            Name = "FrmVisualizar_Etiquetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo - Visor y Emisión de Etiquetas de Códigos de Barras";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.DataGridView dgvEtiquetas;
        private System.Windows.Forms.TableLayoutPanel panelBotones;
        private System.Windows.Forms.Button btnImprimirTodas;
        private System.Windows.Forms.Button btnImprimirSeleccionadas;
    }
}