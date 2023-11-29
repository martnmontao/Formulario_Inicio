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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            lblSueldoPesos.ForeColor = Color.LightGray;
            lblSueldoPesos.Location = new Point(98, 18);
            lblSueldoPesos.Name = "lblSueldoPesos";
            lblSueldoPesos.Size = new Size(90, 24);
            lblSueldoPesos.TabIndex = 16;
            lblSueldoPesos.Text = "PESOS";
            // 
            // lblSueldoDolar
            // 
            lblSueldoDolar.AutoSize = true;
            lblSueldoDolar.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldoDolar.ForeColor = Color.LightGray;
            lblSueldoDolar.Location = new Point(488, 18);
            lblSueldoDolar.Name = "lblSueldoDolar";
            lblSueldoDolar.Size = new Size(95, 24);
            lblSueldoDolar.TabIndex = 17;
            lblSueldoDolar.Text = "DOLAR";
            // 
            // pictureBoxVolver
            // 
            pictureBoxVolver.BackColor = Color.FromArgb(40, 40, 40);
            pictureBoxVolver.Cursor = Cursors.Hand;
            pictureBoxVolver.Image = (Image)resources.GetObject("pictureBoxVolver.Image");
            pictureBoxVolver.Location = new Point(12, 3);
            pictureBoxVolver.Name = "pictureBoxVolver";
            pictureBoxVolver.Size = new Size(57, 50);
            pictureBoxVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVolver.TabIndex = 22;
            pictureBoxVolver.TabStop = false;
            pictureBoxVolver.Click += pictureBoxVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(pictureBoxVolver);
            panel1.Controls.Add(lblSueldoPesos);
            panel1.Controls.Add(lblSueldoDolar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 56);
            panel1.TabIndex = 23;
            // 
            // cmbActivos
            // 
            cmbActivos.BackColor = Color.FromArgb(23, 21, 32);
            cmbActivos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivos.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbActivos.ForeColor = Color.LightGray;
            cmbActivos.FormattingEnabled = true;
            cmbActivos.Items.AddRange(new object[] { "0 - Acciones", "1 - Cedears", "2 - Bonos públicos", "3 - Dolar MEP" });
            cmbActivos.Location = new Point(68, 66);
            cmbActivos.Name = "cmbActivos";
            cmbActivos.Size = new Size(746, 24);
            cmbActivos.TabIndex = 24;
            cmbActivos.SelectedIndexChanged += cmbActivos_SelectedIndexChanged;
            // 
            // dgvActivos
            // 
            dgvActivos.AllowUserToResizeColumns = false;
            dgvActivos.BackgroundColor = Color.FromArgb(23, 21, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 21, 32);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 21, 32);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvActivos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvActivos.EnableHeadersVisualStyles = false;
            dgvActivos.Location = new Point(68, 124);
            dgvActivos.Name = "dgvActivos";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(23, 21, 32);
            dgvActivos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvActivos.RowTemplate.Height = 25;
            dgvActivos.ScrollBars = ScrollBars.None;
            dgvActivos.Size = new Size(742, 259);
            dgvActivos.TabIndex = 30;
            // 
            // btnInvertir
            // 
            btnInvertir.BackColor = Color.FromArgb(40, 40, 40);
            btnInvertir.Cursor = Cursors.Hand;
            btnInvertir.FlatAppearance.BorderSize = 0;
            btnInvertir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvertir.ForeColor = Color.LightGray;
            btnInvertir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvertir.Location = new Point(68, 457);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Padding = new Padding(9, 0, 0, 0);
            btnInvertir.Size = new Size(742, 36);
            btnInvertir.TabIndex = 31;
            btnInvertir.Text = "Condirmar";
            btnInvertir.UseVisualStyleBackColor = false;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // Formulario_Inversiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(861, 559);
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
            Load += Formulario_Inversiones_Load;
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