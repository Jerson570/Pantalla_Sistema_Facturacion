namespace Pantalla_Sistema_Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Validación
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está bien, abre el Formulario Principal y oculta el Login
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide(); // Oculta el Login
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }
    }
}
