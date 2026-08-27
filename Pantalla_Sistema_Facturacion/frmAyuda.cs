using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
            WebBrowser navegador = new WebBrowser();
            navegador.Dock = DockStyle.Fill;
            navegador.ScriptErrorsSuppressed = true;
            this.Controls.Add(navegador);

            navegador.Navigate("https://github.com/Jerson570/Pantalla_Sistema_Facturacion");
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
