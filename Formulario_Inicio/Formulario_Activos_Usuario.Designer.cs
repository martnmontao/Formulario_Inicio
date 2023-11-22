namespace Formulario_Inicio
{
    partial class Formulario_Activos_Usuario
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
            btnVender = new Button();
            dgvActivosUsuario = new DataGridView();
            txtCantidadVenta = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidadCompra = new TextBox();
            txtPrecioCompra = new TextBox();
            txtIntereses = new TextBox();
            txtNombreEmpresa = new TextBox();
            btnVentas = new Button();
            btnActivosUsuario = new Button();
            lblEmpresa = new Label();
            lblMoneda = new Label();
            lblIntereses = new Label();
            lblCantidadVenta = new Label();
            lblCantidadCompra = new Label();
            lblPrecioCompra = new Label();
            lblPrecioVenta = new Label();
            cmbActivo = new ComboBox();
            cmbTipoMonedas = new ComboBox();
            pictureBoxBotonVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvActivosUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBotonVolver).BeginInit();
            SuspendLayout();
            // 
            // btnVender
            // 
            btnVender.Location = new Point(281, 445);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(230, 23);
            btnVender.TabIndex = 1;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // dgvActivosUsuario
            // 
            dgvActivosUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivosUsuario.Location = new Point(28, 103);
            dgvActivosUsuario.Name = "dgvActivosUsuario";
            dgvActivosUsuario.ReadOnly = true;
            dgvActivosUsuario.RowTemplate.Height = 25;
            dgvActivosUsuario.Size = new Size(746, 149);
            dgvActivosUsuario.TabIndex = 26;
            // 
            // txtCantidadVenta
            // 
            txtCantidadVenta.Location = new Point(319, 293);
            txtCantidadVenta.Name = "txtCantidadVenta";
            txtCantidadVenta.PlaceholderText = "Cantidad venta";
            txtCantidadVenta.Size = new Size(163, 23);
            txtCantidadVenta.TabIndex = 27;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(319, 352);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio venta";
            txtPrecioVenta.Size = new Size(163, 23);
            txtPrecioVenta.TabIndex = 28;
            // 
            // txtCantidadCompra
            // 
            txtCantidadCompra.Location = new Point(580, 293);
            txtCantidadCompra.Name = "txtCantidadCompra";
            txtCantidadCompra.PlaceholderText = "Cantidad compra";
            txtCantidadCompra.Size = new Size(163, 23);
            txtCantidadCompra.TabIndex = 39;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(580, 352);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PlaceholderText = "Precio compra";
            txtPrecioCompra.Size = new Size(163, 23);
            txtPrecioCompra.TabIndex = 41;
            // 
            // txtIntereses
            // 
            txtIntereses.Location = new Point(580, 402);
            txtIntereses.Name = "txtIntereses";
            txtIntereses.PlaceholderText = "Intereses";
            txtIntereses.Size = new Size(163, 23);
            txtIntereses.TabIndex = 42;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(84, 293);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.PlaceholderText = "Empresa";
            txtNombreEmpresa.Size = new Size(163, 23);
            txtNombreEmpresa.TabIndex = 43;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(188, 12);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(121, 23);
            btnVentas.TabIndex = 45;
            btnVentas.Text = "Activos en venta";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnActivosUsuario
            // 
            btnActivosUsuario.Location = new Point(492, 17);
            btnActivosUsuario.Name = "btnActivosUsuario";
            btnActivosUsuario.Size = new Size(121, 23);
            btnActivosUsuario.TabIndex = 46;
            btnActivosUsuario.Text = "Mis activos";
            btnActivosUsuario.UseVisualStyleBackColor = true;
            btnActivosUsuario.Click += btnActivosUsuario_Click;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(84, 265);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(55, 15);
            lblEmpresa.TabIndex = 47;
            lblEmpresa.Text = "Empresa:";
            // 
            // lblMoneda
            // 
            lblMoneda.AutoSize = true;
            lblMoneda.Location = new Point(84, 331);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(54, 15);
            lblMoneda.TabIndex = 48;
            lblMoneda.Text = "Moneda:";
            // 
            // lblIntereses
            // 
            lblIntereses.AutoSize = true;
            lblIntereses.Location = new Point(580, 384);
            lblIntereses.Name = "lblIntereses";
            lblIntereses.Size = new Size(56, 15);
            lblIntereses.TabIndex = 49;
            lblIntereses.Text = "Intereses:";
            // 
            // lblCantidadVenta
            // 
            lblCantidadVenta.AutoSize = true;
            lblCantidadVenta.Location = new Point(319, 265);
            lblCantidadVenta.Name = "lblCantidadVenta";
            lblCantidadVenta.Size = new Size(83, 15);
            lblCantidadVenta.TabIndex = 51;
            lblCantidadVenta.Text = "Cantida venta:";
            // 
            // lblCantidadCompra
            // 
            lblCantidadCompra.AutoSize = true;
            lblCantidadCompra.Location = new Point(580, 275);
            lblCantidadCompra.Name = "lblCantidadCompra";
            lblCantidadCompra.Size = new Size(102, 15);
            lblCantidadCompra.TabIndex = 52;
            lblCantidadCompra.Text = "Cantidad compra:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(580, 331);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(87, 15);
            lblPrecioCompra.TabIndex = 53;
            lblPrecioCompra.Text = "Precio compra:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(319, 331);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(75, 15);
            lblPrecioVenta.TabIndex = 54;
            lblPrecioVenta.Text = "Precio venta:";
            // 
            // cmbActivo
            // 
            cmbActivo.FormattingEnabled = true;
            cmbActivo.Items.AddRange(new object[] { "0 - Acciones", "1 - Cedears", "2 - Bonos públicos", "3 - Dolar MEP" });
            cmbActivo.Location = new Point(28, 56);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(746, 23);
            cmbActivo.TabIndex = 44;
            cmbActivo.Text = "Activos";
            cmbActivo.SelectedIndexChanged += cmbActivo_SelectedIndexChanged;
            // 
            // cmbTipoMonedas
            // 
            cmbTipoMonedas.FormattingEnabled = true;
            cmbTipoMonedas.Items.AddRange(new object[] { "ARG", "USD" });
            cmbTipoMonedas.Location = new Point(84, 352);
            cmbTipoMonedas.Name = "cmbTipoMonedas";
            cmbTipoMonedas.Size = new Size(163, 23);
            cmbTipoMonedas.TabIndex = 71;
            cmbTipoMonedas.Text = "Moneda";
            cmbTipoMonedas.SelectedIndexChanged += cmbTipoMonedas_SelectedIndexChanged;
            // 
            // pictureBoxBotonVolver
            // 
            pictureBoxBotonVolver.BackColor = Color.Transparent;
            pictureBoxBotonVolver.Image = Properties.Resources.botonVolver1;
            pictureBoxBotonVolver.Location = new Point(1, 0);
            pictureBoxBotonVolver.Name = "pictureBoxBotonVolver";
            pictureBoxBotonVolver.Size = new Size(59, 50);
            pictureBoxBotonVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBotonVolver.TabIndex = 72;
            pictureBoxBotonVolver.TabStop = false;
            pictureBoxBotonVolver.Click += pictureBoxBotonVolver_Click;
            // 
            // Formulario_Activos_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 551);
            Controls.Add(pictureBoxBotonVolver);
            Controls.Add(cmbTipoMonedas);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblCantidadCompra);
            Controls.Add(lblCantidadVenta);
            Controls.Add(lblIntereses);
            Controls.Add(lblMoneda);
            Controls.Add(lblEmpresa);
            Controls.Add(btnActivosUsuario);
            Controls.Add(btnVentas);
            Controls.Add(cmbActivo);
            Controls.Add(txtNombreEmpresa);
            Controls.Add(txtIntereses);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCantidadCompra);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCantidadVenta);
            Controls.Add(dgvActivosUsuario);
            Controls.Add(btnVender);
            Name = "Formulario_Activos_Usuario";
            Text = "Formulario_Activos_Usuario";
            Load += Formulario_Activos_Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActivosUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBotonVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVender;
        private DataGridView dgvActivosUsuario;
        private TextBox txtCantidadVenta;
        private TextBox txtPrecioVenta;
        private TextBox textBox6;
        private TextBox txtIntereses;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtCc;
        private TextBox txtMoneda;
        private TextBox txtPrecioCompra;
        private TextBox txtNombreEmpresa;
        private Button btnVentas;
        private Button btnActivosUsuario;
        private Label lblEmpresa;
        private Label lblMoneda;
        private Label lblIntereses;
        private Label lblCantidadVenta;
        private Label lblCantidadCompra;
        private Label lblPrecioCompra;
        private Label lblPrecioVenta;
        private TextBox txtCantidadCompra;
        private ComboBox cmbActivo;
        private ComboBox cmbTipoMonedas;
        private PictureBox pictureBoxBotonVolver;
    }
}