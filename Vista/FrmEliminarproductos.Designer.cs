namespace Pry_Sistema_Punto_de_Venta
{
    partial class FrmEliminarproductos
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
            label10 = new Label();
            btnEliminar = new Button();
            nudPorcentaje = new NumericUpDown();
            txtPrecioventa = new TextBox();
            label6 = new Label();
            chkGranel = new CheckBox();
            chkUnidad = new CheckBox();
            label5 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombrep = new TextBox();
            labelNombre = new Label();
            txtCodigobarras = new TextBox();
            label1 = new Label();
            panelHeader = new Panel();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            groupBoxDatos = new GroupBox();
            cbxCategoria = new ComboBox();
            label7 = new Label();
            panelDerecho = new Panel();
            groupBoxStock = new GroupBox();
            label8 = new Label();
            txtStockactual = new TextBox();
            label9 = new Label();
            txtStockminimo = new TextBox();
            groupBoxImagen = new GroupBox();
            pcbImagen = new PictureBox();
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(47, 53, 66);
            label10.Location = new Point(27, 25);
            label10.Name = "label10";
            label10.Size = new Size(221, 32);
            label10.TabIndex = 0;
            label10.Text = "Eliminar Producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(3, 699);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(621, 106);
            btnEliminar.TabIndex = 97;
            btnEliminar.Text = "Eliminar este Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.Enabled = false;
            nudPorcentaje.Font = new Font("Segoe UI", 11F);
            nudPorcentaje.Location = new Point(267, 477);
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(167, 37);
            nudPorcentaje.TabIndex = 112;
            nudPorcentaje.ValueChanged += nudPorcentaje_ValueChanged_1;
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioventa.BackColor = Color.FromArgb(245, 246, 250);
            txtPrecioventa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPrecioventa.ForeColor = Color.FromArgb(231, 76, 60);
            txtPrecioventa.Location = new Point(267, 547);
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.ReadOnly = true;
            txtPrecioventa.Size = new Size(456, 37);
            txtPrecioventa.TabIndex = 111;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(231, 76, 60);
            label6.Location = new Point(25, 550);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 110;
            label6.Text = "Precio Venta :";
            // 
            // chkGranel
            // 
            chkGranel.AutoSize = true;
            chkGranel.Enabled = false;
            chkGranel.Font = new Font("Segoe UI", 11F);
            chkGranel.ForeColor = Color.Black;
            chkGranel.Location = new Point(467, 338);
            chkGranel.Name = "chkGranel";
            chkGranel.Size = new Size(122, 34);
            chkGranel.TabIndex = 107;
            chkGranel.Text = "A Granel";
            chkGranel.UseVisualStyleBackColor = true;
            // 
            // chkUnidad
            // 
            chkUnidad.AutoSize = true;
            chkUnidad.Enabled = false;
            chkUnidad.Font = new Font("Segoe UI", 11F);
            chkUnidad.ForeColor = Color.Black;
            chkUnidad.Location = new Point(267, 338);
            chkUnidad.Name = "chkUnidad";
            chkUnidad.Size = new Size(146, 34);
            chkUnidad.TabIndex = 106;
            chkUnidad.Text = "Por Unidad";
            chkUnidad.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 340);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 105;
            label5.Text = "Se vende :";
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCosto.Font = new Font("Segoe UI", 11F);
            txtCosto.Location = new Point(267, 407);
            txtCosto.Name = "txtCosto";
            txtCosto.ReadOnly = true;
            txtCosto.Size = new Size(456, 37);
            txtCosto.TabIndex = 104;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 410);
            label4.Name = "label4";
            label4.Size = new Size(146, 30);
            label4.TabIndex = 6;
            label4.Text = "Precio Costo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 480);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 4;
            label3.Text = "Margen de Venta :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(267, 197);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(456, 37);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 200);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 2;
            label2.Text = "Descripción :";
            // 
            // txtNombrep
            // 
            txtNombrep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrep.Font = new Font("Segoe UI", 11F);
            txtNombrep.Location = new Point(267, 127);
            txtNombrep.Name = "txtNombrep";
            txtNombrep.ReadOnly = true;
            txtNombrep.Size = new Size(456, 37);
            txtNombrep.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11F);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(25, 130);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(235, 30);
            labelNombre.TabIndex = 20;
            labelNombre.Text = "Nombre del Producto :";
            // 
            // txtCodigobarras
            // 
            txtCodigobarras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigobarras.Font = new Font("Segoe UI", 11F);
            txtCodigobarras.Location = new Point(267, 57);
            txtCodigobarras.MaxLength = 13;
            txtCodigobarras.Name = "txtCodigobarras";
            txtCodigobarras.Size = new Size(456, 37);
            txtCodigobarras.TabIndex = 1;
            txtCodigobarras.KeyDown += txtCodigobarras_KeyDown_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Código de barras :";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1445, 74);
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
            tableLayoutPanelPrincipal.Location = new Point(0, 74);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.Padding = new Padding(20);
            tableLayoutPanelPrincipal.RowCount = 1;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Size = new Size(1445, 851);
            tableLayoutPanelPrincipal.TabIndex = 104;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(cbxCategoria);
            groupBoxDatos.Controls.Add(label7);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Controls.Add(txtCodigobarras);
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
            groupBoxDatos.Padding = new Padding(20);
            groupBoxDatos.Size = new Size(749, 805);
            groupBoxDatos.TabIndex = 101;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = " BÚSQUEDA E INFORMACIÓN DEL PRODUCTO ";
            // 
            // cbxCategoria
            // 
            cbxCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.Enabled = false;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(267, 267);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(456, 36);
            cbxCategoria.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 270);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 22;
            label7.Text = "Categoría :";
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(groupBoxStock);
            panelDerecho.Controls.Add(groupBoxImagen);
            panelDerecho.Controls.Add(btnEliminar);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(795, 23);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(627, 805);
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
            groupBoxStock.Padding = new Padding(20);
            groupBoxStock.Size = new Size(621, 195);
            groupBoxStock.TabIndex = 102;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = " INVENTARIO / EXISTENCIAS ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 60);
            label8.Name = "label8";
            label8.Size = new Size(141, 30);
            label8.TabIndex = 15;
            label8.Text = "Stock Actual :";
            // 
            // txtStockactual
            // 
            txtStockactual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockactual.Font = new Font("Segoe UI", 11F);
            txtStockactual.Location = new Point(233, 57);
            txtStockactual.Name = "txtStockactual";
            txtStockactual.ReadOnly = true;
            txtStockactual.Size = new Size(301, 37);
            txtStockactual.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 130);
            label9.Name = "label9";
            label9.Size = new Size(156, 30);
            label9.TabIndex = 16;
            label9.Text = "Stock Mínimo :";
            // 
            // txtStockminimo
            // 
            txtStockminimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStockminimo.Font = new Font("Segoe UI", 11F);
            txtStockminimo.Location = new Point(233, 127);
            txtStockminimo.Name = "txtStockminimo";
            txtStockminimo.ReadOnly = true;
            txtStockminimo.Size = new Size(301, 37);
            txtStockminimo.TabIndex = 18;
            // 
            // groupBoxImagen
            // 
            groupBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxImagen.Controls.Add(pcbImagen);
            groupBoxImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxImagen.ForeColor = Color.FromArgb(74, 85, 104);
            groupBoxImagen.Location = new Point(3, 215);
            groupBoxImagen.Name = "groupBoxImagen";
            groupBoxImagen.Padding = new Padding(20);
            groupBoxImagen.Size = new Size(621, 456);
            groupBoxImagen.TabIndex = 103;
            groupBoxImagen.TabStop = false;
            groupBoxImagen.Text = " IMAGEN DEL PRODUCTO ";
            // 
            // pcbImagen
            // 
            pcbImagen.BackColor = Color.FromArgb(245, 246, 250);
            pcbImagen.BorderStyle = BorderStyle.Fixed3D;
            pcbImagen.Dock = DockStyle.Fill;
            pcbImagen.Location = new Point(20, 47);
            pcbImagen.Name = "pcbImagen";
            pcbImagen.Size = new Size(581, 389);
            pcbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImagen.TabIndex = 0;
            pcbImagen.TabStop = false;
            // 
            // FrmEliminarproductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 925);
            Controls.Add(tableLayoutPanelPrincipal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEliminarproductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEliminarproductos";
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

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.TextBox txtPrecioventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGranel;
        private System.Windows.Forms.CheckBox chkUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrep;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtCodigobarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockactual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockminimo;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox pcbImagen;
    }
}