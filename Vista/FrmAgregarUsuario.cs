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

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmAgregarUsuario : Form
    {
        private clsUsuariosController usuario = new clsUsuariosController();
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

       

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            
            // Limpiamos los campos en caso de éxito
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
                txtNombre.Clear();
                txtApellidoPaterno.Clear();
                txtApellidoMaterno.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtPassword.Clear();
        }
    
    }
}
