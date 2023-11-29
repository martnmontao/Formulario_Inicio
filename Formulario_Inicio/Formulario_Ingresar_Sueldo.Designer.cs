namespace Formulario_Inicio
{
    partial class Formulario_Ingresar_Sueldo
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
            txtSueldo = new TextBox();
            btnIngresarSueldo = new Button();
            pictureBoxBotonVolver = new PictureBox();
            btnObtenerValorDolar = new Button();
            txtSueldoDolar = new TextBox();
            btnVenderMep = new Button();
            btnComprarMep = new Button();
            lblIngresarSueldo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBotonVolver).BeginInit();
            SuspendLayout();
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = SystemColors.InactiveBorder;
            txtSueldo.Location = new Point(88, 153);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(374, 23);
            txtSueldo.TabIndex = 0;
            // 
            // btnIngresarSueldo
            // 
            btnIngresarSueldo.BackColor = Color.FromArgb(40, 40, 40);
            btnIngresarSueldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarSueldo.ForeColor = Color.LightGray;
            btnIngresarSueldo.Location = new Point(78, 348);
            btnIngresarSueldo.Name = "btnIngresarSueldo";
            btnIngresarSueldo.Size = new Size(415, 34);
            btnIngresarSueldo.TabIndex = 2;
            btnIngresarSueldo.Text = "Confirmar";
            btnIngresarSueldo.UseVisualStyleBackColor = false;
            btnIngresarSueldo.Click += btnIngresarSueldo_Click;
            // 
            // pictureBoxBotonVolver
            // 
            pictureBoxBotonVolver.BackColor = Color.Transparent;
            pictureBoxBotonVolver.Image = Properties.Resources.botonVolver1;
            pictureBoxBotonVolver.Location = new Point(-1, -1);
            pictureBoxBotonVolver.Name = "pictureBoxBotonVolver";
            pictureBoxBotonVolver.Size = new Size(59, 50);
            pictureBoxBotonVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBotonVolver.TabIndex = 7;
            pictureBoxBotonVolver.TabStop = false;
            pictureBoxBotonVolver.Click += pictureBoxBotonVolver_Click;
            // 
            // btnObtenerValorDolar
            // 
            btnObtenerValorDolar.BackColor = Color.FromArgb(40, 40, 40);
            btnObtenerValorDolar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnObtenerValorDolar.ForeColor = Color.LightGray;
            btnObtenerValorDolar.Location = new Point(197, 281);
            btnObtenerValorDolar.Name = "btnObtenerValorDolar";
            btnObtenerValorDolar.Size = new Size(161, 26);
            btnObtenerValorDolar.TabIndex = 9;
            btnObtenerValorDolar.Text = "Obtener valor";
            btnObtenerValorDolar.UseVisualStyleBackColor = false;
            btnObtenerValorDolar.Click += btnObtenerValorDolar_Click;
            // 
            // txtSueldoDolar
            // 
            txtSueldoDolar.BackColor = SystemColors.InactiveBorder;
            txtSueldoDolar.Location = new Point(184, 230);
            txtSueldoDolar.Name = "txtSueldoDolar";
            txtSueldoDolar.PlaceholderText = "Valor total";
            txtSueldoDolar.Size = new Size(193, 23);
            txtSueldoDolar.TabIndex = 8;
            // 
            // btnVenderMep
            // 
            btnVenderMep.BackColor = Color.FromArgb(40, 40, 40);
            btnVenderMep.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenderMep.ForeColor = Color.LightGray;
            btnVenderMep.Location = new Point(46, 57);
            btnVenderMep.Name = "btnVenderMep";
            btnVenderMep.Size = new Size(178, 42);
            btnVenderMep.TabIndex = 10;
            btnVenderMep.Text = "Vender";
            btnVenderMep.UseVisualStyleBackColor = false;
            btnVenderMep.Click += btnVenderMep_Click;
            // 
            // btnComprarMep
            // 
            btnComprarMep.BackColor = Color.FromArgb(40, 40, 40);
            btnComprarMep.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprarMep.ForeColor = Color.LightGray;
            btnComprarMep.Location = new Point(338, 57);
            btnComprarMep.Name = "btnComprarMep";
            btnComprarMep.Size = new Size(178, 42);
            btnComprarMep.TabIndex = 11;
            btnComprarMep.Text = "Comprar";
            btnComprarMep.UseVisualStyleBackColor = false;
            // 
            // lblIngresarSueldo
            // 
            lblIngresarSueldo.AutoSize = true;
            lblIngresarSueldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresarSueldo.ForeColor = Color.LightGray;
            lblIngresarSueldo.Location = new Point(184, 117);
            lblIngresarSueldo.Name = "lblIngresarSueldo";
            lblIngresarSueldo.Size = new Size(193, 17);
            lblIngresarSueldo.TabIndex = 12;
            lblIngresarSueldo.Text = "Deposite el sueldo que desee:";
            // 
            // Formulario_Ingresar_Sueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 23, 39);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 450);
            Controls.Add(lblIngresarSueldo);
            Controls.Add(btnComprarMep);
            Controls.Add(btnVenderMep);
            Controls.Add(btnObtenerValorDolar);
            Controls.Add(txtSueldoDolar);
            Controls.Add(pictureBoxBotonVolver);
            Controls.Add(btnIngresarSueldo);
            Controls.Add(txtSueldo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Ingresar_Sueldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Ingresar_Sueldo";
            Load += Formulario_Ingresar_Sueldo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBotonVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldo;
        private Button btnIngresarSueldo;
        private PictureBox pictureBoxBotonVolver;
        private Button btnObtenerValorDolar;
        private TextBox txtSueldoDolar;
        private Button btnVenderMep;
        private Button btnComprarMep;
        private Label lblIngresarSueldo;
    }
}