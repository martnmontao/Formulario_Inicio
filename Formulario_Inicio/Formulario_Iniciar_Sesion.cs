

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

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            if (txtContraseña.Text == "Usuario")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
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
            string contraseña = txtContraseña.Text;


            if (txtUsuario.Text == "Apache" && txtContraseña.Text == "1")
            {
                Formulario_Admin formularioAdmin = new Formulario_Admin(nombre, "EL JEFE");
                formularioAdmin.Show();
            }
            else
            {

                try
                {
                    Persona persona = new Usuario(nombre, "0", 0, 0, contraseña);
                    Usuario usuario = (Usuario)persona;
                    if (usuario.VarificarNombreYContraseña(usuario))
                    {
                        Serializadora.EscribirJsonUsuariosARegistrar(usuario, ruta);
                        Formulario_Menu_Usuario formularioMenu = new Formulario_Menu_Usuario(usuario);
                        formularioMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ya hay un usuario con el nombre ingresado. Porfavor ingrese su contraseña.");
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