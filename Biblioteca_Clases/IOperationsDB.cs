using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public interface IOperationsDB<T>
    {
        bool Add(string nombreTabla);

        bool Update(string id);

        bool Delete(string id, string nombreTabla);

        List<T> Select();



    }
}
