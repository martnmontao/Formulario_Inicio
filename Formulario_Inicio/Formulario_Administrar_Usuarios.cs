using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Clases;
using Newtonsoft.Json;


namespace Formulario_Inicio
{
    public partial class Formulario_Administrar_Usuarios : Form
    {
        public Formulario_Administrar_Usuarios()
        {
            InitializeComponent();
        }

        private void Formulario_Administrar_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {


            //List<Usuario> lista = Serializadora.LeerJson();
            //Serializadora.EscribirJsonAgregarUsuarios(lista);



            string filejson = File.ReadAllText(@"C:\Users\Lomu\Desktop\MisUsuarios.json");

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;



        }



        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();

        }
    }
}
