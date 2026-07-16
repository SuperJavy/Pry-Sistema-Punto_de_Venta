using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmLogin : Form
    {
        ClsLoginController LOGIN = new ClsLoginController();
        ClsCorteCajaController controllerCorte = new ClsCorteCajaController();
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                LOGIN.validarcampos(txtUsuario.Text, txtpassword.Text, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return;
            }
        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Al marcarlo como Handled = true, cancelamos la acción de la tecla en el TextBox
                e.Handled = true;
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
                int idUsr = LOGIN.usuario_id;
                if (idUsr <= 0)
                {
                    MessageBox.Show("No se pudo identificar el ID del usuario en sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Preguntamos al Controlador (no al Modelo) si este usuario ya
                    // tiene un corte con fecha_de_cierre = NULL.
                    if (controllerCorte.TieneTurnoAbierto(idUsr))
                    {
                        // El turno sigue abierto. Saltamos la apertura y vamos directo al menú.
                        MessageBox.Show("Se detectó un turno abierto anterior. Retomando la sesión de caja...", "Turno Restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmPrincipal principal = new FrmPrincipal(LOGIN.ROl, txtUsuario.Text, idUsr);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {

                        // Lanzamos la ventana modal obligatoria de apertura de caja
                        using (FrmAperturaCaja frmApertura = new FrmAperturaCaja(idUsr))
                        {
                            if (frmApertura.ShowDialog() == DialogResult.OK)
                            {
                                FrmPrincipal principal = new FrmPrincipal(LOGIN.ROl, txtUsuario.Text, idUsr);
                                principal.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Si el usuario evade la apertura, limpiamos y cerramos sesión
                                txtUsuario.Clear();
                                txtpassword.Clear();
                                txtUsuario.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pcbMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
        }

        private void pcbMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '*';

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar_Click(sender, e);
                //ruido windows
                e.SuppressKeyPress = true;
            }
        }
        
    }
}
