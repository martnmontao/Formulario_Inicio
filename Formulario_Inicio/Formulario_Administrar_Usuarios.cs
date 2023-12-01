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
using MySql.Data.MySqlClient;
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

        int idNombreDGV = 1;



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
                gridUsuariosMySql.Visible = false;

                AlternarMuestraBotones(false);





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
                AlternarMuestraBotones(false);
                gridUsuariosMySql.Visible = false;
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
                admin.AgregarAMySql();
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
            admin.AgregarAMySql();
            MostrarUsuariosOrdenados();

        }




        public void OrdenarPersonas(List<Usuario> listaUsers, Comparison<Usuario> comparador)
        {
            listaUsers.Sort(comparador);
        }

        private void ConfigurarGridView()
        {
            gridUsuarios.ColumnCount = 6;

            gridUsuarios.Columns[0].Name = "Documento";
            gridUsuarios.Columns[1].Name = "Nombre";
            gridUsuarios.Columns[2].Name = "Contraseña";
            gridUsuarios.Columns[3].Name = "Pesos";
            gridUsuarios.Columns[4].Name = "Dólares";
            gridUsuarios.Columns[5].Name = "Empresa";
        }



        private void MostrarUsuariosOrdenados()
        {
            gridUsuarios.Rows.Clear();
            foreach (Usuario user in lista)
            {
                gridUsuarios.Rows.Add(user.Dni, user.Nombre, user.Contraseña, user.Sueldo, user.SueldoDolares, user.Empresa);
            }
        }



        private void Formulario_Administrar_Usuarios_Load(object sender, EventArgs e)
        {
            //MostrarUsuariosOrdenados();
        }



        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            admin.ModificarUsuarios(txtID.Text, txtNombre.Text, txtContraseña.Text, txtDocumento.Text, txtPesos.Text, txtDolares.Text, txtEmpresa.Text);
            LlenarDataGridView(gridUsuariosMySql);
        }






        private void btnUsuariosMySql_Click(object sender, EventArgs e)
        {
            AlternarMuestraBotones(true);
            try
            {
                UsuarioADO usuarioADO = new UsuarioADO();
                Usuario usuario = new Usuario();


                List<UsuarioADO> listaUsuarioADOs = new List<UsuarioADO>();

                var serializadorJSON = new SerializadorJSON<Usuario>(pathUsuarios);
                List<Usuario> listaUsuarios = serializadorJSON.Deserializar();
                foreach (Usuario user in listaUsuarios)
                {
                    usuarioADO = (UsuarioADO)user;
                    break;
                }

                listaUsuarioADOs = usuarioADO.Select();

                gridUsuariosMySql.Visible = true;
                MostrarGridUsuarios(gridUsuariosMySql);

            }
            catch
            {
                MessageBox.Show("No se encontraron usuarios en la base de datos");
            }
        }

        private void gridUsuariosMySql_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[2].Value.ToString();
            string contraseñaUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[3].Value.ToString();
            string documentoUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[1].Value.ToString();
            string empresaUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[6].Value.ToString();
            string idUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[0].Value.ToString();
            string pesosUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[4].Value.ToString();
            string dolaresUsuario = gridUsuariosMySql.Rows[gridUsuariosMySql.CurrentRow.Index].Cells[5].Value.ToString();




            txtNombre.Text = nombreUsuario;
            txtDocumento.Text = documentoUsuario;
            txtContraseña.Text = contraseñaUsuario;
            txtEmpresa.Text = empresaUsuario;
            txtID.Text = idUsuario;
            txtPesos.Text = pesosUsuario;
            txtDolares.Text = dolaresUsuario;
        }

        private void MostrarGridUsuarios(DataGridView dataGridView)
        {

            //gridUsuariosMySql.DataSource = listaGenerica;
            LlenarDataGridView(dataGridView);
        }


        public static void LlenarDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataBase dataBase = new DataBase();
                string query = "SELECT * FROM usuarios";

                dataGridView.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dataBase.OpenDataGridView());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                dataBase.CloseDataGridView();


            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo mostrar");
            }
        }

        private void btnEliminarMySql_Click(object sender, EventArgs e)
        {
            admin.EliminarUsuarioMySql(txtID.Text);
            LlenarDataGridView(gridUsuariosMySql);
        }


        private void AlternarMuestraBotones(bool alternar)
        {
            lblContraseña.Visible = alternar;
            lblDocumento.Visible = alternar;
            lblNombre.Visible = alternar;
            lblEmpresa.Visible = alternar;
            lblID.Visible = alternar;
            lblPesos.Visible = alternar;
            lblDolares.Visible = alternar;

            txtContraseña.Visible = alternar;
            txtID.Visible = alternar;
            txtNombre.Visible = alternar;
            txtPesos.Visible = alternar;
            txtDolares.Visible = alternar;
            txtEmpresa.Visible = alternar;
            txtDocumento.Visible = alternar;
            btnModificarUsuario.Visible = alternar;
            btnEliminarMySql.Visible = alternar;

        }
    }
}
