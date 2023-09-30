using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Menu_Usuario : Form
    {
        private string nombre_usuario;
        public Formulario_Menu_Usuario(string nombre)
        {
            InitializeComponent();
            this.nombre_usuario = nombre;
        }

        private void Formulario_Menu_Load(object sender, EventArgs e)
        {

            this.lblNombreUsuario.Text = nombre_usuario;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
