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
        private string empresa;
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
        public Usuario(string nombre, string dni, string contraseña, string empresa)
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
        public string Empresa { get => empresa; set => empresa = value; }


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
            //var serializadorJson = new SerializadorJSON<Usuario>(pathMisUsuarios);
            UsuarioADO usuarioADO = new UsuarioADO();
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select();
            bool iniciarSesion = false;
            foreach (UsuarioADO userADO in listaUsuariosADO)
            {
                if (usuario.Nombre == userADO.Nombre && usuario.Contraseña == userADO.Contraseña && userADO.Documento == usuario.dni)
                {
                    iniciarSesion = true;

                    break;
                }
            }

            return iniciarSesion;
        }
        public UsuarioADO DevolverUsuarios(UsuarioADO usuarioADO)
        {
            
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select();

            

            //bool iniciarSesion = false;
            foreach (UsuarioADO userADO in listaUsuariosADO)
            {
                if (usuarioADO.Nombre == userADO.Nombre && usuarioADO.Contraseña == userADO.Contraseña && userADO.Documento == usuarioADO.Documento)
                {
                    usuarioADO = userADO;

                    break;
                }
            }

            return usuarioADO;
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
        public static bool VerificarDatosIngresados(string nombre, string clave, string dni)
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


        public ActivosADO ObtenerActivo(string nombreTabla, string idActivo)
        {




            DataBase db = new DataBase();

            ActivosADO activoADO = db.DevolverActivo(nombreTabla, idActivo);

            return activoADO;
          
        }



        public static bool VerificarActivosEnUsuario(Usuario usuario, int cantidadAVender, ActivosADO activo)
        {
            bool verificar = false;
            DataBase db = new DataBase();

           

            string id = db.DevolverIDUsuario(usuario.Dni);

            List<ActivosADO> listaActivosSinVender = DataBase.SelectActivosUsuario(id);


            foreach(ActivosADO actADO in listaActivosSinVender)
            {
                if (actADO.Distintivo == activo.Distintivo && cantidadAVender >= activo.CantidadVenta)
                {
                    verificar = true;
                    break;
                }
            }

            if (listaActivosSinVender.Count <= 0)
            {
                verificar = false;
            }

            



            return verificar;
        }


        public void ComprarActivo(string idActivo, UsuarioADO usuario, ActivosADO activo,string cantidadCompra, string precioCompra, string idUsuario)
        {
       

           
            UsuarioADO usuarioA = new UsuarioADO();
            List<UsuarioADO> listaUsuariosADO = usuarioA.Select();
            ActivosADO activoADO = new ActivosADO();
            int bandera = 0;
      
            List<ActivosADO> listaActivosADO = activoADO.Select();

            int cC = int.Parse(cantidadCompra);
            float pC = float.Parse(precioCompra);
            ActivosADO activoComprado = CrearActivoCompradoVendido(usuario, activo, cC, precioCompra, cantidadCompra, precioCompra);
            //DataBase db = new DataBase();
            foreach(UsuarioADO userADO in listaUsuariosADO)
            {

                foreach (ActivosADO act in listaActivosADO)
                {
                    if(bandera == 0)
                    {
                        if (act.IdUsuario == idUsuario && act.Moneda == activo.Moneda.ToString())
                        {
                            act.CantidadVenta -= cC;
                            //string id = db.DevolverIDUsuario(userADO.Nombre, userADO.Contraseña, userADO.Documento, userADO.Pesos.ToString(), userADO.Dolares.ToString());

                            act.Update(idActivo);
                            
                            bandera = 1;
                            if (act.Moneda == "USD")
                            {
                                userADO.Dolares += pC * cC;
                                
                                userADO.Update(idUsuario);
                            }
                            else
                            {
                                userADO.Pesos += pC * cC;
                                userADO.Update(idUsuario);
                            }

                        }

                    }

                    if (usuario.Documento == userADO.Documento)
                    {
                        DataBase db = new DataBase();
                        string id;
                        id = db.DevolverIDUsuario(usuario.Documento);
                        activoComprado.IdUsuario = id;

                        if (activo.Moneda == "USD")
                        {
                            userADO.Dolares -= pC * cC;
                            userADO.Update(id);
                        }
                        else
                        {
                            userADO.Pesos -= pC * cC;
                            userADO.Update(id);

                        }
                        break;
                    }
                    
                    
                } 
            }

            activoComprado.Add("activossinvender");
           
        }

        public UsuarioADO VenderActivoPropio(string cantidadCompra,string cantidadVenta,string idActivo, string idUsuario)
        {
            
            int cC = int.Parse(cantidadCompra);
            int cV = int.Parse(cantidadVenta);
            
            DataBase db = new DataBase();
            ActivosADO activoAVender = db.DevolverActivo("activossinvender", idActivo);
            activoAVender.CantidadCompra -= cC;
            activoAVender.CantidadVenta -= cV;
            if(activoAVender.CantidadVenta <= 0)
            {
                activoAVender.Delete(idActivo, "");
            }

            UsuarioADO userADO = db.DevolverUsuario(idUsuario);
            return userADO;
        }
        
        
        //FALTA MODIFICARLO CON USUARIOADO
        public void VenderActivoAUsuario(UsuarioADO usuario, ActivosADO activo,string cantidadVenta, string precioDeVenta, string idUsuario, string idActivo)
        {
            List<UsuarioADO> listaUsuarios = usuario.Select();
            DataBase db = new DataBase();
            string id = db.DevolverIDUsuario(usuario.Documento);
            List<ActivosADO> listaActivosVenta = DataBase.SelectActivosUsuario(id);

            string idUsuarioAVender = db.DevolverIDUsuario(activo.Distintivo);
            UsuarioADO usuarioAVender = new UsuarioADO();

            int bandera = 0;
            int bandera2 = 0;

            int cV = int.Parse(cantidadVenta);
            ActivosADO activoAVender = CrearActivoCompradoVendido(usuario, activo, cV, precioDeVenta, cantidadVenta, precioDeVenta);

            string idUsuario2 = db.DevolverIDUsuario(usuario.Documento);

            foreach(UsuarioADO userADO in listaUsuarios)
            {
                //MODIFICAMOS EL SUELDO DE CARLOS Y MODIFICAR EL ACTIVO EN LA TABLA DE ACTIVOS EN VENTA
                if(bandera == 0)
                {
                    if(usuario.Documento == userADO.Documento)
                    {
                        activo.CantidadCompra -= cV;
                            
                        if (activo.CantidadCompra <= 0 && activo.CantidadVenta <= 0)
                        {
                            activo.Delete(idActivo, "");
                        }
                        if(activo.Moneda == "USD")
                        {
                            userADO.Dolares += float.Parse(precioDeVenta);
                                
                            userADO.Update(idUsuario2);
                        }
                        else
                        {
                            userADO.Pesos += float.Parse(precioDeVenta);
                            userADO.Update(idUsuario2);

                        }

                        activo.Update(idActivo);
                        bandera = 1;


                    }

                }
                //MODIFICAMOS EL SUELDO A PABLITO
                if(bandera2 == 0)
                {
                    if(activo.Distintivo == userADO.Documento)
                    {
                        usuarioAVender = userADO;

                        if (activo.Moneda == "USD")
                        {

                            

                            userADO.Dolares -= float.Parse(precioDeVenta);
                            userADO.Update(idUsuario);

                        }
                        else
                        {
                            userADO.Pesos -= float.Parse(precioDeVenta);
                            userADO.Update(idUsuario);

                        }
                        bandera2 = 1;
                    }

                }
                   
            }

            foreach(ActivosADO actADO in listaActivosVenta)
            {
                if (actADO.Distintivo == usuario.Documento)
                {
                    string idActivoUsuario = db.DevolverIDActivo(actADO.Distintivo,actADO.Empresa,actADO.CantidadVenta,actADO.CantidadCompra, actADO.Moneda);
                    actADO.CantidadVenta -= cV;
                    if(actADO.CantidadVenta <= 0)
                    {
                        actADO.Delete(idActivoUsuario, "");
                    }
                    break;
                }
                
            }


            activoAVender.Distintivo = activo.Distintivo;
            activoAVender.IdUsuario = idUsuarioAVender;
            activoAVender.Add("activossinvender");
                
            
          
        }
       
        public ActivosADO CrearActivoCompradoVendido(UsuarioADO usuario, ActivosADO activo, int cantidadCompra, string precioCompra,string cantidadVenta, string precioVenta) 
        {

            ETipoMoneda tipoMoneda = ETipoMoneda.ARG;
            if(activo.Moneda == "USD")
            {
                tipoMoneda = ETipoMoneda.USD;
            }
            
            int cV = int.Parse(cantidadVenta);
            int cC = cantidadCompra;
            float pC = float.Parse(precioCompra);
            float pV = float.Parse(precioVenta);
            Activos activoAVender = null;
           // ActivosADO actADO = null; 
            switch (activo.Activo)
            {
                case "Cedear":
                    activoAVender = new Cedear(activo.Empresa, cC, pC, cV, pV, ETipoActivo.Cedear, tipoMoneda, activo.Intereses, usuario.Documento);
                    break;
                case "Accion":
                    activoAVender = new Acciones(activo.Empresa, cC, pC, cV, pV, ETipoActivo.Accion, tipoMoneda, activo.Intereses, usuario.Documento);
                    break;
                case "Bono":
                    activoAVender = new Bonos(activo.Empresa, cC, pC, cV, pV, ETipoActivo.Bono, tipoMoneda, activo.Intereses, usuario.Documento);
                    break;
                case "MEP":
                    activoAVender = new dolarMep(activo.Empresa, cC, pC, cV, pV, ETipoActivo.MEP, tipoMoneda, activo.Intereses, usuario.Documento);
                    break;
            }

            return (ActivosADO)activoAVender;

        }


        public static explicit operator Usuario(UsuarioADO usuario)
        {
            var documento = usuario.Documento;
            var nombre = usuario.Nombre;
            var contraseña = usuario.Contraseña;
            var empresa = usuario.Empresa.ToString();

            return new Usuario(nombre, documento, contraseña, empresa);
        }




    }
}
