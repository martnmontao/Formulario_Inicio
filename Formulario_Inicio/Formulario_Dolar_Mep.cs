﻿using Biblioteca_Clases;
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
        private UsuarioADO usuario;
        Administrador admin;
        string pathMisUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string pathAdmin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        public Formulario_Dolar_Mep(UsuarioADO usuario)
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
            int sueldoDolares = Convert.ToInt32(usuario.Dolares);
            lblDolaresUsuario.Text = "Disponible: " + "US$ " + usuario.Dolares.ToString();
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
            UsuarioADO usuarioADO = (UsuarioADO)usuario;
            List<UsuarioADO> listaUsuarioADO = usuarioADO.Select();
            DataBase db = new DataBase();
            string idUsuario = db.DevolverIDUsuario(usuarioADO.Documento);
            


            
            foreach (UsuarioADO user in listaUsuarioADO)
            {
                if (usuarioADO.Documento == user.Documento && user.Dolares > 0)
                {
                    user.Dolares -= tkbMontoDolares.Value;
                    user.Pesos += (Convert.ToInt32(tkbMontoDolares.Value) * admin.ValorDolarVenta);
                    user.Update(idUsuario);
                    MessageBox.Show("Se le ha transferido la equivalencia. Consulte su billetera para ver su dinero disponible.");
                    break;
                }
                else
                {
                    MessageBox.Show("No posee saldo en su cuenta. Ingrese dinero para comprar Dolar MEP.");
                    break;
                }
            }
            
            lblDolaresUsuario.Text = usuarioADO.Dolares.ToString();

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            this.Hide();
            fm.Show();
        }
    }
}
