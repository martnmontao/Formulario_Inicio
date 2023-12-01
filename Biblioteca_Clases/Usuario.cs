using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Formulario_Inicio;
//using System.Windows.Forms;


namespace Biblioteca_Clases
{
    [Serializable]

    public class Usuario : Persona
    {
        private string pathMisUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        private string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        private string pathUsuarioARegistrar = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";
        private string rutaActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        private bool empresa;
        private double sueldo;
        private double sueldoDolares;
        private List<Usuario> listaUsuarios;
        private List<Activos> listaActivos;
        private List<Activos> listaActivosVentas;


        public Usuario()
        {

        }

        public Usuario(string nombre, string dni, string contraseña) : base(nombre, dni, contraseña)
        {

        }
        public Usuario(string nombre, string dni, string contraseña, bool empresa)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.contraseña = contraseña;
            this.empresa = empresa;
            this.sueldo = 0;
            this.sueldoDolares = 0;
            this.listaActivos = new List<Activos>();
            this.listaUsuarios = new List<Usuario>();
            this.listaActivosVentas = new List<Activos>();
 
        }

        public double SueldoDolares { get => sueldoDolares; set => sueldoDolares = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public List<Activos> ListaActivos { get => listaActivos; set => listaActivos = value; }
        public List<Activos> ListaActivosVentas { get => listaActivosVentas; set => listaActivosVentas = value; }
        public bool Empresa { get => empresa; set => empresa = value; }


        public void AgregarActivo(Usuario usuario, Activos activo)
        {

            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuarios);



            List<Usuario> listaUsuarios = serializadorJson.Deserializar();
            List<Usuario> nuevaLista = new List<Usuario>();
            foreach (Usuario user in listaUsuarios)
            {

                if (usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña)
                {
                    user.ListaActivos.Add(activo);
                }
                nuevaLista.Add(user);
            }
            serializadorJson2.Serializar(nuevaLista);
        }
        public bool IniciarSesion(Usuario usuario)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);

            listaUsuarios = serializadorJson.Deserializar();
            bool iniciarSesion = false;
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña && user.dni == usuario.dni)
                {
                    iniciarSesion = true;

                    break;
                }
            }

            return iniciarSesion;
        }
        public Usuario DevolverUsuarios(Usuario usuario)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);

            listaUsuarios = serializadorJson.Deserializar();

            //bool iniciarSesion = false;
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Nombre == user.Nombre && usuario.Contraseña == user.Contraseña && user.dni == usuario.dni)
                {
                    usuario = user;

                    break;
                }
            }

            return usuario;
        }
        public Administrador DevolverAdminitrador(Administrador admin)
        {
            var serializadorJson = new SerializadorJSON<Administrador>(pathAdministrador);

            List<Administrador> listaAdministradores = serializadorJson.Deserializar();

            foreach (Administrador adm in listaAdministradores)
            {
                if (adm.Nombre == admin.Nombre && adm.Contraseña == admin.Contraseña)
                {
                    admin = adm;

                    break;
                }
            }

            return admin;
        }
        public bool VerificarDatosIngresados(string nombre, string clave, string dni)
        {
            bool verificacion = true;
            int documento;

            if (nombre.Trim().Length < 5 || clave.Trim().Length < 5 || dni.Trim().Length < 7)
            {
                verificacion = false;
            }

            try
            {
                documento = int.Parse(dni);
                if (documento < 30000000 || documento > 50000000)
                {
                    verificacion = false;
                }
            }
            catch
            {
                verificacion = false;
            }


            return verificacion;

        }
        public bool VerificarUsuarioRegistradoRepetido(Usuario usuario)
        {
            bool verificar = true;
            var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarioARegistrar);



            listaUsuarios = serializadorJson.Deserializar();
            foreach (Usuario user in listaUsuarios)
            {
                if (usuario.Dni == user.Dni)
                {
                    verificar = false;
                    break;
                }
            }
            return verificar;

        }


        public Activos ObtenerActivo(string distintivo, ETipoMoneda tipoMoneda)
        {
            //EN EL CASO DE COMPRARLE A UN USUARIO, DEBERA TAMBIEN RECORRER LA LISTA DE LOS ACTIVOS EN VENTAS DE CADA USUARIO, ACORDATE
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            listaUsuarios = serializadorJson.Deserializar();
            Activos activo = null;

            foreach (Usuario user in listaUsuarios)
            {
                foreach (Activos act in user.ListaActivosVentas)
                {
                    if (distintivo == act.Distintivo && act.Moneda == tipoMoneda)
                    {
                        activo = act;
                        break;
                    }
                }

                foreach (Activos act in user.listaActivos)
                {
                    if (distintivo == act.Distintivo && act.Moneda == tipoMoneda)
                    {
                        activo = act;
                        break;
                    }
                }
            }




            return activo;
        }



        public bool verificarActivosEnUsuario(Usuario usuario, int cantidadAVender, Activos activo)
        {
            bool verificar = true;
            foreach(Activos act in usuario.ListaActivos)
            {
                if(act.Distintivo == activo.Distintivo && cantidadAVender > activo.Cv)
                {
                    verificar = false;
                    break;
                }
            }
            
            
            if (usuario.ListaActivos.Count <= 0)
            {
                verificar = false;
            }



            return verificar;
        }


        public void ComprarActivo(string idActivo, Usuario usuario, Activos activo,string cantidadCompra, string precioCompra)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuarios);
            
            listaUsuarios = serializadorJson.Deserializar();




            int cC = int.Parse(cantidadCompra);
            float pC = float.Parse(precioCompra);
            Activos activoComprado = CrearActivoCompradoVendido(usuario, activo, cC, precioCompra, cantidadCompra, precioCompra);
          
            foreach(Usuario user in listaUsuarios)
            {
                    
                foreach (Activos act in user.ListaActivosVentas)
                {
                    if(activo.Distintivo == act.Distintivo && act.Moneda == activo.Moneda)
                    {
                        act.Cv -= cC;
                        ActivosADO actADO = (ActivosADO)act;
                        actADO.Update(idActivo);
                        if(act.Moneda == ETipoMoneda.USD)
                        {
                            user.sueldoDolares += pC*cC;
                        }
                        else
                        {
                            user.Sueldo += pC * cC;
                            //actADO.Update(idActivo);
                        }

                    }
                }
                    
                if(usuario.dni == user.dni)
                {
                    user.listaActivos.Add(activoComprado);
                    if(activo.Moneda == ETipoMoneda.USD)
                    {
                        user.sueldoDolares -= pC*cC;
                    }
                    else
                    {
                        user.sueldo -= pC*cC;
                    }
                }
                
                  
            }

            serializadorJson2.Serializar(listaUsuarios);
        }

        







        public Usuario VenderActivoPropio(Usuario usuario, Activos activo, string cantidadCompra, string precioCompra,string cantidadVenta, string precioDeVenta)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuarios);
            


            listaUsuarios = serializadorJson.Deserializar();
            int cC = int.Parse(cantidadCompra);
            int cV = int.Parse(cantidadVenta);
            Activos activoAVender = CrearActivoCompradoVendido(usuario, activo, cC, precioCompra,cantidadVenta, precioDeVenta);
            
            foreach(Usuario user in listaUsuarios)
            {
                if(user.dni == usuario.dni)
                {
                    user.ListaActivosVentas.Add(activoAVender);
                }
                foreach(Activos act in user.listaActivos)
                {
                    if(act.Distintivo == user.dni && act.Moneda == activo.Moneda)
                    {
                        act.Cc -= cC;
                        act.Cv -= cV;
                        if(act.Cv <= 0)
                        {
                            user.listaActivos.Remove(act);
                            break;
                        }
                        usuario = user;
                    }
                }
            }
            serializadorJson2.Serializar(listaUsuarios);
            return usuario;
        }
        public void VenderActivoAUsuario(Usuario usuario, Activos activo,string cantidadVenta, string precioDeVenta)
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            var serializadorJson2 = new SerializadorJSON<List<Usuario>>(pathMisUsuarios);

            listaUsuarios = serializadorJson.Deserializar();
            int cV = int.Parse(cantidadVenta);
            Activos activoAVender = CrearActivoCompradoVendido(usuario, activo, cV, precioDeVenta, cantidadVenta, precioDeVenta);
            foreach(Usuario user in listaUsuarios)
            {
                foreach(Activos act in user.ListaActivosVentas) 
                {
                    if (activo.Distintivo == user.dni && act.Moneda == activo.Moneda && activo.Empresa == act.Empresa)
                    {
                        act.Cc -= cV;
                        user.ListaActivos.Add(activoAVender);
                        if(act.Cc <= 0 && act.Cv <= 0)
                        {
                            user.ListaActivosVentas.Remove(act);
                        }
                        if(act.Moneda == ETipoMoneda.USD)
                        {
                            user.SueldoDolares -= float.Parse(precioDeVenta);
                        }
                        else
                        {
                            user.Sueldo -= float.Parse(precioDeVenta);
                        }
                        break;
                    }
                    
                }

                if(user.Dni == usuario.Dni)
                {
                    foreach(Activos act in user.ListaActivos)
                    {
                        if(act.Moneda == activo.Moneda && activo.Empresa == act.Empresa)
                        {
                            act.Cv -= cV;
                            if(act.Cv <= 0)
                            {
                                act.Cv = 0;
                            }
                        }
                    }
                    if (activo.Moneda == ETipoMoneda.USD)
                    {
                        user.SueldoDolares += float.Parse(precioDeVenta);
                    }
                    else
                    {
                        user.Sueldo += float.Parse(precioDeVenta);
                    }
                }

            }
            

            serializadorJson2.Serializar(listaUsuarios);
        }
        public bool VerificarActivoEnUsuario(Usuario usuario, string distintivo,Activos activo)
        {
            bool verificar = false;
            var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);

            listaUsuarios = serializadorJson.Deserializar();
            
            foreach(Usuario user in listaUsuarios)
            {
                if(user.dni == distintivo)
                {
                    foreach(Activos act in usuario.listaActivos)
                    {
                        if(activo.Empresa == act.Empresa)
                        {
                            verificar = true;
                            break;
                        }
                    }
                }
            }
            return verificar;
        }
        private Activos CrearActivoCompradoVendido(Usuario usuario, Activos activo, int cantidadCompra, string precioCompra,string cantidadVenta, string precioVenta) 
        {
            int cV = int.Parse(cantidadVenta);
            int cC = cantidadCompra;
            float pC = float.Parse(precioCompra);
            float pV = float.Parse(precioVenta);
            Activos activoAVender = null;
            switch (activo.Activo)
            {
                case ETipoActivo.Cedear:
                    activoAVender = new Cedear(activo.Empresa, cC, pC, cV, pV, activo.Activo, activo.Moneda, activo.Intereses, usuario.dni);
                    break;
                case ETipoActivo.Accion:
                    activoAVender = new Acciones(activo.Empresa, cC, pC, cV, pV, activo.Activo, activo.Moneda, activo.Intereses, usuario.dni);
                    break;
                case ETipoActivo.Bono:
                    activoAVender = new Bonos(activo.Empresa, cC, pC, cV, pV, activo.Activo, activo.Moneda, activo.Intereses, usuario.dni);
                    break;
                case ETipoActivo.MEP:
                    activoAVender = new dolarMep(activo.Empresa, cC, pC, cV, pV, activo.Activo, activo.Moneda, activo.Intereses, usuario.dni);
                    break;
            }

            return activoAVender;

        }







    }
}
