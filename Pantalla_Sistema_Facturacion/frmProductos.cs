using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
        }
    }
}
