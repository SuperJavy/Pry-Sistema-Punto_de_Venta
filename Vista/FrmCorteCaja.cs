using Pry_Sistema_Punto_de_Venta.Controlador;
using System.Data;

namespace Pry_Sistema_Punto_de_Venta.Vista
{

    public partial class FrmCorteCaja : Form
    {//Variables de clase
        private int idCorteInterno = 0;
        ClsCorteCajaController controllerCorte = new ClsCorteCajaController();
        private int idUsuarioSesion;
        private string rolUsuario; // Agregado para seguridad por rol
        private decimal montoEsperadoInterno = 0; // Guardará el monto total en memoria, no en el Label
        private Dictionary<string, decimal> datosCorteActivo;
        private int idCajeroSeleccionado = 0;
        private bool cargandoCombo = false;


        //Constructores
        // El contructor recibe el id y rol por seguridad
        public FrmCorteCaja(int idUsuario, string rol)
        {
            InitializeComponent();
            this.idUsuarioSesion = idUsuario;
            this.rolUsuario = rol;
            this.Load += FrmCorteCaja_Load;

            // Cada vez que el cajero escribe el conteo físico, recalculamos en vivo
            // el panel Resumen (Total esperado / Total declarado / Diferencia).
            txtTotalFisico.TextChanged += (s, e) => ActualizarResumen();
            txtTotalFisico.Enter += (s, e) => txtTotalFisico.SelectAll();
        }

        //Metodos
        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            cmbCajerosAbiertos.SelectedIndexChanged -= cmbCajerosAbiertos_SelectedIndexChanged_1;
            cmbCajerosAbiertos.SelectedIndexChanged += cmbCajerosAbiertos_SelectedIndexChanged_1;
            idCajeroSeleccionado = this.idUsuarioSesion;

            AplicarSeguridadPorRol();

