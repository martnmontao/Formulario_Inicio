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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnVolver = new PictureBox();
            lblTitulo = new Label();
            btnCargarUsuarios = new Button();
            btnValidarUsuarios = new Button();
            btnEliminarUsuarios = new Button();
            bntUsuariosARegistrar = new Button();
            gridUsuarios = new DataGridView();
            btnVerificarEmpresa = new Button();
            chkMostrarContraseña = new CheckBox();
            btnMySql = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 51);
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
            lblTitulo.ForeColor = Color.LightGray;
            lblTitulo.Location = new Point(208, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de usuarios";
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnCargarUsuarios.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarUsuarios.ForeColor = Color.LightGray;
            btnCargarUsuarios.Location = new Point(79, 555);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(144, 44);
            btnCargarUsuarios.TabIndex = 2;
            btnCargarUsuarios.Text = "Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = false;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // btnValidarUsuarios
            // 
            btnValidarUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnValidarUsuarios.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidarUsuarios.ForeColor = Color.LightGray;
            btnValidarUsuarios.Location = new Point(196, 605);
            btnValidarUsuarios.Name = "btnValidarUsuarios";
            btnValidarUsuarios.Size = new Size(144, 44);
            btnValidarUsuarios.TabIndex = 3;
            btnValidarUsuarios.Text = "Validar usuarios";
            btnValidarUsuarios.UseVisualStyleBackColor = false;
            btnValidarUsuarios.Click += btnValidarUsuarios_Click;
            // 
            // btnEliminarUsuarios
            // 
            btnEliminarUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnEliminarUsuarios.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarUsuarios.ForeColor = Color.LightGray;
            btnEliminarUsuarios.Location = new Point(196, 605);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Size = new Size(144, 44);
            btnEliminarUsuarios.TabIndex = 4;
            btnEliminarUsuarios.Text = "Eliminar usuario";
            btnEliminarUsuarios.UseVisualStyleBackColor = false;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // bntUsuariosARegistrar
            // 
            bntUsuariosARegistrar.BackColor = Color.FromArgb(40, 40, 40);
            bntUsuariosARegistrar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntUsuariosARegistrar.ForeColor = Color.LightGray;
            bntUsuariosARegistrar.Location = new Point(314, 555);
            bntUsuariosARegistrar.Name = "bntUsuariosARegistrar";
            bntUsuariosARegistrar.Size = new Size(144, 44);
            bntUsuariosARegistrar.TabIndex = 5;
            bntUsuariosARegistrar.Text = "Usuarios a registrar";
            bntUsuariosARegistrar.UseVisualStyleBackColor = false;
            bntUsuariosARegistrar.Click += bntUsuariosARegistrar_Click;
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.BackgroundColor = Color.FromArgb(23, 21, 39);
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.GridColor = Color.FromArgb(40, 40, 40);
            gridUsuarios.Location = new Point(57, 71);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 21, 37);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            gridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.ScrollBars = ScrollBars.None;
            gridUsuarios.Size = new Size(635, 478);
            gridUsuarios.TabIndex = 6;
            // 
            // btnVerificarEmpresa
            // 
            btnVerificarEmpresa.BackColor = Color.FromArgb(40, 40, 40);
            btnVerificarEmpresa.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificarEmpresa.ForeColor = Color.LightGray;
            btnVerificarEmpresa.Location = new Point(431, 605);
            btnVerificarEmpresa.Name = "btnVerificarEmpresa";
            btnVerificarEmpresa.Size = new Size(144, 44);
            btnVerificarEmpresa.TabIndex = 8;
            btnVerificarEmpresa.Text = "Verificar empresa";
            btnVerificarEmpresa.UseVisualStyleBackColor = false;
            btnVerificarEmpresa.Visible = false;
            btnVerificarEmpresa.Click += btnVerificarEmpresa_Click;
            // 
            // chkMostrarContraseña
            // 
            chkMostrarContraseña.AutoSize = true;
            chkMostrarContraseña.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarContraseña.Location = new Point(1610, 777);
            chkMostrarContraseña.Name = "chkMostrarContraseña";
            chkMostrarContraseña.Size = new Size(204, 20);
            chkMostrarContraseña.TabIndex = 14;
            chkMostrarContraseña.Text = "Mostrar contraseña";
            chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnMySql
            // 
            btnMySql.BackColor = Color.FromArgb(40, 40, 40);
            btnMySql.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMySql.ForeColor = Color.LightGray;
            btnMySql.Location = new Point(548, 555);
            btnMySql.Name = "btnMySql";
            btnMySql.Size = new Size(144, 44);
            btnMySql.TabIndex = 15;
            btnMySql.Text = "Registrar a MySql";
            btnMySql.UseVisualStyleBackColor = false;
            btnMySql.Click += btnMySql_Click;
            // 
            // Formulario_Administrar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 39);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(757, 683);
            Controls.Add(btnMySql);
            Controls.Add(chkMostrarContraseña);
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
            Load += Formulario_Administrar_Usuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox chkMostrarContraseña;
        private Button btnMySql;
    }
}