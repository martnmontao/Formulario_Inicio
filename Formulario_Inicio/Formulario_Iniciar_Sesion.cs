

using Biblioteca_Clases;
namespace Formulario_Inicio
{
    public partial class Formulario_Iniciar_Sesion : Form
    {
        public Formulario_Iniciar_Sesion()
        {
            InitializeComponent();
        }
        private void Fomurlario_Iniciar_Sesion_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USER")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Username";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            txtContrase�a.UseSystemPasswordChar = true;
            if (txtContrase�a.Text == "Usuario")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "Contrase�a";
                txtContrase�a.ForeColor = Color.DimGray;
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";
            string nombre = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;


            if (txtUsuario.Text == "Apache" && txtContrase�a.Text == "1")
            {
                Formulario_Admin formularioAdmin = new Formulario_Admin(nombre, "EL JEFE");
                formularioAdmin.Show();
            }
            else
            {

                try
                {
                    Persona persona = new Usuario(nombre, "0", 0, 0, contrase�a);
                    Usuario usuario = (Usuario)persona;
                    if (usuario.VarificarNombreYContrase�a(usuario))
                    {
                        Serializadora.EscribirJsonUsuariosARegistrar(usuario, ruta);
                        Formulario_Menu_Usuario formularioMenu = new Formulario_Menu_Usuario(usuario);
                        formularioMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ya hay un usuario con el nombre ingresado. Porfavor ingrese su contrase�a.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}