using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class Bonos : Activos
    {


        public Bonos(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo tipoActivo, ETipoMoneda moneda, float intereses, string distintivo) : base(nombreActivo, cc, pc, cv, pv, tipoActivo, moneda, intereses, distintivo)
        {
            this.Intereses = intereses / 100;
        }


        



    }
}
