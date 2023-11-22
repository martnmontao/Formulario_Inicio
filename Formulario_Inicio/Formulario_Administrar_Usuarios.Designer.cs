namespace Formulario_Inicio
{
    partial class Formulario_Administrar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Administrar_Usuarios));
            panel1 = new Panel();
            btnVolver = new PictureBox();
            lblTitulo = new Label();
            btnCargarUsuarios = new Button();
            btnValidarUsuarios = new Button();
            btnEliminarUsuarios = new Button();
            bntUsuariosARegistrar = new Button();
            gridUsuarios = new DataGridView();
            btnVerificarEmpresa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 211, 213);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 51);
            panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(49, 50);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 1;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(337, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de usuarios";
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.Location = new Point(764, 57);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(144, 44);
            btnCargarUsuarios.TabIndex = 2;
            btnCargarUsuarios.Text = "Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = true;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // btnValidarUsuarios
            // 
            btnValidarUsuarios.Location = new Point(764, 220);
            btnValidarUsuarios.Name = "btnValidarUsuarios";
            btnValidarUsuarios.Size = new Size(144, 44);
            btnValidarUsuarios.TabIndex = 3;
            btnValidarUsuarios.Text = "Validar usuarios";
            btnValidarUsuarios.UseVisualStyleBackColor = true;
            btnValidarUsuarios.Click += btnValidarUsuarios_Click;
            // 
            // btnEliminarUsuarios
            // 
            btnEliminarUsuarios.Location = new Point(764, 254);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Size = new Size(144, 44);
            btnEliminarUsuarios.TabIndex = 4;
            btnEliminarUsuarios.Text = "Eliminar usuario";
            btnEliminarUsuarios.UseVisualStyleBackColor = true;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // bntUsuariosARegistrar
            // 
            bntUsuariosARegistrar.Location = new Point(764, 139);
            bntUsuariosARegistrar.Name = "bntUsuariosARegistrar";
            bntUsuariosARegistrar.Size = new Size(144, 44);
            bntUsuariosARegistrar.TabIndex = 5;
            bntUsuariosARegistrar.Text = "Usuarios a registrar";
            bntUsuariosARegistrar.UseVisualStyleBackColor = true;
            bntUsuariosARegistrar.Click += bntUsuariosARegistrar_Click;
            // 
            // gridUsuarios
            // 
            gridUsuarios.BackgroundColor = SystemColors.ActiveCaption;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(74, 57);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(617, 527);
            gridUsuarios.TabIndex = 6;
            // 
            // btnVerificarEmpresa
            // 
            btnVerificarEmpresa.Location = new Point(764, 304);
            btnVerificarEmpresa.Name = "btnVerificarEmpresa";
            btnVerificarEmpresa.Size = new Size(144, 44);
            btnVerificarEmpresa.TabIndex = 8;
            btnVerificarEmpresa.Text = "Verificar empresa";
            btnVerificarEmpresa.UseVisualStyleBackColor = true;
            btnVerificarEmpresa.Click += btnVerificarEmpresa_Click;
            // 
            // Formulario_Administrar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 233, 234);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(968, 596);
            Controls.Add(btnVerificarEmpresa);
            Controls.Add(gridUsuarios);
            Controls.Add(bntUsuariosARegistrar);
            Controls.Add(btnEliminarUsuarios);
            Controls.Add(btnValidarUsuarios);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Administrar_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Administrar_Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private PictureBox btnVolver;
        private Button btnCargarUsuarios;
        private Button btnValidarUsuarios;
        private Button btnEliminarUsuarios;
        private Button bntUsuariosARegistrar;
        private DataGridView gridUsuarios;
        private Button btnVerificarEmpresa;
    }
}