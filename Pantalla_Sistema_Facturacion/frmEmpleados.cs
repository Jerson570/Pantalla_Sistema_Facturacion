using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirRegistro_Click(object sender, EventArgs e)
        {
            frmPrincipal principalForm = new frmPrincipal();
            principalForm.ShowDialog();
            this.Hide();
        }
    }
}
