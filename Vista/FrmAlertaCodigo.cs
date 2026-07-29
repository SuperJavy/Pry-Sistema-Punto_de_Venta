using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmAlertaCodigo : Form
    {
        public FrmAlertaCodigo()
        {
            InitializeComponent();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void pcbMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '*';
            txtpassword.Invalidate();
            txtpassword.Update();
        }
        private void pcbMostrar_MouseDown(object sender, MouseEventArgs e)
        {

            txtpassword.PasswordChar = '\0';
            txtpassword.Invalidate();
            txtpassword.Update();
        }
        public string PasswordIngresado
        {
            get { return txtpassword.Text; }
        }
    }
}
