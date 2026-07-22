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
using Microsoft.VisualBasic;
using Pry_Sistema_Punto_de_Venta.Controlador;
using Pry_Sistema_Punto_de_Venta.Controlador.Pry_Sistema_Punto_de_Venta.Controlador;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    // CAPA VISTA: solo dibuja datos y reacciona a clics. Nunca abre una conexión
    // ni arma una consulta SQL directamente — todo pasa por ClsCorteCajaController.
    public partial class FrmCorteCaja : Form
    {
        private int idCorteInterno = 0;

        // Antes: "ClsCorteDiarioController" — esa clase no existe en el proyecto;
        // el controlador real que expone ObtenerCorteDinamico/RegistrarCierreCaja
        // es ClsCorteCajaController (ver ClsCorteCajaController.cs).
        ClsCorteCajaController controllerCorte = new ClsCorteCajaController();
        private int idUsuarioSesion;
        private string rolUsuario; // Agregado para seguridad por rol
        private decimal montoEsperadoInterno = 0; // Guardará el monto total en memoria, no en el Label

        // Actualizamos el constructor para recibir el ID y el Rol
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

        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            GenerarCorteDelDia();
            AplicarSeguridadPorRol(); // Se ejecuta después de cargar los datos
            ActualizarResumen();      // Pinta el panel Resumen con el estado inicial
        }

        // ÚNICO punto de verdad para saber si el usuario en sesión es administrador.
        // La tabla `rol` define id 1 = Administrador, id 2 = Cajero, y el resto del
        // sistema (ver FrmPrincipal.IntentarAcceso) usa el id_rol como texto ("1"),
        // por eso "1" es la comparación principal. Se dejan "admin"/"administrador"
        // como respaldo por si en algún punto de login se guarda el nombre del rol
        // en vez del id.
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
                // Extraemos los datos reales del turno activo desde la base de datos
                Dictionary<string, decimal> datosCorte = controllerCorte.ObtenerCorteDinamico(idUsuarioSesion);

                // Si no hay un turno abierto para este usuario, avisamos y no dejamos
                // que se realice un corte "fantasma" de $0.00 (antes esto pasaba silenciosamente).
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

                // Mapeamos las variables sin datos quemados
                decimal fondoInicial = datosCorte["FondoInicial"];
                decimal ventasEfectivo = datosCorte["VentasEfectivo"];
                decimal salidasCompras = datosCorte["Salidas"];
                decimal totalTickets = datosCorte["TotalTickets"];
                decimal articulosVendidos = datosCorte["ArticulosVendidos"];
                decimal articulosCancelados = datosCorte["ArticulosCancelados"];

                // Cálculos matemáticos de caja
                decimal totalEnCajon = fondoInicial + ventasEfectivo;

                // GUARDAMOS EL MONTO REAL EN LA VARIABLE INTERNA (Indispensable para el botón de cierre)
                this.montoEsperadoInterno = totalEnCajon;

                // Reflejamos los valores exactos en los componentes visuales
                lblFondoValor.Text = fondoInicial.ToString("C2");
                lblVentasEfectivoValor.Text = "+ " + ventasEfectivo.ToString("C2");
                lblTotalCajonValor.Text = totalEnCajon.ToString("C2");

                lblTicketsValor.Text = totalTickets.ToString("N0");
                lblArticulosValor.Text = articulosVendidos.ToString("N0");
                lblCanceladosValor.Text = articulosCancelados.ToString("N0");
                lblTotalEsperadoInfo.Text = totalEnCajon.ToString("C2");
                // (Antes había aquí una segunda asignación a lblTotalCajonValor con
                // "ventasEfectivo", que pisaba el valor correcto de totalEnCajon puesto
                // arriba. Se quitó: ese label es el "Total esperado" y debe reflejar
                // fondo + ventas - salidas, no solo las ventas en efectivo.)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar el Corte de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para aplicar el "Corte Ciego"
        private void AplicarSeguridadPorRol()
        {
            // Ocultamos TODOS los componentes del cálculo si el usuario NO es administrador.
            // Antes solo se ocultaba lblTotalCajonValor, pero el cajero podía ver
            // fondo + ventas - salidas y sacar el total esperado a mano con calculadora,
            // lo cual anulaba por completo el propósito del corte ciego.
            if (!EsAdministrador())
            {
                lblFondoValor.Text = "$ ****.**";
                lblVentasEfectivoValor.Text = "$ ****.**";
                //lblSalidasValor.Text = "$ ****.**";
                lblTotalCajonValor.Text = "$ ****.**";
            }
        }

        // Calcula y pinta el panel "Resumen" (Total esperado / Total declarado / Diferencia)
        // a partir de lo que el cajero va escribiendo en txtTotalFisico. Se llama al cargar
        // el formulario y cada vez que ese textbox cambia, así el cajero ve la diferencia
        // en vivo antes de confirmar el corte.
        private void ActualizarResumen()
        {
            decimal.TryParse(txtTotalFisico.Text, out decimal montoDeclarado);
            decimal diferencia = montoDeclarado - montoEsperadoInterno;

            // El total esperado en el Resumen respeta el mismo corte ciego que el
            // panel de "Información del sistema": un cajero no debe poder leerlo aquí.
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

        private void btnRealizarCorte_Click_1(object sender, EventArgs e)
        {

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
                        $"¡Atención! Hay un FALTANTE de {diferencia:C2} en la caja.\n\nEsperado: {montoEsperado:C2}\nDeclarado: {montoReal:C2}\n\n¿Está seguro de que desea registrar el corte con este faltante? La aplicación se cerrará." :
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
                    bool cerrado = controllerCorte.RegistrarCierreCaja(this.idCorteInterno, this.idUsuarioSesion, montoEsperado, montoReal);

                    if (cerrado)
                    {
                        MessageBox.Show("Corte realizado exitosamente. El turno se ha cerrado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
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
        }
    }
}