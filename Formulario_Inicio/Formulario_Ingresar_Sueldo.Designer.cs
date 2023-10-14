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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Ingresar_Sueldo));
            txtSueldoPesos = new TextBox();
            btnIngresarSueldo = new Button();
            txtSueldoDolares = new TextBox();
            lblInformacionSueldo = new Label();
            label1 = new Label();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // txtSueldoPesos
            // 
            txtSueldoPesos.Location = new Point(102, 121);
            txtSueldoPesos.Name = "txtSueldoPesos";
            txtSueldoPesos.Size = new Size(387, 23);
            txtSueldoPesos.TabIndex = 0;
            // 
            // btnIngresarSueldo
            // 
            btnIngresarSueldo.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarSueldo.Location = new Point(102, 365);
            btnIngresarSueldo.Name = "btnIngresarSueldo";
            btnIngresarSueldo.Size = new Size(387, 32);
            btnIngresarSueldo.TabIndex = 2;
            btnIngresarSueldo.Text = "Ingresar ";
            btnIngresarSueldo.UseVisualStyleBackColor = true;
            btnIngresarSueldo.Click += btnIngresarSueldo_Click;
            // 
            // txtSueldoDolares
            // 
            txtSueldoDolares.Location = new Point(102, 239);
            txtSueldoDolares.Name = "txtSueldoDolares";
            txtSueldoDolares.ReadOnly = true;
            txtSueldoDolares.Size = new Size(387, 23);
            txtSueldoDolares.TabIndex = 3;
            // 
            // lblInformacionSueldo
            // 
            lblInformacionSueldo.AutoSize = true;
            lblInformacionSueldo.BackColor = SystemColors.ControlDark;
            lblInformacionSueldo.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacionSueldo.Location = new Point(66, 74);
            lblInformacionSueldo.Name = "lblInformacionSueldo";
            lblInformacionSueldo.Size = new Size(472, 24);
            lblInformacionSueldo.TabIndex = 4;
            lblInformacionSueldo.Text = "Ingrese el dinero que quiera depositar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 174);
            label1.Name = "label1";
            label1.Size = new Size(309, 24);
            label1.TabIndex = 5;
            label1.Text = "Equivalencia en dolares:";
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(199, 292);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(190, 32);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Formulario_Ingresar_Sueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(619, 450);
            Controls.Add(btnConvertir);
            Controls.Add(label1);
            Controls.Add(lblInformacionSueldo);
            Controls.Add(txtSueldoDolares);
            Controls.Add(btnIngresarSueldo);
            Controls.Add(txtSueldoPesos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Ingresar_Sueldo";
            Text = "Formulario_Ingresar_Sueldo";
            Load += Formulario_Ingresar_Sueldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldoPesos;
        private Button btnIngresarSueldo;
        private TextBox txtSueldoDolares;
        private Label lblInformacionSueldo;
        private Label label1;
        private Button btnConvertir;
    }
}