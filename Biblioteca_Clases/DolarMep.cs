using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class dolarMep : Activos
    {
        private float tipoCambio;
        private float valorDolar;
        public dolarMep(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo tipoActivo, ETipoMoneda moneda,float intereses, string distintivo, float tipoCambio) : base(nombreActivo, cc, pc, cv, pv, tipoActivo, moneda, intereses, distintivo)
        {
            this.tipoCambio = tipoCambio;
        }
        public dolarMep(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo tipoActivo, ETipoMoneda moneda, float intereses, string distintivo) : base(nombreActivo, cc, pc, cv, pv, tipoActivo, moneda, intereses, distintivo)
        {

        }


        public override float CalcularValorCompra(int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
