
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
    public partial class Formulario_Admin : Form
    {
        private Administrador administrador;
        public Formulario_Admin()
        {

        }

        public Formulario_Admin(string nombre, string idUsuario)
        {
            InitializeComponent();
            this.lblNombreUsuario.Text = "Usuario: " + nombre;
            this.lblIdUsuario.Text = "Id: " + idUsuario;
            //this.administrador = new Administrador(nombre, idUsuario);

        }
        private void Formulario_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            Formulario_Administrar_Usuarios fAU = new Formulario_Administrar_Usuarios();
            fAU.Show();

        }
    }
}
