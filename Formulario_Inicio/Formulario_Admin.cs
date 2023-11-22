
using Biblioteca_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Admin : Form
    {
        Administrador admin;
        string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        public Formulario_Admin()
        {

        }
        public Formulario_Admin(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.lblNombreUsuario.Text = admin.Nombre;
        }
        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            Formulario_Administrar_Usuarios fAU = new Formulario_Administrar_Usuarios();
            fAU.Show();

        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            Formulario_Administrar_Activos fAA = new Formulario_Administrar_Activos();
            fAA.Show();
            this.Hide();
        }

        private void btnActualizarDolar_Click(object sender, EventArgs e)
        {
            var serializadorJson = new SerializadorJSON<Administrador>(pathAdministrador);
            try
            {
                string a = txtValorCompraDolar.Text;
                double valorDolarVenta = double.Parse(txtValorVentaDolar.Text);
                double valorDolarCompra = double.Parse(txtValorCompraDolar.Text);

                admin.ValorDolarCompra = valorDolarCompra;
                admin.ValorDolarVenta = valorDolarVenta;
                serializadorJson.Serializar(admin);

            }
            catch
            {
                MessageBox.Show("Ingrese valores reales");
            }


        }
    }
}
