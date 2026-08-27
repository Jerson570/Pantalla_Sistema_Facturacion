namespace Pantalla_Sistema_Facturacion
{
    partial class frmFacturas
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
            txtNroFactura = new TextBox();
            txtDescuento = new TextBox();
            cmbCliente = new ComboBox();
            cmbEmpleado = new ComboBox();
            txtTotalIva = new TextBox();
            txtTotalFactura = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtFacturas = new DateTimePicker();
            txtDetallesFactura = new TextBox();
            btnSalirFacturas = new Button();
            btnActualizarFacturas = new Button();
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
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(236, 20);
            label1.Name = "label1";
            label1.Size = new Size(318, 27);
            label1.TabIndex = 1;
            label1.Text = "Administracion De Facturas";
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
            // txtNroFactura
            // 
            txtNroFactura.BackColor = SystemColors.Control;
            txtNroFactura.Location = new Point(129, 111);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(193, 27);
            txtNroFactura.TabIndex = 1;
            // 
            // txtDescuento
            // 
            txtDescuento.BackColor = SystemColors.Control;
            txtDescuento.Location = new Point(30, 269);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PlaceholderText = "Descuento";
            txtDescuento.Size = new Size(247, 27);
            txtDescuento.TabIndex = 2;
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = SystemColors.Control;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(129, 162);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(193, 28);
            cmbCliente.TabIndex = 3;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.BackColor = SystemColors.Control;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(129, 208);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(193, 28);
            cmbEmpleado.TabIndex = 4;
            // 
            // txtTotalIva
            // 
            txtTotalIva.BackColor = SystemColors.Control;
            txtTotalIva.Location = new Point(30, 318);
            txtTotalIva.Name = "txtTotalIva";
            txtTotalIva.PlaceholderText = "Total Iva";
            txtTotalIva.Size = new Size(247, 27);
            txtTotalIva.TabIndex = 5;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.BackColor = SystemColors.Control;
            txtTotalFactura.Location = new Point(30, 370);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.PlaceholderText = "Total Factura";
            txtTotalFactura.Size = new Size(247, 27);
            txtTotalFactura.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 117);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 7;
            label2.Text = "Nro Factua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 172);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 8;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 218);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 9;
            label4.Text = "Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(450, 121);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 7;
            label5.Text = "Fecha";
            // 
            // dtFacturas
            // 
            dtFacturas.CalendarMonthBackground = SystemColors.Control;
            dtFacturas.DropDownAlign = LeftRightAlignment.Right;
            dtFacturas.Format = DateTimePickerFormat.Short;
            dtFacturas.Location = new Point(521, 117);
            dtFacturas.Name = "dtFacturas";
            dtFacturas.Size = new Size(124, 27);
            dtFacturas.TabIndex = 10;
            // 
            // txtDetallesFactura
            // 
            txtDetallesFactura.BackColor = SystemColors.Control;
            txtDetallesFactura.Location = new Point(444, 172);
            txtDetallesFactura.Multiline = true;
            txtDetallesFactura.Name = "txtDetallesFactura";
            txtDetallesFactura.PlaceholderText = "Detalles";
            txtDetallesFactura.Size = new Size(292, 142);
            txtDetallesFactura.TabIndex = 12;
            // 
            // btnSalirFacturas
            // 
            btnSalirFacturas.Location = new Point(607, 370);
            btnSalirFacturas.Name = "btnSalirFacturas";
            btnSalirFacturas.Size = new Size(154, 36);
            btnSalirFacturas.TabIndex = 14;
            btnSalirFacturas.Text = "Salir";
            btnSalirFacturas.UseVisualStyleBackColor = true;
            btnSalirFacturas.Click += btnSalirProductos_Click;
            // 
            // btnActualizarFacturas
            // 
            btnActualizarFacturas.Location = new Point(409, 370);
            btnActualizarFacturas.Name = "btnActualizarFacturas";
            btnActualizarFacturas.Size = new Size(154, 36);
            btnActualizarFacturas.TabIndex = 13;
            btnActualizarFacturas.Text = "Actualizar";
            btnActualizarFacturas.UseVisualStyleBackColor = true;
            btnActualizarFacturas.Click += btnActualizarFacturas_Click;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirFacturas);
            Controls.Add(btnActualizarFacturas);
            Controls.Add(txtDetallesFactura);
            Controls.Add(dtFacturas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtTotalFactura);
            Controls.Add(txtTotalIva);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbCliente);
            Controls.Add(txtDescuento);
            Controls.Add(txtNroFactura);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFacturas";
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
        private TextBox txtNroFactura;
        private TextBox txtDescuento;
        private ComboBox cmbCliente;
        private ComboBox cmbEmpleado;
        private TextBox txtTotalIva;
        private TextBox txtTotalFactura;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtFacturas;
        private TextBox txtDetallesFactura;
        private Button btnSalirFacturas;
        private Button btnActualizarFacturas;
    }
}