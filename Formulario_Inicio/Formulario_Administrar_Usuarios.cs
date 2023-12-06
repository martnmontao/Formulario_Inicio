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

            this.btnValidarUsuarios.Visible = false;

            ConfigurarGridView();
        }
        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarios);
                lista = serializadorJson.Deserializar();

                btnValidarUsuarios.Visible = false;

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

                
                this.Size = new System.Drawing.Size(743, 696);

                LlenarDataGridView(gridUsuariosMySql, "SELECT * FROM registro");
                btnValidarUsuarios.Visible = true;
                lblTitulo.Location = new System.Drawing.Point(226, 9);

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
            try
            {
                UsuarioADO usuarioADO = new UsuarioADO(txtNombre.Text, txtDocumento.Text, txtContraseña.Text, double.Parse(txtPesos.Text), double.Parse(txtDolares.Text), txtEmpresa.Text);
                usuarioADO.Add("usuarios");
               
                admin.EliminarUsuarioMySql(usuarioADO, txtID.Text, "registro");




            }
            catch
            {
                MessageBox.Show("No hay usuarios para validar.");
            }
            finally
            {
                LlenarDataGridView(gridUsuariosMySql, "SELECT * FROM registro");

            }

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
            this.Size = new System.Drawing.Size(743, 696);
            lblTitulo.Location = new System.Drawing.Point(226, 9);

        }



        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            admin.ModificarUsuarios(txtID.Text, txtNombre.Text, txtContraseña.Text, txtDocumento.Text, txtPesos.Text, txtDolares.Text, txtEmpresa.Text);
            LlenarDataGridView(gridUsuariosMySql, "SELECT * FROM usuarios");
        }






        private void btnUsuariosMySql_Click(object sender, EventArgs e)
        {
            AlternarMuestraBotones(true);
            try
            {
                LlenarDataGridView(gridUsuariosMySql, "SELECT * FROM usuarios");
                btnValidarUsuarios.Visible = false;
                this.Size = new System.Drawing.Size(1463, 696);
                lblTitulo.Location = new System.Drawing.Point(578, 9);



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




        public static void LlenarDataGridView(DataGridView dataGridView, string query)
        {
            try
            {
                DataBase dataBase = new DataBase();


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

            admin.EliminarUsuarioMySql(new UsuarioADO(), txtID.Text, "usuarios");
            LlenarDataGridView(gridUsuariosMySql, "SELECT * FROM usuarios");
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
