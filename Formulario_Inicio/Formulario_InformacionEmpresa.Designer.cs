namespace Formulario_Inicio
{
    partial class Formulario_InformacionEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_InformacionEmpresa));
            lblInformacion = new Label();
            lblDescripcion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnVolver = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.Location = new Point(371, 9);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(283, 33);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "¿Quiénes somos?";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(205, 94);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(584, 16);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "InverLux es una empresa especializada en el manejo de inversiones.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 110);
            label1.Name = "label1";
            label1.Size = new Size(806, 16);
            label1.TabIndex = 2;
            label1.Text = "En InverLux encontraras variedad acciones a las cuales puede invertir el dinero que deseas.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(1025, 16);
            label2.TabIndex = 3;
            label2.Text = "Trabajamos con el objetivo de mostrarle al mundo cómo y dónde invertir puede traerles grandes beneficios a futuro. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(293, 407);
            label3.Name = "label3";
            label3.Size = new Size(430, 30);
            label3.TabIndex = 4;
            label3.Text = "¡COMIENZA A INVERTIR YA!";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(411, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 170);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Image = Properties.Resources.iconoVolver;
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(57, 58);
            btnVolver.TabIndex = 6;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(lblInformacion);
            panel2.Controls.Add(btnVolver);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 58);
            panel2.TabIndex = 7;
            // 
            // Formulario_InformacionEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 197, 0);
            ClientSize = new Size(1041, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDescripcion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_InformacionEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_InformacionEmpresa";
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private Label lblDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox btnVolver;
        private Panel panel2;
    }
}