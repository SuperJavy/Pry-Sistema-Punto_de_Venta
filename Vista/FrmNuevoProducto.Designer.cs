namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmNuevoProducto
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
            label1 = new Label();
            txtCodigo = new TextBox();
            labelNombre = new Label();
            txtNombrep = new TextBox();
            label2 = new Label();
            label5 = new Label();
            chkUnidad = new CheckBox();
            chkGranel = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            txtStockactual = new TextBox();
            txtStockminimo = new TextBox();
            label10 = new Label();
            btnGuardarproducto = new Button();
            panelHeader = new Panel();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            groupBoxDatos = new GroupBox();
            btnGenerar = new Button();
            cbxCategoria = new ComboBox();
            label7 = new Label();
            txtDescripcion = new TextBox();
            panelDerecho = new Panel();
            groupBoxStock = new GroupBox();
            groupBoxImagen = new GroupBox();
            pcbImagen = new PictureBox();
            btnSeleccionarImagen = new Button();
            panelHeader.SuspendLayout();
            tableLayoutPanelPrincipal.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            panelDerecho.SuspendLayout();
            groupBoxStock.SuspendLayout();
            groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 54);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.Font = new Font("Segoe UI", 11F);
            txtCodigo.Location = new Point(336, 47);
            txtCodigo.Margin = new Padding(6, 7, 6, 7);
            txtCodigo.MaxLength = 13;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(422, 42);
            txtCodigo.TabIndex = 1;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(30, 138);
            labelNombre.Margin = new Padding(6, 0, 6, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(276, 36);
            labelNombre.TabIndex = 20;
            labelNombre.Text = "Nombre del Producto :";
            // 
            // txtNombrep
            // 
            txtNombrep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrep.Font = new Font("Segoe UI", 11F);
            txtNombrep.Location = new Point(320, 132);
            txtNombrep.Margin = new Padding(6, 7, 6, 7);
            txtNombrep.MaxLength = 50;
            txtNombrep.Name = "txtNombrep";
            txtNombrep.Size = new Size(546, 42);
            txtNombrep.TabIndex = 2;
            txtNombrep.KeyPress += txtNombrep_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 222);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 36);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(30, 312);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 36);
            label5.TabIndex = 8;
            label5.Text = "Se vende :";
            // 
            // chkUnidad
            // 
            chkUnidad.AutoSize = true;
            chkUnidad.Font = new Font("Segoe UI", 11F);
            chkUnidad.ForeColor = Color.Black;
            chkUnidad.Location = new Point(320, 310);
            chkUnidad.Margin = new Padding(6, 7, 6, 7);
            chkUnidad.Name = "chkUnidad";
            chkUnidad.Size = new Size(168, 40);
            chkUnidad.TabIndex = 4;
            chkUnidad.Text = "Por Unidad";
            chkUnidad.UseVisualStyleBackColor = true;
            // 
            // chkGranel
            // 
            chkGranel.AutoSize = true;
            chkGranel.Font = new Font("Segoe UI", 11F);
            chkGranel.ForeColor = Color.Black;
            chkGranel.Location = new Point(560, 310);
            chkGranel.Margin = new Padding(6, 7, 6, 7);
            chkGranel.Name = "chkGranel";
            chkGranel.Size = new Size(140, 40);
            chkGranel.TabIndex = 5;
            chkGranel.Text = "A Granel";
            chkGranel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(40, 67);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 36);
            label8.TabIndex = 15;
            label8.Text = "Stock Actual :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(40, 166);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(184, 36);
            label9.TabIndex = 16;
            label9.Text = "Stock Mínimo :";
            // 
            // txtStockactual
            // 
            txtStockactual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockactual.Font = new Font("Segoe UI", 11F);
            txtStockactual.Location = new Point(280, 60);
            txtStockactual.Margin = new Padding(6, 7, 6, 7);
            txtStockactual.MaxLength = 10;
            txtStockactual.Name = "txtStockactual";
            txtStockactual.Size = new Size(359, 42);
            txtStockactual.TabIndex = 17;
            txtStockactual.Text = "0";
            txtStockactual.KeyPress += txtStockactual_KeyPress;
            // 
            // txtStockminimo
            // 
            txtStockminimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockminimo.Font = new Font("Segoe UI", 11F);
            txtStockminimo.Location = new Point(280, 160);
            txtStockminimo.Margin = new Padding(6, 7, 6, 7);
            txtStockminimo.MaxLength = 10;
            txtStockminimo.Name = "txtStockminimo";
            txtStockminimo.Size = new Size(359, 42);
            txtStockminimo.TabIndex = 18;
            txtStockminimo.Text = "0";
            txtStockminimo.KeyPress += txtStockminimo_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(32, 35);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(387, 38);
            label10.TabIndex = 0;
            label10.Text = "Registro de Nuevo Producto";
            // 
            // btnGuardarproducto
            // 
            btnGuardarproducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarproducto.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardarproducto.Cursor = Cursors.Hand;
            btnGuardarproducto.FlatAppearance.BorderSize = 0;
            btnGuardarproducto.FlatStyle = FlatStyle.Flat;
            btnGuardarproducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarproducto.ForeColor = Color.White;
            btnGuardarproducto.Location = new Point(4, 821);
            btnGuardarproducto.Margin = new Padding(6, 7, 6, 7);
            btnGuardarproducto.Name = "btnGuardarproducto";
            btnGuardarproducto.Size = new Size(744, 127);
            btnGuardarproducto.TabIndex = 99;
            btnGuardarproducto.Text = "Guardar Producto";
            btnGuardarproducto.UseVisualStyleBackColor = false;
            btnGuardarproducto.Click += btnGuardarproducto_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 7, 6, 7);
            panelHeader.Name = "panelHeader";
            panelHeader.RightToLeft = RightToLeft.No;
            panelHeader.Size = new Size(1734, 96);
            panelHeader.TabIndex = 100;
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.ColumnCount = 2;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanelPrincipal.Controls.Add(groupBoxDatos, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelDerecho, 1, 0);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(0, 96);
            tableLayoutPanelPrincipal.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.Padding = new Padding(24, 24, 24, 24);
            tableLayoutPanelPrincipal.RowCount = 1;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Size = new Size(1734, 1014);
            tableLayoutPanelPrincipal.TabIndex = 104;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(btnGenerar);
            groupBoxDatos.Controls.Add(cbxCategoria);
            groupBoxDatos.Controls.Add(label7);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Controls.Add(txtCodigo);
            groupBoxDatos.Controls.Add(labelNombre);
            groupBoxDatos.Controls.Add(txtNombrep);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(txtDescripcion);
            groupBoxDatos.Controls.Add(label5);
            groupBoxDatos.Controls.Add(chkUnidad);
            groupBoxDatos.Controls.Add(chkGranel);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxDatos.Location = new Point(28, 28);
            groupBoxDatos.Margin = new Padding(4, 4, 24, 4);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(6, 7, 6, 7);
            groupBoxDatos.Size = new Size(899, 958);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " INFORMACIÓN DEL PRODUCTO ";
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.Location = new Point(768, 49);
            btnGenerar.Margin = new Padding(4, 4, 4, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(115, 46);
            btnGenerar.TabIndex = 24;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(320, 386);
            cbxCategoria.Margin = new Padding(4, 4, 4, 4);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(546, 39);
            cbxCategoria.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 386);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 36);
            label7.TabIndex = 22;
            label7.Text = "Categoría :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(320, 218);
            txtDescripcion.Margin = new Padding(6, 7, 6, 7);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(546, 42);
            txtDescripcion.TabIndex = 3;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(btnGuardarproducto);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(955, 28);
            panelDerecho.Margin = new Padding(4, 4, 4, 4);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(751, 958);
            panelDerecho.TabIndex = 105;
            // 
            // groupBoxStock
            // 
            groupBoxStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStock.Controls.Add(label8);
            groupBoxStock.Controls.Add(txtStockactual);
            groupBoxStock.Controls.Add(label9);
            groupBoxStock.Controls.Add(txtStockminimo);
            groupBoxStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxStock.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxStock.Location = new Point(4, 0);
            groupBoxStock.Margin = new Padding(6, 7, 6, 7);
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Padding = new Padding(6, 7, 6, 7);
            groupBoxStock.Size = new Size(744, 234);
            groupBoxStock.TabIndex = 102;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = " INVENTARIO / EXISTENCIAS ";
            // 
            // groupBoxImagen
            // 
            groupBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxImagen.Controls.Add(pcbImagen);
            groupBoxImagen.Controls.Add(btnSeleccionarImagen);
            groupBoxImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxImagen.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxImagen.Location = new Point(4, 246);
            groupBoxImagen.Margin = new Padding(6, 7, 6, 7);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Padding = new Padding(6, 7, 6, 7);
            groupBoxImagen.Size = new Size(744, 556);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pcbImagen
            // 
            pcbImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbImagen.BackColor = Color.FromArgb(245, 246, 250);
            pcbImagen.BorderStyle = BorderStyle.Fixed3D;
            pcbImagen.Location = new Point(40, 48);
            pcbImagen.Margin = new Padding(4, 4, 4, 4);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(664, 406);
            pcbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImagen.TabIndex = 0;
            pcbImagen.TabStop = false;
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
            btnSeleccionarImagen.Location = new Point(40, 473);
            btnSeleccionarImagen.Margin = new Padding(4, 4, 4, 4);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(665, 60);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Seleccionar Imagen...";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1734, 1110);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevoProductio";
            Shown += FrmNuevoProducto_Shown;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelPrincipal.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            panelDerecho.ResumeLayout(false);
            groupBoxStock.ResumeLayout(false);
            groupBoxStock.PerformLayout();
            groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombrep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUnidad;
        private System.Windows.Forms.CheckBox chkGranel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockactual;
        private System.Windows.Forms.TextBox txtStockminimo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardarproducto;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal; // Agregado para fluidez
        private System.Windows.Forms.Panel panelDerecho; // Agregado para fluidez
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private TextBox txtDescripcion;
        private ComboBox cbxCategoria;
        private Label label7;
        private Button btnGenerar;
    }
}