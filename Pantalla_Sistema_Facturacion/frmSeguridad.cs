using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmSeguridad : Form
    {
        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalirSeguridad_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnActualizarSeguridad_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado para actualizar la seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtUsuarioSeguridad.Text) || string.IsNullOrEmpty(txtContraseñaSeguridad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Seguridad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
