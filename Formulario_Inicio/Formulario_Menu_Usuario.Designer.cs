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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Menu_Usuario));
            toolStripComboBox1 = new ToolStripComboBox();
            menuVertical = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            barraTitulo = new Panel();
            btnOpciones = new PictureBox();
            panelContenedor = new Panel();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).BeginInit();
            SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(236, 207, 44);
            menuVertical.Controls.Add(label1);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(260, 607);
            menuVertical.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OldSansBlack", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 17);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 1;
            label1.Text = "AdminisTrading";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagenDolar2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(236, 207, 44);
            barraTitulo.Controls.Add(btnOpciones);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(260, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(667, 50);
            barraTitulo.TabIndex = 1;
            // 
            // btnOpciones
            // 
            btnOpciones.Image = (Image)resources.GetObject("btnOpciones.Image");
            btnOpciones.Location = new Point(6, 9);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(35, 35);
            btnOpciones.SizeMode = PictureBoxSizeMode.Zoom;
            btnOpciones.TabIndex = 0;
            btnOpciones.TabStop = false;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(252, 202, 114);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(260, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(667, 557);
            panelContenedor.TabIndex = 2;
          
            // 
            // Formulario_Menu_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 37, 113);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(927, 607);
            ControlBox = false;
            Controls.Add(panelContenedor);
            Controls.Add(barraTitulo);
            Controls.Add(menuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Menu_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Menu";
            Load += Formulario_Menu_Load;
            menuVertical.ResumeLayout(false);
            menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnOpciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripComboBox toolStripComboBox1;
        private Panel menuVertical;
        protected Panel barraTitulo;
        private Panel panelContenedor;
        private PictureBox btnOpciones;
        private Label label1;
        private PictureBox pictureBox1;
    }
}