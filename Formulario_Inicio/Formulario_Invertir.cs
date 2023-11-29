using Biblioteca_Clases;
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
        private Activos activo;
        private Usuario usuario;
        private Administrador admin;
        private Activos activoComprado;
        List<Activos> listaActivosOperar;
        List<Activos> listaOfertasUsuarios;
        List<Activos> listaActivosVentasUsuarios;
        List<Activos> listaActivos;
        bool empresa;
        ETipoMoneda tipoMoneda;
        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        private string pathUsuarios = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MisUsuarios.json";

        public Formulario_Invertir(Activos activo, Usuario usuario)
        {
            InitializeComponent();
            this.activo = activo;
            this.admin = new Administrador();
            this.usuario = usuario;
            listaActivosOperar = new List<Activos>();

            txtPrecio.Visible = true;
            empresa = false;

        }





        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[8].Value.ToString();
                activo = usuario.ObtenerActivo(distintivo, tipoMoneda);
                int cantidadVenta = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[5].Value;
                float precioVenta = float.Parse(dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[6].Value.ToString());
                int cantidadCompraIngresada = int.Parse(txtCantidad.Text);
                float precioIngresado = float.Parse(txtPrecio.Text);

                activo.Validar = true;

                activo.PrecioActivo += ManejadorPrecioCompraActivo;
                activo.MonedaActivo += ManejadorSaldoInsuficiente;
                activo.CantidadActivos += ManejadorCantidadCompraActivo;




                if (precioVenta == precioIngresado || activo.Validar == true)
                {
                    activo.ValidarPrecioCompraActivo(activo, precioIngresado * cantidadCompraIngresada);
                    activo.VerificarMoneda(precioIngresado * cantidadCompraIngresada, usuario, activo.Moneda);
                    activo.ValidarCantidadCompraActivo(cantidadVenta, cantidadCompraIngresada);
                }



                if (activo.Validar)
                {
                    usuario.ComprarActivo(usuario, activo, txtCantidad.Text, precioVenta.ToString());
                    MessageBox.Show("Su compra se ha realizado con exito!");
                    MostrarDGV();

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
            MostrarDGV();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Formulario_Inversiones fI = new Formulario_Inversiones(usuario);
            fI.Show();
            this.Hide();
        }



        private void btnVenderActivos_Click(object sender, EventArgs e)
        {

            btnVender.Visible = true;
            if (usuario.Empresa == false)
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


            if (usuario.Empresa == false)
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

            string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[8].Value.ToString();
            int cantidadCompra = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[3].Value;
            activo = usuario.ObtenerActivo(distintivo, tipoMoneda);

            if (int.Parse(txtCantidad.Text) > cantidadCompra)
            {
                MessageBox.Show("La cantidad ingresada es mayor a la cantidad de venta del activo. Ingrese otro valor.");
            }
            else if (int.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese un valor distinto de 0 si desea vender una activo");

            }

            else if (usuario.VerificarActivoEnUsuario(usuario, distintivo, activo))
            {
                usuario.VenderActivoAUsuario(usuario, activo, txtCantidad.Text, txtPrecio.Text);
            }
            else
            {
                MessageBox.Show("No posees ese activo en tu cuenta.");

            }

            MostrarDGV();
        }

        private void cmbTipoMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {


            List<Activos> listaActivos = null;
            int indice = cmbTipoMonedas.SelectedIndex;
            switch (indice)
            {
                case 0:
                    tipoMoneda = ETipoMoneda.ARG;

                    break;
                case 1:
                    tipoMoneda = ETipoMoneda.USD;
                    break;
                default:
                    tipoMoneda = activo.Moneda;
                    break;
            }

            listaActivos = admin.FiltrarPorMoneda(tipoMoneda, usuario, activo.Empresa);
            MostrarEnDGV(listaActivos);

        }

        private void MostrarEnDGV(List<Activos> listaActivos)
        {
            dgvMercadoSecundario.DataSource = listaActivos;
        }
        private void MostrarDGV()
        {
            var serializadorJson = new SerializadorJSON<Usuario>(pathUsuarios);

            List<Usuario> listaUsuarios = serializadorJson.Deserializar();

            foreach (Usuario user in listaUsuarios)
            {
                foreach (Activos act in user.ListaActivosVentas)
                {
                    if (act.Empresa == activo.Empresa)
                    {
                        listaActivosOperar.Add(act);
                    }
                    if (act.Distintivo == usuario.Dni)
                    {
                        listaActivosOperar.Remove(act);
                    }
                }
            }

            dgvMercadoSecundario.DataSource = listaActivosOperar;
        }


    }
}
