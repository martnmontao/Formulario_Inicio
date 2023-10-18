using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{

    public class Administrador : Persona
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";

        public Administrador()
        {
            
        }
        public Administrador(string nombre, string id):base(nombre, id)
        {
            
        
        }
        public void ValidarUsuario(List<Usuario> listaUsuarios, string nombre)
        {
            List<Usuario> listaUsuariosRegistrados = Serializadora.LeerJsonUsuarios(ruta);
            try
            {
                foreach(Usuario usuario in listaUsuarios)
                {
                    if(nombre == usuario.Nombre)
                    {
                        listaUsuariosRegistrados.Add(usuario);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Serializadora.ModificarJson(listaUsuariosRegistrados, ruta);  
        }

        public void EliminarUsuario(List<Usuario> listaUsuarios, string nombre, string ruta)
        {
            try
            {
                foreach(Usuario usuario in listaUsuarios)
                {
                    if(nombre == usuario.Nombre)
                    {
                        listaUsuarios.Remove(usuario);
                        break;
                      
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Serializadora.ModificarJson(listaUsuarios, ruta);
        }




    }
}
