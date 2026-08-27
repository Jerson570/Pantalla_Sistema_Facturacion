namespace Pantalla_Sistema_Facturacion
{
    partial class frmInformes
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            rbtnPdf = new RadioButton();
            rbtnExcel = new RadioButton();
            btnSalirInformes = new Button();
            btnGenerarInforme = new Button();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(236, 20);
            label1.Name = "label1";
            label1.Size = new Size(272, 27);
            label1.TabIndex = 1;
            label1.Text = "Generador De Informes";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 127);
            label2.Name = "label2";
            label2.Size = new Size(153, 18);
            label2.TabIndex = 2;
            label2.Text = "Seleccione Informe";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Control;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(563, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(148, 28);
            comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(458, 127);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 4;
            label3.Text = "Ordenar por";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(211, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 211);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 11;
            label5.Text = "Fecha inicio";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(524, 207);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(124, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 212);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 13;
            label4.Text = "Fecha final";
            // 
            // rbtnPdf
            // 
            rbtnPdf.AutoSize = true;
            rbtnPdf.Location = new Point(261, 297);
            rbtnPdf.Name = "rbtnPdf";
            rbtnPdf.Size = new Size(56, 24);
            rbtnPdf.TabIndex = 15;
            rbtnPdf.TabStop = true;
            rbtnPdf.Text = "PDF";
            rbtnPdf.UseVisualStyleBackColor = true;
            // 
            // rbtnExcel
            // 
            rbtnExcel.AutoSize = true;
            rbtnExcel.Location = new Point(473, 297);
            rbtnExcel.Name = "rbtnExcel";
            rbtnExcel.Size = new Size(64, 24);
            rbtnExcel.TabIndex = 15;
            rbtnExcel.TabStop = true;
            rbtnExcel.Text = "Excel";
            rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // btnSalirInformes
            // 
            btnSalirInformes.Location = new Point(415, 373);
            btnSalirInformes.Name = "btnSalirInformes";
            btnSalirInformes.Size = new Size(154, 36);
            btnSalirInformes.TabIndex = 17;
            btnSalirInformes.Text = "Salir";
            btnSalirInformes.UseVisualStyleBackColor = true;
            btnSalirInformes.Click += btnSalirInformes_Click;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(217, 373);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(154, 36);
            btnGenerarInforme.TabIndex = 16;
            btnGenerarInforme.Text = "Generar Informe";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirInformes);
            Controls.Add(btnGenerarInforme);
            Controls.Add(rbtnExcel);
            Controls.Add(rbtnPdf);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInformes";
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
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private RadioButton rbtnPdf;
        private RadioButton rbtnExcel;
        private Button btnSalirInformes;
        private Button btnGenerarInforme;
    }
}