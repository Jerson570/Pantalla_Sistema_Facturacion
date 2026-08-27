using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnActualizarFacturas_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNroFactura.Text)||string.IsNullOrEmpty(txtDescuento.Text)||
                string.IsNullOrEmpty(txtTotalIva.Text)||string.IsNullOrEmpty(txtTotalFactura.Text)||
                string.IsNullOrEmpty(txtDetallesFactura.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cmbCliente.SelectedIndex == -1 || cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente y un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dtFacturas.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de la factura no puede ser mayor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Factura actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
