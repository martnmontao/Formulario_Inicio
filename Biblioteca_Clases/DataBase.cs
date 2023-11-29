using System;
using System.Collections.Generic;
using System.Data;
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

        
        public static void InsertUsuarios(string documento, string nombre, string contraseña, double pesos, double dolares)
        {
            try
            {
                OpenConnection();

                commandMySql.Parameters.Clear();

                var query = $"INSERT INTO usuarios(Documento,Nombre,Contraseña,Pesos,Dolares) VALUES(@Documento, @Nombre, @Contraseña, @Pesos, @Dolares)";
               
                commandMySql.CommandText = query;
                commandMySql.Parameters.AddWithValue("@Documento", documento);
                commandMySql.Parameters.AddWithValue("@Nombre", nombre);
                commandMySql.Parameters.AddWithValue("@Contraseña", contraseña);
                commandMySql.Parameters.AddWithValue("@Pesos", pesos);
                commandMySql.Parameters.AddWithValue("@Dolares", dolares);

                commandMySql.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("No se pudo ingresar los datos");
            }
            finally
            {
                connectionMySql.Close();
            }
        }
        public static List<T> Select<T>(string query, Func<MySqlDataReader, T> mapObject) where T : UsuarioADO
        {

            var lista = new List<T>();
            
            try
            {
                OpenConnection();

                commandMySql.CommandText = query;

                using( var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = mapObject(reader);
                        lista.Add(objeto);
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
        public static List<T> Select<T>(string query) where T : UsuarioADO
        {


            try
            {

                OpenConnection();
                List<T> listaUsuarioADO = new List<T>();
                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T usuario = (T)reader;
                        listaUsuarioADO.Add(usuario);
                    }
                }
                return listaUsuarioADO;
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
