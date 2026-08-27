namespace Pantalla_Sistema_Facturacion
{
    partial class frmCategorias
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
            txtNombreCategoria = new TextBox();
            btnActualizarCategoria = new Button();
            btnSalirCategoria = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Highlight;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 57);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(190, 16);
            label1.Name = "label1";
            label1.Size = new Size(242, 27);
            label1.TabIndex = 0;
            label1.Text = "Categoria Productos";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.BackColor = SystemColors.Control;
            txtNombreCategoria.Location = new Point(140, 176);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.PlaceholderText = "Nombre  categoria ";
            txtNombreCategoria.Size = new Size(280, 27);
            txtNombreCategoria.TabIndex = 1;
            // 
            // btnActualizarCategoria
            // 
            btnActualizarCategoria.Location = new Point(61, 318);
            btnActualizarCategoria.Name = "btnActualizarCategoria";
            btnActualizarCategoria.Size = new Size(208, 46);
            btnActualizarCategoria.TabIndex = 2;
            btnActualizarCategoria.Text = "Actualizar";
            btnActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnSalirCategoria
            // 
            btnSalirCategoria.Location = new Point(314, 318);
            btnSalirCategoria.Name = "btnSalirCategoria";
            btnSalirCategoria.Size = new Size(208, 46);
            btnSalirCategoria.TabIndex = 3;
            btnSalirCategoria.Text = "Salir";
            btnSalirCategoria.UseVisualStyleBackColor = true;
            btnSalirCategoria.Click += btnSalir_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalirCategoria);
            Controls.Add(btnActualizarCategoria);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoriaProductos";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombreCategoria;
        private Button btnActualizarCategoria;
        private Button btnSalirCategoria;
    }
}