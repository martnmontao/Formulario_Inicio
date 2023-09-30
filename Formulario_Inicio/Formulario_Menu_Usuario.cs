namespace Formulario_Inicio
{
    public partial class Formulario_Menu_Usuario : Form
    {
        public Formulario_Menu_Usuario()
        {
            InitializeComponent();
        }
        private void Formulario_Menu_Load(object sender, EventArgs e)
        {



        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 237)
            {
                menuVertical.Width = 60;
            }
            else
            {
                menuVertical.Width = 237;
            }
        }



        private void btmCerrarClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarClick_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormalizar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnNormalizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormalizar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }
    }
}
