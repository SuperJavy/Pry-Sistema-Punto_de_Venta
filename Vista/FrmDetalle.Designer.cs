namespace Pry_Sistema_Punto_de_Venta.Vista
{
    partial class FrmDetalle
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
            dtgDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgDetalles).BeginInit();
            SuspendLayout();
            // 
            // dtgDetalles
            // 
            dtgDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDetalles.Location = new Point(12, 12);
            dtgDetalles.Name = "dtgDetalles";
            dtgDetalles.RowHeadersWidth = 72;
            dtgDetalles.Size = new Size(776, 426);
            dtgDetalles.TabIndex = 0;
            // 
            // FrmDetalle
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgDetalles);
            Name = "FrmDetalle";
            Text = "FrmDetalle";
            ((System.ComponentModel.ISupportInitialize)dtgDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgDetalles;
    }
}