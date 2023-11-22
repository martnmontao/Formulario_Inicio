using Biblioteca_Clases;
using Microsoft.VisualBasic.ApplicationServices;
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
        private string tipoCambio;
        private Administrador admin;
        string pathUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        public Formulario_Ingresar_Sueldo()
        {

        }
        public Formulario_Ingresar_Sueldo(Usuario usuario, string tipoCambio)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.tipoCambio = tipoCambio;
        }
        private void Formulario_Ingresar_Sueldo_Load(object sender, EventArgs e)
        {
            if (tipoCambio == "dolar")
            {
                lblIngresarSueldo.Visible = false;
            }
            else
            {
                txtSueldo.Text = "0";
                txtSueldoDolar.Visible = false;
                btnObtenerValorDolar.Visible = false;
                btnComprarMep.Visible = false;
                btnVenderMep.Visible = false;
            }
        }

        private void btnIngresarSueldo_Click(object sender, EventArgs e)
        {
            var serializadoraJson = new SerializadorJSON<Usuario>(pathUsuarios);
            listaUsuarios = serializadoraJson.Deserializar();
            this.sueldoPesos = double.Parse(txtSueldo.Text);
            if (tipoCambio == "pesos")
            {
                if (sueldoPesos > 50000)
                {
                    MessageBox.Show($"No puede agregar más de $50000 a su cuenta. Su sueldo es de: {usuario.Sueldo}");
                }
                else if (usuario.Sueldo >= 50000 || (usuario.Sueldo + sueldoPesos) > 50000)
                {
                    MessageBox.Show($"No puede tener más de $50000 en su cuenta. Su sueldo es de: {usuario.Sueldo}. Porfavor invierta el dinero y vuelva a intentarlo.");
                }

                foreach (Usuario user in listaUsuarios)
                {
                    if (usuario.Dni == user.Dni)
                    {
                        usuario.Sueldo += sueldoPesos;
                        ModificarSueldo(usuario, usuario.Sueldo, sueldoPesos);
                        break;
                    }
                }

            }

            else
            {
                foreach (Usuario user in listaUsuarios)
                {
                    if (usuario.Dni == user.Dni)
                    {

                        if (usuario.Sueldo > 0)
                        {
                            usuario.SueldoDolares = ConvertirPesoADolar(double.Parse(txtSueldo.Text));
                            MessageBox.Show("Operación exitosa!");
                        }
                        else
                        {
                            MessageBox.Show("No pesee esa cantidad en su cuenta. Deposite dinero o pruebe con otra cantidad.");
                        }


                        ModificarSueldo(usuario, usuario.SueldoDolares, sueldoPesos);
                        break;
                    }
                }
            }

        }

        public void ModificarSueldo(Usuario usuarioAModificar, double sueldo, double sueldoIngresado)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathUsuarios);

            listaUsuarios = serializadorJson.Deserializar();
            foreach (Usuario user in listaUsuarios)
            {
                if (usuarioAModificar.Dni == user.Dni)
                {
                    if (tipoCambio == "pesos")
                    {
                        user.Sueldo = sueldo;

                    }
                    else
                    {
                        user.SueldoDolares += sueldo;
                        user.Sueldo = user.Sueldo - sueldoIngresado;
                        usuario = user;
                    }
                }
            }

            serializadorJson2.Serializar(listaUsuarios);
        }

        public double ConvertirPesoADolar(double pesos)
        {
            var serializadorJson = new SerializadorJSON<Administrador>(pathAdministrador);

            double valorDolar = 0;
            List<Administrador> listaAdministradores = serializadorJson.Deserializar();
            foreach (Administrador adm in listaAdministradores)
            {
                valorDolar = adm.ValorDolarCompra;
                break;
            }
            this.sueldoDolares = pesos / valorDolar;
            this.sueldoDolares = (Math.Truncate(this.sueldoDolares * 100) / 100);
            return sueldoDolares;
        }

        private void pictureBoxBotonVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            this.Hide();
            fm.Show();
        }

        private void btnObtenerValorDolar_Click(object sender, EventArgs e)
        {
            txtSueldoDolar.Text = ConvertirPesoADolar(double.Parse(txtSueldo.Text)).ToString();
        }

        private void btnVenderMep_Click(object sender, EventArgs e)
        {
            Formulario_Dolar_Mep fDM = new Formulario_Dolar_Mep(usuario);
            fDM.Show();
            this.Hide();
        }
    }
}
