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
        private string pathMisUsuariosARegistrar = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";
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
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuariosARegistrar);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuariosARegistrar);

            listaUsuarioARegistrar = serializadorJson.Deserializar();



            Usuario usuario = new Usuario(nombreUsuario, dni, contraseña, false);
            if (usuario.VerificarDatosIngresados(nombreUsuario, contraseña, dni))
            {
                if (usuario.VerificarUsuarioRegistradoRepetido(usuario))
                {
                    listaUsuarioARegistrar.Add(usuario);
                    serializadorJson2.Serializar(listaUsuarioARegistrar);
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

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

    }
}
