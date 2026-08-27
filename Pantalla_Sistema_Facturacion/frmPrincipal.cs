using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes ventana = new frmClientes();
            ventana.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos ventana = new frmProductos();
            ventana.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas ventana = new frmFacturas();
            ventana.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes ventana = new frmInformes();
            ventana.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados ventana = new frmEmpleados();
            ventana.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles ventana = new frmRoles();
            ventana.Show();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmSeguridad ventana = new frmSeguridad();
            ventana.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ventana = new frmAyuda();
            ventana.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercade ventana = new frmAcercade();
            ventana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            ventana.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
