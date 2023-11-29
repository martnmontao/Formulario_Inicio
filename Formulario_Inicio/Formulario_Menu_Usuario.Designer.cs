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
            btnIngresarDinero = new Button();
            menuVertical = new Panel();
            btnCartera = new Button();
            lblIdUsuario = new Label();
            btnInvertir = new Button();
            lblNombreUsuario = new Label();
            btnIconoUsuario = new PictureBox();
            btnInformacion = new Button();
            btnDolarMEP = new Button();
            panelContenedor = new Panel();
            barraTitulo = new Panel();
            btnMinimizarClick = new PictureBox();
            btnCerrarClick = new PictureBox();
            lblTitulo = new Label();
            btnOpciones = new PictureBox();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnIconoUsuario).BeginInit();
            panelContenedor.SuspendLayout();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).BeginInit();
            SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // btnIngresarDinero
            // 
            btnIngresarDinero.BackColor = Color.FromArgb(40, 40, 40);
            btnIngresarDinero.Cursor = Cursors.Hand;
            btnIngresarDinero.FlatAppearance.BorderSize = 0;
            btnIngresarDinero.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIngresarDinero.FlatStyle = FlatStyle.Flat;
            btnIngresarDinero.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarDinero.ForeColor = Color.LightGray;
            btnIngresarDinero.Image = (Image)resources.GetObject("btnIngresarDinero.Image");
            btnIngresarDinero.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresarDinero.Location = new Point(308, 95);
            btnIngresarDinero.Name = "btnIngresarDinero";
            btnIngresarDinero.Padding = new Padding(7, 0, 0, 0);
            btnIngresarDinero.Size = new Size(189, 52);
            btnIngresarDinero.TabIndex = 2;
            btnIngresarDinero.Text = "Depositar";
            btnIngresarDinero.UseVisualStyleBackColor = false;
            btnIngresarDinero.Click += btnIngresarDinero_Click;
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(23, 21, 39);
            menuVertical.Controls.Add(btnCartera);
            menuVertical.Controls.Add(lblIdUsuario);
            menuVertical.Controls.Add(btnInvertir);
            menuVertical.Controls.Add(lblNombreUsuario);
            menuVertical.Controls.Add(btnIconoUsuario);
            menuVertical.Controls.Add(btnInformacion);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 50);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(233, 468);
            menuVertical.TabIndex = 0;
            // 
            // btnCartera
            // 
            btnCartera.BackColor = Color.FromArgb(40, 40, 40);
            btnCartera.Cursor = Cursors.Hand;
            btnCartera.FlatAppearance.BorderSize = 0;
            btnCartera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCartera.FlatStyle = FlatStyle.Flat;
            btnCartera.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCartera.ForeColor = Color.LightGray;
            btnCartera.Image = (Image)resources.GetObject("btnCartera.Image");
            btnCartera.ImageAlign = ContentAlignment.MiddleLeft;
            btnCartera.Location = new Point(16, 225);
            btnCartera.Name = "btnCartera";
            btnCartera.Size = new Size(200, 45);
            btnCartera.TabIndex = 10;
            btnCartera.Text = "    Movimientos";
            btnCartera.UseVisualStyleBackColor = false;
            btnCartera.Click += btnCartera_Click;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.BackColor = Color.Transparent;
            lblIdUsuario.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdUsuario.ForeColor = Color.LightGray;
            lblIdUsuario.Location = new Point(76, 55);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(92, 15);
            lblIdUsuario.TabIndex = 9;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // btnInvertir
            // 
            btnInvertir.BackColor = Color.FromArgb(40, 40, 40);
            btnInvertir.Cursor = Cursors.Hand;
            btnInvertir.FlatAppearance.BorderSize = 0;
            btnInvertir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvertir.ForeColor = Color.LightGray;
            btnInvertir.Image = (Image)resources.GetObject("btnInvertir.Image");
            btnInvertir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvertir.Location = new Point(16, 143);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Padding = new Padding(9, 0, 0, 0);
            btnInvertir.Size = new Size(200, 45);
            btnInvertir.TabIndex = 4;
            btnInvertir.Text = "Mercado";
            btnInvertir.UseVisualStyleBackColor = false;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.LightGray;
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
            btnInformacion.BackColor = Color.FromArgb(40, 40, 40);
            btnInformacion.Cursor = Cursors.Hand;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInformacion.ForeColor = Color.LightGray;
            btnInformacion.Image = (Image)resources.GetObject("btnInformacion.Image");
            btnInformacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformacion.Location = new Point(16, 313);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Padding = new Padding(8, 0, 0, 0);
            btnInformacion.Size = new Size(200, 45);
            btnInformacion.TabIndex = 6;
            btnInformacion.Text = "Información";
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnDolarMEP
            // 
            btnDolarMEP.BackColor = Color.FromArgb(40, 40, 40);
            btnDolarMEP.Cursor = Cursors.Hand;
            btnDolarMEP.FlatAppearance.BorderSize = 0;
            btnDolarMEP.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnDolarMEP.FlatStyle = FlatStyle.Flat;
            btnDolarMEP.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDolarMEP.ForeColor = Color.LightGray;
            btnDolarMEP.Image = (Image)resources.GetObject("btnDolarMEP.Image");
            btnDolarMEP.ImageAlign = ContentAlignment.MiddleLeft;
            btnDolarMEP.Location = new Point(716, 95);
            btnDolarMEP.Name = "btnDolarMEP";
            btnDolarMEP.Padding = new Padding(2, 0, 0, 0);
            btnDolarMEP.Size = new Size(189, 52);
            btnDolarMEP.TabIndex = 3;
            btnDolarMEP.Text = "    Dolar MEP";
            btnDolarMEP.UseVisualStyleBackColor = false;
            btnDolarMEP.Click += btnDolarMEP_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(23, 21, 24);
            panelContenedor.Controls.Add(btnDolarMEP);
            panelContenedor.Controls.Add(menuVertical);
            panelContenedor.Controls.Add(barraTitulo);
            panelContenedor.Controls.Add(btnIngresarDinero);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1041, 518);
            panelContenedor.TabIndex = 2;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(23, 21, 39);
            barraTitulo.Controls.Add(btnMinimizarClick);
            barraTitulo.Controls.Add(btnCerrarClick);
            barraTitulo.Controls.Add(lblTitulo);
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.LightGray;
            lblTitulo.Location = new Point(441, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 33);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "InverLux";
            // 
            // btnOpciones
            // 
            btnOpciones.BackColor = Color.FromArgb(40, 40, 40);
            btnOpciones.Cursor = Cursors.Hand;
            btnOpciones.Image = (Image)resources.GetObject("btnOpciones.Image");
            btnOpciones.Location = new Point(16, 3);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(41, 41);
            btnOpciones.SizeMode = PictureBoxSizeMode.Zoom;
            btnOpciones.TabIndex = 0;
            btnOpciones.TabStop = false;
            btnOpciones.Click += btnOpciones_Click;
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
            panelContenedor.ResumeLayout(false);
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOpciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripComboBox toolStripComboBox1;
        private Button btnInfoInversiones;
        private Button btnIngresarDinero;
        private Panel menuVertical;
        private Button btnCartera;
        private Label lblNombreUsuario;
        private PictureBox btnIconoUsuario;
        private Button btnInformacion;
        private Button btnInvertir;
        private Button btnDolarMEP;
        private Panel panelContenedor;
        protected Panel barraTitulo;
        private PictureBox btnMinimizarClick;
        private PictureBox btnCerrarClick;
        private Label lblTitulo;
        private PictureBox btnOpciones;
        private Label lblIdUsuario;
    }
}