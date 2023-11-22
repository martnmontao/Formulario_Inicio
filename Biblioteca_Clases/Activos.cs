using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
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

        public virtual float CalcularValorCompra(int cantidad)
        {
            return pv*cantidad;
        }

       
        
    }
}
