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
        private string ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";
        private double sueldo;
        private double sueldoDolares;
        private string contraseña;
        private string accionApple;
        private string accionMicrosoft;
        private string accionTesla;
        private string accionAmazon;

        List<Usuario> listaUsuarios;
        public Usuario()
        {
            
        }
        public Usuario(string nombre, string idUsuario, string contraseña):base(nombre, idUsuario) 
        {
            this.sueldo = 0;
            this.sueldoDolares = 0;
            this.contraseña = contraseña;
        }

        public double SueldoDolares { get => sueldoDolares; set => sueldoDolares = value;}
        public double Sueldo { get => sueldo; set => sueldo = value;}
        public string Contraseña { get => contraseña; set => contraseña = value;}
        public bool VerificarUsuarioEnListaRegistrados(Usuario usuario)
        {
            this.listaUsuarios = Serializadora.LeerJsonUsuarios(ruta);
            bool validar = true;
            foreach(Usuario user in listaUsuarios)
            {
                if(usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña)
                { 
                    validar = false;
                    break;
                }
            }
            
            return validar;
        }
        public bool VerificarUsuarioEnListaARegistrar(Usuario usuario)
        {
            this.listaUsuarios = Serializadora.LeerJsonUsuarios(ruta2);
            bool validar = true;
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Nombre.ToLower() == user.Nombre.ToLower() && usuario.Contraseña == user.Contraseña)
                {
                    validar = false;
                    break;
                }
            }

            return validar;
        }

        public bool VerificarNombreYContraseña(Usuario usuario)
        {
            listaUsuarios = Serializadora.LeerJsonUsuarios(ruta);
            bool verificar = true;
            foreach(Usuario user in listaUsuarios)
            {
                if(usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña)
                {
                    verificar = true;
                    break;
                }
                else if(usuario.Nombre == user.Nombre && usuario.Contraseña != user.Contraseña)
                {
                    verificar = false;
                    break;
                }
            }
            return verificar;
        }

        
        public override string ToString()
        {
            return base.ToString() + $"Sueldo: {this.Sueldo}";
        }




    }
}
