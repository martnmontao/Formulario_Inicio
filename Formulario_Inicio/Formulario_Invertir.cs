using Biblioteca_Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Invertir : Form
    {
        private ActivosADO activoADO;
        private Activos activo;
        private UsuarioADO usuario;
        private Administrador admin;
        private ActivosADO activoComprado;
        List<Activos> listaActivosOperar;
        List<Activos> listaOfertasUsuarios;
        List<Activos> listaActivosVentasUsuarios;
        List<Activos> listaActivos;
        Usuario user;
        bool empresa;
        ETipoMoneda tipoMoneda;
        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        private string pathUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";

        public Formulario_Invertir(ActivosADO activoADO, UsuarioADO usuario)
        {
            InitializeComponent();
            this.activoADO = activoADO;
            this.admin = new Administrador();
            this.usuario = usuario;
            this.user = new Usuario();
            listaActivosOperar = new List<Activos>();

            txtPrecio.Visible = true;
            empresa = false;

        }





        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();
                string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[9].Value.ToString();
                string idActivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[0].Value.ToString();
                activoADO = user.ObtenerActivo("activos", idActivo);
                int cantidadVenta = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[5].Value;
                float precioVenta = float.Parse(dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[6].Value.ToString());
                int cantidadCompraIngresada = int.Parse(txtCantidad.Text);
                float precioIngresado = float.Parse(txtPrecio.Text);
                string idUsuario = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[10].Value.ToString();


                activoADO.Validar = true;

                activoADO.PrecioActivo += ManejadorPrecioCompraActivo;
                activoADO.MonedaActivo += ManejadorSaldoInsuficiente;
                activoADO.CantidadActivos += ManejadorCantidadCompraActivo;




                if (precioVenta == precioIngresado || activoADO.Validar == true)
                {
                    activoADO.ValidarPrecioCompraActivo(activoADO, precioIngresado * cantidadCompraIngresada);
                    activoADO.VerificarMoneda(precioIngresado * cantidadCompraIngresada, usuario, activoADO.Moneda);
                    activoADO.ValidarCantidadCompraActivo(cantidadVenta, cantidadCompraIngresada);
                }



                if (activoADO.Validar)
                {



                    user.ComprarActivo(idActivo, usuario, activoADO, txtCantidad.Text, precioVenta.ToString(), idUsuario);
                    MessageBox.Show("Su compra se ha realizado con exito!");
                    LlenarDataGridView(dgvMercadoSecundario, "SELECT * FROM activos where empresa = '" + activoADO.Empresa + "';");


                }

            }
            catch
            {
                MessageBox.Show("Hubo un error. Verifique que haya ingresado valores correctos.");

            }

        }


        public void ManejadorSaldoInsuficiente(object sender, EventArgs e)
        {
            MessageBox.Show("Activo: " + ((Activos)sender).Empresa + ". No posee el siguiente saldo en su cuenta: " + ((ActivoEvent)e).SueldoInsuficiente);

        }
        public void ManejadorCantidadCompraActivo(object sender, EventArgs e)
        {

            MessageBox.Show("Acitvo: " + ((Activos)sender).Empresa + ". Ingrese una cantidad diferente de: " + ((ActivoEvent)e).CantidadActivos);
        }

        public void ManejadorPrecioCompraActivo(object sender, EventArgs e)
        {

            MessageBox.Show("Acitvo: " + ((Activos)sender).Empresa + "Ingrese otro precio diferente de: " + ((ActivoEvent)e).ValorActivo);
        }








        private void Formulario_Invertir_Load(object sender, EventArgs e)
        {
            LlenarDataGridView(dgvMercadoSecundario, "SELECT * FROM activos where empresa = '" + activoADO.Empresa + "';");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Formulario_Inversiones fI = new Formulario_Inversiones(usuario);
            fI.Show();
            this.Hide();
        }



        private void btnVenderActivos_Click(object sender, EventArgs e)
        {

            
            if (usuario.Empresa == "False")
            {

                txtCantidad.Visible = true;
                lblCantidad.Visible = true;
                txtPrecio.Visible = true;
                btnComprar.Visible = false;
                lblPrecio.Visible = true;
                btnVender.Visible = true;

            }
        }

        private void btnComprarActivo_Click(object sender, EventArgs e)
        {


            if (usuario.Empresa == "False")
            {
                btnComprar.Visible = true;
                btnVender.Visible = false;
                txtCantidad.Visible = true;
                lblCantidad.Visible = true;
                txtPrecio.Visible = true;
                lblPrecio.Visible = true;



            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            List<Activos> listaActivos = null;
            user = (Usuario)usuario;
            string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[9].Value.ToString();
            string idActivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[0].Value.ToString();
            string idUsuario = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[10].Value.ToString();
            //DataBase db = new DataBase();
            user = (Usuario)usuario;
            int cantidadCompra = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[3].Value;
            activoADO = user.ObtenerActivo("activos", idActivo);
            ActivosADO actADO = new ActivosADO (activoADO.Activo,activoADO.Empresa,activoADO.Moneda,activoADO.CantidadCompra,activoADO.PrecioCompra,activoADO.CantidadVenta,activoADO.PrecioVenta,activoADO.Intereses,activoADO.Distintivo);
            
            
            actADO.Distintivo = user.Dni;




            //string idUsuarioAVender = db.DevolverIDUsuario(user.Dni);


            //ActivosADO activoAVender = db.DevolverActivo("activossinvender",idUsuarioAVender);

            if (int.Parse(txtCantidad.Text) > cantidadCompra)
            {
                MessageBox.Show("La cantidad ingresada es mayor a la cantidad de venta del activo. Ingrese otro valor.");
            }
            else if (int.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese un valor distinto de 0 si desea vender una activo");

            }
            else if (Usuario.VerificarActivosEnUsuario(user, cantidadCompra, actADO))
            {


                user.VenderActivoAUsuario(usuario, activoADO, txtCantidad.Text, txtPrecio.Text, idUsuario, idActivo);
                LlenarDataGridView(dgvMercadoSecundario, "SELECT * FROM activos where empresa = '" + activoADO.Empresa + "';");
            }
            else
            {
                MessageBox.Show("No posees ese activo en tu cuenta.");

            }

        }

        private void cmbTipoMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {


            List<ActivosADO> listaActivos = null;
            int indice = cmbTipoMonedas.SelectedIndex;
            switch (indice)
            {
                case 0:
                    LlenarDataGridView(dgvMercadoSecundario, "SELECT * FROM activos WHERE moneda = 'ARG' AND empresa = '" + activoADO.Empresa + "';");
                    break;
                case 1:
                    LlenarDataGridView(dgvMercadoSecundario, "SELECT * FROM activos WHERE moneda = 'USD' AND empresa = '" + activoADO.Empresa + "';");

                    break;
                default:
                    tipoMoneda = activo.Moneda;
                    break;
            }




        }







        public static void LlenarDataGridView(DataGridView dataGridView, string query)
        {
            try
            {
                DataBase dataBase = new DataBase();


                dataGridView.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dataBase.OpenDataGridView());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                dataBase.CloseDataGridView();


            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo mostrar");
            }
        }

    }
}
