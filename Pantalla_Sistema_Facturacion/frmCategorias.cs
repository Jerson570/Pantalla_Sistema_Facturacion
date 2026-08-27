using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal principalForm = new frmPrincipal();
            this.Close();
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de categoría válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
