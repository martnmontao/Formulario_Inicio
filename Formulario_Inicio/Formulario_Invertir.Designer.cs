namespace Formulario_Inicio
{
    partial class Formulario_Invertir
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
            dgvMercadoSecundario = new DataGridView();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            cmbTipoMonedas = new ComboBox();
            btnVender = new Button();
            btnCancelar = new Button();
            btnComprar = new Button();
            btnVenderActivos = new Button();
            btnComprarActivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMercadoSecundario).BeginInit();
            SuspendLayout();
            // 
            // dgvMercadoSecundario
            // 
            dgvMercadoSecundario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMercadoSecundario.Location = new Point(35, 91);
            dgvMercadoSecundario.Name = "dgvMercadoSecundario";
            dgvMercadoSecundario.RowTemplate.Height = 25;
            dgvMercadoSecundario.ScrollBars = ScrollBars.None;
            dgvMercadoSecundario.Size = new Size(742, 150);
            dgvMercadoSecundario.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.LightGray;
            lblPrecio.Location = new Point(484, 244);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(65, 15);
            lblPrecio.TabIndex = 68;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.LightGray;
            lblCantidad.Location = new Point(161, 244);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(85, 15);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(484, 272);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(163, 23);
            txtPrecio.TabIndex = 56;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(161, 272);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad";
            txtCantidad.Size = new Size(163, 23);
            txtCantidad.TabIndex = 55;
            // 
            // cmbTipoMonedas
            // 
            cmbTipoMonedas.FormattingEnabled = true;
            cmbTipoMonedas.Items.AddRange(new object[] { "ARG", "USD" });
            cmbTipoMonedas.Location = new Point(120, 53);
            cmbTipoMonedas.Name = "cmbTipoMonedas";
            cmbTipoMonedas.Size = new Size(563, 23);
            cmbTipoMonedas.TabIndex = 70;
            cmbTipoMonedas.Text = "Moneda";
            cmbTipoMonedas.SelectedIndexChanged += cmbTipoMonedas_SelectedIndexChanged;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(40, 40, 40);
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = Color.LightGray;
            btnVender.ImageAlign = ContentAlignment.MiddleLeft;
            btnVender.Location = new Point(448, 330);
            btnVender.Name = "btnVender";
            btnVender.Padding = new Padding(9, 0, 0, 0);
            btnVender.Size = new Size(235, 36);
            btnVender.TabIndex = 71;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(40, 40, 40);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(120, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(9, 0, 0, 0);
            btnCancelar.Size = new Size(235, 36);
            btnCancelar.TabIndex = 72;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(40, 40, 40);
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.LightGray;
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(448, 330);
            btnComprar.Name = "btnComprar";
            btnComprar.Padding = new Padding(9, 0, 0, 0);
            btnComprar.Size = new Size(235, 36);
            btnComprar.TabIndex = 73;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVenderActivos
            // 
            btnVenderActivos.BackColor = Color.FromArgb(40, 40, 40);
            btnVenderActivos.Cursor = Cursors.Hand;
            btnVenderActivos.FlatAppearance.BorderSize = 0;
            btnVenderActivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVenderActivos.FlatStyle = FlatStyle.Flat;
            btnVenderActivos.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderActivos.ForeColor = Color.LightGray;
            btnVenderActivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenderActivos.Location = new Point(516, 11);
            btnVenderActivos.Name = "btnVenderActivos";
            btnVenderActivos.Padding = new Padding(9, 0, 0, 0);
            btnVenderActivos.Size = new Size(235, 36);
            btnVenderActivos.TabIndex = 74;
            btnVenderActivos.Text = "Venta";
            btnVenderActivos.UseVisualStyleBackColor = false;
            btnVenderActivos.Click += btnVenderActivos_Click;
            // 
            // btnComprarActivo
            // 
            btnComprarActivo.BackColor = Color.FromArgb(40, 40, 40);
            btnComprarActivo.Cursor = Cursors.Hand;
            btnComprarActivo.FlatAppearance.BorderSize = 0;
            btnComprarActivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnComprarActivo.FlatStyle = FlatStyle.Flat;
            btnComprarActivo.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprarActivo.ForeColor = Color.LightGray;
            btnComprarActivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprarActivo.Location = new Point(72, 11);
            btnComprarActivo.Name = "btnComprarActivo";
            btnComprarActivo.Padding = new Padding(9, 0, 0, 0);
            btnComprarActivo.Size = new Size(235, 36);
            btnComprarActivo.TabIndex = 75;
            btnComprarActivo.Text = "Compra";
            btnComprarActivo.UseVisualStyleBackColor = false;
            btnComprarActivo.Click += btnComprarActivo_Click;
            // 
            // Formulario_Invertir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(854, 407);
            Controls.Add(btnComprarActivo);
            Controls.Add(btnVenderActivos);
            Controls.Add(btnComprar);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(cmbTipoMonedas);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(dgvMercadoSecundario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Invertir";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar";
            Load += Formulario_Invertir_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMercadoSecundario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMercadoSecundario;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private ComboBox cmbTipoMonedas;
        private Button btnVender;
        private Button btnCancelar;
        private Button btnComprar;
        private Button btnVenderActivos;
        private Button btnComprarActivo;
    }
}