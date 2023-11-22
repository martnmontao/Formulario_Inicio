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
            listaOfertasUsuarios = usuario.ListaOfertasActivos;
            txtPrecio.Visible = false;
            empresa = false;

        }





        private void btnComprar_Click(object sender, EventArgs e)
        {
            string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[8].Value.ToString();
            activo = usuario.ObtenerActivo(distintivo, tipoMoneda);
            string precioCompra = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[4].Value.ToString();
            int cantidadVenta = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[5].Value;




            if (int.Parse(txtCantidad.Text) > cantidadVenta)
            {
                MessageBox.Show("La cantidad ingresada es mayor a la cantidad de venta del activo. Ingrese otro valor.");
            }
            else if (int.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese un valor distinto de 0 si desea comprar una activo");

            }
            else
            {
                if (tipoMoneda == ETipoMoneda.USD && int.Parse(txtPrecio.Text) > usuario.SueldoDolares)
                {

                    MessageBox.Show("No posee esa cantidad de dólares en su cuenta");

                }
                else if (int.Parse(txtPrecio.Text) > usuario.Sueldo)
                {

                    MessageBox.Show("No posee esa cantidad de pesos en su cuenta");

                }
                else if (int.Parse(txtPrecio.Text) < float.Parse(precioCompra))
                {
                    MessageBox.Show("No hay activos con ese valor de compra. Seleccione otro activo.");

                }
                else
                {
                    usuario.ComprarActivo(usuario, activo, txtCantidad.Text, precioCompra);
                    MessageBox.Show("Su compra se ha realizado con exito!");

                }
            }
        }


        private void Formulario_Invertir_Load(object sender, EventArgs e)
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



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Formulario_Inversiones fI = new Formulario_Inversiones(usuario);
            fI.Show();
            this.Hide();
        }

        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadCompra = int.Parse(txtCantidad.Text);

                switch (activo.Activo)
                {
                    case ETipoActivo.Bono:
                        txtPrecioFinal.Text = ((activo.Pv * activo.Intereses * cantidadCompra) + cantidadCompra * activo.Pv).ToString();
                        break;
                    case ETipoActivo.MEP:
                        txtPrecioFinal.Text = (activo.Pv * activo.Intereses).ToString();
                        break;
                    default:
                        txtPrecioFinal.Text = (activo.Pv * cantidadCompra).ToString();
                        break;

                }

            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
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
            string distintivo = dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[8].Value.ToString();
            int cantidadVenta = (int)dgvMercadoSecundario.Rows[dgvMercadoSecundario.CurrentRow.Index].Cells[5].Value;
            activo = usuario.ObtenerActivo(distintivo, tipoMoneda);
            if (int.Parse(txtCantidad.Text) > cantidadVenta)
            {
                MessageBox.Show("La cantidad ingresada es mayor a la cantidad de venta del activo. Ingrese otro valor.");
            }
            else if (int.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese un valor distinto de 0 si desea vender una activo");

            }
            usuario.VenderActivoAUsuario(usuario, activo, txtCantidad.Text, txtPrecio.Text);


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
            }
            listaActivos = admin.FiltrarPorMoneda(tipoMoneda, usuario);
            mostrarEnDGV(listaActivos);
        }

        private void mostrarEnDGV(List<Activos> listaActivos)
        {
            dgvMercadoSecundario.DataSource = listaActivos;
        }
    }
}
