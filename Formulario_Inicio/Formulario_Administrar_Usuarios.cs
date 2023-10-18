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
            this.btnEliminarUsuarios.Visible = false;
            this.btnValidarUsuarios.Visible = false;

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            string filejson = File.ReadAllText(rutaMisUsuarios);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;
            btnEliminarUsuarios.Visible = true;
            btnValidarUsuarios.Visible = false;
        }


        private void bntUsuariosARegistrar_Click(object sender, EventArgs e)
        {
            string filejson = File.ReadAllText(rutaUsuariosARegistrar);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;
            btnValidarUsuarios.Visible = true;
            btnEliminarUsuarios.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btnValidarUsuarios_Click(object sender, EventArgs e)
        {

            try
            {
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
                admin.ValidarUsuario(listaUsuariosARegistrar, nombre);
                admin.EliminarUsuario(listaUsuariosARegistrar, nombre, rutaUsuariosARegistrar);
            }
            catch
            {
                MessageBox.Show("No hay usuarios para validar.");
            }


        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
                listaUsuarios = Serializadora.LeerJsonUsuarios(rutaMisUsuarios);
                admin.EliminarUsuario(listaUsuarios, nombre, rutaMisUsuarios);
            }
            catch
            {
                MessageBox.Show("No hay usuarios para eliminar.");
            }


        }


    }
}
