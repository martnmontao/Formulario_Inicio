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
            if (menuVertical.Width == 260)
            {
                menuVertical.Width = 57;
            }
            else
            {
                menuVertical.Width = 260;
            }
        }

        
    }
}
