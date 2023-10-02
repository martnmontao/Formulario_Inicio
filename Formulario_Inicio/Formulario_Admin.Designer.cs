namespace Formulario_Inicio
{
    partial class Formulario_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Admin));
            panelIzquierdo = new Panel();
            btnAcciones = new Button();
            btnUsuarios = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblNombreUsuario = new Label();
            lblIdUsuario = new Label();
            btnLogoUsuario = new PictureBox();
            panelIzquierdo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(246, 212, 94);
            panelIzquierdo.Controls.Add(btnAcciones);
            panelIzquierdo.Controls.Add(btnUsuarios);
            panelIzquierdo.Location = new Point(0, 100);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(209, 496);
            panelIzquierdo.TabIndex = 1;
            // 
            // btnAcciones
            // 
            btnAcciones.BackColor = Color.FromArgb(40, 40, 40);
            btnAcciones.Cursor = Cursors.Hand;
            btnAcciones.FlatAppearance.BorderSize = 0;
            btnAcciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcciones.FlatStyle = FlatStyle.Flat;
            btnAcciones.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcciones.ForeColor = Color.LightGray;
            btnAcciones.Location = new Point(12, 119);
            btnAcciones.Name = "btnAcciones";
            btnAcciones.Size = new Size(183, 40);
            btnAcciones.TabIndex = 3;
            btnAcciones.Text = "Acciones";
            btnAcciones.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.LightGray;
            btnUsuarios.Location = new Point(13, 30);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(182, 40);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 212, 94);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(lblIdUsuario);
            panel1.Controls.Add(btnLogoUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 100);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.ImagenDolar5;
            pictureBox1.Location = new Point(852, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(124, 19);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(95, 21);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdUsuario.Location = new Point(124, 60);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(124, 21);
            lblIdUsuario.TabIndex = 1;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // btnLogoUsuario
            // 
            btnLogoUsuario.Image = (Image)resources.GetObject("btnLogoUsuario.Image");
            btnLogoUsuario.Location = new Point(0, 0);
            btnLogoUsuario.Name = "btnLogoUsuario";
            btnLogoUsuario.Size = new Size(101, 100);
            btnLogoUsuario.TabIndex = 0;
            btnLogoUsuario.TabStop = false;
            // 
            // Formulario_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 596);
            Controls.Add(panel1);
            Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Admin";
            Text = "Formulario_Admin";
            Load += Formulario_Admin_Load;
            panelIzquierdo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelIzquierdo;
        private Button button1;
        private Panel panel1;
        private PictureBox btnLogoUsuario;
        private Label lblNombreUsuario;
        private Label lblIdUsuario;
        private PictureBox pictureBox1;
        private Button btnUsuarios;
        private Button btnAcciones;
    }
}