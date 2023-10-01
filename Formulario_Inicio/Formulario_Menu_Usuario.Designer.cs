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
            btnInformacion = new Button();
            btnConfiguracion = new Button();
            btnInvertir = new Button();
            btnIngresarDinero = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            barraTitulo = new Panel();
            btnMinimizarClick = new PictureBox();
            btmCerrarClick = new PictureBox();
            btnOpciones = new PictureBox();
            panelContenedor = new Panel();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btmCerrarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(255, 197, 0);
            menuVertical.Controls.Add(btnInformacion);
            menuVertical.Controls.Add(btnConfiguracion);
            menuVertical.Controls.Add(btnInvertir);
            menuVertical.Controls.Add(btnIngresarDinero);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 50);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(233, 468);
            menuVertical.TabIndex = 0;
            // 
            // btnInformacion
            // 
            btnInformacion.Cursor = Cursors.Hand;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInformacion.ForeColor = SystemColors.ActiveCaptionText;
            btnInformacion.Image = (Image)resources.GetObject("btnInformacion.Image");
            btnInformacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformacion.Location = new Point(0, 37);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Padding = new Padding(14, 0, 0, 0);
            btnInformacion.Size = new Size(230, 34);
            btnInformacion.TabIndex = 6;
            btnInformacion.Text = "Información";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = SystemColors.ActiveCaptionText;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.BottomLeft;
            btnConfiguracion.Location = new Point(0, 93);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(14, 0, 0, 0);
            btnConfiguracion.Size = new Size(233, 34);
            btnConfiguracion.TabIndex = 5;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnInvertir
            // 
            btnInvertir.Cursor = Cursors.Hand;
            btnInvertir.FlatAppearance.BorderSize = 0;
            btnInvertir.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvertir.ForeColor = SystemColors.ActiveCaptionText;
            btnInvertir.Image = (Image)resources.GetObject("btnInvertir.Image");
            btnInvertir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvertir.Location = new Point(0, 199);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Padding = new Padding(15, 0, 0, 0);
            btnInvertir.Size = new Size(233, 34);
            btnInvertir.TabIndex = 4;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            // 
            // btnIngresarDinero
            // 
            btnIngresarDinero.Cursor = Cursors.Hand;
            btnIngresarDinero.FlatAppearance.BorderSize = 0;
            btnIngresarDinero.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnIngresarDinero.FlatStyle = FlatStyle.Flat;
            btnIngresarDinero.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarDinero.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresarDinero.Image = (Image)resources.GetObject("btnIngresarDinero.Image");
            btnIngresarDinero.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresarDinero.Location = new Point(3, 145);
            btnIngresarDinero.Name = "btnIngresarDinero";
            btnIngresarDinero.Padding = new Padding(2, 0, 0, 0);
            btnIngresarDinero.Size = new Size(230, 34);
            btnIngresarDinero.TabIndex = 2;
            btnIngresarDinero.Text = "Depositar";
            btnIngresarDinero.UseVisualStyleBackColor = true;
            btnIngresarDinero.Click += btnInvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(463, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 33);
            label1.TabIndex = 1;
            label1.Text = "InverLux";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagenDolar2;
            pictureBox1.Location = new Point(400, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(255, 197, 0);
            barraTitulo.Controls.Add(pictureBox1);
            barraTitulo.Controls.Add(btnMinimizarClick);
            barraTitulo.Controls.Add(btmCerrarClick);
            barraTitulo.Controls.Add(label1);
            barraTitulo.Controls.Add(btnOpciones);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1041, 50);
            barraTitulo.TabIndex = 1;
            // 
            // btnMinimizarClick
            // 
            btnMinimizarClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarClick.BackgroundImage = Properties.Resources.minimizar3;
            btnMinimizarClick.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizarClick.Cursor = Cursors.Hand;
            btnMinimizarClick.Location = new Point(973, 0);
            btnMinimizarClick.Name = "btnMinimizarClick";
            btnMinimizarClick.Size = new Size(31, 31);
            btnMinimizarClick.TabIndex = 2;
            btnMinimizarClick.TabStop = false;
            btnMinimizarClick.Click += btnMinimizarClick_Click;
            // 
            // btmCerrarClick
            // 
            btmCerrarClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btmCerrarClick.BackgroundImage = Properties.Resources.imagenDeEquis2;
            btmCerrarClick.BackgroundImageLayout = ImageLayout.Zoom;
            btmCerrarClick.Cursor = Cursors.Hand;
            btmCerrarClick.Location = new Point(1010, 0);
            btmCerrarClick.Name = "btmCerrarClick";
            btmCerrarClick.Size = new Size(31, 31);
            btmCerrarClick.TabIndex = 1;
            btmCerrarClick.TabStop = false;
            btmCerrarClick.Click += btmCerrarClick_Click;
            // 
            // btnOpciones
            // 
            btnOpciones.Cursor = Cursors.Hand;
            btnOpciones.Image = (Image)resources.GetObject("btnOpciones.Image");
            btnOpciones.Location = new Point(15, 9);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(35, 35);
            btnOpciones.SizeMode = PictureBoxSizeMode.Zoom;
            btnOpciones.TabIndex = 0;
            btnOpciones.TabStop = false;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Control;
            panelContenedor.Controls.Add(menuVertical);
            panelContenedor.Controls.Add(barraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1041, 518);
            panelContenedor.TabIndex = 2;
            // 
            // Formulario_Menu_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 37, 113);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 518);
            ControlBox = false;
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Menu_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Menu";
            Load += Formulario_Menu_Load;
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btmCerrarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).EndInit();
            panelContenedor.ResumeLayout(false);
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
        private PictureBox btnMinimizarClick;
        private PictureBox btmCerrarClick;
        private Button btnIngresarDinero;
        private Button btnConfiguracion;
        private Button btnInformacion;
        private Button btnInvertir;
        private Button button1;
    }
}