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
            btnGuardarProducto = new Button();
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
            label10.Location = new Point(32, 35);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(284, 38);
            label10.TabIndex = 0;
            label10.Text = "Modificar Productos";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 7, 6, 7);
            panelHeader.Name = "panelHeader";
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
            tableLayoutPanelPrincipal.Margin = new Padding(4);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.Padding = new Padding(24);
            tableLayoutPanelPrincipal.RowCount = 1;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Size = new Size(1734, 1014);
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
            groupBoxDatos.Location = new Point(28, 28);
            groupBoxDatos.Margin = new Padding(4, 4, 24, 4);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(4);
            groupBoxDatos.Size = new Size(899, 958);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " DATOS GENERALES DEL PRODUCTO ";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(320, 310);
            cbxCategoria.Margin = new Padding(4);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(533, 39);
            cbxCategoria.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 317);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 36);
            label7.TabIndex = 25;
            label7.Text = "Categoría :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // txtCodigodebarras
            // 
            txtCodigodebarras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigodebarras.Font = new Font("Segoe UI", 11F);
            txtCodigodebarras.Location = new Point(320, 48);
            txtCodigodebarras.Margin = new Padding(4);
            txtCodigodebarras.MaxLength = 13;
            txtCodigodebarras.Name = "txtCodigodebarras";
            txtCodigodebarras.Size = new Size(533, 42);
            txtCodigodebarras.TabIndex = 1;
            txtCodigodebarras.KeyDown += txtCodigodebarras_KeyDown;
            txtCodigodebarras.KeyPress += txtCodigodebarras_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(30, 138);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
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
            txtNombrep.Margin = new Padding(4);
            txtNombrep.MaxLength = 50;
            txtNombrep.Name = "txtNombrep";
            txtNombrep.Size = new Size(533, 42);
            txtNombrep.TabIndex = 2;
            txtNombrep.KeyPress += txtNombrep_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 36);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(320, 216);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(533, 42);
            txtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(30, 403);
            label5.Margin = new Padding(4, 0, 4, 0);
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
            chkUnidad.Location = new Point(320, 401);
            chkUnidad.Margin = new Padding(4);
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
            chkGranel.Location = new Point(560, 401);
            chkGranel.Margin = new Padding(4);
            chkGranel.Name = "chkGranel";
            chkGranel.Size = new Size(140, 40);
            chkGranel.TabIndex = 5;
            chkGranel.Text = "A Granel";
            chkGranel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 493);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 36);
            label4.TabIndex = 6;
            label4.Text = "Precio Costo :";
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCosto.Font = new Font("Segoe UI", 11F);
            txtCosto.Location = new Point(320, 487);
            txtCosto.Margin = new Padding(4);
            txtCosto.MaxLength = 10;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(533, 42);
            txtCosto.TabIndex = 6;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 589);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(225, 36);
            label3.TabIndex = 4;
            label3.Text = "Margen de Venta :";
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.Font = new Font("Segoe UI", 11F);
            nudPorcentaje.Location = new Point(320, 584);
            nudPorcentaje.Margin = new Padding(4);
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(200, 42);
            nudPorcentaje.TabIndex = 7;
            nudPorcentaje.ValueChanged += nudPorcentaje_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 204, 113);
            label6.Location = new Point(30, 685);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 36);
            label6.TabIndex = 13;
            label6.Text = "Precio Venta :";
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioventa.BackColor = Color.FromArgb(245, 246, 250);
            txtPrecioventa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPrecioventa.ForeColor = Color.FromArgb(46, 204, 113);
            txtPrecioventa.Location = new Point(320, 679);
            txtPrecioventa.Margin = new Padding(4);
            txtPrecioventa.MaxLength = 10;
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.Size = new Size(533, 42);
            txtPrecioventa.TabIndex = 14;
            txtPrecioventa.TextChanged += txtPrecioventa_TextChanged;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(btnGuardarProducto);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(955, 28);
            panelDerecho.Margin = new Padding(4);
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
            groupBoxStock.Margin = new Padding(4);
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Padding = new Padding(4);
            groupBoxStock.Size = new Size(744, 222);
            groupBoxStock.TabIndex = 102;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = " INVENTARIO / EXISTENCIAS ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(40, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 36);
            label8.TabIndex = 15;
            label8.Text = "Hay :";
            // 
            // txtStockactual
            // 
            txtStockactual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockactual.Font = new Font("Segoe UI", 11F);
            txtStockactual.Location = new Point(280, 54);
            txtStockactual.Margin = new Padding(4);
            txtStockactual.MaxLength = 10;
            txtStockactual.Name = "txtStockactual";
            txtStockactual.Size = new Size(424, 42);
            txtStockactual.TabIndex = 17;
            txtStockactual.KeyPress += txtStockactual_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(40, 138);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 36);
            label9.TabIndex = 16;
            label9.Text = "Mínimo :";
            // 
            // txtStockminimo
            // 
            txtStockminimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockminimo.Font = new Font("Segoe UI", 11F);
            txtStockminimo.Location = new Point(280, 132);
            txtStockminimo.Margin = new Padding(4);
            txtStockminimo.MaxLength = 10;
            txtStockminimo.Name = "txtStockminimo";
            txtStockminimo.Size = new Size(424, 42);
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
            groupBoxImagen.Location = new Point(4, 240);
            groupBoxImagen.Margin = new Padding(4);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Padding = new Padding(4);
            groupBoxImagen.Size = new Size(744, 562);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pcbImagen
            // 
            pcbImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbImagen.BackColor = Color.FromArgb(245, 246, 250);
            pcbImagen.BorderStyle = BorderStyle.FixedSingle;
            pcbImagen.Location = new Point(40, 48);
            pcbImagen.Margin = new Padding(4);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(665, 413);
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
            btnSeleccionarImagen.Location = new Point(40, 479);
            btnSeleccionarImagen.Margin = new Padding(4);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(665, 60);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Cambiar Imagen...";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarProducto.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardarProducto.Cursor = Cursors.Hand;
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(4, 821);
            btnGuardarProducto.Margin = new Padding(4);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(744, 127);
            btnGuardarProducto.TabIndex = 98;
            btnGuardarProducto.Text = "Actualizar este Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click_1;
            // 
            // FrmModoficar
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1734, 1110);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
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
        private System.Windows.Forms.Button btnGuardarProducto;
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