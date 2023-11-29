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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Formulario_Inicio
{
    public partial class Formulario_Administrar_Usuarios : Form
    {
        private string pathUsuarios = @"C:\Users\Lomu\Desktop\MisUsuarios.json";
        private string pathUsuariosARegistrar = @"C:\Users\Lomu\Desktop\MisUsuariosARegistrar.xml";
        private Administrador admin;
        private List<Usuario> lista;
        private List<Usuario> listaUsuariosARegistrar;
        private List<Usuario> listaUsuarios;

        private string nombre;

        int idNombreDGV = 2;



        public Formulario_Administrar_Usuarios()
        {
            InitializeComponent();
            this.admin = new Administrador();
            this.btnEliminarUsuarios.Visible = false;
            this.btnValidarUsuarios.Visible = false;

            ConfigurarGridView();
        }
        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarios);
                lista = serializadorJson.Deserializar();
                btnEliminarUsuarios.Visible = true;
                btnValidarUsuarios.Visible = false;
                btnVerificarEmpresa.Visible = true;
                OrdenarPersonas(lista, (usuario1, usuario2) => usuario1.Dni.CompareTo(usuario2.Dni));
                MostrarUsuariosOrdenados();
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

                var serializadorXML = new SerializadorXML<Usuario>(pathUsuariosARegistrar);
                lista = serializadorXML.Deserializar();
                OrdenarPersonas(lista, (usuario1, usuario2) => usuario1.Nombre.CompareTo(usuario2.Nombre));

                MostrarUsuariosOrdenados();
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
            //admin.RegistrarAMySql();
        }

        private void btnValidarUsuarios_Click(object sender, EventArgs e)
        {

            var serializadorXML = new SerializadorXML<Usuario>(pathUsuariosARegistrar);
            var listaUsuariosARegistrar = serializadorXML.Deserializar();
            var serializadorJSON = new SerializadorJSON<List<Usuario>>(pathUsuarios);
            var serializadorJSON2 = new SerializadorJSON<Usuario>(pathUsuarios);

            listaUsuarios = serializadorJSON2.Deserializar();


            try
            {
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[idNombreDGV].Value.ToString();
                listaUsuarios = admin.ValidarUsuario(listaUsuariosARegistrar, nombre);
                admin.EliminarUsuario(listaUsuariosARegistrar, nombre, pathUsuariosARegistrar, false);
                serializadorJSON.Serializar(listaUsuarios);
                MostrarUsuariosOrdenados();


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
                nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
                listaUsuarios = jsonSerializador.Deserializar();
                admin.EliminarUsuario(listaUsuarios, nombre, pathUsuarios, true);
                MostrarUsuariosOrdenados();


            }
            catch
            {
                MessageBox.Show("No hay usuarios para eliminar.");
            }


        }

        private void btnVerificarEmpresa_Click(object sender, EventArgs e)
        {
            nombre = gridUsuarios.Rows[gridUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
            admin.VerificarEmpresa(nombre, pathUsuarios);
            MostrarUsuariosOrdenados();

        }




        public void OrdenarPersonas(List<Usuario> listaUsers, Comparison<Usuario> comparador)
        {
            listaUsers.Sort(comparador);
        }

        private void ConfigurarGridView()
        {
            gridUsuarios.ColumnCount = 6;
            gridUsuarios.Columns[0].Name = "Pesos";
            gridUsuarios.Columns[1].Name = "Dólares";
            gridUsuarios.Columns[2].Name = "Nombre";
            gridUsuarios.Columns[3].Name = "Empresa";
            gridUsuarios.Columns[4].Name = "Contraseña";
            gridUsuarios.Columns[5].Name = "Documento";
        }



        private void MostrarUsuariosOrdenados()
        {
            gridUsuarios.Rows.Clear();
            foreach (Usuario user in lista)
            {
                gridUsuarios.Rows.Add(user.Sueldo, user.SueldoDolares, user.Nombre, user.Empresa, user.Contraseña, user.Dni);
            }
        }



        private void Formulario_Administrar_Usuarios_Load(object sender, EventArgs e)
        {
            //MostrarUsuariosOrdenados();
        }

        private void btnMySql_Click(object sender, EventArgs e)
        {
            admin.RegistrarAMySql();
        }
    }
}
