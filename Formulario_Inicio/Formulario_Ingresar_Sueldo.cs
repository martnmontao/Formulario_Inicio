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
        private UsuarioADO usuario;
        private List<Usuario> listaUsuarios;
        private string tipoCambio;
        private Administrador admin;
        string pathUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        public Formulario_Ingresar_Sueldo()
        {

        }
        public Formulario_Ingresar_Sueldo(UsuarioADO usuario, string tipoCambio)
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
            

            DataBase db = new DataBase();

            string idUsuario = db.DevolverIDUsuario(usuario.Documento);


            UsuarioADO usuarioADO = db.DevolverUsuario(idUsuario);
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select();

            this.sueldoPesos = double.Parse(txtSueldo.Text);
            if (tipoCambio == "pesos")
            {
                if (sueldoPesos > 50000)
                {
                    MessageBox.Show($"No puede agregar más de $50000 a su cuenta. Su sueldo es de: {usuarioADO.Pesos}");
                }
                else if (usuario.Pesos >= 50000 || (usuario.Pesos + sueldoPesos) > 50000)
                {
                    MessageBox.Show($"No puede tener más de $50000 en su cuenta. Su sueldo es de: {usuarioADO.Pesos}. Porfavor invierta el dinero y vuelva a intentarlo.");
                }
                else
                {

                    foreach (UsuarioADO userADO in listaUsuariosADO)
                    {
                        if (usuario.Documento == userADO.Documento)
                        {
                            usuarioADO.Pesos += sueldoPesos;
                        

                            ModificarSueldo(usuario, usuarioADO.Pesos, sueldoPesos);
                            break;
                        }
                    }
                    MessageBox.Show("Se le ha depositado el dinero ingresado.");

                }

            }

            else
            {
                foreach (UsuarioADO userADO in listaUsuariosADO)
                {
                    if (usuario.Documento == userADO.Documento)
                    {

                        if (usuario.Pesos > 0)
                        {
                            usuario.Dolares = ConvertirPesoADolar(double.Parse(txtSueldo.Text));
                            MessageBox.Show("Operación exitosa!");
                        }
                        else
                        {
                            MessageBox.Show("No pesee esa cantidad en su cuenta. Deposite dinero o pruebe con otra cantidad.");
                        }


                        ModificarSueldo(usuario, usuario.Dolares, sueldoPesos);
                        break;
                    }
                }
            }

        }

        public void ModificarSueldo(UsuarioADO usuarioAModificar, double sueldo, double sueldoIngresado)
        {

            UsuarioADO usuarioADO = (UsuarioADO)usuarioAModificar;
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select();
            DataBase db = new DataBase();
            string idUsuario = db.DevolverIDUsuario(usuarioADO.Documento);

            foreach (UsuarioADO userADO in listaUsuariosADO)
            {
                if (usuarioAModificar.Documento == userADO.Documento)
                {
                    if (tipoCambio == "pesos")
                    {
                        userADO.Pesos = sueldo;
                        userADO.Update(idUsuario);
                    }
                    else
                    {
                        userADO.Dolares += sueldo;
                        userADO.Pesos = userADO.Pesos - sueldoIngresado;
                        userADO.Update(idUsuario);
                    }
                }
            }

     
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
            DataBase db = new DataBase();

            string id = db.DevolverIDUsuario(usuario.Documento);

            usuario = db.DevolverUsuario(id);


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
