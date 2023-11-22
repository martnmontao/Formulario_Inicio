namespace Formulario_Inicio
{
    partial class Formulario_Inversiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Inversiones));
            lblNumeroInversionApple = new Label();
            lblNumeroInversionMicrosoft = new Label();
            lblNumeroInversionTesla = new Label();
            lblNumeroInversionAmazon = new Label();
            lblSueldoPesos = new Label();
            lblSueldoDolar = new Label();
            pictureBoxVolver = new PictureBox();
            panel1 = new Panel();
            cmbActivos = new ComboBox();
            dgvActivos = new DataGridView();
            btnInvertir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVolver).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroInversionApple
            // 
            lblNumeroInversionApple.AutoSize = true;
            lblNumeroInversionApple.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroInversionApple.Location = new Point(447, 110);
            lblNumeroInversionApple.Name = "lblNumeroInversionApple";
            lblNumeroInversionApple.Size = new Size(0, 24);
            lblNumeroInversionApple.TabIndex = 8;
            // 
            // lblNumeroInversionMicrosoft
            // 
            lblNumeroInversionMicrosoft.AutoSize = true;
            lblNumeroInversionMicrosoft.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroInversionMicrosoft.Location = new Point(438, 229);
            lblNumeroInversionMicrosoft.Name = "lblNumeroInversionMicrosoft";
            lblNumeroInversionMicrosoft.Size = new Size(0, 24);
            lblNumeroInversionMicrosoft.TabIndex = 9;
            // 
            // lblNumeroInversionTesla
            // 
            lblNumeroInversionTesla.AutoSize = true;
            lblNumeroInversionTesla.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroInversionTesla.Location = new Point(447, 336);
            lblNumeroInversionTesla.Name = "lblNumeroInversionTesla";
            lblNumeroInversionTesla.Size = new Size(0, 24);
            lblNumeroInversionTesla.TabIndex = 10;
            // 
            // lblNumeroInversionAmazon
            // 
            lblNumeroInversionAmazon.AutoSize = true;
            lblNumeroInversionAmazon.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroInversionAmazon.Location = new Point(438, 443);
            lblNumeroInversionAmazon.Name = "lblNumeroInversionAmazon";
            lblNumeroInversionAmazon.Size = new Size(0, 24);
            lblNumeroInversionAmazon.TabIndex = 11;
            // 
            // lblSueldoPesos
            // 
            lblSueldoPesos.AutoSize = true;
            lblSueldoPesos.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldoPesos.Location = new Point(264, 18);
            lblSueldoPesos.Name = "lblSueldoPesos";
            lblSueldoPesos.Size = new Size(90, 24);
            lblSueldoPesos.TabIndex = 16;
            lblSueldoPesos.Text = "PESOS";
            // 
            // lblSueldoDolar
            // 
            lblSueldoDolar.AutoSize = true;
            lblSueldoDolar.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldoDolar.Location = new Point(618, 18);
            lblSueldoDolar.Name = "lblSueldoDolar";
            lblSueldoDolar.Size = new Size(95, 24);
            lblSueldoDolar.TabIndex = 17;
            lblSueldoDolar.Text = "DOLAR";
            // 
            // pictureBoxVolver
            // 
            pictureBoxVolver.Cursor = Cursors.Hand;
            pictureBoxVolver.Image = (Image)resources.GetObject("pictureBoxVolver.Image");
            pictureBoxVolver.Location = new Point(0, 0);
            pictureBoxVolver.Name = "pictureBoxVolver";
            pictureBoxVolver.Size = new Size(69, 60);
            pictureBoxVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVolver.TabIndex = 22;
            pictureBoxVolver.TabStop = false;
            pictureBoxVolver.Click += pictureBoxVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 211, 213);
            panel1.Controls.Add(pictureBoxVolver);
            panel1.Controls.Add(lblSueldoPesos);
            panel1.Controls.Add(lblSueldoDolar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 56);
            panel1.TabIndex = 23;
            // 
            // cmbActivos
            // 
            cmbActivos.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbActivos.FormattingEnabled = true;
            cmbActivos.Items.AddRange(new object[] { "0 - Acciones", "1 - Cedears", "2 - Bonos públicos", "3 - Dolar MEP" });
            cmbActivos.Location = new Point(68, 66);
            cmbActivos.Name = "cmbActivos";
            cmbActivos.Size = new Size(746, 24);
            cmbActivos.TabIndex = 24;
            cmbActivos.Text = "Activos";
            cmbActivos.SelectedIndexChanged += cmbActivos_SelectedIndexChanged;
            // 
            // dgvActivos
            // 
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Location = new Point(68, 96);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.ReadOnly = true;
            dgvActivos.RowTemplate.Height = 25;
            dgvActivos.Size = new Size(746, 392);
            dgvActivos.TabIndex = 25;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(877, 96);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(138, 23);
            btnInvertir.TabIndex = 26;
            btnInvertir.Text = "Confirmar";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // Formulario_Inversiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 233, 234);
            ClientSize = new Size(1077, 570);
            Controls.Add(btnInvertir);
            Controls.Add(dgvActivos);
            Controls.Add(cmbActivos);
            Controls.Add(panel1);
            Controls.Add(lblNumeroInversionAmazon);
            Controls.Add(lblNumeroInversionTesla);
            Controls.Add(lblNumeroInversionMicrosoft);
            Controls.Add(lblNumeroInversionApple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Inversiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Inversiones";
            ((System.ComponentModel.ISupportInitialize)pictureBoxVolver).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNumeroInversionApple;
        private Label lblNumeroInversionMicrosoft;
        private Label lblNumeroInversionTesla;
        private Label lblNumeroInversionAmazon;
        private Label lblSueldoPesos;
        private Label lblSueldoDolar;
        private PictureBox pictureBoxVolver;
        private Panel panel1;
        private ComboBox cmbActivos;
        private DataGridView dgvActivos;
        private Button btnInvertir;
    }
}