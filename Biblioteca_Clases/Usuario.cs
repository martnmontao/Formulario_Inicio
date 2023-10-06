using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    [Serializable]

    public class Usuario : Persona
    {
        
        private float sueldo;

        public Usuario()
        {
            
        }
        public Usuario(string nombre, string idUsuario, int sueldo):base(nombre, idUsuario) 
        {
            this.sueldo = sueldo;
        }

        public float Sueldo { get => sueldo; set => sueldo = value; }

        public override string ToString()
        {
            return base.ToString() + $"Sueldo: {this.Sueldo}";
        }




    }
}
