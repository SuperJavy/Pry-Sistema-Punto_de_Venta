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
    public partial class FrmAgregarUsuario : Form
    {
        private clsUsuariosController usuario = new clsUsuariosController();
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            usuario.cargarRoles(this);
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedValue == null)
            {
                NotificarUsuario("Por favor, selecciona un rol de la lista.", true);
                return; 
            }

            int idRolSeleccionado = Convert.ToInt32(cmbRol.SelectedValue);

           
            usuario.registrarUsuario(
                txtNombre.Text,
                txtApellidoPaterno.Text,
                txtApellidoMaterno.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtPassword.Text,
                idRolSeleccionado, 
                this
            );
            // Limpiamos los campos en caso de éxito
            LimpiarCampos();
        }

        public void llenarComboRoles(DataTable roles)
        {
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "Id";
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtPassword.Clear();
        }

        // Método público para que el Controlador lance las alertas
        public void NotificarUsuario(string mensaje, bool esError)
        {
            MessageBox.Show(
                mensaje,
                "Gestión de Usuarios",
                MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Warning : MessageBoxIcon.Information
            );
        }


    }
}
