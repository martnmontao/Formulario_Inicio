using Biblioteca_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Ingresar_Sueldo : Form
    {
        private float sueldoPesos;
        private float sueldoDolares;
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        public Formulario_Ingresar_Sueldo(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.listaUsuarios = Serializadora.LeerJsonUsuarios(ruta);
        }
        private void Formulario_Ingresar_Sueldo_Load(object sender, EventArgs e)
        {

            txtSueldoPesos.Text = "0";
            txtSueldoDolares.Text = "0";

        }


        private void btnIngresarSueldo_Click(object sender, EventArgs e)
        {
            this.sueldoPesos = float.Parse(txtSueldoPesos.Text);
            this.sueldoDolares = float.Parse(txtSueldoDolares.Text);
            foreach (Usuario user in listaUsuarios)
            {
                if (this.usuario.Nombre == user.Nombre)
                {
                    this.usuario.ModificarSueldo(this.usuario, (this.sueldoPesos + user.Sueldo), (this.sueldoDolares + user.SueldoDolares));
                    break;
                }
            }
            //user.ModificarSueldo(this.usuario, float.Parse(txtSueldoPesos.Text), float.Parse(txtSueldoDolares.Text));
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            this.sueldoPesos = float.Parse(txtSueldoPesos.Text);
            txtSueldoDolares.Text = ConvertirPesoADolar(sueldoPesos).ToString();

        }

        private double ConvertirPesoADolar(float pesos)
        {
            float valorPeso = 0.0029f;
            this.sueldoDolares = pesos * valorPeso;
            return sueldoDolares;
        }

    }
}
