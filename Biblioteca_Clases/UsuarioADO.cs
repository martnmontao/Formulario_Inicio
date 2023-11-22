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
        public float Pesos { get; set; }
        public float Dolares {  get; set; }

        public UsuarioADO(string nombre, string documento, string contraseña, float pesos, float dolares):base("usuarios", ["Documento", "Nombre", "Contraseña", "Pesos", "Dolares"])
        {
            Nombre = nombre;
            Documento = documento;
            Contraseña = contraseña;
            Pesos = pesos;
            Dolares = dolares;
        }

        //Va a agregar un elemento a mySql
        public bool Add()
        {
            return true;
        }

        //Va a actualizar mi elemento de mySql
        public bool Update() 
        { 
            return true; 
        }

        //Va a eliminar mi elemento de mySql
        public bool Delete() 
        {
            return true;
        }

        //Va a obtener todos los elementos de mySql
        public List<UsuarioADO> Select()
        {
            var usuarios = GetAll();
            return usuarios;
        }

        public static explicit operator UsuarioADO(MySqlDataReader reader)
        {
            var documento = reader["Documento"].ToString();
            var nombre = reader["Nombre"].ToString();
            var contraseña = reader["Contraseña"].ToString();
            var pesos = Convert.ToInt32(reader["Pesos"]);
            var dolares = Convert.ToInt32(reader["Dolares"]);
            return new UsuarioADO(nombre, documento, contraseña, pesos, dolares);
        }

    }
}
