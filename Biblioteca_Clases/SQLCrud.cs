using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class SQLCrud<T> where T : UsuarioADO
    {
        private string _tableName;
        private string[] _columnas;
        public SQLCrud(string tablaName, string[] columnas)
        {
            _columnas = columnas;
            _tableName = tablaName;
        }

        public List<T> GetAll()
        {
            return DataBase.Select<T>(PrepareSelectQuery());
        }
        private string PrepareSelectQuery()
        {
            var cols = string.Join("'", _columnas);
            var query = $"SELECT {cols} FROM {_tableName}";

            return query;
        }


    }
}
