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

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmCorteCaja : Form
    {
        ClsCorteDiarioController controllerCorte = new ClsCorteDiarioController();
        private int idUsuarioSesion;
        public FrmCorteCaja(int idUsuario)
        {
            InitializeComponent();
            this.idUsuarioSesion = idUsuario;
            this.Load += FrmCorteCaja_Load;
        }

        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            GenerarCorteDelDia();
        }

        private void GenerarCorteDelDia()
        {
            try
            {
                
                // Extraemos los datos reales del turno activo desde la base de datos
                Dictionary<string, decimal> datosCorte = controllerCorte.ObtenerCorteDinamico(idUsuarioSesion);

                // Mapeamos las variables sin datos quemados
                decimal fondoInicial = datosCorte["FondoInicial"];
                decimal ventasEfectivo = datosCorte["VentasEfectivo"];
                decimal salidasCompras = datosCorte["Salidas"];
                decimal totalTickets = datosCorte["TotalTickets"];
                decimal articulosVendidos = datosCorte["ArticulosVendidos"];
                decimal articulosCancelados = datosCorte["ArticulosCancelados"];

                //Cálculos matemáticos de caja
                decimal totalEnCajon = fondoInicial + ventasEfectivo - salidasCompras;

                //Reflejamos los valores exactos en los componentes visuales
                lblFondoValor.Text = fondoInicial.ToString("C2");
                lblVentasEfectivoValor.Text = "+ " + ventasEfectivo.ToString("C2");
                lblSalidasValor.Text = "- " + salidasCompras.ToString("C2");
                lblTotalCajonValor.Text = totalEnCajon.ToString("C2");

                lblTicketsValor.Text = totalTickets.ToString("N0");
                lblArticulosValor.Text = articulosVendidos.ToString("N0");
                lblCanceladosValor.Text = articulosCancelados.ToString("N0");
                lblTotalVentasValor.Text = ventasEfectivo.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar el Corte de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRealizarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                // Extraemos el total esperado
                string totalTexto = lblTotalCajonValor.Text.Replace("$", "").Trim();
                if (!decimal.TryParse(totalTexto, out decimal montoEsperado))
                {
                    MessageBox.Show("No se pudo calcular el monto esperado en caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pedimos al cajero que declare el efectivo
                string respuestaCajero = Interaction.InputBox(
                    "Por favor, cuente el dinero en su gaveta e ingrese la cantidad total final:",
                    "Declaración de Efectivo",
                    "0.00"
                );

                if (string.IsNullOrWhiteSpace(respuestaCajero)) return;

                if (!decimal.TryParse(respuestaCajero, out decimal montoReal) || montoReal < 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad numérica válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Calculamos la diferencia en vivo
                decimal diferencia = montoReal - montoEsperado;
                DialogResult confirmacion;

                //Lógica Profesional de Faltantes/Sobrantes
                if (diferencia < 0)
                {
                    // Hay un FALTANTE
                    confirmacion = MessageBox.Show(
                        $"¡Atención! Hay un FALTANTE de {diferencia:C2} en la caja.\n\n" +
                        $"Esperado: {montoEsperado:C2}\nDeclarado: {montoReal:C2}\n\n" +
                        "¿Está seguro de que desea registrar el corte con este faltante? La aplicación se cerrará.",
                        "Faltante Detectado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                }
                else if (diferencia > 0)
                {
                    // Hay un SOBRANTE
                    confirmacion = MessageBox.Show(
                        $"Hay un SOBRANTE de {diferencia:C2} en la caja.\n\n" +
                        "¿Desea continuar y cerrar el turno?",
                        "Sobrante Detectado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // Corte PERFECTO
                    confirmacion = MessageBox.Show(
                        "El corte cuadra perfectamente.\n\n¿Está seguro de cerrar el turno?",
                        "Corte Perfecto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                }

                //Procedemos al cierre si el cajero aceptó
                if (confirmacion == DialogResult.Yes)
                {
                    bool cerrado = controllerCorte.RegistrarCierreCaja(this.idUsuarioSesion, montoEsperado, montoReal);

                    if (cerrado)
                    {
                        MessageBox.Show("Corte realizado exitosamente. El turno se ha cerrado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
