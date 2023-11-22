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
            ((System.ComponentModel.ISupportInitialize)tkbMontoDolares).BeginInit();
            SuspendLayout();
            // 
            // btnVenderMEP
            // 
            btnVenderMEP.Location = new Point(57, 50);
            btnVenderMEP.Name = "btnVenderMEP";
            btnVenderMEP.Size = new Size(176, 23);
            btnVenderMEP.TabIndex = 0;
            btnVenderMEP.Text = "Vender";
            btnVenderMEP.UseVisualStyleBackColor = true;
            btnVenderMEP.Click += btnVenderMEP_Click;
            // 
            // btnComprarMEP
            // 
            btnComprarMEP.Location = new Point(372, 50);
            btnComprarMEP.Name = "btnComprarMEP";
            btnComprarMEP.Size = new Size(178, 23);
            btnComprarMEP.TabIndex = 1;
            btnComprarMEP.Text = "Comprar";
            btnComprarMEP.UseVisualStyleBackColor = true;
            btnComprarMEP.Click += btnComprarMEP_Click;
            // 
            // tkbMontoDolares
            // 
            tkbMontoDolares.Location = new Point(74, 180);
            tkbMontoDolares.Maximum = 10000;
            tkbMontoDolares.Name = "tkbMontoDolares";
            tkbMontoDolares.Size = new Size(412, 45);
            tkbMontoDolares.TabIndex = 2;
            tkbMontoDolares.Scroll += tkbMontoDolares_Scroll;
            // 
            // lblValorDolares
            // 
            lblValorDolares.AutoSize = true;
            lblValorDolares.Location = new Point(77, 132);
            lblValorDolares.Name = "lblValorDolares";
            lblValorDolares.Size = new Size(103, 15);
            lblValorDolares.TabIndex = 3;
            lblValorDolares.Text = "Monto en dólares:";
            // 
            // lblMontoPesos
            // 
            lblMontoPesos.AutoSize = true;
            lblMontoPesos.Location = new Point(77, 307);
            lblMontoPesos.Name = "lblMontoPesos";
            lblMontoPesos.Size = new Size(95, 15);
            lblMontoPesos.TabIndex = 4;
            lblMontoPesos.Text = "Monto en pesos:";
            // 
            // txtValorEnPesos
            // 
            txtValorEnPesos.Location = new Point(77, 341);
            txtValorEnPesos.Name = "txtValorEnPesos";
            txtValorEnPesos.ReadOnly = true;
            txtValorEnPesos.Size = new Size(409, 23);
            txtValorEnPesos.TabIndex = 5;
            // 
            // lblDolaresUsuario
            // 
            lblDolaresUsuario.AutoSize = true;
            lblDolaresUsuario.Location = new Point(77, 244);
            lblDolaresUsuario.Name = "lblDolaresUsuario";
            lblDolaresUsuario.Size = new Size(69, 15);
            lblDolaresUsuario.TabIndex = 6;
            lblDolaresUsuario.Text = "Disponible: ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(188, 393);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(163, 23);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblValorVenta
            // 
            lblValorVenta.AutoSize = true;
            lblValorVenta.Location = new Point(121, 95);
            lblValorVenta.Name = "lblValorVenta";
            lblValorVenta.Size = new Size(68, 15);
            lblValorVenta.TabIndex = 8;
            lblValorVenta.Text = "Valor venta:";
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Location = new Point(436, 95);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new Size(80, 15);
            lblValorCompra.TabIndex = 9;
            lblValorCompra.Text = "Valor compra:";
            // 
            // Formulario_Dolar_Mep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
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
            Name = "Formulario_Dolar_Mep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario_Dolar_Mep";
            Load += Formulario_Dolar_Mep_Load;
            ((System.ComponentModel.ISupportInitialize)tkbMontoDolares).EndInit();
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
    }
}