using Biblioteca_Clases;
using System.Drawing.Text;

namespace Formulario_Inicio
{
    public partial class Formulario_Menu_Usuario : Form
    {

        private UsuarioADO usuario;
        public Formulario_Menu_Usuario(UsuarioADO usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void Formulario_Menu_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = usuario.Nombre;
            lblIdUsuario.Text = usuario.Documento;
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 233)
            {
                menuVertical.Width = 77;
                btnInformacion.Width = 55;
                btnInvertir.Width = 55;
                btnCartera.Width = 55;

                btnInformacion.Text = "";
                btnInvertir.Text = "";
                btnCartera.Text = "";

            }
            else
            {
                menuVertical.Width = 233;
                btnInformacion.Width = 200;
                btnInvertir.Width = 200;
                btnCartera.Width = 200;
                btnInformacion.Text = "Información";
                btnInvertir.Text = "Mercado";
                btnCartera.Text = "Movimientos";


            }
        }



        private void btnCerrarClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Iniciar_Sesion fIS = new Formulario_Iniciar_Sesion();
            fIS.Show();
        }

        private void btnMinimizarClick_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresarDinero_Click(object sender, EventArgs e)
        {
            Formulario_Ingresar_Sueldo fIS = new Formulario_Ingresar_Sueldo(usuario, "pesos");
            fIS.Show();
            this.Hide();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Formulario_InformacionEmpresa fInfo = new Formulario_InformacionEmpresa();
            fInfo.Show();

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Formulario_Inversiones formInvertir = new Formulario_Inversiones(usuario);
            formInvertir.Show();
            this.Hide();
        }

        

        private void btnCartera_Click(object sender, EventArgs e)
        {
            Formulario_Activos_Usuario fAU = new Formulario_Activos_Usuario(usuario);
            fAU.Show();
            this.Hide();
        }

        private void btnDolarMEP_Click(object sender, EventArgs e)
        {
            Formulario_Dolar_Mep fDM = new Formulario_Dolar_Mep(usuario);
            fDM.Show();
            this.Hide();
        }
    }
}
