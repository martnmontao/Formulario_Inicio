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
        private float sueldoDolares;
        private string contraseña;
        private List<Usuario> listaUsuarios;
        public Usuario()
        {
            
        }
        public Usuario(string nombre, string idUsuario, float sueldo, float sueldoDolares, string contraseña):base(nombre, idUsuario) 
        {
            this.sueldo = sueldo;
            this.sueldoDolares = sueldoDolares;
            this.contraseña = contraseña;
            this.listaUsuarios = Serializadora.LeerJsonUsuarios(ruta);
        }

        public float SueldoDolares { get => sueldoDolares; set => sueldoDolares = value;}
        public float Sueldo { get => sueldo; set => sueldo = value;}
        public string Contraseña { get => contraseña; set => contraseña = value;}


        public bool VerificarUsuarioRegistrado(Usuario usuario)
        {
            bool validar = true;
            foreach(Usuario user in listaUsuarios)
            {
                if(usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña)
                { 
                    validar = false;
                }
                break;
            }
            
            return validar;
        }

        public bool VarificarNombreYContraseña(Usuario usuario)
        {
            bool verificar = true;
            foreach(Usuario user in listaUsuarios)
            {
                if(usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña)
                {
                    verificar = true;
                }
                else if(usuario.Nombre == user.Nombre && usuario.Contraseña != user.Contraseña)
                {
                    verificar = false;
                }
                break;
            }
            return verificar;
        }

        public void ModificarSueldo(Usuario usuario, float SueldoAPesos, float SueldoADolares)
        {
            //List<Usuario> listaSueldoModificado = listaUsuarios;
            foreach(Usuario user in listaUsuarios)
            {
                if(usuario.nombre == user.nombre)
                {
                    this.SueldoDolares = SueldoADolares;
                    this.Sueldo = SueldoAPesos;
                }
            }

        }


        public override string ToString()
        {
            return base.ToString() + $"Sueldo: {this.Sueldo}";
        }




    }
}
