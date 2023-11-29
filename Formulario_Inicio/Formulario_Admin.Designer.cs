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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblNombreUsuario = new Label();
            btnLogoUsuario = new PictureBox();
            btnActualizarDolar = new Button();
            txtValorCompraDolar = new TextBox();
            btnUsuarios = new Button();
            txtValorVentaDolar = new TextBox();
            btnSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 21, 39);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(btnLogoUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.ImagenDolar5;
            pictureBox1.Location = new Point(571, 0);
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
            lblNombreUsuario.ForeColor = Color.LightGray;
            lblNombreUsuario.Location = new Point(127, 18);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(95, 21);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre";
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
            // btnActualizarDolar
            // 
            btnActualizarDolar.BackColor = Color.FromArgb(40, 40, 40);
            btnActualizarDolar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizarDolar.ForeColor = Color.LightGray;
            btnActualizarDolar.Location = new Point(212, 339);
            btnActualizarDolar.Name = "btnActualizarDolar";
            btnActualizarDolar.Size = new Size(272, 43);
            btnActualizarDolar.TabIndex = 3;
            btnActualizarDolar.Text = "Actualizar dolar";
            btnActualizarDolar.UseVisualStyleBackColor = false;
            btnActualizarDolar.Click += btnActualizarDolar_Click;
            // 
            // txtValorCompraDolar
            // 
            txtValorCompraDolar.Location = new Point(127, 211);
            txtValorCompraDolar.Name = "txtValorCompraDolar";
            txtValorCompraDolar.PlaceholderText = "Valor compra dolar";
            txtValorCompraDolar.Size = new Size(443, 23);
            txtValorCompraDolar.TabIndex = 11;
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
            btnUsuarios.Location = new Point(127, 124);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(443, 40);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click_1;
            // 
            // txtValorVentaDolar
            // 
            txtValorVentaDolar.Location = new Point(127, 284);
            txtValorVentaDolar.Name = "txtValorVentaDolar";
            txtValorVentaDolar.PlaceholderText = "Valor venta dolar";
            txtValorVentaDolar.Size = new Size(443, 23);
            txtValorVentaDolar.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(40, 40, 40);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(12, 466);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 29);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Formulario_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 24);
            ClientSize = new Size(684, 507);
            Controls.Add(btnSalir);
            Controls.Add(txtValorVentaDolar);
            Controls.Add(txtValorCompraDolar);
            Controls.Add(btnUsuarios);
            Controls.Add(btnActualizarDolar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelIzquierdo;
        private Button btnSalir;
        private Panel panel1;
        private PictureBox btnLogoUsuario;
        private PictureBox pictureBox1;
        private Button btnAcciones;
        private Button btnActualizarDolar;
        private TextBox txtValorCompraDolar;
        private Label lblNombreUsuario;
        private Button btnUsuarios;
        private TextBox txtValorVentaDolar;
    }
}