namespace Pantalla_Sistema_Facturacion
{
    partial class frmSeguridad
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cmbEmpleado = new ComboBox();
            txtContraseñaSeguridad = new TextBox();
            txtUsuarioSeguridad = new TextBox();
            btnSalirSeguridad = new Button();
            btnActualizarSeguridad = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 55);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(125, 19);
            label1.Name = "label1";
            label1.Size = new Size(394, 23);
            label1.TabIndex = 0;
            label1.Text = "Administracion De Usuarios Del Sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 110);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 12;
            label2.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.BackColor = SystemColors.Control;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(215, 105);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(259, 28);
            cmbEmpleado.TabIndex = 11;
            // 
            // txtContraseñaSeguridad
            // 
            txtContraseñaSeguridad.BackColor = SystemColors.Control;
            txtContraseñaSeguridad.Location = new Point(190, 233);
            txtContraseñaSeguridad.Name = "txtContraseñaSeguridad";
            txtContraseñaSeguridad.PlaceholderText = "Contraseña";
            txtContraseñaSeguridad.Size = new Size(249, 27);
            txtContraseñaSeguridad.TabIndex = 14;
            // 
            // txtUsuarioSeguridad
            // 
            txtUsuarioSeguridad.BackColor = SystemColors.Control;
            txtUsuarioSeguridad.Location = new Point(190, 180);
            txtUsuarioSeguridad.Name = "txtUsuarioSeguridad";
            txtUsuarioSeguridad.PlaceholderText = "Usuario";
            txtUsuarioSeguridad.Size = new Size(249, 27);
            txtUsuarioSeguridad.TabIndex = 13;
            // 
            // btnSalirSeguridad
            // 
            btnSalirSeguridad.Location = new Point(331, 339);
            btnSalirSeguridad.Name = "btnSalirSeguridad";
            btnSalirSeguridad.Size = new Size(154, 36);
            btnSalirSeguridad.TabIndex = 16;
            btnSalirSeguridad.Text = "Salir";
            btnSalirSeguridad.UseVisualStyleBackColor = true;
            btnSalirSeguridad.Click += btnSalirSeguridad_Click;
            // 
            // btnActualizarSeguridad
            // 
            btnActualizarSeguridad.Location = new Point(133, 339);
            btnActualizarSeguridad.Name = "btnActualizarSeguridad";
            btnActualizarSeguridad.Size = new Size(154, 36);
            btnActualizarSeguridad.TabIndex = 15;
            btnActualizarSeguridad.Text = "Actualizar";
            btnActualizarSeguridad.UseVisualStyleBackColor = true;
            // 
            // frmSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalirSeguridad);
            Controls.Add(btnActualizarSeguridad);
            Controls.Add(txtContraseñaSeguridad);
            Controls.Add(txtUsuarioSeguridad);
            Controls.Add(label2);
            Controls.Add(cmbEmpleado);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeguridad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ComboBox cmbEmpleado;
        private TextBox txtContraseñaSeguridad;
        private TextBox txtUsuarioSeguridad;
        private Button btnSalirSeguridad;
        private Button btnActualizarSeguridad;
    }
}