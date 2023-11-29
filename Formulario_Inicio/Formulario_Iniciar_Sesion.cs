
using Biblioteca_Clases;
namespace Formulario_Inicio
{
    public partial class Formulario_Iniciar_Sesion : Form
    {
        private Administrador admin;
        private string nombre;
        private string contraseña;
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
     
            this.nombre = txtUsuario.Text;
            this.contraseña = txtContraseña.Text;
            this.documento = txtDocumento.Text;
            Usuario usuario = new Usuario(nombre, documento, contraseña);

            if (usuario.IniciarSesion(usuario))
            {
   
                usuario = usuario.DevolverUsuarios(usuario);
                Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe o aún un administrador no lo ha validado. Porfavor vuelva a intentarlo o registrese.");
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
            this.contraseña = txtContraseña.Text;
            Administrador admin = new Administrador(nombre, txtDocumento.Text, contraseña);
            admin = usuario.DevolverAdminitrador(admin);

            if (admin.verificarAdministrador(nombre, contraseña))
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