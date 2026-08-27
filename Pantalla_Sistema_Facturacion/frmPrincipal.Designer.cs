namespace Pantalla_Sistema_Facturacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSalir = new Button();
            label1 = new Label();
            pnlBarraSuperior = new Panel();
            btnAyuda = new Button();
            btnSeguridad = new Button();
            btnFacturacion = new Button();
            btnMenuTablas = new Button();
            cmsTablas = new ContextMenuStrip(components);
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            cmsFacturacion = new ContextMenuStrip(components);
            facturasToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            cmsSeguridad = new ContextMenuStrip(components);
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            seguToolStripMenuItem = new ToolStripMenuItem();
            cmsAyuda = new ContextMenuStrip(components);
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pnlBarraSuperior.SuspendLayout();
            cmsTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsFacturacion.SuspendLayout();
            cmsSeguridad.SuspendLayout();
            cmsAyuda.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = SystemColors.HotTrack;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Image = Properties.Resources.principal;
            btnSalir.Location = new Point(23, 288);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 56);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(216, 17);
            label1.TabIndex = 11;
            label1.Text = "SISTEMA DE FACTURACION";
            label1.Click += label1_Click;
            // 
            // pnlBarraSuperior
            // 
            pnlBarraSuperior.BackColor = SystemColors.ControlDarkDark;
            pnlBarraSuperior.Controls.Add(btnAyuda);
            pnlBarraSuperior.Controls.Add(btnSeguridad);
            pnlBarraSuperior.Controls.Add(btnFacturacion);
            pnlBarraSuperior.Controls.Add(btnMenuTablas);
            pnlBarraSuperior.Controls.Add(label1);
            pnlBarraSuperior.Dock = DockStyle.Top;
            pnlBarraSuperior.Location = new Point(0, 0);
            pnlBarraSuperior.Name = "pnlBarraSuperior";
            pnlBarraSuperior.Size = new Size(800, 55);
            pnlBarraSuperior.TabIndex = 16;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = SystemColors.ControlDarkDark;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Location = new Point(652, 7);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(129, 39);
            btnAyuda.TabIndex = 20;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click_1;
            // 
            // btnSeguridad
            // 
            btnSeguridad.BackColor = SystemColors.ControlDarkDark;
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Location = new Point(517, 7);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(129, 39);
            btnSeguridad.TabIndex = 19;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = false;
            btnSeguridad.Click += btnSeguridad_Click_1;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = SystemColors.ControlDarkDark;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Location = new Point(382, 7);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(129, 39);
            btnFacturacion.TabIndex = 18;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnMenuTablas
            // 
            btnMenuTablas.BackColor = SystemColors.ControlDarkDark;
            btnMenuTablas.ContextMenuStrip = cmsTablas;
            btnMenuTablas.FlatAppearance.BorderSize = 0;
            btnMenuTablas.FlatStyle = FlatStyle.Flat;
            btnMenuTablas.Location = new Point(264, 7);
            btnMenuTablas.Name = "btnMenuTablas";
            btnMenuTablas.Size = new Size(129, 39);
            btnMenuTablas.TabIndex = 17;
            btnMenuTablas.Text = "Tablas";
            btnMenuTablas.UseVisualStyleBackColor = false;
            btnMenuTablas.Click += btnTablas_Click;
            // 
            // cmsTablas
            // 
            cmsTablas.ImageScalingSize = new Size(20, 20);
            cmsTablas.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, categoriasToolStripMenuItem });
            cmsTablas.Name = "cmsTablas";
            cmsTablas.Size = new Size(150, 76);
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(149, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(149, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(149, 24);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.principal;
            pictureBox1.Location = new Point(-1, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // cmsFacturacion
            // 
            cmsFacturacion.ImageScalingSize = new Size(20, 20);
            cmsFacturacion.Items.AddRange(new ToolStripItem[] { facturasToolStripMenuItem, informesToolStripMenuItem });
            cmsFacturacion.Name = "cmsFacturacion";
            cmsFacturacion.Size = new Size(137, 52);
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(136, 24);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(136, 24);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // cmsSeguridad
            // 
            cmsSeguridad.ImageScalingSize = new Size(20, 20);
            cmsSeguridad.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguToolStripMenuItem });
            cmsSeguridad.Name = "cmsSeguridad";
            cmsSeguridad.Size = new Size(153, 76);
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(152, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(152, 24);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // seguToolStripMenuItem
            // 
            seguToolStripMenuItem.Name = "seguToolStripMenuItem";
            seguToolStripMenuItem.Size = new Size(152, 24);
            seguToolStripMenuItem.Text = "Seguridad";
            seguToolStripMenuItem.Click += seguToolStripMenuItem_Click;
            // 
            // cmsAyuda
            // 
            cmsAyuda.ImageScalingSize = new Size(20, 20);
            cmsAyuda.Items.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem, acercaDeToolStripMenuItem });
            cmsAyuda.Name = "cmsAyuda";
            cmsAyuda.Size = new Size(147, 52);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(146, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(146, 24);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBarraSuperior);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            pnlBarraSuperior.ResumeLayout(false);
            pnlBarraSuperior.PerformLayout();
            cmsTablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsFacturacion.ResumeLayout(false);
            cmsSeguridad.ResumeLayout(false);
            cmsAyuda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        private Label label1;
        private Panel pnlBarraSuperior;
        private PictureBox pictureBox1;
        private Button btnMenuTablas;
        private Button btnAyuda;
        private Button btnSeguridad;
        private Button btnFacturacion;
        private ContextMenuStrip cmsTablas;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ContextMenuStrip cmsFacturacion;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ContextMenuStrip cmsSeguridad;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ContextMenuStrip cmsAyuda;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem seguToolStripMenuItem;
    }
}