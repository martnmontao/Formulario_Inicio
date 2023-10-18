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
        private double sueldoPesos;
        private double sueldoDolares;
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        public Formulario_Ingresar_Sueldo()
        {

        }
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
            this.sueldoPesos = double.Parse(txtSueldoPesos.Text);
            this.sueldoDolares = double.Parse(txtSueldoDolares.Text);
            if (sueldoPesos > 50000)
            {
                MessageBox.Show($"No puede agregar más de $50000 a su cuenta. Su sueldo es de: {usuario.Sueldo}");
            }
            else if (usuario.Sueldo >= 50000 || (usuario.Sueldo + sueldoPesos) > 50000)
            {
                MessageBox.Show($"No puede tener más de $50000 en su cuenta. Su sueldo es de: {usuario.Sueldo}. Porfavor invierta el dinero y vuelva a intentarlo.");
            }

            else
            {
                foreach (Usuario user in listaUsuarios)
                {
                    if (this.usuario.Nombre == user.Nombre)
                    {
                        usuario.Sueldo += sueldoPesos;
                        usuario.SueldoDolares = ConvertirPesoADolar(usuario.Sueldo);
                        ModificarSueldo(this.usuario, usuario.Sueldo, usuario.SueldoDolares);
                        break;
                    }
                }
            }

        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            this.sueldoPesos = double.Parse(txtSueldoPesos.Text);
            txtSueldoDolares.Text = ConvertirPesoADolar(sueldoPesos).ToString();

        }
        public void ModificarSueldo(Usuario usuario, double SueldoAPesos, double SueldoADolares)
        {
            listaUsuarios = Serializadora.LeerJsonUsuarios(ruta);
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Nombre == user.Nombre)
                {
                    user.Sueldo = SueldoAPesos;
                    user.SueldoDolares = SueldoADolares;
                }
            }

            Serializadora.ModificarJson(listaUsuarios, ruta);
        }

        public double ConvertirPesoADolar(double pesos)
        {
            double valorPeso = 0.0029f;
            this.sueldoDolares = pesos * valorPeso;
            this.sueldoDolares = (Math.Truncate(this.sueldoDolares * 100) / 100);
            return sueldoDolares;
        }

        private void pictureBoxBotonVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            this.Hide();
            fm.Show();
        }
    }
}
