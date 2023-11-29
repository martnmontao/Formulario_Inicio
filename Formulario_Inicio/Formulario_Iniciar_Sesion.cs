
using Biblioteca_Clases;
namespace Formulario_Inicio
{
    public partial class Formulario_Iniciar_Sesion : Form
    {
        private Administrador admin;
        private string nombre;
        private string contrase�a;
        private string documento;
        public Formulario_Iniciar_Sesion()
        {
            InitializeComponent();
            //this.admin = new Administrador("carlitos", "45301748", "1");
        }
        private void Formulario_Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            //Serializadora.EscribirAdministradorJson(admin);
            //DataBase.OpenConnection();
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
     
            this.nombre = txtUsuario.Text;
            this.contrase�a = txtContrase�a.Text;
            this.documento = txtDocumento.Text;
            Usuario usuario = new Usuario(nombre, documento, contrase�a);

            if (usuario.IniciarSesion(usuario))
            {
   
                usuario = usuario.DevolverUsuarios(usuario);
                Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe o a�n un administrador no lo ha validado. Porfavor vuelva a intentarlo o registrese.");
            }

        }
        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formulario_Registro fr = new Formulario_Registro();
            fr.Show();
            this.Hide();
        }

        private void btnIniciarAdmin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            this.nombre = txtUsuario.Text;
            this.contrase�a = txtContrase�a.Text;
            Administrador admin = new Administrador(nombre, txtDocumento.Text, contrase�a);
            admin = usuario.DevolverAdminitrador(admin);

            if (admin.verificarAdministrador(nombre, contrase�a))
            {
                Formulario_Admin fa = new Formulario_Admin(admin);
                fa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usted no es administrador");
            }
        }

    }
}