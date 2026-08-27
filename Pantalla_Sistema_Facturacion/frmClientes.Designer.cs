namespace Pantalla_Sistema_Facturacion
{
    partial class frmClientes
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
            btnRegresarClientes = new Button();
            panel1 = new Panel();
            txtBuscar = new TextBox();
            btnBuscarCliente = new Button();
            dataGridView1 = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRegresarClientes
            // 
            btnRegresarClientes.BackColor = SystemColors.Highlight;
            btnRegresarClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresarClientes.Cursor = Cursors.Hand;
            btnRegresarClientes.FlatAppearance.BorderSize = 0;
            btnRegresarClientes.FlatStyle = FlatStyle.Flat;
            btnRegresarClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarClientes.ForeColor = SystemColors.ButtonHighlight;
            btnRegresarClientes.Location = new Point(0, 5);
            btnRegresarClientes.Name = "btnRegresarClientes";
            btnRegresarClientes.Size = new Size(111, 45);
            btnRegresarClientes.TabIndex = 0;
            btnRegresarClientes.Text = "Regresar";
            btnRegresarClientes.UseVisualStyleBackColor = false;
            btnRegresarClientes.Click += btnRegresarClientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnRegresarClientes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 57);
            panel1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(47, 121);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(206, 27);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackgroundImage = Properties.Resources.lupa;
            btnBuscarCliente.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarCliente.Location = new Point(259, 121);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(75, 29);
            btnBuscarCliente.TabIndex = 4;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(472, 205);
            dataGridView1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(36, 426);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(126, 44);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(203, 426);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 44);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(371, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 8;
            label1.Text = "Buscar";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 550);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtBuscar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresarClientes;
        private Panel panel1;
        private TextBox txtBuscar;
        private Button btnBuscarCliente;
        private DataGridView dataGridView1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
    }
}