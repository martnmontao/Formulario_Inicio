namespace Formulario_Inicio
{
    partial class Formulario_Administrar_Activos
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
            dgvActivos = new DataGridView();
            btnConfirmarCambios = new Button();
            btnEliminarActivo = new Button();
            cmbActivo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            SuspendLayout();
            // 
            // dgvActivos
            // 
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Location = new Point(64, 25);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.RowTemplate.Height = 25;
            dgvActivos.Size = new Size(677, 399);
            dgvActivos.TabIndex = 0;
            dgvActivos.CellClick += dgvActivos_CellClick;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Location = new Point(768, 155);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(117, 23);
            btnConfirmarCambios.TabIndex = 1;
            btnConfirmarCambios.Text = "Confirmar";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // btnEliminarActivo
            // 
            btnEliminarActivo.Location = new Point(1001, 155);
            btnEliminarActivo.Name = "btnEliminarActivo";
            btnEliminarActivo.Size = new Size(117, 23);
            btnEliminarActivo.TabIndex = 2;
            btnEliminarActivo.Text = "Eliminar";
            btnEliminarActivo.UseVisualStyleBackColor = true;
            btnEliminarActivo.Click += btnEliminarActivo_Click;
            // 
            // cmbActivo
            // 
            cmbActivo.FormattingEnabled = true;
            cmbActivo.Items.AddRange(new object[] { "0 - Acciones", "1 - Cedears", "2 - Bonos públicos", "3 - Dolar MEP" });
            cmbActivo.Location = new Point(768, 25);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(350, 23);
            cmbActivo.TabIndex = 9;
            cmbActivo.Text = "Activos";
            cmbActivo.SelectedIndexChanged += cmbActivo_SelectedIndexChanged;
            // 
            // Formulario_Administrar_Activos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 446);
            Controls.Add(cmbActivo);
            Controls.Add(btnEliminarActivo);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(dgvActivos);
            Name = "Formulario_Administrar_Activos";
            Text = "Formulario_Administrar_Activos";
            Load += Formulario_Administrar_Activos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvActivos;
        private Button btnConfirmarCambios;
        private Button btnEliminarActivo;
        private ComboBox cmbActivo;
    }
}