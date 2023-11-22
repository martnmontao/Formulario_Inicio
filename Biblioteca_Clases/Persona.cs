
namespace Biblioteca_Clases
{

    public class Persona
    {
        protected string nombre;
        protected string contraseña;
        protected string dni;
        public Persona()
        {
            
        }
        public Persona(string nombre, string dni, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.Dni = dni;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}