using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class ActivosADO : IOperationsDB<ActivosADO>
    {



        public delegate void delegadoActivo(object sender, ActivoEvent actEvent);


        public event delegadoActivo CantidadActivos;
        public event delegadoActivo PrecioActivo;
        public event delegadoActivo MonedaActivo;

        public bool Validar { get; set; }
        public string Activo { get; set; }
        public string Empresa { get; set; }
        public string Moneda { get; set; }
        public int CantidadCompra { get; set; }
        public double PrecioCompra { get; set; }
        public int CantidadVenta { get; set; }
        public double PrecioVenta { get; set; }
        public int Intereses { get; set; }
        public string Distintivo { get; set; }

        public string IdUsuario { get; set; }

        public ActivosADO()
        {

        }
        public ActivosADO(string tipoActivo, string empresa, string moneda, int cantidadCompra, double precioCompra, int cantidadVenta, double precioVenta, int intereses, string distintivo, string idUsuario):this(tipoActivo,empresa,moneda,cantidadCompra,precioCompra,cantidadVenta,precioVenta,intereses,distintivo)
        {
            IdUsuario = idUsuario;
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





        

        public void ValidarCantidadCompraActivo(int cantidadVenta, int cantidadCompra)
        {

            if (cantidadCompra > cantidadVenta || cantidadCompra <= 0)
            {
                ActivoEvent evento = new ActivoEvent();
                evento.CantidadActivos = cantidadCompra;
                Validar = false;
                CantidadActivos(this, evento);
            }

        }
        public void ValidarPrecioCompraActivo(ActivosADO act, float precio)
        {


            if (precio < act.PrecioVenta || precio == 0)
            {
                ActivoEvent evento = new ActivoEvent();
                evento.ValorActivo = precio;
                Validar = false;

                PrecioActivo(this, evento);
            }

        }
        public void VerificarMoneda(float precioActivo, UsuarioADO usuario, string tipoMoneda)
        {
            if (tipoMoneda == "USD")
            {
                if (precioActivo > usuario.Dolares || precioActivo < usuario.Dolares)
                {
                    ActivoEvent evento = new ActivoEvent();
                    evento.SueldoInsuficiente = precioActivo;
                    Validar = false;
                    MonedaActivo(this, evento);
                }
            }
            else
            {
                if (precioActivo > usuario.Pesos)
                {
                    ActivoEvent evento = new ActivoEvent();
                    evento.SueldoInsuficiente = precioActivo;
                    Validar = false;

                    MonedaActivo(this, evento);
                }
            }

        }
        public bool Add(string nombreTabla)
        {
            DataBase.InsertActivos(nombreTabla,Activo, Empresa, Moneda, CantidadCompra, PrecioCompra, CantidadVenta, PrecioVenta, Intereses, Distintivo, IdUsuario);
            return true;
        }

        //Va a actualizar mi elemento de mySql
        public bool Update(string id)
        {
            DataBase.UpdateActivos(id, Activo, Empresa, Moneda, CantidadCompra, PrecioCompra, CantidadVenta, PrecioVenta);
            return true;
        }

        //Va a eliminar mi elemento de mySql
        public bool Delete(string id, string nombreTabla)
        {
            DataBase.DeleteActivo(id);
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
            var precioCompra = float.Parse(reader["precioCompra"].ToString());
            var cantidadVenta = Convert.ToInt32(reader["cantidadVenta"]);
            var precioVenta = float.Parse(reader["precioVenta"].ToString());
            var moneda = reader["moneda"].ToString();
            var intereses = int.Parse(reader["intereses"].ToString());
            var distintivo = reader["distintivo"].ToString();
            var idUsuario = reader["idUsuario"].ToString();



            return new ActivosADO(tipoActivo, nombreEmpresa, moneda, cantidadCompra, precioCompra, cantidadVenta,precioVenta,intereses,distintivo,idUsuario);
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
