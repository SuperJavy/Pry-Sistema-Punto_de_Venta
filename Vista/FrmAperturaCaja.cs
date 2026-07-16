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

        // Guardamos el id del corte recién abierto por si algún formulario
        // posterior (por ejemplo el de ventas) necesita saber cuál es.
        public int IdCorteAbierto { get; private set; }

        public FrmAperturaCaja(int idUsuario)
        {
            InitializeComponent();
            this.idUsuarioSesion = idUsuario;
            this.ControlBox = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // RegistrarApertura ya no recibe "this" (el Form) y ya no retorna
            // un simple bool: ahora retorna una tupla (exito, idCorte, mensaje).
            // El controlador ya no muestra el MessageBox por su cuenta, así que
            // la vista es responsable de mostrarlo aquí.
            var resultado = controller.RegistrarApertura(idUsuarioSesion, txtFondoCaja.Text);

            if (!resultado.exito)
            {
                MessageBox.Show(resultado.mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.IdCorteAbierto = resultado.idCorte;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}