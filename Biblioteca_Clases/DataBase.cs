using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
        public static void InsertUsuarios(string nombreTabla, string documento, string nombre, string contraseña, double pesos, double dolares, string empresa)
        {
            try
            {
                OpenConnection();

                commandMySql.Parameters.Clear();

                var query = $"INSERT INTO {nombreTabla}(Documento,Nombre,Contraseña,Pesos,Dolares,Empresa) VALUES(@Documento, @Nombre, @Contraseña, @Pesos, @Dolares,@Empresa)";
               
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

        public static void DeleteUsuario(string id, string nombreTabla)
        {
            try
            {
                OpenConnection();
                var query = $"DELETE FROM {nombreTabla} where id= '"+id+"';";
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
        public static List<ActivosADO> SelectActivosUsuario(string id)
        {


            try
            {

                OpenConnection();
                var query = $"SELECT * FROM activossinvender WHERE idUsuario = '{id}'";
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



       


        







        public static void InsertActivos(string nombreTabla, string tipoActivo, string empresa, string moneda, int cantidadCompra, double precioCompra, int cantidadVenta, double precioVenta, int intereses, string distintivo, string idUsuario)
        {
            try
            {
                OpenConnection();

                commandMySql.Parameters.Clear();

                var query = $"INSERT INTO {nombreTabla}(activo, empresa, cantidadCompra, precioCompra, cantidadVenta, precioVenta, moneda, intereses, distintivo, idUsuario) " +
                       "VALUES (@activo, @empresa, @cantidadCompra, @precioCompra, @cantidadVenta, @precioVenta, @moneda, @intereses, @distintivo, @idUsuario)";

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
                commandMySql.Parameters.AddWithValue("@idUsuario", idUsuario);





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

        public  string DevolverIDUsuario(string documento)
        {

            var query = $"SELECT id FROM usuarios WHERE Documento = '{documento}';";

            try
            {

                OpenConnection();

                commandMySql.CommandText = query;

                string idUsuario;

                object result = commandMySql.ExecuteScalar();

                idUsuario = result.ToString();

                return idUsuario;
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
        public string DevolverIDUsuarioConID(string id)
        {

            var query = $"SELECT id FROM usuarios WHERE id = '{id}';";

            try
            {

                OpenConnection();

                commandMySql.CommandText = query;

                string idUsuario;

                object result = commandMySql.ExecuteScalar();

                idUsuario = result.ToString();

                return idUsuario;
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

        public string DevolverIDActivo(string distintivo, string empresa, int cantidadVenta, int cantidadCompra, string moneda)
        {

            var query = $"SELECT id FROM activossinvender WHERE distintivo = '{distintivo}' AND empresa = '{empresa}' AND cantidadVenta = '{cantidadVenta}' AND cantidadCompra = '{cantidadCompra}' AND moneda = '{moneda}';";

            try
            {

                OpenConnection();

                commandMySql.CommandText = query;

                string idActivo;

                object result = commandMySql.ExecuteScalar();

                idActivo = result.ToString();

                return idActivo;
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
        public UsuarioADO DevolverUsuario(string idUsuario)
        {

            var query = $"SELECT * FROM usuarios WHERE id = '{idUsuario}';";

            UsuarioADO usuario = null;
            try
            {

                OpenConnection();

                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = (UsuarioADO)reader;
                        
                    }
                }

                

                

                return usuario;
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

        public ActivosADO DevolverActivo(string nombreTabla,string idActivo)
        {

            var query = $"SELECT * FROM {nombreTabla} WHERE id = '{idActivo}';";

            ActivosADO activo = null;
            try
            {

                OpenConnection();

                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        activo = (ActivosADO)reader;

                    }
                }





                return activo;
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




        public static void DeleteActivo(string id)
        {
            try
            {
                OpenConnection();
                var query = $"DELETE FROM activossinvender where id= '{id}';";
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








    }
}
