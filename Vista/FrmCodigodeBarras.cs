using Pry_Sistema_Punto_de_Venta.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmCodigodeBarras : Form
    {
        ClsProductController controller = new ClsProductController();
        private TextBox  _textBoxDestino;
        public FrmCodigodeBarras()
        {
            InitializeComponent();
        }
        public FrmCodigodeBarras(TextBox cajaDeTextoDeLaOtraPantalla)
        {
            InitializeComponent();
            _textBoxDestino = cajaDeTextoDeLaOtraPantalla;
            if (_textBoxDestino != null && !string.IsNullOrEmpty(_textBoxDestino.Text))
            {
                txtCodigo.Text = _textBoxDestino.Text;
            }
        }
        public void notificarUsuario(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = controller.generarcode(this);
                Image image = controller.imgec(txtCodigo.Text, this);

                if (image != null)
                {
                    picCodigoBarras.Image = image;
                }
            }
            else
            {
                Image image = controller.imgec(txtCodigo.Text, this);

                if (image != null)
                {
                    picCodigoBarras.Image = image;
                }
            }
            string c =txtCodigo.Text;
            controller.Existentecode(c,this);
        }
    
        private void btnUsarcode_Click(object sender, EventArgs e)
        {
            string c = txtCodigo.Text;
           
            if (_textBoxDestino != null)
            {
                _textBoxDestino.Text = this.txtCodigo.Text;
                controller.InsertCodeBD(c, picCodigoBarras.Image, this);
            }

            this.Close();

            
        }

        public void limpiarcaja()
        {
            txtCodigo.Clear();
            picCodigoBarras.Image= null;
        }
    }
}
