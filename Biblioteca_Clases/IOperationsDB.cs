using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public interface IOperationsDB<T>
    {
        bool Add();

        bool Update();

        bool Delete();

        List<T> Select();



    }
}
