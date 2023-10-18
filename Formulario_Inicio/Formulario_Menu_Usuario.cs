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
            Formulario_Ingresar_Sueldo fi = new Formulario_Ingresar_Sueldo();
            lblIdUsuario.Text = usuario.IdUsuario;
            lblNombreUsuario.Text = usuario.Nombre;
            lblSueldo.Text = "$ARG: " + usuario.Sueldo.ToString();
            lblSueldoDolares.Text = "$USD: " + fi.ConvertirPesoADolar(usuario.Sueldo).ToString();
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 233)
            {
                menuVertical.Width = 77;
            }
            else
            {
                menuVertical.Width = 233;
            }

            if (menuVertical.Width == 77)
            {
                pictureBoxApple.Location = new Point(133, 248);
                pictureBoxMicrosoft.Location = new Point(287, 383);
                lblSueldo.Location = new Point(204, 103);
                pictureBoxLogo.Location = new Point(474, 246);
                pictureBoxAmazon.Location = new Point(660, 383);
                lblSueldoDolares.Location = new Point(655, 105);
            }
            else
            {
                lblSueldo.Location = new Point(345, 105);
                pictureBoxApple.Location = new Point(334, 246);
                pictureBoxMicrosoft.Location = new Point(444, 383);
                pictureBoxLogo.Location = new Point(566, 251);
                pictureBoxAmazon.Location = new Point(680, 383);
                lblSueldoDolares.Location = new Point(747, 105);
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
            Formulario_Ingresar_Sueldo formIngresarSueldo = new Formulario_Ingresar_Sueldo(usuario);
            formIngresarSueldo.Show();
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

        private void btnInfoInversiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario_Ingresos formIngresos = new Formulario_Ingresos(usuario);
            formIngresos.Show();
        }


    }
}
