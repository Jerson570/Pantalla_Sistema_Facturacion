namespace Pantalla_Sistema_Facturacion
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnValidar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(215, 324);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(132, 34);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 34);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cerrar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(264, 141);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(222, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(264, 253);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(222, 27);
            txtClave.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11F);
            label1.Location = new Point(340, 100);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F);
            label2.Location = new Point(314, 212);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13F);
            label3.Location = new Point(285, 29);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 6;
            label3.Text = "INICIAR SESION";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnValidar);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
