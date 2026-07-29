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
    public partial class FrmEliminarproductos : Form
    {
        ClsProductController controlador = new ClsProductController();
        public FrmEliminarproductos()
        {
            InitializeComponent();
            DataTable roles = controlador.Cargarcatego(this);
            llenarComboRoles(roles);


            txtNombrep.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCosto.ReadOnly = true;
            txtPrecioventa.ReadOnly = true;
            txtStockactual.ReadOnly = true;
            txtStockminimo.ReadOnly = true;

            cbxCategoria.Enabled = false;
            chkUnidad.Enabled = false;
            chkGranel.Enabled = false;
            nudPorcentaje.Enabled = false;
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
                        pcbImagen.Image = null;
                    }
                }
                else
                {
                    pcbImagen.Image = null;
                }
            }
            else
            {
                LimpiarFormulario();
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
        private void LimpiarFormulario()
        {
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
        private void txtCodigobarras_KeyDown_1(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string codigo = txtCodigobarras.Text.Trim();

                    DataTable dt = controlador.BuscarProEliminar(codigo, this);
                    llenarCampos(dt);

                    // Evita el sonido molesto "beep" de Windows al dar Enter
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void nudPorcentaje_ValueChanged_1(object sender, EventArgs e)
        {
            float preciov = controlador.Calcularpreciov(txtCosto.Text, nudPorcentaje.Value.ToString(), this);
            txtPrecioventa.Text = preciov.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            controlador.Eliminarproduct(txtCodigobarras.Text, this);
        }
    
    }
}