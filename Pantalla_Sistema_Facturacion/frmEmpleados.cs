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

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) || string.IsNullOrWhiteSpace(txtDocumentoEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionEmpleado.Text) || string.IsNullOrWhiteSpace(txtTelefonoEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtEmailEmpleado.Text) || string.IsNullOrWhiteSpace(txtDetallesEmpleado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el empleado.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRolEmpleados.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de Rol.");
                return;
            }
            if (dtSalidaEmpleado.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de ingreso no puede ser mayor a la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                MessageBox.Show("Empleado actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
