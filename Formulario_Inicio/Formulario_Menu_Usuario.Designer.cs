namespace Formulario_Inicio
{
    partial class Formulario_Menu_Usuario
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblNombreUsuario = new Label();
            btnSalir = new Button();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            eSTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.MenuHighlight;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.GradientActiveCaption;
            lblTitulo.Location = new Point(302, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BOLSA DE VALORES";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.MenuHighlight;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.GradientActiveCaption;
            lblUsuario.Location = new Point(535, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = SystemColors.Highlight;
            lblNombreUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = SystemColors.GradientActiveCaption;
            lblNombreUsuario.Location = new Point(655, 45);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(77, 21);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "NOMBRE";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Highlight;
            btnSalir.Location = new Point(669, 460);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, eSTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(54, 20);
            iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // eSTToolStripMenuItem
            // 
            eSTToolStripMenuItem.Name = "eSTToolStripMenuItem";
            eSTToolStripMenuItem.Size = new Size(37, 20);
            eSTToolStripMenuItem.Text = "EST";
            // 
            // Formulario_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_Menu_Parcial;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 506);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Menu";
            Load += Formulario_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblNombreUsuario;
        private Button btnSalir;
        private ToolStripComboBox toolStripComboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem eSTToolStripMenuItem;
    }
}