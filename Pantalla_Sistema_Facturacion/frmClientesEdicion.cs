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

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
               string.IsNullOrWhiteSpace(txtDocumentoCliente.Text) ||
               string.IsNullOrWhiteSpace(txtDireccionCliente.Text) ||
               string.IsNullOrWhiteSpace(txtTelefonoCliente.Text) ||
               string.IsNullOrWhiteSpace(txtEmailCliente.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Aquí iría la lógica para actualizar el cliente en la base de datos
                MessageBox.Show("Cliente actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
