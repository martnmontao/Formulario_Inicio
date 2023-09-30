namespace Formulario_Inicio
{
    partial class Fomurlario_Iniciar_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fomurlario_Iniciar_Sesion));
            lblLogin = new Label();
            pnlDolar = new Panel();
            lblEmpresa = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtAcceder = new Button();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            pnlDolar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.LightGray;
            lblLogin.Location = new Point(486, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(108, 33);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // pnlDolar
            // 
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
            lblEmpresa.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(53, 9);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(190, 31);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "AdminisTrading";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaptionText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(343, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "USER";
            txtUsuario.Size = new Size(392, 15);
            txtUsuario.TabIndex = 1;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ActiveCaptionText;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(343, 183);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "PASSWORD";
            txtContraseña.Size = new Size(392, 15);
            txtContraseña.TabIndex = 2;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtAcceder
            // 
            txtAcceder.BackColor = Color.FromArgb(40, 40, 40);
            txtAcceder.FlatAppearance.BorderSize = 0;
            txtAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            txtAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            txtAcceder.FlatStyle = FlatStyle.Flat;
            txtAcceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAcceder.ForeColor = Color.LightGray;
            txtAcceder.Location = new Point(343, 263);
            txtAcceder.Name = "txtAcceder";
            txtAcceder.Size = new Size(392, 40);
            txtAcceder.TabIndex = 0;
            txtAcceder.Text = "LOGIN";
            txtAcceder.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(15, 15, 15);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(764, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(15, 15);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(15, 15, 15);
            btnMinimizar.Image = Properties.Resources.minimizar1;
            btnMinimizar.Location = new Point(743, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(15, 15);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Fomurlario_Iniciar_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_Inicio_sesion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 390);
            ControlBox = false;
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(txtAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pnlDolar);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fomurlario_Iniciar_Sesion";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORMULARIO";
            Load += Form1_Load;
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
        private Button txtAcceder;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Label lblEmpresa;
    }
}