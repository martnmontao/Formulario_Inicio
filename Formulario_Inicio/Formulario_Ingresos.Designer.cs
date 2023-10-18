namespace Formulario_Inicio
{
    partial class Formulario_Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Ingresos));
            pictureBoxApple = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblSueldo = new Label();
            lblSueldoDolares = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxApple
            // 
            pictureBoxApple.ErrorImage = null;
            pictureBoxApple.Image = Properties.Resources.AppleLogo1;
            pictureBoxApple.Location = new Point(55, 200);
            pictureBoxApple.Name = "pictureBoxApple";
            pictureBoxApple.Size = new Size(100, 67);
            pictureBoxApple.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxApple.TabIndex = 0;
            pictureBoxApple.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.MicrosoftLogo1;
            pictureBox2.Location = new Point(240, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoTesla;
            pictureBox3.Location = new Point(55, 333);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(240, 333);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(55, 56);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(35, 15);
            lblSueldo.TabIndex = 8;
            lblSueldo.Text = "$Arg:";
            // 
            // lblSueldoDolares
            // 
            lblSueldoDolares.AutoSize = true;
            lblSueldoDolares.Location = new Point(55, 123);
            lblSueldoDolares.Name = "lblSueldoDolares";
            lblSueldoDolares.Size = new Size(55, 15);
            lblSueldoDolares.TabIndex = 9;
            lblSueldoDolares.Text = "$Dolares:";
            // 
            // Formulario_Ingresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(lblSueldoDolares);
            Controls.Add(lblSueldo);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxApple);
            Name = "Formulario_Ingresos";
            Text = "Formulario_Ingresos";
            Load += Formulario_Ingresos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxApple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxApple;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblSueldo;
        private Label lblSueldoDolares;
    }
}