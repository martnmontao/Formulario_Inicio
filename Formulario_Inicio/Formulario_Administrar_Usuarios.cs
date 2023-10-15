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
        private string rutaMisUsuarios = @"C:\Users\Lomu\Desktop\MisUsuarios.json";
        private string rutaUsuariosARegistrar = @"C:\Users\Lomu\Desktop\MisUsuariosARegistrar.json";
        private Administrador admin;
        private List<Usuario> listaUsuarios;
        private List<Usuario> listaUsuariosARegistrar;
        private string nombre;

        public Formulario_Administrar_Usuarios()
        {
            InitializeComponent();
            this.admin = new Administrador();
            this.listaUsuariosARegistrar = Serializadora.LeerJsonUsuarios(rutaUsuariosARegistrar);

        }

        private void Formulario_Administrar_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            string filejson = File.ReadAllText(rutaMisUsuarios);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;
        }


        private void bntUsuariosARegistrar_Click(object sender, EventArgs e)
        {
            string filejson = File.ReadAllText(rutaUsuariosARegistrar);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btnValidarUsuarios_Click(object sender, EventArgs e)
        {
            nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            admin.ValidarUsuario(listaUsuariosARegistrar, nombre);
            admin.EliminarUsuario(listaUsuariosARegistrar, nombre, rutaUsuariosARegistrar);
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            listaUsuarios = Serializadora.LeerJsonUsuarios(rutaMisUsuarios);
            string a = gridUsuarios.CurrentRow.ToString();
            //int usuario = (int)gridUsuarios.CurrentRow.Index; 
            nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            admin.EliminarUsuario(listaUsuarios, nombre, rutaMisUsuarios);
        }


    }
}
