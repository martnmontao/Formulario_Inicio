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
            panel2 = new Panel();
            btnVolver = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.ForeColor = Color.LightGray;
            lblInformacion.Location = new Point(371, 9);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(283, 33);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "¿Quiénes somos?";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.LightGray;
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
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(117, 110);
            label1.Name = "label1";
            label1.Size = new Size(799, 16);
            label1.TabIndex = 2;
            label1.Text = "En InverLux encontraras cuatro acciones a las cuales puedes invertir el dinero que deseas.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
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
            label3.ForeColor = Color.LightGray;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(lblInformacion);
            panel2.Controls.Add(btnVolver);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 58);
            panel2.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(57, 58);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 6;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Formulario_InformacionEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 39);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
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
        private Panel panel2;
        private PictureBox btnVolver;
    }
}