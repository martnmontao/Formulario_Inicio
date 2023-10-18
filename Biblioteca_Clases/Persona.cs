
namespace Biblioteca_Clases
{

    public class Persona
    {
        protected string nombre;
        protected string idUsuario;

        public Persona()
        {
            
        }

        public Persona(string nombre, string idUsuario)
        {
            this.nombre = nombre;
            this.idUsuario = idUsuario;
        }



        public string Nombre { get => nombre; set => nombre = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }

        public override string ToString()
        {
            return $"{this.nombre} -- {this.idUsuario}";
        }



    }
}