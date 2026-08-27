using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnSalirInformes_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (cmbInforme.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de informe.");
                return;
            }
            if (cmbOrdenarInforme.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenamiento.");
                return;
            }
            if (dtInicioInforme.Value > dtFinalInforme.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                return;
            }
            if (rbtnPdf.Checked == false && rbtnExcel.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un formato de informe.");
                return;
            }
            else
            {

                MessageBox.Show("Informe generado correctamente.");
            }
        }
    }
}
