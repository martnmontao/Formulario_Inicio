using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
//using System.Xml;
//using System.Xml.Serialization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Biblioteca_Clases
{
    public class Serializadora
    {
        private static string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        private static string ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosDos.xml";




        public static void EscribirJson(Persona persona)
        {
            Usuario usuario = (Usuario)persona;
            try
            {
                List<Usuario> listaPersona = LeerJson();         
                listaPersona.Add(usuario);
                string json = JsonConvert.SerializeObject(listaPersona, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static List<Usuario> LeerJson()
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



        
        
        
        






    }
}
