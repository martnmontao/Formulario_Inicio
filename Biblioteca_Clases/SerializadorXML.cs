using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Clases
{
    public class SerializadorXML<T> : Serializador, ISerializable<T> where T : new()
    {
        public SerializadorXML(string path):base(path)
        {
            
        }

        public List<T> Deserializar()
        {
            var lista = new List<T>();
            using(var stream = new StreamReader(Path))
            {
                if(stream != null)
                {
                    var xml = new XmlSerializer(typeof(List<T>));
                    var listaDeseariazliada = xml.Deserialize(stream);
                    if(listaDeseariazliada != null)
                    {
                        lista = (List<T>)(listaDeseariazliada);
                    }
                }
            }
            return lista;
        }

   
        public void Serializar(T datos)
        {
            using(var stream = new StreamWriter(Path))
            {
                if(stream != null)
                {
                    var xml = new XmlSerializer(typeof(T));
                    xml.Serialize(stream, datos);
                }
            }
        }
    }
}
