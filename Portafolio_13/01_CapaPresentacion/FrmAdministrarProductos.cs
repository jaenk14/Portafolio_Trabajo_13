using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using _02_CapaLogicaNegocio;

namespace _01_CapaPresentacion
{
    public partial class FrmAdministrarProductos : Form
    {
        public FrmAdministrarProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EntidadProductos GenerarEntidadProducto()
        {
            EntidadProductos producto = new EntidadProductos();
            producto.Descripcion = txtDescripcion.Text;
            producto.Preciocompra = Convert.ToDecimal(txtPrecioCompra.Text);
            producto.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            producto.Gravado = Convert.ToInt32(txtGravado.Text);
            return producto;
        }
        public void Limpiar()
        {
            txtDescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtGravado.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EntidadProductos producto = new EntidadProductos();
            BLProductos logica = new BLProductos(Configuracion.getConnectionString);

            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text) |
                    string.IsNullOrEmpty(txtPrecioCompra.Text) |
                    string.IsNullOrEmpty(txtPrecioVenta.Text) |
                    string.IsNullOrEmpty(txtGravado.Text) )
                {
                    MessageBox.Show("Faltan Datos. Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    producto = GenerarEntidadProducto();
                    resultado = logica.insertar(producto);
                    txtDescripcion.Focus();
                    Limpiar();
                    MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
    }
}
