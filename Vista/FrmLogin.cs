using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            

            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();


        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = (txtpassword.PasswordChar == '*') ? '\0' : '*';
        }
    }
}
