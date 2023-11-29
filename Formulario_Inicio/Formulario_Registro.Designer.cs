namespace Formulario_Inicio
{
    partial class Formulario_Registro
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
            Confirmar = new Button();
            txtBoxNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnCancelar = new Button();
            pnlSuperior = new Panel();
            lblRegistro = new Label();
            txtNroDocumento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // Confirmar
            // 
            Confirmar.BackColor = Color.FromArgb(40, 40, 40);
            Confirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Confirmar.ForeColor = Color.LightGray;
            Confirmar.Location = new Point(232, 322);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(116, 32);
            Confirmar.TabIndex = 0;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = false;
            Confirmar.Click += Confirmar_Click;
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.Location = new Point(43, 109);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.Size = new Size(305, 23);
            txtBoxNombreUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(43, 256);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(305, 23);
            txtContraseña.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(40, 40, 40);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(43, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 32);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(23, 21, 39);
            pnlSuperior.Controls.Add(lblRegistro);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(404, 68);
            pnlSuperior.TabIndex = 7;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistro.ForeColor = Color.LightGray;
            lblRegistro.Location = new Point(87, 22);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(231, 30);
            lblRegistro.TabIndex = 7;
            lblRegistro.Text = "REGISTRARSE";
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Location = new Point(43, 177);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(305, 23);
            txtNroDocumento.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(43, 81);
            label1.Name = "label1";
            label1.Size = new Size(171, 16);
            label1.TabIndex = 10;
            label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(43, 225);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 11;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(43, 146);
            label3.Name = "label3";
            label3.Size = new Size(152, 16);
            label3.TabIndex = 12;
            label3.Text = "Nro. Documento:";
            // 
            // Formulario_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 24);
            ClientSize = new Size(404, 393);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNroDocumento);
            Controls.Add(pnlSuperior);
            Controls.Add(btnCancelar);
            Controls.Add(txtContraseña);
            Controls.Add(txtBoxNombreUsuario);
            Controls.Add(Confirmar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Registro";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Confirmar;
        private TextBox txtBoxNombreUsuario;
        private TextBox txtContraseña;
        private Button btnCancelar;
        private Panel pnlSuperior;
        private Label lblRegistro;
        private TextBox txtNroDocumento;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}