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