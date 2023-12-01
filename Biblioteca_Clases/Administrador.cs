using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{

    public class Administrador : Persona
    {
        string pathUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";
        string pathUsuariosARegistrar = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuariosARegistrar.json";
        string pathAdministrador = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Administrador.json";

        private double valorDolarCompra;
        private double valorDolarVenta;

        public double ValorDolarCompra { get => valorDolarCompra; set => valorDolarCompra = value; }
        public double ValorDolarVenta { get => valorDolarVenta; set => valorDolarVenta = value; }

        public Administrador()
        {

        }
        public Administrador(string nombre, string dni, string contraseña) : base(nombre, dni, contraseña)
        {


        }
        public List<Usuario> ValidarUsuario(List<Usuario> listaUsuarios, string nombre)
        {
            var serializadorJSON = new SerializadorJSON<Usuario>(pathUsuarios);
            List<Usuario> listaUsuariosRegistrados = serializadorJSON.Deserializar();
            try
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (nombre == usuario.Nombre)
                    {
                        listaUsuariosRegistrados.Add(usuario);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listaUsuariosRegistrados;
        }

        public void EliminarUsuario(List<Usuario> listaUsuarios, string nombre, string path, bool xmlOJson)
        {

            var serializadorJSON = new SerializadorJSON<List<Usuario>>(path);
            var serializadorXML = new SerializadorXML<List<Usuario>>(path);

            try
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (nombre == usuario.Nombre)
                    {
                        listaUsuarios.Remove(usuario);
                        break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if(xmlOJson)
            {
                serializadorJSON.Serializar(listaUsuarios);

            }
            else
            {
                serializadorXML.Serializar(listaUsuarios);
            }
        }



        public bool verificarAdministrador(string nombre, string contraseña)
        {
            var serializadorJSON = new SerializadorJSON<Administrador>(pathAdministrador);
            //var serializadorJSON2 = new SerializadorJSON<List<Administrador>>(pathAdministrador);
            bool validar = false;
            List<Administrador> listaAdministrador = serializadorJSON.Deserializar();
            foreach (Administrador adm in listaAdministrador)
            {
                if (nombre == adm.Nombre && contraseña == adm.Contraseña)
                {
                    validar = true;
                    break;
                }
            }
            return validar;
        }

        public void CrearActivo(Usuario usuario, ETipoActivo tipoActivo, string empresa, string cantidadCompra, string precioCompra, string cantidadVenta, string precioVenta, ETipoMoneda moneda, string intereses, string distintivo, string pathActivos)
        {
            var serializadorJSON = new SerializadorJSON<Usuario>(pathUsuarios);
            var serializadorJSON2 = new SerializadorJSON<List<Usuario>>(pathUsuarios);
            
            var serializadorJSONActivo = new SerializadorJSON<Activos>(pathActivos);
            var serializadorJSONActivo2 = new SerializadorJSON<List<Activos>>(pathActivos);

            List<Usuario> listaUsuarios = serializadorJSON.Deserializar();
            List<Activos> listaActivos = serializadorJSONActivo.Deserializar();
            
            int cc = int.Parse(cantidadCompra);
            float pc = float.Parse(precioCompra);
            int cv = int.Parse(cantidadVenta);
            float pv = float.Parse(precioVenta);


            float interes = float.Parse(intereses);
            Activos activoGenerar = null;
            switch (tipoActivo)
            {
                case ETipoActivo.Cedear:
                    activoGenerar = new Cedear(empresa, cc, pc, cv, pv, tipoActivo, moneda, interes, distintivo);
                    break;
                case ETipoActivo.Accion:
                    activoGenerar = new Acciones(empresa, cc, pc, cv, pv, tipoActivo, moneda, interes, distintivo);
                    break;
                case ETipoActivo.Bono:
                    activoGenerar = new Bonos(empresa, cc, pc, cv, pv, tipoActivo, moneda, interes, distintivo);
                    break;
                default:
                    activoGenerar = new dolarMep(empresa, cc, pc, cv, pv, tipoActivo, moneda, interes, distintivo);
                    break;
            }
            listaActivos.Add(activoGenerar);
            foreach (Usuario user in listaUsuarios)
            {
                if (user.Dni == usuario.Dni)
                {
                    user.ListaActivosVentas.Add(activoGenerar);
                    serializadorJSON2.Serializar(listaUsuarios);
                    break;
                }
            }
            serializadorJSONActivo2.Serializar(listaActivos);
        }

        public void EliminarActivo(List<Activos> listaActivos, string nombreEmpresa, string pathActivos)
        {
            var serializadorJSONActivo = new SerializadorJSON<List<Activos>>(pathActivos);


            try
            {
                foreach (Activos activo in listaActivos)
                {
                    if (nombreEmpresa == activo.Empresa)
                    {
                        listaActivos.Remove(activo);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            serializadorJSONActivo.Serializar(listaActivos);
        }

        public List<ActivosADO> FiltrarPorActivos(ETipoActivo tipoActivo)
        {
            
            ActivosADO activosADO = new ActivosADO();
            List<ActivosADO> listaActivosADO = activosADO.Select();
            List<ActivosADO> filtrarLista = new List<ActivosADO>();


            foreach(ActivosADO activoAdo in listaActivosADO)
            {
                
                    if (activoAdo.Activo == tipoActivo.ToString())
                    {
                        filtrarLista.Add(activoAdo);
                    }

               
            }
            return filtrarLista;
        }


        


        public List<ActivosADO> FiltrarPorMoneda(ETipoMoneda tipoMoneda, Usuario usuario, string nombreEmpresa)
        {
            ActivosADO actADO = new ActivosADO();
            List<ActivosADO> listaActivosADOS = actADO.Select();
            List<ActivosADO> filtrarLista = new List<ActivosADO>();
            
            foreach(ActivosADO act in listaActivosADOS)
            {
                if(act.Moneda == tipoMoneda.ToString() && act.Empresa == nombreEmpresa)
                {
                    filtrarLista.Add(act);
                }
                if(act.Distintivo == usuario.Dni)
                {
                    filtrarLista.Remove(act);
                }
            }
            
            return filtrarLista;
        }

        public ETipoActivo IndicarTipoActivo(int indice)
        {
            ETipoActivo activo;
            switch (indice)
            {
                case 0:
                    activo = ETipoActivo.Accion;
                    break;
                case 1:
                    activo = ETipoActivo.Cedear;
                    break;
                case 2:
                    activo = ETipoActivo.Bono;
                    break;
                default:
                    activo = ETipoActivo.MEP;
                    break;
            }
            return activo;
        }

        public List<Usuario> VerificarEmpresa(string nombre, string pathUsuarios)
        {
            var serializadorJSON = new SerializadorJSON<Usuario>(pathUsuarios);
            var serializadorJSON2 = new SerializadorJSON<List<Usuario>>(pathUsuarios);


            List<Usuario> listaUsuarios = serializadorJSON.Deserializar();
            foreach(Usuario user in listaUsuarios)
            {
                if(user.Nombre == nombre)
                {
                    user.Empresa = true;
                    break;
                }
            }

            serializadorJSON2.Serializar(listaUsuarios);
            return listaUsuarios;
        }

        public void AgregarAMySql()
        {
            UsuarioADO usuarioADO = new UsuarioADO();


            

            var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarios);
            List<Usuario> listaUsuarios = serializadorJson.Deserializar();
            
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select(); 
            if(listaUsuariosADO.Count >= 0)
            {
                foreach(Usuario usuario in listaUsuarios)
                {   
                   
                    usuarioADO = (UsuarioADO)usuario;
                    if(VerificarExistenciaUsuario(usuarioADO))
                    {
                        usuarioADO.Add();
                    }
                       
                }
            }
        }
    
        public void EliminarUsuarioMySql(string id)
        {
            UsuarioADO usuarioADO = new UsuarioADO();
            usuarioADO.Delete(id);

        }


        private bool VerificarExistenciaUsuario(UsuarioADO usuario)
        {
            UsuarioADO usuarioADO = new UsuarioADO();
            bool verificar = true;
            List<UsuarioADO> listaUsuariosADO = usuarioADO.Select();
            foreach(UsuarioADO user in listaUsuariosADO)
            {
                if(usuario.Documento == user.Documento)
                {
                    verificar = false;
                    break;
                }
            }
            return verificar;

        }

        public void ModificarUsuarios(string id, string nombre, string contraseña, string documento, string pesos, string dolares, string empresa)
        {


            UsuarioADO usuarioADO = new UsuarioADO(nombre,documento,contraseña, double.Parse(pesos), double.Parse(dolares), empresa);
            usuarioADO.Update(id);


            


        }

        public void AgregarActivoMySql(ETipoActivo tipoActivo, string empresa, string moneda, string cantidadCompra, string precioCompra, string cantidadVenta, string precioVenta, string intereses, string distintivo)
        {

            ActivosADO activosADO = new ActivosADO(tipoActivo.ToString(), empresa, moneda, int.Parse(cantidadCompra), double.Parse(precioCompra), int.Parse(cantidadVenta), double.Parse(precioVenta), int.Parse(intereses), distintivo);
            activosADO.Add();


        }

            
    



    }
}
