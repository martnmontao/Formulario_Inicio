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

        #region UsuariosMySql
       /* public static List<T> Select<T>(string query, Func<MySqlDataReader, T> mapObject) where T : UsuarioADO
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


        }*/
        public static void InsertUsuarios(string documento, string nombre, string contraseña, double pesos, double dolares, string empresa)
        {
            try
            {
                OpenConnection();

                commandMySql.Parameters.Clear();

                var query = $"INSERT INTO usuarios(Documento,Nombre,Contraseña,Pesos,Dolares,Empresa) VALUES(@Documento, @Nombre, @Contraseña, @Pesos, @Dolares,@Empresa)";
               
                commandMySql.CommandText = query;
                commandMySql.Parameters.AddWithValue("@Documento", documento);
                commandMySql.Parameters.AddWithValue("@Nombre", nombre);
                commandMySql.Parameters.AddWithValue("@Contraseña", contraseña);
                commandMySql.Parameters.AddWithValue("@Pesos", pesos);
                commandMySql.Parameters.AddWithValue("@Dolares", dolares);
                commandMySql.Parameters.AddWithValue("@Empresa", empresa);


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
        public static List<T> Select<T>(string query) where T : UsuarioADO
        {


            try
            {

                OpenConnection();
                List<T> listaUsuario = new List<T>();
                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T dato = (T)reader;
                        listaUsuario.Add(dato);
                    }
                }
                return listaUsuario;
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


        public static void UpdateUsuario(string id, string documento, string nombre, string contraseña, double pesos, double dolares, string empresa)
        {
            try
            {
                OpenConnection();
                var query = $"UPDATE usuarios set Documento='" + documento + "', Nombre='"+nombre+"', Contraseña='"+contraseña+"', Pesos='"+pesos+"', Dolares='"+dolares+"', Empresa='" + empresa+"' WHERE id ='"+id+"';";
                commandMySql.ExecuteNonQuery();
                commandMySql = new MySqlCommand(query, OpenConnectionUpdate());
                MySqlDataReader reader = commandMySql.ExecuteReader();
                Console.WriteLine("Se modifico el usuario");
                while(reader.Read()) 
                {
                
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connectionMySql.Close();
            }
        }

        public static void DeleteUsuario(string id)
        {
            try
            {
                OpenConnection();
                var query = $"DELETE FROM usuarios where id= '"+id+"';";
                commandMySql.ExecuteNonQuery();
                commandMySql = new MySqlCommand(query, OpenConnectionUpdate());
                MySqlDataReader reader = commandMySql.ExecuteReader();
                Console.WriteLine("Se modifico el usuario");
                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connectionMySql.Close();
            }
        }
        #endregion 

        public static List<ActivosADO> SelectActivos()
        {


            try
            {

                OpenConnection();
                var query = "SELECT * FROM activos";
                List<ActivosADO> listaActivos = new List<ActivosADO>();
                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ActivosADO dato = (ActivosADO)reader;
                        listaActivos.Add(dato);
                    }
                }
                return listaActivos;
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







        public static void InsertActivos(string tipoActivo, string empresa, string moneda, int cantidadCompra, double precioCompra, int cantidadVenta, double precioVenta, int intereses, string distintivo)
        {
            try
            {
                OpenConnection();

                commandMySql.Parameters.Clear();

                var query = "INSERT INTO activos(activo, empresa, cantidadCompra, precioCompra, cantidadVenta, precioVenta, moneda, intereses, distintivo) " +
                       "VALUES (@activo, @empresa, @cantidadCompra, @precioCompra, @cantidadVenta, @precioVenta, @moneda, @intereses, @distintivo)";

                commandMySql.CommandText = query;
                commandMySql.Parameters.AddWithValue("@activo", tipoActivo);
                commandMySql.Parameters.AddWithValue("@empresa", empresa);
                commandMySql.Parameters.AddWithValue("@moneda", moneda);
                commandMySql.Parameters.AddWithValue("@cantidadCompra", cantidadCompra);
                commandMySql.Parameters.AddWithValue("@precioCompra", precioCompra);
                commandMySql.Parameters.AddWithValue("@cantidadVenta", cantidadVenta);
                commandMySql.Parameters.AddWithValue("@precioVenta", precioVenta);
                commandMySql.Parameters.AddWithValue("@intereses", intereses);
                commandMySql.Parameters.AddWithValue("@distintivo", distintivo);
     



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

        public static void UpdateActivos(string id, string tipoActivo, string empresa, string moneda, int cantidadCompra, double precioCompra, int cantidadVenta, double precioVenta)
        {
        
            try
            {
                OpenConnection();
           
                var query = $"UPDATE activos set activo='" + tipoActivo + "', empresa='" + empresa + "', cantidadCompra='" + cantidadCompra + "', precioCompra='" + precioCompra + "', cantidadVenta='" + cantidadVenta + "', precioVenta='" + precioVenta + "', moneda='" +moneda+ "' WHERE id ='" + id + "';";
                commandMySql.ExecuteNonQuery();
                commandMySql = new MySqlCommand(query, OpenConnectionUpdate());
                MySqlDataReader reader = commandMySql.ExecuteReader();
                Console.WriteLine("Se modifico el activo");
                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        public MySqlConnection OpenDataGridView() 
        {
            return connectionMySql;
        }
        public static MySqlConnection OpenConnectionUpdate()
        {
            return connectionMySql;
        }
        public void CloseDataGridView()
        {
            connectionMySql.Close();
        }

    }
}
