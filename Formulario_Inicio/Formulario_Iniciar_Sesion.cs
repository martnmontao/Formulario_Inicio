
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
                txtUsuario.Text = "USER";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            if (txtContraseña.Text == "PASSWORD")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
            }//PUTO
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "PASSWORD";
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

        private void txtAcceder_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario formularioMenu = new Formulario_Menu_Usuario();
            formularioMenu.Show();
        }

        
    }
}