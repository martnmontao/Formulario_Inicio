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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnVolver = new PictureBox();
            label1 = new Label();
            gridUsuarios = new DataGridView();
            btnCargarUsuarios = new Button();
            btnValidarUsuarios = new Button();
            btnEliminarUsuarios = new Button();
            bntUsuariosARegistrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 186, 75);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 51);
            panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Image = Properties.Resources.iconoVolver1;
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(49, 50);
            btnVolver.TabIndex = 1;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 33);
            label1.TabIndex = 0;
            label1.Text = "Lista de usuarios";
            // 
            // gridUsuarios
            // 
            gridUsuarios.BackgroundColor = Color.FromArgb(255, 192, 128);
            gridUsuarios.BorderStyle = BorderStyle.None;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(64, 57);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            gridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(419, 412);
            gridUsuarios.TabIndex = 1;
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.Location = new Point(64, 493);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(144, 44);
            btnCargarUsuarios.TabIndex = 2;
            btnCargarUsuarios.Text = "Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = true;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // btnValidarUsuarios
            // 
            btnValidarUsuarios.Location = new Point(447, 493);
            btnValidarUsuarios.Name = "btnValidarUsuarios";
            btnValidarUsuarios.Size = new Size(135, 44);
            btnValidarUsuarios.TabIndex = 3;
            btnValidarUsuarios.Text = "Validar usuarios";
            btnValidarUsuarios.UseVisualStyleBackColor = true;
            btnValidarUsuarios.Click += btnValidarUsuarios_Click;
            // 
            // btnEliminarUsuarios
            // 
            btnEliminarUsuarios.Location = new Point(637, 493);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Size = new Size(132, 44);
            btnEliminarUsuarios.TabIndex = 4;
            btnEliminarUsuarios.Text = "Eliminar usuario";
            btnEliminarUsuarios.UseVisualStyleBackColor = true;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // bntUsuariosARegistrar
            // 
            bntUsuariosARegistrar.Location = new Point(251, 493);
            bntUsuariosARegistrar.Name = "bntUsuariosARegistrar";
            bntUsuariosARegistrar.Size = new Size(133, 44);
            bntUsuariosARegistrar.TabIndex = 5;
            bntUsuariosARegistrar.Text = "Usuarios a registrar";
            bntUsuariosARegistrar.UseVisualStyleBackColor = true;
            bntUsuariosARegistrar.Click += bntUsuariosARegistrar_Click;
            // 
            // Formulario_Administrar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 212, 94);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(968, 596);
            Controls.Add(bntUsuariosARegistrar);
            Controls.Add(btnEliminarUsuarios);
            Controls.Add(btnValidarUsuarios);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(gridUsuarios);
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
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnVolver;
        private DataGridView gridUsuarios;
        private Button btnCargarUsuarios;
        private Button btnValidarUsuarios;
        private Button btnEliminarUsuarios;
        private Button bntUsuariosARegistrar;
    }
}