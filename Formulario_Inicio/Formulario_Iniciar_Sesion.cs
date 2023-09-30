
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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            txtContrase�a.UseSystemPasswordChar = true;
            if (txtContrase�a.Text == "PASSWORD")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
            }//PUTO
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "PASSWORD";
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

        private void txtAcceder_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario formularioMenu = new Formulario_Menu_Usuario();
            formularioMenu.Show();
        }

        
    }
}