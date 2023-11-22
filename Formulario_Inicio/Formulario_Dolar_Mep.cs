using Biblioteca_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Dolar_Mep : Form
    {
        private Usuario usuario;
        Administrador admin;
        string pathMisUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string pathAdmin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        public Formulario_Dolar_Mep(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnComprarMEP_Click(object sender, EventArgs e)
        {
            Formulario_Ingresar_Sueldo fIS = new Formulario_Ingresar_Sueldo(usuario, "dolar");
            fIS.Show();
            this.Hide();
        }

        private void btnVenderMEP_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_Dolar_Mep_Load(object sender, EventArgs e)
        {
            ObtenerAdmin();
            int sueldoDolares = Convert.ToInt32(usuario.SueldoDolares);
            lblDolaresUsuario.Text = "Disponible: " + "US$ " + usuario.SueldoDolares.ToString();
            tkbMontoDolares.Maximum = sueldoDolares;
            lblValorVenta.Text = admin.ValorDolarVenta.ToString();
            lblValorCompra.Text = admin.ValorDolarCompra.ToString();
        }

        private void tkbMontoDolares_Scroll(object sender, EventArgs e)
        {

            double valorDeCambio = Convert.ToInt32(tkbMontoDolares.Value) * admin.ValorDolarVenta;
            txtValorEnPesos.Text = valorDeCambio.ToString();
            lblValorDolares.Text = "Monto en dólares: " + tkbMontoDolares.Value.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuarios);

            List<Usuario> listaUsuarios = serializadorJson.Deserializar();
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Dni == user.Dni)
                {
                    user.SueldoDolares -= tkbMontoDolares.Value;
                    user.Sueldo += (Convert.ToInt32(tkbMontoDolares.Value) * admin.ValorDolarVenta);
                    MessageBox.Show("Se le ha transferido la equivalencia. Consulte su billetera para ver su dinero disponible.");
                    break;
                }
            }
            serializadorJson2.Serializar(listaUsuarios);
            lblDolaresUsuario.Text = usuario.SueldoDolares.ToString();

        }

        private void ObtenerAdmin()
        {
            var serializadorJson = new SerializadorJSON<Administrador>(pathAdmin);
            List<Administrador> listaAdministradores = serializadorJson.Deserializar();
            this.admin = new Administrador();
            foreach (Administrador adm in listaAdministradores)
            {
                this.admin = adm;
                break;
            }
        }



    }
}
