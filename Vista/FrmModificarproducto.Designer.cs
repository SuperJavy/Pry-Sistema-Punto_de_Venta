namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmModoficar
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
            label10 = new Label();
            panelHeader = new Panel();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            groupBoxDatos = new GroupBox();
            cbxCategoria = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txtCodigodebarras = new TextBox();
            labelNombre = new Label();
            txtNombrep = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            chkUnidad = new CheckBox();
            chkGranel = new CheckBox();
            label4 = new Label();
            txtCosto = new TextBox();
            label3 = new Label();
            nudPorcentaje = new NumericUpDown();
            label6 = new Label();
            txtPrecioventa = new TextBox();
            panelDerecho = new Panel();
            groupBoxStock = new GroupBox();
            label8 = new Label();
            txtStockactual = new TextBox();
            label9 = new Label();
            txtStockminimo = new TextBox();
            groupBoxImagen = new GroupBox();
            pcbImagen = new PictureBox();
            btnSeleccionarImagen = new Button();
            button1 = new Button();
            panelHeader.SuspendLayout();
            tableLayoutPanelPrincipal.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
            panelDerecho.SuspendLayout();
            groupBoxStock.SuspendLayout();
            groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagen).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(27, 29);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(249, 32);
            label10.TabIndex = 0;
            label10.Text = "Modificar Productos";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
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
            groupBoxDatos.Controls.Add(cbxCategoria);
            groupBoxDatos.Controls.Add(label7);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Controls.Add(txtCodigodebarras);
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
            groupBoxDatos.Size = new Size(749, 799);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " DATOS GENERALES DEL PRODUCTO ";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(267, 258);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(445, 36);
            cbxCategoria.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 264);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 25;
            label7.Text = "Categoría :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // txtCodigodebarras
            // 
            txtCodigodebarras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigodebarras.Font = new Font("Segoe UI", 11F);
            txtCodigodebarras.Location = new Point(267, 40);
            txtCodigodebarras.MaxLength = 13;
            txtCodigodebarras.Name = "txtCodigodebarras";
            txtCodigodebarras.Size = new Size(445, 37);
            txtCodigodebarras.TabIndex = 1;
            txtCodigodebarras.KeyDown += txtCodigodebarras_KeyDown;
            txtCodigodebarras.KeyPress += txtCodigodebarras_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(25, 115);
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
            txtNombrep.MaxLength = 50;
            txtNombrep.Name = "txtNombrep";
            txtNombrep.Size = new Size(445, 37);
            txtNombrep.TabIndex = 2;
            txtNombrep.KeyPress += txtNombrep_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 185);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(267, 180);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(445, 37);
            txtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 336);
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
            chkUnidad.Location = new Point(267, 334);
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
            chkGranel.Location = new Point(467, 334);
            chkGranel.Name = "chkGranel";
            chkGranel.Size = new Size(122, 34);
            chkGranel.TabIndex = 5;
            chkGranel.Text = "A Granel";
            chkGranel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 411);
            label4.Name = "label4";
            label4.Size = new Size(146, 30);
            label4.TabIndex = 6;
            label4.Text = "Precio Costo :";
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCosto.Font = new Font("Segoe UI", 11F);
            txtCosto.Location = new Point(267, 406);
            txtCosto.MaxLength = 10;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(445, 37);
            txtCosto.TabIndex = 6;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 491);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 4;
            label3.Text = "Margen de Venta :";
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.Font = new Font("Segoe UI", 11F);
            nudPorcentaje.Location = new Point(267, 487);
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(167, 37);
            nudPorcentaje.TabIndex = 7;
            nudPorcentaje.ValueChanged += nudPorcentaje_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 204, 113);
            label6.Location = new Point(25, 571);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 13;
            label6.Text = "Precio Venta :";
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioventa.BackColor = Color.FromArgb(245, 246, 250);
            txtPrecioventa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPrecioventa.ForeColor = Color.FromArgb(46, 204, 113);
            txtPrecioventa.Location = new Point(267, 566);
            txtPrecioventa.MaxLength = 10;
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.Size = new Size(445, 37);
            txtPrecioventa.TabIndex = 14;
            txtPrecioventa.TextChanged += txtPrecioventa_TextChanged;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(button1);
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
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Size = new Size(621, 185);
            groupBoxStock.TabIndex = 102;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = " INVENTARIO / EXISTENCIAS ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 50);
            label8.Name = "label8";
            label8.Size = new Size(62, 30);
            label8.TabIndex = 15;
            label8.Text = "Hay :";
            // 
            // txtStockactual
            // 
            txtStockactual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockactual.Font = new Font("Segoe UI", 11F);
            txtStockactual.Location = new Point(233, 45);
            txtStockactual.MaxLength = 10;
            txtStockactual.Name = "txtStockactual";
            txtStockactual.Size = new Size(355, 37);
            txtStockactual.TabIndex = 17;
            txtStockactual.KeyPress += txtStockactual_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 115);
            label9.Name = "label9";
            label9.Size = new Size(98, 30);
            label9.TabIndex = 16;
            label9.Text = "Mínimo :";
            // 
            // txtStockminimo
            // 
            txtStockminimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockminimo.Font = new Font("Segoe UI", 11F);
            txtStockminimo.Location = new Point(233, 110);
            txtStockminimo.MaxLength = 10;
            txtStockminimo.Name = "txtStockminimo";
            txtStockminimo.Size = new Size(355, 37);
            txtStockminimo.TabIndex = 18;
            txtStockminimo.KeyPress += txtStockminimo_KeyPress;
            // 
            // groupBoxImagen
            // 
            groupBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxImagen.Controls.Add(pcbImagen);
            groupBoxImagen.Controls.Add(btnSeleccionarImagen);
            groupBoxImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxImagen.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxImagen.Location = new Point(3, 200);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Size = new Size(621, 469);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pcbImagen
            // 
            pcbImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbImagen.BackColor = Color.FromArgb(245, 246, 250);
            pcbImagen.BorderStyle = BorderStyle.FixedSingle;
            pcbImagen.Location = new Point(33, 40);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(555, 345);
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
            btnSeleccionarImagen.Location = new Point(33, 400);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(555, 50);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Cambiar Imagen...";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 685);
            button1.Name = "button1";
            button1.Size = new Size(621, 106);
            button1.TabIndex = 98;
            button1.Text = "Actualizar este Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmModoficar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 925);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmModoficar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModoficar";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelPrincipal.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
            panelDerecho.ResumeLayout(false);
            groupBoxStock.ResumeLayout(false);
            groupBoxStock.PerformLayout();
            groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal; // Agregado
        private System.Windows.Forms.Panel panelDerecho; // Agregado
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrecioventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkGranel;
        private System.Windows.Forms.CheckBox chkUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrep;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtCodigodebarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox txtStockminimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockactual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private ComboBox cbxCategoria;
        private Label label7;
    }
}