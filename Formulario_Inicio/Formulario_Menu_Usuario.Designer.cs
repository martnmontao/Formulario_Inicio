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
            btnInvertir = new Button();
            btnConfiguracion = new Button();
            btnIngresarDinero = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            barraTitulo = new Panel();
            btnNormalizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizarClick = new PictureBox();
            btmCerrarClick = new PictureBox();
            btnOpciones = new PictureBox();
            panelContenedor = new Panel();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNormalizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btmCerrarClick).BeginInit();
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
            menuVertical.BackColor = Color.FromArgb(255, 197, 0);
            menuVertical.Controls.Add(btnInvertir);
            menuVertical.Controls.Add(btnConfiguracion);
            menuVertical.Controls.Add(btnIngresarDinero);
            menuVertical.Controls.Add(label1);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(237, 607);
            menuVertical.TabIndex = 0;
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
            btnInvertir.Location = new Point(0, 168);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(237, 34);
            btnInvertir.TabIndex = 4;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.Dock = DockStyle.Bottom;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 573);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(3, 0, 0, 0);
            btnConfiguracion.Size = new Size(237, 34);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
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
            btnIngresarDinero.Location = new Point(0, 95);
            btnIngresarDinero.Name = "btnIngresarDinero";
            btnIngresarDinero.Padding = new Padding(3, 0, 0, 0);
            btnIngresarDinero.Size = new Size(237, 34);
            btnIngresarDinero.TabIndex = 2;
            btnIngresarDinero.Text = "Depositar";
            btnIngresarDinero.UseVisualStyleBackColor = true;
            btnIngresarDinero.Click += btnInvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 33);
            label1.TabIndex = 1;
            label1.Text = "InverLux";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagenDolar2;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(255, 197, 0);
            barraTitulo.Controls.Add(btnNormalizar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnMinimizarClick);
            barraTitulo.Controls.Add(btmCerrarClick);
            barraTitulo.Controls.Add(btnOpciones);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(237, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(690, 50);
            barraTitulo.TabIndex = 1;
            // 
            // btnNormalizar
            // 
            btnNormalizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormalizar.BackgroundImage = (Image)resources.GetObject("btnNormalizar.BackgroundImage");
            btnNormalizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnNormalizar.Cursor = Cursors.Hand;
            btnNormalizar.Location = new Point(622, 0);
            btnNormalizar.Name = "btnNormalizar";
            btnNormalizar.Size = new Size(31, 31);
            btnNormalizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnNormalizar.TabIndex = 4;
            btnNormalizar.TabStop = false;
            btnNormalizar.Visible = false;
            btnNormalizar.Click += btnNormalizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Location = new Point(622, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(31, 31);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizarClick
            // 
            btnMinimizarClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarClick.BackgroundImage = Properties.Resources.minimizar3;
            btnMinimizarClick.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizarClick.Cursor = Cursors.Hand;
            btnMinimizarClick.Location = new Point(585, 0);
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
            btmCerrarClick.Location = new Point(659, 0);
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
            panelContenedor.BackColor = SystemColors.Control;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(237, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(690, 557);
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
            ((System.ComponentModel.ISupportInitialize)btnNormalizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizarClick).EndInit();
            ((System.ComponentModel.ISupportInitialize)btmCerrarClick).EndInit();
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
        private PictureBox btnMinimizarClick;
        private PictureBox btmCerrarClick;
        private PictureBox btnMaximizar;
        private PictureBox btnNormalizar;
        private Button btnIngresarDinero;
        private Button btnConfiguracion;
        private Button btnInvertir;
    }
}