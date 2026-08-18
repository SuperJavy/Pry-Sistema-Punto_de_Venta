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

namespace Pry_Sistema_Punto_de_Venta
{
    public partial class FrmModoficar : Form
    {
        ClsProductController controlador = new ClsProductController();
        private string _codigoCargado = null;
        private bool _cargandoDatos = false;
        public FrmModoficar()
        {
            InitializeComponent();

            DataTable roles = controlador.Cargarcategoriasm(this);
            llenarComboRoles(roles);
            txtStockactual.ReadOnly = true;
            txtStockminimo.ReadOnly = true;
            chkUnidad.CheckedChanged += ChkUnidad_CheckedChanged;
            chkGranel.CheckedChanged += ChkGranel_CheckedChanged;
        }
        private void ChkUnidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnidad.Checked) chkGranel.Checked = false;
        }

        private void ChkGranel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGranel.Checked) chkUnidad.Checked = false;
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
        public void llenarCampos(DataTable dtproducto)
        {


            if (dtproducto != null && dtproducto.Rows.Count > 0)
            {
                DataRow producto = dtproducto.Rows[0];

                txtNombrep.Text = producto["nombre"].ToString();
                txtDescripcion.Text = producto["Descripcion"].ToString();

                if (dtproducto.Columns.Contains("Categoria_id"))
                {
                    cbxCategoria.SelectedValue = producto["Categoria_id"];
                }

                string tipoVenta = producto["id_tipo_venta"].ToString();
                if (tipoVenta == "1")
                {
                    chkUnidad.Checked = true;
                    chkGranel.Checked = false;
                }
                else
                {
                    chkUnidad.Checked = false;
                    chkGranel.Checked = true;
                }

                txtCosto.Text = producto["Costo"].ToString();
                nudPorcentaje.Value = Convert.ToInt16(producto["Porcentaje"]);
                txtPrecioventa.Text = producto["precio_venta"].ToString();

                txtStockactual.Text = producto["Stock"].ToString();
                txtStockminimo.Text = producto["Stock_minimo"].ToString();
                if (dtproducto.Columns.Contains("Ruta_imagen") && producto["Ruta_imagen"] != DBNull.Value)
                {
                    try
                    {
                        // Extracción directa: MySQL ya nos manda el arreglo de bytes real
                        byte[] imagenBytes = (byte[])producto["Ruta_imagen"];

                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBytes))
                            {
                                pcbImagen.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pcbImagen.Image = null;
                        }
                    }
                    catch (ArgumentException)
                    {
                        // Si la imagen en la BD guardada anteriormente sigue corrupta, no congelará el sistema
                        pcbImagen.Image = null;
                    }
                }
                else
                {
                    pcbImagen.Image = null;
                }
                _codigoCargado = producto["codigo_efectivo"].ToString().Trim();
                _cargandoDatos = false;
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void LimpiarFormulario()
        {
            _codigoCargado = null;
            txtNombrep.Clear();
            txtDescripcion.Clear();
            cbxCategoria.SelectedIndex = -1;
            chkUnidad.Checked = false;
            chkGranel.Checked = false;
            txtCosto.Clear();
            nudPorcentaje.Value = 0;
            txtPrecioventa.Clear();
            txtStockactual.Clear();
            txtStockminimo.Clear();
        }


        private void txtCodigodebarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtCodigodebarras.Text.Trim();

                DataTable dt = controlador.BuscarPro(codigo, this);
                llenarCampos(dt);

                // Evita el sonido molesto "beep" de Windows al dar Enter
                e.SuppressKeyPress = true;
            }
        }


        public void llenarComboRoles(DataTable dtCategoria)
        {
            if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            {
                cbxCategoria.DataSource = null; // Limpia 

                // 2. Asignación de miembros 
                cbxCategoria.DisplayMember = "Nombre";
                cbxCategoria.ValueMember = "Id";

                // 3. Asignación del origen de datos
                cbxCategoria.DataSource = dtCategoria;
            }
            else
            {
                // Opcional: Limpiar el combo si no hay datos
                cbxCategoria.DataSource = null;
            }
        }

        private void txtPrecioventa_TextChanged(object sender, EventArgs e)
        {
            txtPrecioventa.ReadOnly = true;
        }

        private void txtNombrep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
            buscador.Title = "Seleccionar Logo del Negocio";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                pcbImagen.Image = Image.FromFile(buscador.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipoventa = 0;
            if (chkUnidad.Checked)
            {
                tipoventa = 1;
            }
            else if (chkGranel.Checked)
            {
                tipoventa = 2;
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un tipo de venta");
                return;
            }
            string codigoActual = txtCodigodebarras.Text.Trim();

            if (_codigoCargado == null || !string.Equals(codigoActual, _codigoCargado, StringComparison.OrdinalIgnoreCase))
            {
                notificarUsuario("Debe buscar el producto (presione Enter en el código de barras) antes de actualizarlo.", true);
                return;
            }

            if (cbxCategoria.SelectedValue == null)
            {
                notificarUsuario("Debe seleccionar una categoría", true);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea actualizar el producto \"{txtNombrep.Text}\" (código {codigoActual})?",
                "Confirmar actualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            controlador.Actualizarproduc(codigoActual, txtNombrep.Text, txtDescripcion.Text,
                tipoventa.ToString(), txtCosto.Text, txtPrecioventa.Text, cbxCategoria.SelectedValue.ToString(), txtStockactual.Text, txtStockminimo.Text, pcbImagen.Image, nudPorcentaje.Value.ToString(), this);
        }

        private void nudPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            if (_cargandoDatos) return;

            // NUEVO ESCUDO: Si la caja de costo está vacía, no intentes calcular nada.
            if (string.IsNullOrWhiteSpace(txtCosto.Text)) return;

            float preciov = controlador.Calcularprecioventa(txtCosto.Text, nudPorcentaje.Value.ToString(), this);
            txtPrecioventa.Text = preciov.ToString();
        }

        private void txtCodigodebarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }

        private void txtStockactual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtStockminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
