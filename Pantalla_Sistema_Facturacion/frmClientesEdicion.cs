using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmClientesEdicion : Form
    {
        public frmClientesEdicion()
        {
            InitializeComponent();
        }

        private void btnSalirRegistro_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            this.Close();
        }
    }
}
