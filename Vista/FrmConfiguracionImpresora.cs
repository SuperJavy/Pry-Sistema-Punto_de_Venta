using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Sistema_Punto_de_Venta.Vista
{
    public partial class FrmConfiguracionImpresora : Form
    {
        public FrmConfiguracionImpresora()
        {
            InitializeComponent();
            CargarImpresoras();
        }

        private void CargarImpresoras()
        {
            cmbImpresoras.Items.Clear();

            // Extraemos todas las impresoras instaladas en esta computadora
            foreach (string impresora in PrinterSettings.InstalledPrinters)
            {
                cmbImpresoras.Items.Add(impresora);
            }

            // Leemos qué impresora se había guardado antes en esta computadora
            string impresoraGuardada = Properties.Settings.Default.ImpresoraCaja;

            // Si ya había una guardada y aún existe en Windows, la seleccionamos
            if (!string.IsNullOrEmpty(impresoraGuardada) && cmbImpresoras.Items.Contains(impresoraGuardada))
            {
                cmbImpresoras.SelectedItem = impresoraGuardada;
            }
            else if (cmbImpresoras.Items.Count > 0)
            {
                cmbImpresoras.SelectedIndex = 0; // Seleccionamos la primera por defecto
            }

            // Marcamos o desmarcamos la casilla según la configuración guardada
            chkEsTermica.Checked = Properties.Settings.Default.EsTermica;
        }

        private void btnGuardarImpresora_Click(object sender, EventArgs e)
        {
            if (cmbImpresoras.SelectedItem != null)
            {
                // Guardamos los valores en las variables locales de configuración del sistema
                Properties.Settings.Default.ImpresoraCaja = cmbImpresoras.SelectedItem.ToString();
                Properties.Settings.Default.EsTermica = chkEsTermica.Checked;

                // Confirmamos el guardado en el disco
                Properties.Settings.Default.Save();

                MessageBox.Show("Hardware vinculado exitosamente a esta caja.", "Configuración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una impresora de la lista desplegable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
