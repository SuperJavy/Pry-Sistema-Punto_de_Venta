using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pry_Sistema_Punto_de_Venta.Controlador;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmAperturaCaja : Form
    {
        ClsCorteCajaController controller = new ClsCorteCajaController();
        private int idUsuarioSesion;
        public FrmAperturaCaja(int idUsuario)
        {
            InitializeComponent();
            this.idUsuarioSesion = idUsuario;
            this.ControlBox = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool abierto = controller.RegistrarApertura(idUsuarioSesion, txtFondoCaja.Text, this);
            if (abierto)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
