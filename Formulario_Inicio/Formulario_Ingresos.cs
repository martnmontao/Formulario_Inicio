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
    public partial class Formulario_Ingresos : Form
    {
        private Usuario usuario;
        public Formulario_Ingresos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Formulario_Ingresos_Load(object sender, EventArgs e)
        {
            Formulario_Ingresar_Sueldo fi = new Formulario_Ingresar_Sueldo();
            lblSueldoDolares.Text = fi.ConvertirPesoADolar(usuario.Sueldo).ToString();
            lblSueldo.Text = usuario.Sueldo.ToString();

        }

    }
}
