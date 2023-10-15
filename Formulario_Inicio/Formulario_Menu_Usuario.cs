using Biblioteca_Clases;
using System.Drawing.Text;

namespace Formulario_Inicio
{
    public partial class Formulario_Menu_Usuario : Form
    {

        private Usuario usuario;

        public Formulario_Menu_Usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void Formulario_Menu_Load(object sender, EventArgs e)
        {



        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 233)
            {
                menuVertical.Width = 60;
            }
            else
            {
                menuVertical.Width = 233;
            }
        }



        private void btnCerrarClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarClick_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresarDinero_Click(object sender, EventArgs e)
        {
            Formulario_Ingresar_Sueldo formIngresarSueldo = new Formulario_Ingresar_Sueldo(this.usuario);
            this.Hide();
            formIngresarSueldo.Show();

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Formulario_InformacionEmpresa fInfo = new Formulario_InformacionEmpresa();
            fInfo.Show();

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Formulario_Inversiones formInvertir = new Formulario_Inversiones();
            formInvertir.Show();
        }
    }
}
