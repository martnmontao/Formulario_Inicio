namespace Formulario_Inicio
{
    partial class Formulario_Iniciar_Sesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Iniciar_Sesion));
            lblLogin = new Label();
            pnlDolar = new Panel();
            lblEmpresa = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            lblRegistrarse = new LinkLabel();
            btnIniciarAdmin = new Button();
            txtDocumento = new TextBox();
            pnlDolar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.LightGray;
            lblLogin.Location = new Point(405, 25);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(272, 33);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "INICIAR SESIÓN";
            // 
            // pnlDolar
            // 
            pnlDolar.BackColor = Color.FromArgb(23, 21, 39);
            pnlDolar.BackgroundImage = (Image)resources.GetObject("pnlDolar.BackgroundImage");
            pnlDolar.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDolar.Controls.Add(lblEmpresa);
            pnlDolar.Dock = DockStyle.Left;
            pnlDolar.Location = new Point(0, 0);
            pnlDolar.Name = "pnlDolar";
            pnlDolar.Size = new Size(292, 390);
            pnlDolar.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.BackColor = Color.Transparent;
            lblEmpresa.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.LightGray;
            lblEmpresa.Location = new Point(63, 9);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(164, 33);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "InverLux";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaptionText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(343, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(392, 19);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "carlos";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ActiveCaptionText;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(343, 170);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(392, 19);
            txtContraseña.TabIndex = 3;
            txtContraseña.Text = "carlos";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Location = new Point(343, 234);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(392, 41);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "INICIAR SESIÓN";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(15, 15, 15);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(751, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 24);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(15, 15, 15);
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.minimizar1;
            btnMinimizar.Location = new Point(720, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(34, 24);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.BackColor = Color.Transparent;
            lblRegistrarse.Cursor = Cursors.SizeAll;
            lblRegistrarse.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrarse.ForeColor = Color.LightGray;
            lblRegistrarse.LinkColor = Color.LightGray;
            lblRegistrarse.Location = new Point(405, 353);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(278, 18);
            lblRegistrarse.TabIndex = 7;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = ">Registrarme a la aplicación<";
            lblRegistrarse.LinkClicked += lblRegistrarse_LinkClicked;
            // 
            // btnIniciarAdmin
            // 
            btnIniciarAdmin.BackColor = Color.FromArgb(40, 40, 40);
            btnIniciarAdmin.Cursor = Cursors.Hand;
            btnIniciarAdmin.FlatAppearance.BorderSize = 0;
            btnIniciarAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIniciarAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIniciarAdmin.FlatStyle = FlatStyle.Flat;
            btnIniciarAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarAdmin.ForeColor = Color.LightGray;
            btnIniciarAdmin.Location = new Point(343, 290);
            btnIniciarAdmin.Name = "btnIniciarAdmin";
            btnIniciarAdmin.Size = new Size(392, 41);
            btnIniciarAdmin.TabIndex = 8;
            btnIniciarAdmin.Text = "INICIAR SESIÓN COMO ADMINISTRADOR";
            btnIniciarAdmin.UseVisualStyleBackColor = false;
            btnIniciarAdmin.Click += btnIniciarAdmin_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = SystemColors.InactiveCaptionText;
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDocumento.ForeColor = Color.DimGray;
            txtDocumento.Location = new Point(343, 136);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Nro. Documento";
            txtDocumento.Size = new Size(392, 19);
            txtDocumento.TabIndex = 2;
            txtDocumento.Text = "46000000";
            // 
            // Formulario_Iniciar_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 24);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 390);
            ControlBox = false;
            Controls.Add(txtDocumento);
            Controls.Add(btnIniciarAdmin);
            Controls.Add(lblRegistrarse);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pnlDolar);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Iniciar_Sesion";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORMULARIO";
            Load += Formulario_Iniciar_Sesion_Load;
            pnlDolar.ResumeLayout(false);
            pnlDolar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Panel pnlDolar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAcceder;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Label lblEmpresa;
        private LinkLabel lblRegistrarse;
        private Button btnIniciarAdmin;
        private TextBox txtDocumento;
    }
}