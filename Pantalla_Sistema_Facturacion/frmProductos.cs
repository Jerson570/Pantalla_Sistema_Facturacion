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

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoReferenciaProducto.Text) || string.IsNullOrEmpty(txtNombreProducto.Text) ||
                string.IsNullOrEmpty(txtPrecioCompra.Text)|| string.IsNullOrEmpty(txtPrecioVenta.Text)||string.IsNullOrEmpty(txtStock.Text)
                || string.IsNullOrEmpty(txtDetallesProductos.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                MessageBox.Show("Producto actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
