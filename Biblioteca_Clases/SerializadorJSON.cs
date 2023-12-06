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
using System.Xml.Serialization;

namespace Biblioteca_Clases
{
    public class SerializadorJSON<T> : Serializador, ISerializable<T>
    {

        public SerializadorJSON(string path):base(path)
        {
            
        }

        public List<T> Deserializar()
        {
            List<T> lista = new List<T>();

            try
            {
                string json = File.ReadAllText(Path);
                lista = JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }



        public void Serializar(T datos)
        {

            try
            {

                string json = JsonConvert.SerializeObject(datos, Formatting.Indented);
                File.WriteAllText(Path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #region JsonUsuariosRegistrar
       
        #endregion

        #region JsonAdministrador
        public static void EscribirAdministradorJson(Administrador admin)
        {
            string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";
            List<Administrador> listaAdministrador = new List<Administrador>();
            listaAdministrador.Add(admin);
            try
            {

                string json = JsonConvert.SerializeObject(listaAdministrador, Formatting.Indented);
                File.WriteAllText(pathAdministrador, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<Administrador> LeerJsonAdministrador(string ruta)
        {

            List<Administrador> listaPersona = new List<Administrador>();

            try
            {
                string json = File.ReadAllText(ruta);
                listaPersona = JsonConvert.DeserializeObject<List<Administrador>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPersona;
        }
        #endregion

        #region JsonUsuarios
       











        #endregion

        #region JsonActivos
        
        public static List<Activos> LeerJsonActivos(string ruta)
        {

            List<Activos> listaActivos = new List<Activos>();

            try
            {
                string json = File.ReadAllText(ruta);
                listaActivos = JsonConvert.DeserializeObject<List<Activos>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaActivos;
        }


        #endregion










    }
}
