using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class ActivosADO : IOperationsDB<ActivosADO>
    {


       




        public string Activo { get; set; }
        public string Empresa { get; set; }
        public string Moneda { get; set; }
        public int CantidadCompra { get; set; }
        public double PrecioCompra { get; set; }
        public int CantidadVenta { get; set; }
        public double PrecioVenta { get; set; }
        public int Intereses { get; set; }
        public string Distintivo { get; set; }
  

        public ActivosADO()
        {

        }

        public ActivosADO(string tipoActivo, string empresa, string moneda, int cantidadCompra, double precioCompra, int cantidadVenta, double precioVenta, int intereses, string distintivo)
        {

            Activo = tipoActivo;
            Empresa = empresa;
            Moneda = moneda;
            CantidadCompra = cantidadCompra;
            PrecioCompra = precioCompra;
            CantidadVenta = cantidadVenta;
            PrecioVenta = precioVenta;
            Intereses = intereses;
            Distintivo = distintivo;
        }






        public bool Add()
        {
            DataBase.InsertActivos(Activo, Empresa, Moneda, CantidadCompra, PrecioCompra, CantidadVenta, PrecioVenta, Intereses, Distintivo);
            return true;
        }

        //Va a actualizar mi elemento de mySql
        public bool Update(string id)
        {
            DataBase.UpdateActivos(id, Activo, Empresa, Moneda, CantidadCompra, PrecioCompra, CantidadVenta, PrecioVenta);
            return true;
        }

        //Va a eliminar mi elemento de mySql
        public bool Delete(string id)
        {
           // DataBase.DeleteUsuario(id);
            return true;
        }

        //Va a obtener todos los elementos de mySql
        public List<ActivosADO> Select()
        {
            var activos = DataBase.SelectActivos();
            return activos;
        }


        public static explicit operator ActivosADO(MySqlDataReader reader)
        {
            var tipoActivo = reader["activo"].ToString();
            var nombreEmpresa = reader["empresa"].ToString();
            var cantidadCompra = Convert.ToInt32(reader["cantidadCompra"].ToString());
            var precioCompra = Convert.ToInt32(reader["precioCompra"].ToString());
            var cantidadVenta = Convert.ToInt32(reader["cantidadVenta"]);
            var precioVenta = Convert.ToInt32(reader["precioVenta"]);
            var moneda = reader["moneda"].ToString();
            var intereses = int.Parse(reader["intereses"].ToString());
            var distintivo = reader["distintivo"].ToString();


            return new ActivosADO(tipoActivo, nombreEmpresa, moneda, cantidadCompra, precioCompra, cantidadVenta,precioVenta,intereses,distintivo);
        }
        public static explicit operator ActivosADO(Activos activo)
        {
            var tipoActivo = activo.Activo;
            var nombreEmpresa = activo.Empresa;
            var cantidadCompra = Convert.ToInt32(activo.Cc);
            var precioCompra = activo.Pc;
            var cantidadVenta = Convert.ToInt32(activo.Cv);
            var precioVenta = activo.Pv;
            var moneda = activo.Moneda;
            var intereses = activo.Intereses;
            var distintivo = activo.Distintivo;


            return new ActivosADO(tipoActivo.ToString(), nombreEmpresa, moneda.ToString(), cantidadCompra, precioCompra, cantidadVenta, precioVenta, Convert.ToInt32(intereses), distintivo);
        }
    }
}
