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
        private string pathUsuarios = @"C:\Users\Lomu\Desktop\MisUsuarios.json";
        private string pathUsuariosARegistrar = @"C:\Users\Lomu\Desktop\MisUsuariosARegistrar.json";
        private Administrador admin;
        private List<Usuario> listaUsuarios;
        private List<Usuario> listaUsuariosARegistrar;
        private string nombre;

        public Formulario_Administrar_Usuarios()
        {
            InitializeComponent();
            this.admin = new Administrador();
            this.btnEliminarUsuarios.Visible = false;
            this.btnValidarUsuarios.Visible = false;
            this.btnVerificarEmpresa.Visible = false;
            MostrarGrid(pathUsuarios);

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarGrid(pathUsuarios);
                btnEliminarUsuarios.Visible = true;
                btnValidarUsuarios.Visible = false;
                btnVerificarEmpresa.Visible = true;
            }
            catch
            {
                MessageBox.Show("No hay una lista de usuarios.");
            }
        }


        private void bntUsuariosARegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarGrid(pathUsuariosARegistrar);
                btnValidarUsuarios.Visible = true;
                btnEliminarUsuarios.Visible = false;
                btnVerificarEmpresa.Visible = false;
            }
            catch
            {
                MessageBox.Show("No hay una lista de usuarios registrados.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btnValidarUsuarios_Click(object sender, EventArgs e)
        {

            var jsonSerializador = new SerializadorJSON<Usuario>(pathUsuariosARegistrar);
            var listaUsuariosARegistrar = jsonSerializador.Deserializar();
            var serializadorJSON2 = new SerializadorJSON<List<Usuario>>(pathUsuarios);
            listaUsuarios = jsonSerializador.Deserializar();


            try
            {
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
                listaUsuarios = admin.ValidarUsuario(listaUsuariosARegistrar, nombre);
                admin.EliminarUsuario(listaUsuariosARegistrar, nombre, pathUsuariosARegistrar);
                serializadorJSON2.Serializar(listaUsuarios);

                MostrarGrid(pathUsuariosARegistrar);
            }
            catch
            {
                MessageBox.Show("No hay usuarios para validar.");
            }


        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            var jsonSerializador = new SerializadorJSON<Usuario>(pathUsuarios);

            try
            {
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
                listaUsuarios = jsonSerializador.Deserializar();
                admin.EliminarUsuario(listaUsuarios, nombre, pathUsuarios);
                MostrarGrid(pathUsuarios);
            }
            catch
            {
                MessageBox.Show("No hay usuarios para eliminar.");
            }


        }

        private void btnVerificarEmpresa_Click(object sender, EventArgs e)
        {
            nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            admin.VerificarEmpresa(nombre, pathUsuarios);
            MostrarGrid(pathUsuarios);
        }

        private void MostrarGrid(string ruta)
        {
            string filejson = File.ReadAllText(ruta);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            gridUsuarios.DataSource = dt;
        }
    }
}
