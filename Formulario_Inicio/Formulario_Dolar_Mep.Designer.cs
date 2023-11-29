namespace Formulario_Inicio
{
    partial class Formulario_Dolar_Mep
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
            btnVenderMEP = new Button();
            btnComprarMEP = new Button();
            tkbMontoDolares = new TrackBar();
            lblValorDolares = new Label();
            lblMontoPesos = new Label();
            txtValorEnPesos = new TextBox();
            lblDolaresUsuario = new Label();
            btnConfirmar = new Button();
            lblValorVenta = new Label();
            lblValorCompra = new Label();
            btnVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tkbMontoDolares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // btnVenderMEP
            // 
            btnVenderMEP.BackColor = Color.FromArgb(40, 40, 40);
            btnVenderMEP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenderMEP.ForeColor = Color.LightGray;
            btnVenderMEP.Location = new Point(45, 64);
            btnVenderMEP.Name = "btnVenderMEP";
            btnVenderMEP.Size = new Size(176, 42);
            btnVenderMEP.TabIndex = 0;
            btnVenderMEP.Text = "Vender";
            btnVenderMEP.UseVisualStyleBackColor = false;
            btnVenderMEP.Click += btnVenderMEP_Click;
            // 
            // btnComprarMEP
            // 
            btnComprarMEP.BackColor = Color.FromArgb(40, 40, 40);
            btnComprarMEP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprarMEP.ForeColor = Color.LightGray;
            btnComprarMEP.Location = new Point(337, 64);
            btnComprarMEP.Name = "btnComprarMEP";
            btnComprarMEP.Size = new Size(178, 42);
            btnComprarMEP.TabIndex = 1;
            btnComprarMEP.Text = "Comprar";
            btnComprarMEP.UseVisualStyleBackColor = false;
            btnComprarMEP.Click += btnComprarMEP_Click;
            // 
            // tkbMontoDolares
            // 
            tkbMontoDolares.BackColor = Color.FromArgb(40, 40, 40);
            tkbMontoDolares.Location = new Point(63, 199);
            tkbMontoDolares.Maximum = 10000;
            tkbMontoDolares.Name = "tkbMontoDolares";
            tkbMontoDolares.Size = new Size(412, 45);
            tkbMontoDolares.TabIndex = 2;
            tkbMontoDolares.Scroll += tkbMontoDolares_Scroll;
            // 
            // lblValorDolares
            // 
            lblValorDolares.AutoSize = true;
            lblValorDolares.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDolares.ForeColor = Color.LightGray;
            lblValorDolares.Location = new Point(63, 162);
            lblValorDolares.Name = "lblValorDolares";
            lblValorDolares.Size = new Size(115, 17);
            lblValorDolares.TabIndex = 3;
            lblValorDolares.Text = "Monto en dólares:";
            // 
            // lblMontoPesos
            // 
            lblMontoPesos.AutoSize = true;
            lblMontoPesos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoPesos.ForeColor = Color.LightGray;
            lblMontoPesos.Location = new Point(63, 291);
            lblMontoPesos.Name = "lblMontoPesos";
            lblMontoPesos.Size = new Size(105, 17);
            lblMontoPesos.TabIndex = 4;
            lblMontoPesos.Text = "Monto en pesos:";
            // 
            // txtValorEnPesos
            // 
            txtValorEnPesos.Location = new Point(63, 325);
            txtValorEnPesos.Name = "txtValorEnPesos";
            txtValorEnPesos.ReadOnly = true;
            txtValorEnPesos.Size = new Size(412, 23);
            txtValorEnPesos.TabIndex = 5;
            // 
            // lblDolaresUsuario
            // 
            lblDolaresUsuario.AutoSize = true;
            lblDolaresUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDolaresUsuario.ForeColor = Color.LightGray;
            lblDolaresUsuario.Location = new Point(63, 247);
            lblDolaresUsuario.Name = "lblDolaresUsuario";
            lblDolaresUsuario.Size = new Size(76, 17);
            lblDolaresUsuario.TabIndex = 6;
            lblDolaresUsuario.Text = "Disponible: ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 40, 40);
            btnConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.LightGray;
            btnConfirmar.Location = new Point(63, 379);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(415, 34);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblValorVenta
            // 
            lblValorVenta.AutoSize = true;
            lblValorVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorVenta.ForeColor = Color.LightGray;
            lblValorVenta.Location = new Point(86, 126);
            lblValorVenta.Name = "lblValorVenta";
            lblValorVenta.Size = new Size(82, 17);
            lblValorVenta.TabIndex = 8;
            lblValorVenta.Text = "Valor venta:";
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorCompra.ForeColor = Color.LightGray;
            lblValorCompra.Location = new Point(382, 126);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new Size(93, 17);
            lblValorCompra.TabIndex = 9;
            lblValorCompra.Text = "Valor compra:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Image = Properties.Resources.botonVolver1;
            btnVolver.Location = new Point(-1, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(59, 50);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 10;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Formulario_Dolar_Mep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 23, 39);
            ClientSize = new Size(560, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblValorCompra);
            Controls.Add(lblValorVenta);
            Controls.Add(btnConfirmar);
            Controls.Add(lblDolaresUsuario);
            Controls.Add(txtValorEnPesos);
            Controls.Add(lblMontoPesos);
            Controls.Add(lblValorDolares);
            Controls.Add(tkbMontoDolares);
            Controls.Add(btnComprarMEP);
            Controls.Add(btnVenderMEP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario_Dolar_Mep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Dolar_Mep";
            Load += Formulario_Dolar_Mep_Load;
            ((System.ComponentModel.ISupportInitialize)tkbMontoDolares).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVenderMEP;
        private Button btnComprarMEP;
        private TrackBar tkbMontoDolares;
        private Label lblValorDolares;
        private Label lblMontoPesos;
        private TextBox txtValorEnPesos;
        private Label lblDolaresUsuario;
        private Button btnConfirmar;
        private Label lblValorVenta;
        private Label lblValorCompra;
        private PictureBox btnVolver;
    }
}