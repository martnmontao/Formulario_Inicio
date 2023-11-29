using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class ActivoEvent : EventArgs
    {
        private int cantidadActivos;
        private float valorActivo;
        private float sueldoInsuficiente;
        
        public int CantidadActivos { get => cantidadActivos; set => cantidadActivos = value; }
        public float ValorActivo { get => valorActivo; set => valorActivo = value; }

        public float SueldoInsuficiente { get => sueldoInsuficiente; set => sueldoInsuficiente = value; }

        public ActivoEvent()
        {
            

        }

    
    
    
    
    }
}
