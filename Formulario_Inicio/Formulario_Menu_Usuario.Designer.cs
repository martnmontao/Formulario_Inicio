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
            lblIdUsuario = new Label();
            lblNombreUsuario = new Label();
            btnIconoUsuario = new PictureBox();
            btnInformacion = new Button();
            btnInvertir = new Button();
            btnIngresarDinero = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            barraTitulo = new Panel();
            btnMinimizarClick = new PictureBox();
            btnCerrarClick = new PictureBox();
            btnOpciones = new PictureBox();
            panelContenedor = new Panel();
            pictureBoxLogo = new PictureBox();
            lblSueldo = new Label();
            lblSueldoDolares = new Label();
            pictureBoxAmazon = new PictureBox();
            pictureBoxTesla = new PictureBox();
            pictureBoxMicrosoft = new PictureBox();
            pictureBoxApple = new PictureBox();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnIconoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAmazon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTesla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMicrosoft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApple).BeginInit();
            SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(159, 211, 213);
            menuVertical.Controls.Add(lblIdUsuario);
            menuVertical.Controls.Add(lblNombreUsuario);
            menuVertical.Controls.Add(btnIconoUsuario);
            menuVertical.Controls.Add(btnInformacion);
            menuVertical.Controls.Add(btnInvertir);
            menuVertical.Controls.Add(btnIngresarDinero);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 50);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(233, 468);
            menuVertical.TabIndex = 0;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.BackColor = Color.Transparent;
            lblIdUsuario.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdUsuario.ForeColor = Color.FromArgb(79, 88, 88);
            lblIdUsuario.Location = new Point(76, 55);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(92, 15);
            lblIdUsuario.TabIndex = 9;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.FromArgb(79, 88, 88);
            lblNombreUsuario.Location = new Point(76, 12);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(136, 15);
            lblNombreUsuario.TabIndex = 8;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // btnIconoUsuario
            // 
            btnIconoUsuario.BackColor = Color.Transparent;
            btnIconoUsuario.Image = Properties.Resources.usuarioIcono2;
            btnIconoUsuario.Location = new Point(16, 3);
            btnIconoUsuario.Name = "btnIconoUsuario";
            btnIconoUsuario.Padding = new Padding(5, 0, 0, 0);
            btnIconoUsuario.Size = new Size(41, 72);
            btnIconoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnIconoUsuario.TabIndex = 7;
            btnIconoUsuario.TabStop = false;
            // 
            // btnInformacion
            // 
            btnInformacion.Cursor = Cursors.Hand;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 169, 171);
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInformacion.ForeColor = Color.FromArgb(79, 88, 88);
            btnInformacion.Image = (Image)resources.GetObject("btnInformacion.Image");
            btnInformacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformacion.Location = new Point(0, 271);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Padding = new Padding(18, 0, 0, 0);
            btnInformacion.Size = new Size(233, 34);
            btnInformacion.TabIndex = 6;
            btnInformacion.Text = "Información";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnInvertir
            // 
            btnInvertir.Cursor = Cursors.Hand;
            btnInvertir.FlatAppearance.BorderSize = 0;
            btnInvertir.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 169, 171);
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvertir.ForeColor = Color.FromArgb(79, 88, 88);
            btnInvertir.Image = (Image)resources.GetObject("btnInvertir.Image");
            btnInvertir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvertir.Location = new Point(0, 191);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Padding = new Padding(15, 0, 0, 0);
            btnInvertir.Size = new Size(233, 34);
            btnInvertir.TabIndex = 4;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnIngresarDinero
            // 
            btnIngresarDinero.BackColor = Color.Transparent;
            btnIngresarDinero.Cursor = Cursors.Hand;
            btnIngresarDinero.FlatAppearance.BorderSize = 0;
            btnIngresarDinero.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 169, 171);
            btnIngresarDinero.FlatStyle = FlatStyle.Flat;
            btnIngresarDinero.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarDinero.ForeColor = Color.FromArgb(79, 88, 88);
            btnIngresarDinero.Image = (Image)resources.GetObject("btnIngresarDinero.Image");
            btnIngresarDinero.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresarDinero.Location = new Point(0, 113);
            btnIngresarDinero.Name = "btnIngresarDinero";
            btnIngresarDinero.Padding = new Padding(7, 0, 0, 0);
            btnIngresarDinero.Size = new Size(233, 34);
            btnIngresarDinero.TabIndex = 2;
            btnIngresarDinero.Text = "Depositar";
            btnIngresarDinero.UseVisualStyleBackColor = false;
            btnIngresarDinero.Click += btnIngresarDinero_Click;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(159, 211, 213);
            barraTitulo.Controls.Add(pictureBox1);
            barraTitulo.Controls.Add(btnMinimizarClick);
            barraTitulo.Controls.Add(btnCerrarClick);
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
            // btnCerrarClick
            // 
            btnCerrarClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarClick.BackgroundImage = Properties.Resources.imagenDeEquis2;
            btnCerrarClick.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrarClick.Cursor = Cursors.Hand;
            btnCerrarClick.Location = new Point(1010, 0);
            btnCerrarClick.Name = "btnCerrarClick";
            btnCerrarClick.Size = new Size(31, 31);
            btnCerrarClick.TabIndex = 1;
            btnCerrarClick.TabStop = false;
            btnCerrarClick.Click += btnCerrarClick_Click;
            // 
            // btnOpciones
            // 
            btnOpciones.Cursor = Cursors.Hand;
            btnOpciones.Image = (Image)resources.GetObject("btnOpciones.Image");
            btnOpciones.Location = new Point(21, 9);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(35, 35);
            btnOpciones.SizeMode = PictureBoxSizeMode.Zoom;
            btnOpciones.TabIndex = 0;
            btnOpciones.TabStop = false;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(199, 233, 234);
            panelContenedor.Controls.Add(pictureBoxLogo);
            panelContenedor.Controls.Add(lblSueldo);
            panelContenedor.Controls.Add(lblSueldoDolares);
            panelContenedor.Controls.Add(pictureBoxAmazon);
            panelContenedor.Controls.Add(pictureBoxTesla);
            panelContenedor.Controls.Add(pictureBoxMicrosoft);
            panelContenedor.Controls.Add(pictureBoxApple);
            panelContenedor.Controls.Add(menuVertical);
            panelContenedor.Controls.Add(barraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1041, 518);
            panelContenedor.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(566, 251);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(104, 67);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 12;
            pictureBoxLogo.TabStop = false;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.Transparent;
            lblSueldo.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldo.ForeColor = Color.FromArgb(79, 88, 88);
            lblSueldo.Location = new Point(345, 105);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(89, 26);
            lblSueldo.TabIndex = 11;
            lblSueldo.Text = "$Arg:";
            // 
            // lblSueldoDolares
            // 
            lblSueldoDolares.AutoSize = true;
            lblSueldoDolares.BackColor = Color.Transparent;
            lblSueldoDolares.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldoDolares.ForeColor = Color.FromArgb(79, 88, 88);
            lblSueldoDolares.Location = new Point(747, 105);
            lblSueldoDolares.Name = "lblSueldoDolares";
            lblSueldoDolares.Size = new Size(131, 24);
            lblSueldoDolares.TabIndex = 10;
            lblSueldoDolares.Text = "$Dolares:";
            // 
            // pictureBoxAmazon
            // 
            pictureBoxAmazon.Image = (Image)resources.GetObject("pictureBoxAmazon.Image");
            pictureBoxAmazon.Location = new Point(686, 383);
            pictureBoxAmazon.Name = "pictureBoxAmazon";
            pictureBoxAmazon.Size = new Size(100, 67);
            pictureBoxAmazon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAmazon.TabIndex = 5;
            pictureBoxAmazon.TabStop = false;
            // 
            // pictureBoxTesla
            // 
            pictureBoxTesla.Image = Properties.Resources.LogoTesla;
            pictureBoxTesla.Location = new Point(812, 251);
            pictureBoxTesla.Name = "pictureBoxTesla";
            pictureBoxTesla.Size = new Size(100, 62);
            pictureBoxTesla.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTesla.TabIndex = 4;
            pictureBoxTesla.TabStop = false;
            // 
            // pictureBoxMicrosoft
            // 
            pictureBoxMicrosoft.Image = Properties.Resources.MicrosoftLogo1;
            pictureBoxMicrosoft.Location = new Point(444, 383);
            pictureBoxMicrosoft.Name = "pictureBoxMicrosoft";
            pictureBoxMicrosoft.Size = new Size(100, 67);
            pictureBoxMicrosoft.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMicrosoft.TabIndex = 3;
            pictureBoxMicrosoft.TabStop = false;
            // 
            // pictureBoxApple
            // 
            pictureBoxApple.ErrorImage = null;
            pictureBoxApple.Image = Properties.Resources.AppleLogo1;
            pictureBoxApple.Location = new Point(334, 246);
            pictureBoxApple.Name = "pictureBoxApple";
            pictureBoxApple.Size = new Size(100, 67);
            pictureBoxApple.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxApple.TabIndex = 2;
            pictureBoxApple.TabStop = false;
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
            menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnIconoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAmazon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTesla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMicrosoft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApple).EndInit();
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
        private PictureBox btnCerrarClick;
        private Button btnIngresarDinero;
        private Button btnInfoInversiones;
        private Button btnInformacion;
        private Button btnInvertir;
        private Button button1;
        private Label lblNombreUsuario;
        private PictureBox btnIconoUsuario;
        private Label lblIdUsuario;
        private PictureBox pictureBoxApple;
        private PictureBox pictureBoxMicrosoft;
        private PictureBox pictureBoxTesla;
        private PictureBox pictureBoxAmazon;
        private Label lblSueldoDolares;
        private Label lblSueldo;
        private PictureBox pictureBoxLogo;
    }
}