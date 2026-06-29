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
            label3 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            chkUnidad = new CheckBox();
            chkGranel = new CheckBox();
            txtPrecioventa = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtStockactual = new TextBox();
            txtStockminimo = new TextBox();
            nudPorcentaje = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
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
            label1.Location = new Point(25, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.Font = new Font("Segoe UI", 11F);
            txtCodigo.Location = new Point(267, 40);
            txtCodigo.Margin = new Padding(5, 6, 5, 6);
            txtCodigo.MaxLength = 13;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(352, 37);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(25, 115);
            labelNombre.Margin = new Padding(5, 0, 5, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(235, 30);
            labelNombre.TabIndex = 20;
            labelNombre.Text = "Nombre del Producto :";
            // 
            // txtNombrep
            // 
            txtNombrep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrep.Font = new Font("Segoe UI", 11F);
            txtNombrep.Location = new Point(267, 110);
            txtNombrep.Margin = new Padding(5, 6, 5, 6);
            txtNombrep.MaxLength = 50;
            txtNombrep.Name = "txtNombrep";
            txtNombrep.Size = new Size(456, 37);
            txtNombrep.TabIndex = 2;
            txtNombrep.KeyPress += txtNombrep_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 185);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 473);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 4;
            label3.Text = "Margen de Venta :";
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCosto.Font = new Font("Segoe UI", 11F);
            txtCosto.Location = new Point(267, 388);
            txtCosto.Margin = new Padding(5, 6, 5, 6);
            txtCosto.MaxLength = 10;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(456, 37);
            txtCosto.TabIndex = 6;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 393);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 30);
            label4.TabIndex = 6;
            label4.Text = "Precio Costo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 260);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 8;
            label5.Text = "Se vende :";
            // 
            // chkUnidad
            // 
            chkUnidad.AutoSize = true;
            chkUnidad.Font = new Font("Segoe UI", 11F);
            chkUnidad.ForeColor = Color.Black;
            chkUnidad.Location = new Point(267, 258);
            chkUnidad.Margin = new Padding(5, 6, 5, 6);
            chkUnidad.Name = "chkUnidad";
            chkUnidad.Size = new Size(146, 34);
            chkUnidad.TabIndex = 4;
            chkUnidad.Text = "Por Unidad";
            chkUnidad.UseVisualStyleBackColor = true;
            // 
            // chkGranel
            // 
            chkGranel.AutoSize = true;
            chkGranel.Font = new Font("Segoe UI", 11F);
            chkGranel.ForeColor = Color.Black;
            chkGranel.Location = new Point(467, 258);
            chkGranel.Margin = new Padding(5, 6, 5, 6);
            chkGranel.Name = "chkGranel";
            chkGranel.Size = new Size(122, 34);
            chkGranel.TabIndex = 5;
            chkGranel.Text = "A Granel";
            chkGranel.UseVisualStyleBackColor = true;
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioventa.BackColor = Color.FromArgb(245, 246, 250);
            txtPrecioventa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPrecioventa.ForeColor = Color.FromArgb(46, 204, 113);
            txtPrecioventa.Location = new Point(267, 548);
            txtPrecioventa.Margin = new Padding(5, 6, 5, 6);
            txtPrecioventa.MaxLength = 10;
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.ReadOnly = true;
            txtPrecioventa.Size = new Size(456, 37);
            txtPrecioventa.TabIndex = 14;
            txtPrecioventa.TextChanged += txtPrecioventa_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 204, 113);
            label6.Location = new Point(25, 553);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 13;
            label6.Text = "Precio Venta :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 56);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 30);
            label8.TabIndex = 15;
            label8.Text = "Stock Actual :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 138);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(156, 30);
            label9.TabIndex = 16;
            label9.Text = "Stock Mínimo :";
            // 
            // txtStockactual
            // 
            txtStockactual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockactual.Font = new Font("Segoe UI", 11F);
            txtStockactual.Location = new Point(233, 50);
            txtStockactual.Margin = new Padding(5, 6, 5, 6);
            txtStockactual.MaxLength = 10;
            txtStockactual.Name = "txtStockactual";
            txtStockactual.Size = new Size(301, 37);
            txtStockactual.TabIndex = 17;
            txtStockactual.KeyPress += txtStockactual_KeyPress;
            // 
            // txtStockminimo
            // 
            txtStockminimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockminimo.Font = new Font("Segoe UI", 11F);
            txtStockminimo.Location = new Point(233, 133);
            txtStockminimo.Margin = new Padding(5, 6, 5, 6);
            txtStockminimo.MaxLength = 10;
            txtStockminimo.Name = "txtStockminimo";
            txtStockminimo.Size = new Size(301, 37);
            txtStockminimo.TabIndex = 18;
            txtStockminimo.KeyPress += txtStockminimo_KeyPress;
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.Font = new Font("Segoe UI", 11F);
            nudPorcentaje.Location = new Point(267, 469);
            nudPorcentaje.Margin = new Padding(5, 6, 5, 6);
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(167, 37);
            nudPorcentaje.TabIndex = 7;
            nudPorcentaje.ValueChanged += nudGanancia_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(27, 29);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(339, 32);
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
            btnGuardarproducto.Location = new Point(3, 685);
            btnGuardarproducto.Margin = new Padding(5, 6, 5, 6);
            btnGuardarproducto.Name = "btnGuardarproducto";
            btnGuardarproducto.Size = new Size(621, 106);
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
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.RightToLeft = RightToLeft.No;
            panelHeader.Size = new Size(1445, 80);
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
            tableLayoutPanelPrincipal.Location = new Point(0, 80);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.Padding = new Padding(20);
            tableLayoutPanelPrincipal.RowCount = 1;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Size = new Size(1445, 845);
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
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(txtCosto);
            groupBoxDatos.Controls.Add(label3);
            groupBoxDatos.Controls.Add(nudPorcentaje);
            groupBoxDatos.Controls.Add(label6);
            groupBoxDatos.Controls.Add(txtPrecioventa);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxDatos.Location = new Point(23, 23);
            groupBoxDatos.Margin = new Padding(3, 3, 20, 3);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(5, 6, 5, 6);
            groupBoxDatos.Size = new Size(749, 799);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " INFORMACIÓN DEL PRODUCTO ";
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.Location = new Point(627, 40);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(96, 38);
            btnGenerar.TabIndex = 24;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(267, 322);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(456, 36);
            cbxCategoria.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 322);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 22;
            label7.Text = "Categoría :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(267, 182);
            txtDescripcion.Margin = new Padding(5, 6, 5, 6);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(456, 37);
            txtDescripcion.TabIndex = 3;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(btnGuardarproducto);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(795, 23);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(627, 799);
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
            groupBoxStock.Location = new Point(3, 0);
            groupBoxStock.Margin = new Padding(5, 6, 5, 6);
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Padding = new Padding(5, 6, 5, 6);
            groupBoxStock.Size = new Size(621, 195);
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
            groupBoxImagen.Location = new Point(3, 205);
            groupBoxImagen.Margin = new Padding(5, 6, 5, 6);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Padding = new Padding(5, 6, 5, 6);
            groupBoxImagen.Size = new Size(621, 464);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pcbImagen
            // 
            pcbImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbImagen.BackColor = Color.FromArgb(245, 246, 250);
            pcbImagen.BorderStyle = BorderStyle.Fixed3D;
            pcbImagen.Location = new Point(33, 40);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(555, 340);
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
            btnSeleccionarImagen.Location = new Point(33, 395);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(555, 50);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Seleccionar Imagen...";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 925);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevoProductio";
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUnidad;
        private System.Windows.Forms.CheckBox chkGranel;
        private System.Windows.Forms.TextBox txtPrecioventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockactual;
        private System.Windows.Forms.TextBox txtStockminimo;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
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