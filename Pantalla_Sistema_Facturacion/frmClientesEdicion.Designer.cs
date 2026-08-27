namespace Pantalla_Sistema_Facturacion
{
    partial class frmClientesEdicion
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            txtDocumentoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtEmailCliente = new TextBox();
            btnActualizarCliente = new Button();
            btnSalirRegistro = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.MenuHighlight;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(500, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(153, 79);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 1;
            label1.Text = "Nuevo Registro";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = SystemColors.Control;
            txtNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCliente.ForeColor = SystemColors.WindowFrame;
            txtNombreCliente.Location = new Point(105, 150);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Nombre Cliente";
            txtNombreCliente.Size = new Size(277, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.BackColor = SystemColors.Control;
            txtDocumentoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumentoCliente.ForeColor = SystemColors.WindowFrame;
            txtDocumentoCliente.Location = new Point(105, 207);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.PlaceholderText = "Documento";
            txtDocumentoCliente.Size = new Size(277, 27);
            txtDocumentoCliente.TabIndex = 3;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = SystemColors.Control;
            txtDireccionCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccionCliente.ForeColor = SystemColors.WindowFrame;
            txtDireccionCliente.Location = new Point(105, 265);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.PlaceholderText = "Direccion";
            txtDireccionCliente.Size = new Size(277, 27);
            txtDireccionCliente.TabIndex = 4;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = SystemColors.Control;
            txtTelefonoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoCliente.ForeColor = SystemColors.WindowFrame;
            txtTelefonoCliente.Location = new Point(105, 315);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.PlaceholderText = "Telefono";
            txtTelefonoCliente.Size = new Size(277, 27);
            txtTelefonoCliente.TabIndex = 5;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.BackColor = SystemColors.Control;
            txtEmailCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailCliente.ForeColor = SystemColors.WindowFrame;
            txtEmailCliente.Location = new Point(105, 363);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.PlaceholderText = "Email";
            txtEmailCliente.Size = new Size(277, 27);
            txtEmailCliente.TabIndex = 6;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.BackColor = SystemColors.ControlLightLight;
            btnActualizarCliente.Location = new Point(89, 418);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(124, 52);
            btnActualizarCliente.TabIndex = 7;
            btnActualizarCliente.Text = "Actualizar";
            btnActualizarCliente.UseVisualStyleBackColor = false;
            // 
            // btnSalirRegistro
            // 
            btnSalirRegistro.BackColor = SystemColors.ControlLightLight;
            btnSalirRegistro.Location = new Point(269, 418);
            btnSalirRegistro.Name = "btnSalirRegistro";
            btnSalirRegistro.Size = new Size(124, 52);
            btnSalirRegistro.TabIndex = 8;
            btnSalirRegistro.Text = "Salir";
            btnSalirRegistro.UseVisualStyleBackColor = false;
            btnSalirRegistro.Click += btnSalirRegistro_Click;
            // 
            // frmClientesEdicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 650);
            Controls.Add(btnSalirRegistro);
            Controls.Add(label1);
            Controls.Add(btnActualizarCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtDocumentoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientesEdicion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientesEdicion";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtNombreCliente;
        private TextBox txtDocumentoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtEmailCliente;
        private Button btnActualizarCliente;
        private Button btnSalirRegistro;
        private PictureBox pictureBox1;
    }
}