namespace Pantalla_Sistema_Facturacion
{
    partial class frmRoles
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtDetallesRoles = new TextBox();
            txtNombreRol = new TextBox();
            btnSalirRoles = new Button();
            btnActualizarRoles = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 67);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(208, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 27);
            label1.TabIndex = 1;
            label1.Text = "Rol De Empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtDetallesRoles
            // 
            txtDetallesRoles.BackColor = SystemColors.Control;
            txtDetallesRoles.Location = new Point(158, 157);
            txtDetallesRoles.Multiline = true;
            txtDetallesRoles.Name = "txtDetallesRoles";
            txtDetallesRoles.PlaceholderText = "Descripcion Detallada ";
            txtDetallesRoles.Size = new Size(292, 142);
            txtDetallesRoles.TabIndex = 25;
            // 
            // txtNombreRol
            // 
            txtNombreRol.BackColor = SystemColors.Control;
            txtNombreRol.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreRol.ForeColor = SystemColors.WindowFrame;
            txtNombreRol.Location = new Point(178, 109);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.PlaceholderText = "Nombre Rol";
            txtNombreRol.Size = new Size(252, 27);
            txtNombreRol.TabIndex = 24;
            // 
            // btnSalirRoles
            // 
            btnSalirRoles.BackColor = SystemColors.ControlLightLight;
            btnSalirRoles.Location = new Point(329, 353);
            btnSalirRoles.Name = "btnSalirRoles";
            btnSalirRoles.Size = new Size(124, 52);
            btnSalirRoles.TabIndex = 27;
            btnSalirRoles.Text = "Salir";
            btnSalirRoles.UseVisualStyleBackColor = false;
            btnSalirRoles.Click += btnSalirRoles_Click;
            // 
            // btnActualizarRoles
            // 
            btnActualizarRoles.BackColor = SystemColors.ControlLightLight;
            btnActualizarRoles.Location = new Point(149, 353);
            btnActualizarRoles.Name = "btnActualizarRoles";
            btnActualizarRoles.Size = new Size(124, 52);
            btnActualizarRoles.TabIndex = 26;
            btnActualizarRoles.Text = "Actualizar";
            btnActualizarRoles.UseVisualStyleBackColor = false;
            btnActualizarRoles.Click += btnActualizarRoles_Click;
            // 
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalirRoles);
            Controls.Add(btnActualizarRoles);
            Controls.Add(txtDetallesRoles);
            Controls.Add(txtNombreRol);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRoles";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtDetallesRoles;
        private TextBox txtNombreRol;
        private Button btnSalirRoles;
        private Button btnActualizarRoles;
    }
}