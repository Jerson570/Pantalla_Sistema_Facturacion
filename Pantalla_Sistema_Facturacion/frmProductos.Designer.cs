namespace Pantalla_Sistema_Facturacion
{
    partial class frmProductos
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtNombreProducto = new TextBox();
            txtCodigo = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            btnActualizarProductos = new Button();
            btnSalirProductos = new Button();
            cmbCategoriaProductos = new ComboBox();
            label2 = new Label();
            txtDetallesProductos = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(260, 16);
            label1.Name = "label1";
            label1.Size = new Size(291, 23);
            label1.TabIndex = 0;
            label1.Text = "Administracion De Productos";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 55);
            panel1.TabIndex = 1;
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
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = SystemColors.Control;
            txtNombreProducto.Location = new Point(27, 104);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.PlaceholderText = "Nombre Producto";
            txtNombreProducto.Size = new Size(249, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Control;
            txtCodigo.Location = new Point(27, 157);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Codigo Referencia";
            txtCodigo.Size = new Size(249, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = SystemColors.Control;
            txtPrecioCompra.Location = new Point(27, 210);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PlaceholderText = "Precio Compra";
            txtPrecioCompra.Size = new Size(249, 27);
            txtPrecioCompra.TabIndex = 4;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = SystemColors.Control;
            txtPrecioVenta.Location = new Point(27, 266);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio Venta";
            txtPrecioVenta.Size = new Size(249, 27);
            txtPrecioVenta.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Control;
            txtStock.Location = new Point(27, 322);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Cantidad de Stock";
            txtStock.Size = new Size(249, 27);
            txtStock.TabIndex = 6;
            // 
            // btnActualizarProductos
            // 
            btnActualizarProductos.Location = new Point(382, 374);
            btnActualizarProductos.Name = "btnActualizarProductos";
            btnActualizarProductos.Size = new Size(154, 36);
            btnActualizarProductos.TabIndex = 7;
            btnActualizarProductos.Text = "Actualizar";
            btnActualizarProductos.UseVisualStyleBackColor = true;
            // 
            // btnSalirProductos
            // 
            btnSalirProductos.Location = new Point(580, 374);
            btnSalirProductos.Name = "btnSalirProductos";
            btnSalirProductos.Size = new Size(154, 36);
            btnSalirProductos.TabIndex = 8;
            btnSalirProductos.Text = "Salir";
            btnSalirProductos.UseVisualStyleBackColor = true;
            btnSalirProductos.Click += btnSalirProductos_Click;
            // 
            // cmbCategoriaProductos
            // 
            cmbCategoriaProductos.BackColor = SystemColors.Control;
            cmbCategoriaProductos.FormattingEnabled = true;
            cmbCategoriaProductos.Location = new Point(531, 115);
            cmbCategoriaProductos.Name = "cmbCategoriaProductos";
            cmbCategoriaProductos.Size = new Size(176, 28);
            cmbCategoriaProductos.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(452, 119);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 10;
            label2.Text = "Categoria";
            // 
            // txtDetallesProductos
            // 
            txtDetallesProductos.BackColor = SystemColors.Control;
            txtDetallesProductos.Location = new Point(452, 198);
            txtDetallesProductos.Multiline = true;
            txtDetallesProductos.Name = "txtDetallesProductos";
            txtDetallesProductos.PlaceholderText = "Detalles";
            txtDetallesProductos.Size = new Size(249, 117);
            txtDetallesProductos.TabIndex = 11;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDetallesProductos);
            Controls.Add(label2);
            Controls.Add(cmbCategoriaProductos);
            Controls.Add(btnSalirProductos);
            Controls.Add(btnActualizarProductos);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreProducto);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtNombreProducto;
        private TextBox txtCodigo;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private Button btnActualizarProductos;
        private Button btnSalirProductos;
        private ComboBox cmbCategoriaProductos;
        private Label label2;
        private TextBox txtDetallesProductos;
    }
}