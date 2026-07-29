using Pry_Sistema_Punto_de_Venta.Controlador;
using System.Data;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmPerfil : Form
    {
        ClsPerfilController perfilController = new ClsPerfilController();
        private string usuario;
        public FrmPerfil(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            CargarPerfil();

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtUsuario.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;
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
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            bool hayVentaPendiente = false;
            foreach (Form formularioAbierto in Application.OpenForms)
            {
                if (formularioAbierto is FrmVentas ventanaVentas && ventanaVentas.ventaPendiente)
                {
                    hayVentaPendiente = true;
                    break;
                }
            }

            if (hayVentaPendiente)
            {
                MessageBox.Show("No se puede cerrar sesión en este momento.\n\nDejaste una operación a la mitad. Por favor, regresa a la pantalla de Ventas o Compras y termina de cobrar, o cancela el ticket para poder salir.",
                    "Operaciones Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro que deseas salir del sistema?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmacion == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        public void CargarPerfil()
        {
            DataTable dtPerfil = perfilController.ObtenerPerfil(usuario);
            if (dtPerfil.Rows.Count > 0)
            {
                DataRow row = dtPerfil.Rows[0];
                txtNombre.Text = row["nombre"].ToString();
                txtApellido.Text = row["apellido_paterno"].ToString();
                txtUsuario.Text = row["nickname"].ToString();
                txtCorreo.Text = row["correo"].ToString();
                txtTelefono.Text = row["telefono"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información del perfil.");
            }
        }

        private void btnGuardarContrasena_Click(object sender, EventArgs e)
        {
            perfilController.Actualizarpassword(usuario, txtPassword.Text, this);
        }

        private void pcbMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pcbMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardarContrasena_Click(sender, e);
                //ruido windows
                e.SuppressKeyPress = true;
            }
        }
    }
}