using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void btnSalirRoles_Click(object sender, EventArgs e)
        {
            frmPrincipal principalForm = new frmPrincipal();
            principalForm.Show();
            this.Hide();
        }

        private void btnActualizarRoles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text) || string.IsNullOrWhiteSpace(txtDetallesRoles.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
