using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void mnuAdministraClientes_Click(object sender, EventArgs e)
        {
            FrmAdministrarClientes frm = new FrmAdministrarClientes();       
            frm.Show();
        }

        private void mnuAdministrarProductos_Click(object sender, EventArgs e)
        {
            FrmAdministrarProductos frm = new FrmAdministrarProductos();
            frm.Show();
        }

        private void mnuFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.Show();
        }

        
    }
}
