using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public enum ETipoActivo
    {
        //Logica en biblioteca de clases, aplicar polimorfismo, utilizar XML
        //padre = instrumento (metodo comprar y vender)
        Accion,//Acciones locales
        Cedear,//Acciones extranjeras
        Bono,//Rentas fijas del estado
        MEP//Dolar bolsa//Hacerlo cuando se ingrese plata
    }
}
