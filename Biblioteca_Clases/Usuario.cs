using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    [Serializable]

    public class Usuario : Persona
    {
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        private float sueldo;
        private string contraseña;
        private List<Usuario> listaUsuarios;
        public Usuario()
        {
            
        }
        public Usuario(string nombre, string idUsuario, int sueldo, string contraseña):base(nombre, idUsuario) 
        {
            this.sueldo = sueldo;
            this.contraseña = contraseña;
        }

        public float Sueldo { get => sueldo; set => sueldo = value;}
        public string Contraseña { get => contraseña; set => contraseña = value;}


        public bool VerificarUsuario(Usuario user)
        {
            bool validar = false;
            
            List<Usuario> listaUsuariosRegistrados = Serializadora.LeerJsonUsuarios(ruta);
            foreach (Usuario usuarioRegistrado in listaUsuariosRegistrados)
            {

                if (user.Nombre == usuarioRegistrado.Nombre && user.Contraseña != usuarioRegistrado.Contraseña)
                {
                    validar = false;
                }
                else if (listaUsuariosRegistrados.Contains(usuarioRegistrado))
                { 
                    validar = true;
                }
                else
                {
                    validar = false;
                }

                break;    
            }
            
            return validar;
        }



        public override string ToString()
        {
            return base.ToString() + $"Sueldo: {this.Sueldo}";
        }




    }
}
