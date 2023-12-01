using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class UsuarioADO : SQLCrud<UsuarioADO>,IOperationsDB<UsuarioADO>
    {
        public string Documento { get; set; }
        public string Nombre {  get; set; }
        public string Contraseña { get; set; }
        public double Pesos { get; set; }
        public double Dolares {  get; set; }
        public string Empresa { get; set; }

        public string Id { get; set; }

        public UsuarioADO():base("usuarios", ["Documento", "Nombre", "Contraseña", "Pesos", "Dolares", "Empresa"])
        {

        }

        public UsuarioADO(string nombre, string documento, string contraseña, double pesos, double dolares, string empresa):base("usuarios", ["Documento", "Nombre", "Contraseña", "Pesos", "Dolares", "Empresa"])
        {
            Nombre = nombre;
            Documento = documento;
            Contraseña = contraseña;
            Pesos = pesos;
            Dolares = dolares;
            Empresa = empresa;

        }

        //Va a agregar un elemento a mySql
        public bool Add()
        {            
            DataBase.InsertUsuarios(Documento, Nombre, Contraseña, Pesos, Dolares, Empresa);
            return true;
        }

        //Va a actualizar mi elemento de mySql
        public bool Update(string id) 
        {
            DataBase.UpdateUsuario(id, Documento, Nombre, Contraseña, Pesos, Dolares, Empresa);
            return true; 
        }

        //Va a eliminar mi elemento de mySql
        public bool Delete(string id) 
        {
            DataBase.DeleteUsuario(id);
            return true;
        }

        //Va a obtener todos los elementos de mySql
        public List<UsuarioADO> Select()
        {
            var usuarios = GetAll();
            return usuarios;
        }


        public static UsuarioADO MapUsuario(MySqlDataReader reader)
        {
            return (UsuarioADO)reader;
        }


        public static explicit operator UsuarioADO(MySqlDataReader reader)
        {
            var documento = reader["Documento"].ToString();
            var nombre = reader["Nombre"].ToString();
            var contraseña = reader["Contraseña"].ToString();
            var pesos = Convert.ToInt32(reader["Pesos"]);
            var dolares =   Convert.ToInt32(reader["Dolares"]);
            var empresa =  reader["Empresa"].ToString();

            return new UsuarioADO(nombre, documento, contraseña, pesos, dolares, empresa);
        }

        public static explicit operator UsuarioADO(Usuario usuario)
        {
            var documento = usuario.Dni;
            var nombre = usuario.Nombre;
            var contraseña = usuario.Contraseña;
            var pesos = usuario.Sueldo;
            var dolares = usuario.SueldoDolares;
            var empresa = usuario.Empresa.ToString();

            return new UsuarioADO(nombre, documento, contraseña, pesos, dolares, empresa);
        }
        

        

    }
}
