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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnVolver = new PictureBox();
            lblTitulo = new Label();
            btnValidarUsuarios = new Button();
            bntUsuariosARegistrar = new Button();
            gridUsuarios = new DataGridView();
            chkMostrarContraseña = new CheckBox();
            txtDocumento = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            btnModificarUsuario = new Button();
            lblDocumento = new Label();
            lblNombre = new Label();
            lblContraseña = new Label();
            txtID = new TextBox();
            lblID = new Label();
            gridUsuariosMySql = new DataGridView();
            btnUsuariosMySql = new Button();
            txtEmpresa = new TextBox();
            lblEmpresa = new Label();
            txtPesos = new TextBox();
            txtDolares = new TextBox();
            lblDolares = new Label();
            lblPesos = new Label();
            btnEliminarMySql = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuariosMySql).BeginInit();
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
            panel1.Size = new Size(1463, 51);
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
            lblTitulo.Location = new Point(578, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de usuarios";
            // 
            // btnValidarUsuarios
            // 
            btnValidarUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            btnValidarUsuarios.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidarUsuarios.ForeColor = Color.LightGray;
            btnValidarUsuarios.Location = new Point(464, 629);
            btnValidarUsuarios.Name = "btnValidarUsuarios";
            btnValidarUsuarios.Size = new Size(228, 44);
            btnValidarUsuarios.TabIndex = 3;
            btnValidarUsuarios.Text = "Validar usuarios";
            btnValidarUsuarios.UseVisualStyleBackColor = false;
            btnValidarUsuarios.Click += btnValidarUsuarios_Click;
            // 
            // bntUsuariosARegistrar
            // 
            bntUsuariosARegistrar.BackColor = Color.FromArgb(40, 40, 40);
            bntUsuariosARegistrar.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntUsuariosARegistrar.ForeColor = Color.LightGray;
            bntUsuariosARegistrar.Location = new Point(464, 555);
            bntUsuariosARegistrar.Name = "bntUsuariosARegistrar";
            bntUsuariosARegistrar.Size = new Size(228, 44);
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
            gridUsuarios.Location = new Point(57, 106);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 21, 37);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            gridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.ScrollBars = ScrollBars.None;
            gridUsuarios.Size = new Size(635, 443);
            gridUsuarios.TabIndex = 6;
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
            // txtDocumento
            // 
            txtDocumento.Location = new Point(807, 226);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "DOCUMENTO";
            txtDocumento.Size = new Size(292, 23);
            txtDocumento.TabIndex = 16;
            txtDocumento.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(1148, 313);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "CONTRASEÑA";
            txtContraseña.Size = new Size(292, 23);
            txtContraseña.TabIndex = 19;
            txtContraseña.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(807, 313);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "NOMBRE";
            txtNombre.Size = new Size(292, 23);
            txtNombre.TabIndex = 20;
            txtNombre.Visible = false;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnModificarUsuario.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarUsuario.ForeColor = Color.LightGray;
            btnModificarUsuario.Location = new Point(807, 555);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(292, 44);
            btnModificarUsuario.TabIndex = 21;
            btnModificarUsuario.Text = "Modificar usuario";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Visible = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.Transparent;
            lblDocumento.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento.ForeColor = Color.LightGray;
            lblDocumento.Location = new Point(807, 190);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(109, 16);
            lblDocumento.TabIndex = 22;
            lblDocumento.Text = "Documento:";
            lblDocumento.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.LightGray;
            lblNombre.Location = new Point(807, 265);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 16);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre:";
            lblNombre.Visible = false;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.LightGray;
            lblContraseña.Location = new Point(1148, 265);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(116, 16);
            lblContraseña.TabIndex = 24;
            lblContraseña.Text = "Contraseña:";
            lblContraseña.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(807, 147);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(292, 23);
            txtID.TabIndex = 25;
            txtID.Visible = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.ForeColor = Color.LightGray;
            lblID.Location = new Point(807, 106);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 16);
            lblID.TabIndex = 26;
            lblID.Text = "ID:";
            lblID.Visible = false;
            // 
            // gridUsuariosMySql
            // 
            gridUsuariosMySql.AllowUserToResizeRows = false;
            gridUsuariosMySql.BackgroundColor = Color.FromArgb(23, 21, 39);
            gridUsuariosMySql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuariosMySql.GridColor = Color.FromArgb(40, 40, 40);
            gridUsuariosMySql.Location = new Point(57, 106);
            gridUsuariosMySql.Name = "gridUsuariosMySql";
            gridUsuariosMySql.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 21, 37);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            gridUsuariosMySql.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gridUsuariosMySql.RowTemplate.Height = 25;
            gridUsuariosMySql.ScrollBars = ScrollBars.None;
            gridUsuariosMySql.Size = new Size(635, 443);
            gridUsuariosMySql.TabIndex = 29;
            gridUsuariosMySql.CellClick += gridUsuariosMySql_CellClick;
            // 
            // btnUsuariosMySql
            // 
            btnUsuariosMySql.BackColor = Color.FromArgb(40, 40, 40);
            btnUsuariosMySql.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuariosMySql.ForeColor = Color.LightGray;
            btnUsuariosMySql.Location = new Point(57, 555);
            btnUsuariosMySql.Name = "btnUsuariosMySql";
            btnUsuariosMySql.Size = new Size(228, 44);
            btnUsuariosMySql.TabIndex = 30;
            btnUsuariosMySql.Text = "Usuarios MySql";
            btnUsuariosMySql.UseVisualStyleBackColor = false;
            btnUsuariosMySql.Click += btnUsuariosMySql_Click;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(807, 403);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PlaceholderText = "Empresa";
            txtEmpresa.Size = new Size(292, 23);
            txtEmpresa.TabIndex = 31;
            txtEmpresa.Visible = false;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.BackColor = Color.Transparent;
            lblEmpresa.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.LightGray;
            lblEmpresa.Location = new Point(807, 366);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(84, 16);
            lblEmpresa.TabIndex = 32;
            lblEmpresa.Text = "Empresa:";
            lblEmpresa.Visible = false;
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(1148, 147);
            txtPesos.Name = "txtPesos";
            txtPesos.PlaceholderText = "Pesos";
            txtPesos.Size = new Size(292, 23);
            txtPesos.TabIndex = 33;
            txtPesos.Visible = false;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(1148, 226);
            txtDolares.Name = "txtDolares";
            txtDolares.PlaceholderText = "Dolares";
            txtDolares.Size = new Size(292, 23);
            txtDolares.TabIndex = 34;
            txtDolares.Visible = false;
            // 
            // lblDolares
            // 
            lblDolares.AutoSize = true;
            lblDolares.BackColor = Color.Transparent;
            lblDolares.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDolares.ForeColor = Color.LightGray;
            lblDolares.Location = new Point(1148, 190);
            lblDolares.Name = "lblDolares";
            lblDolares.Size = new Size(84, 16);
            lblDolares.TabIndex = 35;
            lblDolares.Text = "Dolares:";
            lblDolares.Visible = false;
            // 
            // lblPesos
            // 
            lblPesos.AutoSize = true;
            lblPesos.BackColor = Color.Transparent;
            lblPesos.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesos.ForeColor = Color.LightGray;
            lblPesos.Location = new Point(1148, 106);
            lblPesos.Name = "lblPesos";
            lblPesos.Size = new Size(62, 16);
            lblPesos.TabIndex = 36;
            lblPesos.Text = "Pesos:";
            lblPesos.Visible = false;
            // 
            // btnEliminarMySql
            // 
            btnEliminarMySql.BackColor = Color.FromArgb(40, 40, 40);
            btnEliminarMySql.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarMySql.ForeColor = Color.LightGray;
            btnEliminarMySql.Location = new Point(1159, 555);
            btnEliminarMySql.Name = "btnEliminarMySql";
            btnEliminarMySql.Size = new Size(292, 44);
            btnEliminarMySql.TabIndex = 37;
            btnEliminarMySql.Text = "Eliminar usuario MySql";
            btnEliminarMySql.UseVisualStyleBackColor = false;
            btnEliminarMySql.Visible = false;
            btnEliminarMySql.Click += btnEliminarMySql_Click;
            // 
            // Formulario_Administrar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 39);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1463, 696);
            Controls.Add(btnEliminarMySql);
            Controls.Add(lblPesos);
            Controls.Add(lblDolares);
            Controls.Add(txtDolares);
            Controls.Add(txtPesos);
            Controls.Add(lblEmpresa);
            Controls.Add(txtEmpresa);
            Controls.Add(btnUsuariosMySql);
            Controls.Add(gridUsuariosMySql);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblDocumento);
            Controls.Add(btnModificarUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(txtDocumento);
            Controls.Add(chkMostrarContraseña);
            Controls.Add(gridUsuarios);
            Controls.Add(bntUsuariosARegistrar);
            Controls.Add(btnValidarUsuarios);
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
            ((System.ComponentModel.ISupportInitialize)gridUsuariosMySql).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private PictureBox btnVolver;
        private Button btnValidarUsuarios;
        private Button bntUsuariosARegistrar;
        private DataGridView gridUsuarios;
        private CheckBox chkMostrarContraseña;
        private TextBox txtDocumento;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button btnModificarUsuario;
        private Label lblDocumento;
        private Label lblNombre;
        private Label lblContraseña;
        private TextBox txtID;
        private Label lblID;
        private DataGridView gridUsuariosMySql;
        private Button btnUsuariosMySql;
        private TextBox txtEmpresa;
        private Label lblEmpresa;
        private TextBox txtPesos;
        private TextBox txtDolares;
        private Label lblDolares;
        private Label lblPesos;
        private Button btnEliminarMySql;
    }
}