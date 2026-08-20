using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo.Entidades;
using System.Data;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmAgregarUsuario : Form
    {
        private clsUsuariosController usuario = new clsUsuariosController();
        private encryptado md5 = new encryptado();

        public FrmAgregarUsuario()
        {
            InitializeComponent();
            usuario.cargarRoles(this);
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
            txtNombreUsuario.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
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
        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length > 8)
            {
                NotificarUsuario("La contraseña no puede estar vacía y debe tener un máximo de 8 caracteres.", true);
                return; // Detiene el proceso de guardado
            }
            if (cmbRol.SelectedValue == null)
            {
                NotificarUsuario("Por favor, selecciona un rol de la lista.", true);
                return;
            }

            int idRolSeleccionado = Convert.ToInt32(cmbRol.SelectedValue);

            string pass = txtPassword.Text;
            string passSegura = md5.EncryptPassword(pass);
            usuario.registrarUsuario(
                txtNombre.Text,
                txtApellidoPaterno.Text,
                txtApellidoMaterno.Text,
                txtNombreUsuario.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                passSegura,
                idRolSeleccionado,
                this
            );
            // Limpiamos los campos en caso de éxito
            LimpiarCampos();
        }
    }
}
