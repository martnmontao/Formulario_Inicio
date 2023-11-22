using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public interface ISerializable<T>
    {
        void Serializar(T datosASerializar);

        List<T> Deserializar();
 
    }
}
