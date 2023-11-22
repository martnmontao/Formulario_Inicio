using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca_Clases
{
    public class DataBase
    {

        public static MySqlConnection connectionMySql;
        public static MySqlCommand commandMySql;
        static DataBase()
        {

            var mySqlStringConnection = @"Server=localhost;Database=inversiones;Uid=root;Pwd=;";
            
            
            connectionMySql = new MySqlConnection(mySqlStringConnection);
            
            //Comandos para hacer las consultas
            commandMySql = new MySqlCommand();
            commandMySql.CommandType = System.Data.CommandType.Text;
            commandMySql.Connection = connectionMySql;



        }


        public static void Insert(Usuario usuario)
        {
            try
            {
                connectionMySql.Open();
                commandMySql.Parameters.Clear();

                var query = $"INSERT INTO usuarios(Documento,Nombre,Contraseña,Pesos,Dolares) VALUES(@Documento, @Nombre, @Contraseña, @Pesos, @Dolares)";

                commandMySql.CommandText = query;
                commandMySql.Parameters.AddWithValue("@Documento", usuario.Dni);
                commandMySql.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                commandMySql.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                commandMySql.Parameters.AddWithValue("@Pesos", usuario.Sueldo);
                commandMySql.Parameters.AddWithValue("@Dolares", usuario.SueldoDolares);

                commandMySql.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connectionMySql.Close();
            }
        }
        public static List<T> Select<T>(string query) where T : UsuarioADO
        {
            var lista = new List<T>();
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                using( var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = (T)reader;
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connectionMySql.Close();
            }


        }
        
        public static void OpenConnection()
        {
            connectionMySql.Open();

        }

    }
}