            if (EsAdministrador())
            {
                CargarComboCajeros();
            }
            else
            {
                GenerarCorteDelDia();
                ActualizarResumen();
            }
        }
        private bool EsAdministrador()
        {
            if (string.IsNullOrWhiteSpace(this.rolUsuario)) return false;

            string rol = this.rolUsuario.Trim().ToLower();
            return rol == "1" || rol == "admin" || rol == "administrador";
        }
        private void GenerarCorteDelDia()
        {

            try
            {
                Dictionary<string, decimal> datosCorte = controllerCorte.ObtenerCorteDinamico(idCajeroSeleccionado);
                datosCorteActivo = datosCorte;

                // Si no hay un turno abierto para este usuario, avisamos y no dejamos
                if (datosCorte.ContainsKey("TurnoEncontrado") && datosCorte["TurnoEncontrado"] == 0)
                {
                    MessageBox.Show(
                        "No se encontró un turno de caja abierto para este usuario. No es posible generar el corte.",
                        "Sin turno activo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    btnRealizarCorte.Enabled = false;
                    return;
                }

                // Guardamos el id del corte activo (necesario para cerrar el turno correcto,
                // no solo "el que esté abierto para ese usuario").
                this.idCorteInterno = Convert.ToInt32(datosCorte["IdCorte"]);

                // Mapeamos las variables
                decimal fondoInicial = datosCorte["FondoInicial"];
                decimal ventasEfectivo = datosCorte["VentasEfectivo"];
                decimal salidasCompras = datosCorte["Salidas"];
                decimal totalTickets = datosCorte["TotalTickets"];
                decimal articulosVendidos = datosCorte["ArticulosVendidos"];
                decimal articulosCancelados = datosCorte["ArticulosCancelados"];

                // Cálculos matemáticos de caja
                // CORRECCIÓN: las Salidas (pagos a proveedores hechos en efectivo durante
                // el turno) SÍ salen físicamente del cajón, así que deben restarse del
                // total esperado. Antes se leían de la BD pero nunca se aplicaban al
                // cálculo, lo que generaba "faltantes" falsos cada vez que se pagaba
                // algo en efectivo desde la caja.
                // Se elimina la resta de salidasCompras para no causar saldos negativos
                decimal totalEnCajon = fondoInicial + ventasEfectivo;

                // GUARDAMOS EL MONTO REAL EN LA VARIABLE INTERNA (Indispensable para el botón de cierre)
                this.montoEsperadoInterno = totalEnCajon;

                // Reflejamos los valores exactos en los componentes visuales
                lblFondoValor.Text = fondoInicial.ToString("C2");
                lblVentasEfectivoValor.Text = "+ " + ventasEfectivo.ToString("C2");
                // lblSalidasValor.Text = "- " + salidasCompras.ToString("C2"); // Descomentar si el control existe en el diseñador
                lblTotalCajonValor.Text = totalEnCajon.ToString("C2");

                lblTicketsValor.Text = totalTickets.ToString("N0");
                lblArticulosValor.Text = articulosVendidos.ToString("N0");
                lblCanceladosValor.Text = articulosCancelados.ToString("N0");
                lblTotalEsperadoInfo.Text = totalEnCajon.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar el Corte de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para aplicar el "Corte Ciego"
        private void AplicarSeguridadPorRol()
        {
            bool esAdmin = EsAdministrador();

            // Controles exclusivos del dueño
            cmbCajerosAbiertos.Visible = esAdmin;
            //lblAuditar.Visible = esAdmin;
            if (!EsAdministrador())
            {
                lblFondoValor.Text = "$ ****.**";
                lblVentasEfectivoValor.Text = "$ ****.**";
                //lblSalidasValor.Text = "$ ****.**";
                lblTotalCajonValor.Text = "$ ****.**";
            }
        }
        private void ActualizarResumen()
        {
            decimal.TryParse(txtTotalFisico.Text, out decimal montoDeclarado);
            decimal diferencia = montoDeclarado - montoEsperadoInterno;

            lblResumenEsperado.Text = EsAdministrador()
                ? montoEsperadoInterno.ToString("C2")
                : "$ ****.**";

            lblTotalContadoResumen.Text = montoDeclarado.ToString("C2");
            lblResumenDiferencia.Text = diferencia.ToString("C2");

            if (diferencia < 0)
            {
                lblResumenDiferencia.ForeColor = Color.FromArgb(231, 76, 60);
                pnlAlertaDiferencia.BackColor = Color.FromArgb(253, 237, 237);
                lblAlertaEstado.ForeColor = Color.FromArgb(192, 57, 43);
                lblAlertaEstado.Text = "⚠ Faltante en caja";
                pnlAlertaDiferencia.Visible = true;
            }
            else if (diferencia > 0)
            {
                lblResumenDiferencia.ForeColor = Color.FromArgb(39, 174, 96);
                pnlAlertaDiferencia.BackColor = Color.FromArgb(234, 250, 241);
                lblAlertaEstado.ForeColor = Color.FromArgb(30, 132, 73);
                lblAlertaEstado.Text = "✔ Sobrante en caja";
                pnlAlertaDiferencia.Visible = true;
            }
            else
            {
                lblResumenDiferencia.ForeColor = Color.FromArgb(44, 62, 80);
                pnlAlertaDiferencia.Visible = false;
            }
        }
        private void btnRealizarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomamos el monto matemático directo de nuestra variable interna
                decimal montoEsperado = this.montoEsperadoInterno;

                // El cajero ya declaró el efectivo en el panel "Declaración de Efectivo"
                // (txtTotalFisico), que además ya se refleja en vivo en el Resumen.
                // Ya no usamos un InputBox aparte: sería pedir el mismo dato dos veces.
                if (!decimal.TryParse(txtTotalFisico.Text, out decimal montoReal) || montoReal < 0)
                {
                    MessageBox.Show(
                        "Ingrese en 'Total físico' la cantidad contada en caja (un número válido) antes de cerrar el turno.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTotalFisico.Focus();
                    return;
                }

                // Calculamos la diferencia en vivo
                decimal diferencia = montoReal - montoEsperado;
                DialogResult confirmacion;

                // Lógica Profesional de Faltantes/Sobrantes (Con seguridad de visualización)
                if (diferencia < 0)
                {
                    // FALTANTE
                    string alerta = EsAdministrador() ?
                        $"¡Atención! Hay un FALTANTE de {diferencia:C2} en la caja.\n\nEsperado: {montoEsperado:C2}\nDeclarado: {montoReal:C2}\n\n¿Está seguro de que desea registrar el corte con este faltante?" :
                        $"¡Atención! Se ha detectado una diferencia negativa en la caja.\n\n¿Está seguro de que su conteo de {montoReal:C2} es correcto? La aplicación se cerrará y guardará el reporte.";

                    confirmacion = MessageBox.Show(alerta, "Diferencia Detectada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else if (diferencia > 0)
                {
                    // SOBRANTE
                    string alerta = EsAdministrador() ?
                        $"Hay un SOBRANTE de {diferencia:C2} en la caja.\n\n¿Desea continuar y cerrar el turno?" :
                        $"Se ha detectado una diferencia positiva en la caja.\n\n¿Desea continuar y cerrar el turno con su declaración de {montoReal:C2}?";

                    confirmacion = MessageBox.Show(alerta, "Diferencia Detectada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    // PERFECTO
                    confirmacion = MessageBox.Show(
                        "El corte ha sido validado.\n\n¿Está seguro de cerrar el turno?",
                        "Corte de Caja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                }

                // Procedemos al cierre si el cajero aceptó
                if (confirmacion == DialogResult.Yes)
                {
                    bool cerrado = controllerCorte.RegistrarCierreCaja(this.idCorteInterno, this.idCajeroSeleccionado, montoEsperado, montoReal);

                    if (cerrado)
                    {
                        MessageBox.Show("Corte realizado exitosamente. El turno se ha cerrado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // CORRECCIÓN: antes se llamaba Application.Exit() sin importar el rol.
                        // Eso rompía la auditoría en lote del admin: cerraba TODA la aplicación
                        // apenas cerraba el primer turno del combo, impidiéndole seguir con los
                        // demás cajeros pendientes. Un cajero normal cierra su propio turno y
                        // termina su sesión (comportamiento original); el admin, en cambio,
                        // se queda en la pantalla y recarga la lista de turnos aún abiertos.
                        if (EsAdministrador())
                        {
                            txtTotalFisico.Clear();
                            CargarComboCajeros();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo registrar el cierre (es posible que este turno ya haya sido cerrado desde otra sesión).",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            ClsPrincipal principal = new ClsPrincipal();
            // Se pasa la sesión activa para que el historial filtre por cajero
            // según el rol (un cajero solo ve lo suyo; el admin ve a todos).
            FrmHistorialCortes frmHistorial = new FrmHistorialCortes(idUsuarioSesion, rolUsuario);

            // Obtenemos el panel contenedor que está un nivel arriba (en el formulario padre)
            Panel contenedorPadre = this.Parent as Panel;

            if (contenedorPadre != null)
            {
                principal.agregaralcontenedor(frmHistorial, contenedorPadre);
            }
            else
            {
                // CORRECCIÓN: antes, si no se encontraba el contenedor padre, el clic
                // simplemente no hacía nada y el usuario se quedaba sin saber por qué.
                MessageBox.Show(
                    "No se pudo abrir el historial de cortes (no se encontró el contenedor de navegación).",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnImprimirCorte_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validamos que exista información cargada del turno
                if (datosCorteActivo == null || !datosCorteActivo.ContainsKey("TurnoEncontrado") || datosCorteActivo["TurnoEncontrado"] == 0)
                {
                    MessageBox.Show("No hay un turno activo cargado para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Tomamos el monto esperado matemático
                decimal montoEsperado = this.montoEsperadoInterno;

                // 3. CORRECCIÓN: Leemos la declaración, pero no bloqueamos si está vacía.
                // Si está en blanco o tiene letras, asume 0m. 
                decimal montoReal = 0m;
                if (!string.IsNullOrWhiteSpace(txtTotalFisico.Text))
                {
                    decimal.TryParse(txtTotalFisico.Text, out montoReal);
                }

                // 4. Calculamos la diferencia al vuelo
                decimal diferencia = montoReal - montoEsperado;

                // 5. Enviamos a imprimir SIN cerrar la base de datos
                ClsTicketController ticketCtrl = new ClsTicketController();

                // Ojo: Asegúrate de tener implementada tu variable nombreImpresora y esTermica
                ticketCtrl.ImprimirTicketCorte(
                    datosCorteActivo,
                    montoEsperado,
                    montoReal,
                    diferencia,
                    idUsuarioSesion.ToString(),
                    "", // Impresora por defecto
                    true); // Asumo true = térmica para el ejemplo, ajústalo según tu configuración

                MessageBox.Show("El ticket previo se ha enviado a la impresora.\n\nRecuerde que el turno aún NO ha sido cerrado.", "Impresión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar imprimir el ticket: " + ex.Message, "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboCajeros()
        {
            cargandoCombo = true;
            try
            {
                DataTable dtCajeros = controllerCorte.ObtenerCajerosConTurnoAbierto();

                if (dtCajeros.Rows.Count > 0)
                {
                    cmbCajerosAbiertos.DisplayMember = "nombre";
                    cmbCajerosAbiertos.ValueMember = "id";
                    cmbCajerosAbiertos.DataSource = dtCajeros;

                    // Forzamos a cargar el primer cajero de la lista
                    cmbCajerosAbiertos.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No hay turnos pendientes por auditar y cerrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCajerosAbiertos.DataSource = null;
                    btnRealizarCorte.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargandoCombo = false;

            // Si hay datos, disparamos la carga de la pantalla manualmente la primera vez
            if (cmbCajerosAbiertos.Items.Count > 0)
            {
                cmbCajerosAbiertos_SelectedIndexChanged_1(null, null);
            }
        }
        // 2. Evento del ComboBox que actualiza toda la pantalla
        private void cmbCajerosAbiertos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cargandoCombo || cmbCajerosAbiertos.SelectedIndex < 0) return;

            try
            {
                //Extraer el ID directamente de la fila de datos
                if (cmbCajerosAbiertos.SelectedItem is DataRowView filaSeleccionada)
                {
                    this.idCajeroSeleccionado = Convert.ToInt32(filaSeleccionada["id"]);
                }
                else if (cmbCajerosAbiertos.SelectedValue != null)
                {
                    this.idCajeroSeleccionado = Convert.ToInt32(cmbCajerosAbiertos.SelectedValue);
                }

                txtTotalFisico.Clear();

                // Recargamos los cálculos con el ID correcto
                GenerarCorteDelDia();
                ActualizarResumen();
            }
            catch { }
        }
    }
}