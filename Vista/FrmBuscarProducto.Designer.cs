namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmBuscarProducto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlFondo = new Panel();
            dtgResultados = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pnlTopControles = new Panel();
            lblInstruccion = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            pnlBottomControles = new Panel();
            btnCancelar = new Button();
            btnSeleccionar = new Button();
            pnlHeader.SuspendLayout();
            pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgResultados).BeginInit();
            pnlTopControles.SuspendLayout();
            pnlBottomControles.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(240, 242, 245);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(47, 53, 66);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(385, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Búsqueda de Productos";
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.White;
            pnlFondo.Controls.Add(dtgResultados);
            pnlFondo.Controls.Add(pnlTopControles);
            pnlFondo.Controls.Add(pnlBottomControles);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 60);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Padding = new Padding(20);
            pnlFondo.Size = new Size(984, 501);
            pnlFondo.TabIndex = 1;
            // 
            // dtgResultados
            // 
            dtgResultados.AllowUserToAddRows = false;
            dtgResultados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dtgResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgResultados.BackgroundColor = Color.White;
            dtgResultados.BorderStyle = BorderStyle.None;
            dtgResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgResultados.ColumnHeadersHeight = 40;
            dtgResultados.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 237, 237);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgResultados.DefaultCellStyle = dataGridViewCellStyle3;
            dtgResultados.Dock = DockStyle.Fill;
            dtgResultados.EnableHeadersVisualStyles = false;
            dtgResultados.GridColor = Color.FromArgb(242, 243, 244);
            dtgResultados.Location = new Point(20, 110);
            dtgResultados.MultiSelect = false;
            dtgResultados.Name = "dtgResultados";
            dtgResultados.ReadOnly = true;
            dtgResultados.RowHeadersVisible = false;
            dtgResultados.RowHeadersWidth = 51;
            dtgResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgResultados.RowTemplate.Height = 35;
            dtgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgResultados.Size = new Size(944, 291);
            dtgResultados.TabIndex = 3;
            dtgResultados.CellClick += dtgResultados_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 9;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 9;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Stock";
            Precio.MinimumWidth = 9;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Precio";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // pnlTopControles
            // 
            pnlTopControles.Controls.Add(lblInstruccion);
            pnlTopControles.Controls.Add(txtBusqueda);
            pnlTopControles.Controls.Add(btnBuscar);
            pnlTopControles.Dock = DockStyle.Top;
            pnlTopControles.Location = new Point(20, 20);
            pnlTopControles.Name = "pnlTopControles";
            pnlTopControles.Size = new Size(944, 90);
            pnlTopControles.TabIndex = 6;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(127, 140, 141);
            lblInstruccion.Location = new Point(0, 0);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(560, 36);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Escriba el nombre o descripción del producto:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Font = new Font("Segoe UI", 14F);
            txtBusqueda.Location = new Point(0, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(780, 51);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(52, 152, 219);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(800, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pnlBottomControles
            // 
            pnlBottomControles.Controls.Add(btnCancelar);
            pnlBottomControles.Controls.Add(btnSeleccionar);
            pnlBottomControles.Dock = DockStyle.Bottom;
            pnlBottomControles.Location = new Point(20, 401);
            pnlBottomControles.Name = "pnlBottomControles";
            pnlBottomControles.Size = new Size(944, 80);
            pnlBottomControles.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(450, 20);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "ESC - Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionar.BackColor = Color.FromArgb(46, 204, 113);
            btnSeleccionar.Cursor = Cursors.Hand;
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(670, 20);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(270, 45);
            btnSeleccionar.TabIndex = 4;
            btnSeleccionar.Text = "ENTER - Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // FrmBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 561);
            Controls.Add(pnlFondo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(800, 450);
            Name = "FrmBuscarProducto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Búsqueda Avanzada";
            KeyDown += FrmBuscarProducto_KeyDown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgResultados).EndInit();
            pnlTopControles.ResumeLayout(false);
            pnlTopControles.PerformLayout();
            pnlBottomControles.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel pnlTopControles;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlBottomControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}