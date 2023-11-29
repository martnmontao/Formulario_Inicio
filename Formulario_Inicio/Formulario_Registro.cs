using Biblioteca_Clases;
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
    public partial class Formulario_Registro : Form
    {
        private string pathMisUsuariosARegistrar = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.xml";
        List<Usuario> listaUsuarioARegistrar = new List<Usuario>();
        public Formulario_Registro()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBoxNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string dni = txtNroDocumento.Text;
            var serializadorXML = new SerializadorXML<Usuario>(pathMisUsuariosARegistrar);
            var serializadorXML2 = new SerializadorXML<List<Usuario>>(pathMisUsuariosARegistrar);

            serializadorXML2.Serializar(listaUsuarioARegistrar);
            listaUsuarioARegistrar = serializadorXML.Deserializar();
            Usuario usuario = new Usuario(nombreUsuario, dni, contraseña, false);
            if (usuario.VerificarDatosIngresados(nombreUsuario, contraseña, dni))
            {
                if (usuario.VerificarUsuarioRegistradoRepetido(usuario))
                {
                    listaUsuarioARegistrar.Add(usuario);
                    serializadorXML2.Serializar(listaUsuarioARegistrar);
                    MessageBox.Show("Se ha registrado con éxito!");

                }
                else
                {
                    MessageBox.Show("Ya se ha registrado un usuario con ese número de documento, porfavor, ingrese otro.");
                }
            }
            else
            {
                MessageBox.Show("Ayuda:\nNombre de usuario y contraseña: +5 carácteres \nDNI: Tiene que ser válido. Ejemplo: 45.000.000(Sin puntos)");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Formulario_Iniciar_Sesion fi = new Formulario_Iniciar_Sesion();
            fi.Show();
            this.Hide();
        }



    }
}
