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
            txtSueldo.Location = new Point(195, 151);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(209, 23);
            txtSueldo.TabIndex = 0;
            // 
            // btnIngresarSueldo
            // 
            btnIngresarSueldo.BackColor = Color.FromArgb(199, 233, 234);
            btnIngresarSueldo.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarSueldo.Location = new Point(105, 381);
            btnIngresarSueldo.Name = "btnIngresarSueldo";
            btnIngresarSueldo.Size = new Size(387, 32);
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
            btnObtenerValorDolar.BackColor = Color.FromArgb(199, 233, 234);
            btnObtenerValorDolar.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnObtenerValorDolar.Location = new Point(232, 313);
            btnObtenerValorDolar.Name = "btnObtenerValorDolar";
            btnObtenerValorDolar.Size = new Size(129, 26);
            btnObtenerValorDolar.TabIndex = 9;
            btnObtenerValorDolar.Text = "Obtener valor";
            btnObtenerValorDolar.UseVisualStyleBackColor = false;
            btnObtenerValorDolar.Click += btnObtenerValorDolar_Click;
            // 
            // txtSueldoDolar
            // 
            txtSueldoDolar.BackColor = SystemColors.InactiveBorder;
            txtSueldoDolar.Location = new Point(195, 231);
            txtSueldoDolar.Name = "txtSueldoDolar";
            txtSueldoDolar.PlaceholderText = "Valor total";
            txtSueldoDolar.Size = new Size(209, 23);
            txtSueldoDolar.TabIndex = 8;
            // 
            // btnVenderMep
            // 
            btnVenderMep.Location = new Point(118, 83);
            btnVenderMep.Name = "btnVenderMep";
            btnVenderMep.Size = new Size(75, 23);
            btnVenderMep.TabIndex = 10;
            btnVenderMep.Text = "Vender";
            btnVenderMep.UseVisualStyleBackColor = true;
            btnVenderMep.Click += btnVenderMep_Click;
            // 
            // btnComprarMep
            // 
            btnComprarMep.Location = new Point(417, 83);
            btnComprarMep.Name = "btnComprarMep";
            btnComprarMep.Size = new Size(75, 23);
            btnComprarMep.TabIndex = 11;
            btnComprarMep.Text = "Comprar";
            btnComprarMep.UseVisualStyleBackColor = true;
            // 
            // lblIngresarSueldo
            // 
            lblIngresarSueldo.AutoSize = true;
            lblIngresarSueldo.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresarSueldo.Location = new Point(195, 34);
            lblIngresarSueldo.Name = "lblIngresarSueldo";
            lblIngresarSueldo.Size = new Size(218, 15);
            lblIngresarSueldo.TabIndex = 12;
            lblIngresarSueldo.Text = "Deposite el sueldo que desee:";
            // 
            // Formulario_Ingresar_Sueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 211, 213);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 489);
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