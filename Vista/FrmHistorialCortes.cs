using Pry_Sistema_Punto_de_Venta.Controlador;
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
    public partial class FrmHistorialCortes : Form
    {
        private readonly ClsCorteCajaController controller = new ClsCorteCajaController();
        private readonly int idUsuarioSesion;
        private readonly string rolUsuario;

        // Copia en memoria del último resultado de búsqueda, para poder pintar
        // el panel de detalle sin volver a consultar la base de datos
        private List<Dictionary<string, object>> historialActual = new List<Dictionary<string, object>>();

        // Constructor, recibe la sesión activa (idUsuario y rol) que viene
        public FrmHistorialCortes(int idUsuarioSesion, string rol)
        {
            InitializeComponent();

            this.idUsuarioSesion = idUsuarioSesion;
            this.rolUsuario = string.IsNullOrWhiteSpace(rol) ? "Cajero" : rol;

            this.Load += FrmHistorialCortes_Load;
            btnBuscar.Click += btnBuscar_Click;
            lblLimpiar.LinkClicked += lblLimpiar_LinkClicked;
            dgvHistorialCortes.SelectionChanged += dgvHistorialCortes_SelectionChanged;
            btnReimprimir.Click += btnReimprimir_Click;
        }

        private void FrmHistorialCortes_Load(object sender, EventArgs e)
        {
            ConfigurarPermisosPorRol();
            CargarFiltrosIniciales();
            BuscarHistorial();
        }

        private void ConfigurarPermisosPorRol()
        {
            bool esAdmin = (rolUsuario == "Administrador" || rolUsuario == "1");
            lblCajero.Visible = esAdmin;
            cmbCajero.Visible = esAdmin;
        }

        private void CargarFiltrosIniciales()
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;

            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new object[] { "Todos", "Cuadrado", "Faltante", "Sobrante", "Abierto" });
            cmbEstado.SelectedIndex = 0;

            cmbCajero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajero.DisplayMember = "Nombre";
            cmbCajero.Items.Clear();
            cmbCajero.Items.Add(new CajeroItem(0, "Todos"));

            if (rolUsuario == "Administrador" || rolUsuario == "1")
            {
                try
                {
                    var cajeros = controller.ObtenerCajeros();
                    foreach (var kvp in cajeros)
                    {
                        cmbCajero.Items.Add(new CajeroItem(kvp.Key, kvp.Value));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la lista de cajeros: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            cmbCajero.SelectedIndex = 0;

            LimpiarDetalle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarHistorial();
        }

        private void lblLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarFiltrosIniciales();
            BuscarHistorial();
        }

        private void BuscarHistorial()
        {
            try
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                if (hasta < desde)
                {
                    MessageBox.Show("La fecha 'Hasta' no puede ser anterior a la fecha 'Desde'.",
                        "Filtro inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCajero = 0;

                // CORRECCIÓN: Aplicamos la misma regla de rol aquí
                if (rolUsuario == "Administrador" || rolUsuario == "1")
                {
                    if (cmbCajero.SelectedItem is CajeroItem cajeroSeleccionado)
                        idCajero = cajeroSeleccionado.Id;
                }
                else
                {
                    // Un cajero no elige: siempre ve solo lo suyo.
                    idCajero = idUsuarioSesion;
                }

                string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

                historialActual = controller.ObtenerHistorial(desde, hasta, idCajero, estado);

                PintarGrid(historialActual);
                PintarMetricas(historialActual);
                LimpiarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el historial de cortes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PintarGrid(List<Dictionary<string, object>> historial)
        {
            dgvHistorialCortes.Columns.Clear();
            dgvHistorialCortes.Rows.Clear();
            dgvHistorialCortes.AutoGenerateColumns = false;

            dgvHistorialCortes.Columns.Add("colId", "ID");
            dgvHistorialCortes.Columns.Add("colFecha", "Fecha");
            dgvHistorialCortes.Columns.Add("colCajero", "Cajero");
            dgvHistorialCortes.Columns.Add("colFondo", "Fondo inicial");
            dgvHistorialCortes.Columns.Add("colEsperado", "Total esperado");
            dgvHistorialCortes.Columns.Add("colReal", "Total real");
            dgvHistorialCortes.Columns.Add("colDiferencia", "Diferencia");
            dgvHistorialCortes.Columns.Add("colEstado", "Estado");
            dgvHistorialCortes.Columns["colId"].Visible = false;

            foreach (var fila in historial)
            {
                DateTime fechaInicial = (DateTime)fila["FechaInicial"];
                string estado = fila["Estado"]?.ToString() ?? "";
                decimal fondo = (decimal)fila["MontoInicial"];
                decimal esperado = (decimal)fila["MontoEsperado"];

                object realObj = fila["MontoReal"];
                string realTxt = realObj == null ? "—" : ((decimal)realObj).ToString("C2");

                object difObj = fila["Diferencia"];
                string difTxt = difObj == null ? "—" : ((decimal)difObj).ToString("C2");

                int idxFila = dgvHistorialCortes.Rows.Add(
                    fila["IdCorte"],
                    fechaInicial.ToString("dd/MM/yyyy HH:mm"),
                    fila["Cajero"],
                    fondo.ToString("C2"),
                    esperado.ToString("C2"),
                    realTxt,
                    difTxt,
                    estado
                );

                Color colorEstado = estado switch
                {
                    "Faltante" => Color.FromArgb(231, 76, 60),
                    "Sobrante" => Color.FromArgb(39, 174, 96),
                    "Abierto" => Color.FromArgb(41, 128, 185),
                    _ => Color.FromArgb(44, 62, 80)
                };
                dgvHistorialCortes.Rows[idxFila].Cells["colEstado"].Style.ForeColor = colorEstado;
                dgvHistorialCortes.Rows[idxFila].Cells["colDiferencia"].Style.ForeColor = colorEstado;
            }
        }

        private void PintarMetricas(List<Dictionary<string, object>> historial)
        {
            lblM1Valor.Text = historial.Count.ToString();

            decimal totalDiferencia = 0m;
            int conFaltante = 0;

            foreach (var fila in historial)
            {
                if (fila["Diferencia"] is decimal dif)
                {
                    totalDiferencia += dif;
                    if (dif < 0) conFaltante++;
                }
            }

            lblM2Valor.Text = totalDiferencia.ToString("C2");
            lblM2Valor.ForeColor = totalDiferencia < 0
                ? Color.FromArgb(231, 76, 60)
                : Color.FromArgb(39, 174, 96);

            lblM3Valor.Text = conFaltante.ToString();
        }

        private void dgvHistorialCortes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistorialCortes.SelectedRows.Count == 0)
            {
                LimpiarDetalle();
                return;
            }
            int idCorte = Convert.ToInt32(dgvHistorialCortes.SelectedRows[0].Cells["colId"].Value);
            var detalle = historialActual.FirstOrDefault(h => (int)h["IdCorte"] == idCorte);

            if (detalle == null)
            {
                LimpiarDetalle();
                return;
            }

            string cajero = detalle["Cajero"]?.ToString() ?? "";
            DateTime fechaInicial = (DateTime)detalle["FechaInicial"];
            decimal fondo = (decimal)detalle["MontoInicial"];
            decimal esperado = (decimal)detalle["MontoEsperado"];
            decimal diferencia = detalle["Diferencia"] is decimal d ? d : 0m;

            lblDetalleTitulo.Text = $"Detalle — {fechaInicial:dd/MM/yyyy}, {cajero}";
            lblDetalleFondoVal.Text = fondo.ToString("C2");
            lblDetalleEsperadoVal.Text = esperado.ToString("C2");
            lblDetalleDiferenciaVal.Text = diferencia.ToString("C2");
            lblDetalleDiferenciaVal.ForeColor = diferencia < 0
                ? Color.FromArgb(231, 76, 60)
                : diferencia > 0
                    ? Color.FromArgb(39, 174, 96)
                    : Color.FromArgb(44, 62, 80);

            btnReimprimir.Enabled = true;
            btnReimprimir.Tag = idCorte;
        }
        private void LimpiarDetalle()
        {
            lblDetalleTitulo.Text = "Detalle — selecciona un corte";
            lblDetalleFondoVal.Text = "—";
            lblDetalleEsperadoVal.Text = "—";
            lblDetalleDiferenciaVal.Text = "—";
            lblDetalleDiferenciaVal.ForeColor = Color.FromArgb(44, 62, 80);
            btnReimprimir.Enabled = false;
            btnReimprimir.Tag = null;
        }
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (btnReimprimir.Tag is int idCorte)
            {
                MessageBox.Show($"Reimprimiendo comprobante del corte #{idCorte}...",
                    "Reimprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private class CajeroItem
        {
            public int Id { get; }
            public string Nombre { get; }
            public CajeroItem(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }
            public override string ToString() => Nombre;
        }

        private void btnReimprimir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
