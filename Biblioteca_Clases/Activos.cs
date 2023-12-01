using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{

    public delegate void delegadoActivo(object sender, ActivoEvent actEvent);
    public class Activos
    {
        private ETipoMoneda moneda;
        protected int cc;
        protected float pc;
        protected int cv;
        protected float pv;
        protected string empresa;
        protected ETipoActivo activo;
        protected float intereses;
        protected string distintivo;
        bool validar;

        public event delegadoActivo CantidadActivos;
        public event delegadoActivo PrecioActivo;
        public event delegadoActivo MonedaActivo;
        public Activos()
        {
                
        }

        public Activos(string nombreActivo, int cc, float pc, int cv, float pv, ETipoActivo activo, ETipoMoneda moneda, float intereses, string distintivo)
        {

            this.Activo = activo;
            this.Cc = cc;
            this.Pc = pc;
            this.Cv = cv;
            this.Pv = pv;
            this.Empresa = nombreActivo;
            this.Moneda = moneda;
            this.Intereses = intereses;
            this.distintivo = distintivo;
        }






        public ETipoActivo Activo { get => activo; set => activo = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public ETipoMoneda Moneda { get => moneda; set => moneda = value; }
        public int Cc { get => cc; set => cc = value; }
        public float Pc { get => pc; set => pc = value; }
        public int Cv { get => cv; set => cv = value; }
        public float Pv { get => pv; set => pv = value; }
        public float Intereses { get => intereses; set => intereses = value; }
        public string Distintivo { get => distintivo; set => distintivo = value; }
        public bool Validar { get => validar; set => validar = value; }

        public bool VerificarActivoRepetido(Activos activo, string pathActivos)
        {
            var serializadorJson = new SerializadorJSON<Activos>(pathActivos);
            bool verificar = true;
            List<Activos> listaActivos = new List<Activos>();
            listaActivos = serializadorJson.Deserializar();
            foreach (Activos act in listaActivos)
            {
                if (act.Empresa == act.Empresa)
                {
                    verificar = false;
                    break;
                }
            }
            return verificar;
        }

        public void ValidarCantidadCompraActivo(int cantidadVenta, int cantidadCompra)
        {
           
            if(cantidadCompra > cantidadVenta || cantidadCompra <= 0)
            {
                ActivoEvent evento = new ActivoEvent();
                evento.CantidadActivos = cantidadCompra;
                Validar = false;
                CantidadActivos(this, evento);
            }
       
        }
        public void ValidarPrecioCompraActivo(Activos act, float precio)
        {
   

            if (precio < act.Pv || precio == 0)
            {
                ActivoEvent evento = new ActivoEvent();
                evento.ValorActivo = precio;
                Validar = false;

                PrecioActivo(this, evento);
            }

        }

        public void VerificarMoneda(float precioActivo, Usuario usuario, ETipoMoneda tipoMoneda)
        {
            if(tipoMoneda == ETipoMoneda.USD)
            {
                if (precioActivo > usuario.SueldoDolares || precioActivo < usuario.SueldoDolares)
                {
                    ActivoEvent evento = new ActivoEvent();
                    evento.SueldoInsuficiente = precioActivo;
                    Validar = false;
                    MonedaActivo(this, evento);
                }
            }
            else
            {
                if(precioActivo > usuario.Sueldo)
                {
                    ActivoEvent evento = new ActivoEvent();
                    evento.SueldoInsuficiente = precioActivo;
                    Validar = false;

                    MonedaActivo(this, evento);
                }
            }

        }


        public virtual float CalcularValorCompra(int cantidad)
        {
            return pv*cantidad;
        }

       
        
    }
}
