using Biblioteca_Clases;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginTrue()
        {

            
            bool result = Biblioteca_Clases.Usuario.VerificarDatosIngresados("carlos", "carlos", "45301748");
            Assert.AreEqual(true,result);

        }
        [TestMethod]
        public void TestUserExist()
        {

           
            UsuarioADO usuario = new UsuarioADO("pablito", "45301748","pablito",0,0,"False");
            bool result = Biblioteca_Clases.Administrador.VerificarExistenciaUsuario(usuario);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestCreateActive()
        {


            UsuarioADO usuario = new UsuarioADO("pablito", "45301748", "pablito", 0, 0, "False");
            ActivosADO activoADO = new ActivosADO("Cedear","Apple","ARG",1,100,1,100,1,"4");
            Usuario user = new Usuario();

            ActivosADO result = user.CrearActivoCompradoVendido(usuario,activoADO,5,"100","1","100");
            Assert.AreEqual(activoADO, result);

        }



    }
}