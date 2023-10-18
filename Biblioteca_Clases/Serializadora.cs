using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Clases
{
    public class Serializadora
    {




        #region EscribirJson
        public static void EscribirJsonUsuariosARegistrar(Usuario usuario, string ruta)
        {
            try
            {
                List<Usuario> listaPersona = LeerJsonUsuarios(ruta);
                if (usuario.VerificarUsuarioEnListaARegistrar(usuario) && usuario.VerificarUsuarioEnListaRegistrados(usuario))
                {
                    listaPersona.Add(usuario);
                }
                foreach (Usuario user in listaPersona)
                {

                    usuario.IdUsuario = (int.Parse(usuario.IdUsuario) + 1).ToString();

                }
                string json = JsonConvert.SerializeObject(listaPersona, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void ModificarJson(List<Usuario> listaUsuarios, string ruta)
        {

            try
            {
                string json = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        #endregion
        #region LeerJson
        public static List<Usuario> LeerJsonUsuarios(string ruta)
        {
            List<Usuario> listaPersona = new List<Usuario>();

            try
            {
                string json = File.ReadAllText(ruta);
                listaPersona = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPersona;
        }

        #endregion
    }
}
