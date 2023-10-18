

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
            string rutaUsuariosRegistrados = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
            string nombre = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;
            int flag = 0;
            List<Usuario> listaUsuarioRegistrados = Serializadora.LeerJsonUsuarios(rutaUsuariosRegistrados);
            List<Usuario> listaUsuarioARegistrar = Serializadora.LeerJsonUsuarios(ruta);

            if (contrase�a.Length < 5 && nombre.Length > 5)
            {
                MessageBox.Show("Ingrese una contrase�a m�s larga");
            }
            else if (nombre.Length < 5 && contrase�a.Length > 5)
            {
                MessageBox.Show("Ingrese un nombre m�s largo");
            }
            else
            {

                Persona persona = new Usuario(nombre.ToLower(),"0", contrase�a);
                Usuario usuario = (Usuario)persona;
                foreach (Usuario user in listaUsuarioRegistrados)
                {
                    if (usuario.Nombre == user.Nombre && usuario.Contrase�a == user.Contrase�a)
                    {
                        usuario = user;
                        flag = 1;
                        break;
                    }
                }

                if (txtUsuario.Text == "Apache" && txtContrase�a.Text == "carlitos")
                {
                    Formulario_Admin formularioAdmin = new Formulario_Admin(nombre, "Administrador");
                    formularioAdmin.Show();
                }
                else
                {

                    try
                    {
                        if (usuario.VerificarNombreYContrase�a(usuario))
                        {
                            Serializadora.EscribirJsonUsuariosARegistrar(usuario, ruta);

                            if (flag == 1)
                            {
                                Formulario_Menu_Usuario formularioMenu = new Formulario_Menu_Usuario(usuario);
                                formularioMenu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Porfavor, espere a que el administrador le d� de alta. �Gracias por registrarse!.");
                            }
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
}