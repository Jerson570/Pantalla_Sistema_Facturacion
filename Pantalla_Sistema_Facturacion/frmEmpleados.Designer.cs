namespace Pantalla_Sistema_Facturacion
{
    partial class frmEmpleados
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
            btnSalirEmpleado = new Button();
            btnActualizarEmpleado = new Button();
            txtEmailEmpleado = new TextBox();
            txtTelefonoEmpleado = new TextBox();
            txtDireccionEmpleado = new TextBox();
            txtDocumentoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            cmbEmpleados = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            txtDetallesEmpleado = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalirEmpleado
            // 
            btnSalirEmpleado.BackColor = SystemColors.ControlLightLight;
            btnSalirEmpleado.Location = new Point(616, 374);
            btnSalirEmpleado.Name = "btnSalirEmpleado";
            btnSalirEmpleado.Size = new Size(124, 52);
            btnSalirEmpleado.TabIndex = 15;
            btnSalirEmpleado.Text = "Salir";
            btnSalirEmpleado.UseVisualStyleBackColor = false;
            btnSalirEmpleado.Click += btnSalirRegistro_Click;
            // 
            // btnActualizarEmpleado
            // 
            btnActualizarEmpleado.BackColor = SystemColors.ControlLightLight;
            btnActualizarEmpleado.Location = new Point(436, 374);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(124, 52);
            btnActualizarEmpleado.TabIndex = 14;
            btnActualizarEmpleado.Text = "Actualizar";
            btnActualizarEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtEmailEmpleado
            // 
            txtEmailEmpleado.BackColor = SystemColors.Control;
            txtEmailEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailEmpleado.ForeColor = SystemColors.WindowFrame;
            txtEmailEmpleado.Location = new Point(42, 367);
            txtEmailEmpleado.Name = "txtEmailEmpleado";
            txtEmailEmpleado.PlaceholderText = "Email";
            txtEmailEmpleado.Size = new Size(277, 27);
            txtEmailEmpleado.TabIndex = 13;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.BackColor = SystemColors.Control;
            txtTelefonoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoEmpleado.ForeColor = SystemColors.WindowFrame;
            txtTelefonoEmpleado.Location = new Point(42, 319);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.PlaceholderText = "Telefono";
            txtTelefonoEmpleado.Size = new Size(277, 27);
            txtTelefonoEmpleado.TabIndex = 12;
            // 
            // txtDireccionEmpleado
            // 
            txtDireccionEmpleado.BackColor = SystemColors.Control;
            txtDireccionEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccionEmpleado.ForeColor = SystemColors.WindowFrame;
            txtDireccionEmpleado.Location = new Point(42, 269);
            txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            txtDireccionEmpleado.PlaceholderText = "Direccion";
            txtDireccionEmpleado.Size = new Size(277, 27);
            txtDireccionEmpleado.TabIndex = 11;
            // 
            // txtDocumentoEmpleado
            // 
            txtDocumentoEmpleado.BackColor = SystemColors.Control;
            txtDocumentoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumentoEmpleado.ForeColor = SystemColors.WindowFrame;
            txtDocumentoEmpleado.Location = new Point(42, 211);
            txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            txtDocumentoEmpleado.PlaceholderText = "Documento";
            txtDocumentoEmpleado.Size = new Size(277, 27);
            txtDocumentoEmpleado.TabIndex = 10;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.BackColor = SystemColors.Control;
            txtNombreEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEmpleado.ForeColor = SystemColors.WindowFrame;
            txtNombreEmpleado.Location = new Point(42, 154);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.PlaceholderText = "Nombre Empleado";
            txtNombreEmpleado.Size = new Size(277, 27);
            txtNombreEmpleado.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(236, 20);
            label1.Name = "label1";
            label1.Size = new Size(349, 27);
            label1.TabIndex = 1;
            label1.Text = "Administracion De Empleados";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 107);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 18;
            label3.Text = "Rol Empleado";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.BackColor = SystemColors.Control;
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(153, 103);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(169, 28);
            cmbEmpleados.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(607, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(492, 103);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 19;
            label5.Text = "Fecha Ingreso";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(607, 140);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(124, 27);
            dateTimePicker2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 144);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 21;
            label2.Text = "Fecha Salida";
            // 
            // txtDetallesEmpleado
            // 
            txtDetallesEmpleado.BackColor = SystemColors.Control;
            txtDetallesEmpleado.Location = new Point(436, 204);
            txtDetallesEmpleado.Multiline = true;
            txtDetallesEmpleado.Name = "txtDetallesEmpleado";
            txtDetallesEmpleado.PlaceholderText = "Detalles";
            txtDetallesEmpleado.Size = new Size(292, 142);
            txtDetallesEmpleado.TabIndex = 23;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDetallesEmpleado);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(cmbEmpleados);
            Controls.Add(panel1);
            Controls.Add(btnSalirEmpleado);
            Controls.Add(btnActualizarEmpleado);
            Controls.Add(txtEmailEmpleado);
            Controls.Add(txtTelefonoEmpleado);
            Controls.Add(txtDireccionEmpleado);
            Controls.Add(txtDocumentoEmpleado);
            Controls.Add(txtNombreEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalirEmpleado;
        private Button btnActualizarEmpleado;
        private TextBox txtEmailEmpleado;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtDireccionEmpleado;
        private TextBox txtDocumentoEmpleado;
        private TextBox txtNombreEmpleado;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox cmbEmpleados;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private TextBox txtDetallesEmpleado;
    }
}