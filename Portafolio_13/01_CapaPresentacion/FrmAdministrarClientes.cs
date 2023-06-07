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
    public partial class FrmAdministrarClientes : Form
    {
        public FrmAdministrarClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EntidadCliente GenerarEntidadCliente()
        {
            EntidadCliente cliente = new EntidadCliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;

            return cliente;
        }

        public void Limpiar()
        {
            txtCodigoCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EntidadCliente cliente = new EntidadCliente();
            BLCliente logica = new BLCliente(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) |
                    string.IsNullOrEmpty(txtTelefono.Text) |
                    string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Faltan Datos. Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente = GenerarEntidadCliente();
                    resultado = logica.insertar(cliente);
                    txtNombre.Focus();
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
