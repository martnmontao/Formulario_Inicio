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
            btnComprar = new Button();
            btnCancelar = new Button();
            dgvMercadoSecundario = new DataGridView();
            txtPrecioFinal = new TextBox();
            btnActualizarPrecio = new Button();
            btnComprarActivo = new Button();
            btnVenderActivos = new Button();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnVender = new Button();
            cmbTipoMonedas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMercadoSecundario).BeginInit();
            SuspendLayout();
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(454, 347);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(235, 23);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(120, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(235, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvMercadoSecundario
            // 
            dgvMercadoSecundario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMercadoSecundario.Location = new Point(120, 91);
            dgvMercadoSecundario.Name = "dgvMercadoSecundario";
            dgvMercadoSecundario.RowTemplate.Height = 25;
            dgvMercadoSecundario.Size = new Size(563, 150);
            dgvMercadoSecundario.TabIndex = 8;
            // 
            // txtPrecioFinal
            // 
            txtPrecioFinal.Location = new Point(520, 272);
            txtPrecioFinal.Name = "txtPrecioFinal";
            txtPrecioFinal.Size = new Size(163, 23);
            txtPrecioFinal.TabIndex = 9;
            // 
            // btnActualizarPrecio
            // 
            btnActualizarPrecio.Location = new Point(551, 301);
            btnActualizarPrecio.Name = "btnActualizarPrecio";
            btnActualizarPrecio.Size = new Size(109, 23);
            btnActualizarPrecio.TabIndex = 11;
            btnActualizarPrecio.Text = "Calcular precio";
            btnActualizarPrecio.UseVisualStyleBackColor = true;
            btnActualizarPrecio.Click += btnActualizarPrecio_Click;
            // 
            // btnComprarActivo
            // 
            btnComprarActivo.Location = new Point(121, 24);
            btnComprarActivo.Name = "btnComprarActivo";
            btnComprarActivo.Size = new Size(234, 23);
            btnComprarActivo.TabIndex = 12;
            btnComprarActivo.Text = "Compra";
            btnComprarActivo.UseVisualStyleBackColor = true;
            btnComprarActivo.Click += btnComprarActivo_Click;
            // 
            // btnVenderActivos
            // 
            btnVenderActivos.Location = new Point(449, 24);
            btnVenderActivos.Name = "btnVenderActivos";
            btnVenderActivos.Size = new Size(235, 23);
            btnVenderActivos.TabIndex = 13;
            btnVenderActivos.Text = "Venta";
            btnVenderActivos.UseVisualStyleBackColor = true;
            btnVenderActivos.Click += btnVenderActivos_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(320, 244);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 68;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(121, 244);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(320, 272);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(163, 23);
            txtPrecio.TabIndex = 56;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(120, 272);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad";
            txtCantidad.Size = new Size(163, 23);
            txtCantidad.TabIndex = 55;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(454, 347);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(237, 23);
            btnVender.TabIndex = 69;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
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
            // Formulario_Invertir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 407);
            Controls.Add(cmbTipoMonedas);
            Controls.Add(btnVender);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(btnVenderActivos);
            Controls.Add(btnComprarActivo);
            Controls.Add(btnActualizarPrecio);
            Controls.Add(txtPrecioFinal);
            Controls.Add(dgvMercadoSecundario);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Name = "Formulario_Invertir";
            Text = "Confirmar";
            Load += Formulario_Invertir_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMercadoSecundario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComprar;
        private Button btnCancelar;
        private DataGridView dgvMercadoSecundario;
        private TextBox txtPrecioFinal;
        private Button btnActualizarPrecio;
        private Button btnComprarActivo;
        private Button btnVenderActivos;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnVender;
        private ComboBox cmbTipoMonedas;
    }
}