using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{

    public class Cedear : Activos
    {
        /*Para calcular tu ganancia, resta el precio al que compraste los CEDEAR del precio al que los vendes. 
         * Si el precio de venta es mayor que el precio de compra, obtendrás una ganancia. Si el precio de venta es menor, 
         * tendrás una pérdida.*/


        /*Comisiones y costos: Ten en cuenta que al comprar y vender CEDEAR, hay comisiones y costos asociados que reducirán tu ganancia. 
         * Asegúrate de conocer los costos asociados con tus transacciones.*/
        /*
          En Argentina, los CEDEAR se cotizan en pesos argentinos, pero representan activos en moneda extranjera. 
        Las fluctuaciones en el tipo de cambio pueden afectar el valor en pesos de tus inversiones en CEDEAR.*/
        private int cantidad;



        public Cedear(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo tipoActivo, ETipoMoneda moneda, float intereses, string distintivo) : base(nombreActivo, cc, pc, cv, pv, tipoActivo, moneda, intereses, distintivo)
        {

        }

        //public Cedear(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo tipoActivo, string moneda, float intereses, string dni) : base(nombreActivo, cc, pc, cv, pv, tipoActivo, moneda, intereses, dni)
        //{
            
        //}
        //public string Dni { get => dni; set => dni = value; }

    


    }
      







    
}
