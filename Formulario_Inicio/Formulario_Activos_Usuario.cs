using Biblioteca_Clases;
using Newtonsoft.Json;
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
    public partial class Formulario_Activos_Usuario : Form
    {
        private Usuario usuario;
        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        string moneda;
        ETipoActivo tipoActivo;
        ETipoMoneda tipoMoneda;
        public Formulario_Activos_Usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AlternarTextBox(false);

        }

        private void Formulario_Activos_Usuario_Load(object sender, EventArgs e)
        {
            dgvActivosUsuario.DataSource = usuario.ListaActivos;
            txtNombreEmpresa.AutoCompleteCustomSource = CargarDatos();
            AlternarTextBox(true);


            if (usuario.Empresa == false)
            {
                txtIntereses.Visible = false;
            }
        }

        private AutoCompleteStringCollection CargarDatos()
        {
            var serializarJsonActivos = new SerializadorJSON<Activos>(pathActivos);

            List<Activos> listaActivos = serializarJsonActivos.Deserializar();
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (Activos act in listaActivos)
            {
                datos.Add(act.Empresa);
            }
            return datos;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            Administrador admin = new Administrador();
            if (usuario.Empresa == false)
            {
                if (verificarActivosEnUsuario())
                {
                    Activos activo = null;
                    string empresa;
                    empresa = dgvActivosUsuario.Rows[dgvActivosUsuario.CurrentRow.Index].Cells[8].Value.ToString();

                    activo = usuario.ObtenerActivo(empresa, tipoMoneda);

                    usuario.VenderActivoPropio(usuario, activo, txtCantidadCompra.Text, txtPrecioCompra.Text, txtCantidadVenta.Text, txtPrecioVenta.Text);
                    MostrarActivos(usuario.ListaActivosVentas);
                }
                else
                {
                    MessageBox.Show("No posee activos en su cuenta");
                }


            }
            else
            {
                try
                {
                    txtIntereses.Text = "1";
                    if (moneda == "ARG" || moneda == "USD")
                    {
                        admin.CrearActivo(usuario, tipoActivo, txtNombreEmpresa.Text, txtCantidadCompra.Text, txtPrecioCompra.Text, txtCantidadVenta.Text, txtPrecioVenta.Text, tipoMoneda, txtIntereses.Text, usuario.Dni, pathActivos);
                    }
                    else
                    {
                        MessageBox.Show("El tipo de moneda del activo debe ser en 'USD' o en 'ARG'");
                    }
                }
                catch
                {
                    MessageBox.Show("No se han ingresado datos válidos");
                }

            }




        }

        private void cmbActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbActivo.SelectedIndex;

            btnVender.Visible = true;
            Administrador admin = new Administrador();
            tipoActivo = admin.IndicarTipoActivo(indice);
            if (tipoActivo == ETipoActivo.Bono)
            {
                txtIntereses.Visible = true;
            }
            else
            {
                txtIntereses.Visible = false;

            }
        }
        private void MostrarActivos(List<Activos> listaActivos)
        {

            dgvActivosUsuario.DataSource = listaActivos;

        }

        private void btnActivosUsuario_Click(object sender, EventArgs e)
        {
            dgvActivosUsuario.DataSource = usuario.ListaActivos;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            dgvActivosUsuario.DataSource = usuario.ListaActivosVentas;
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            txtCantidadVenta.Visible = true;
            txtPrecioVenta.Visible = true;
            txtCantidadCompra.Visible = false;
            txtPrecioCompra.Visible = false;
            txtMoneda.Visible = true;
            txtNombreEmpresa.Visible = true;
            lblCantidadCompra.Visible = false;
            lblPrecioCompra.Visible = false;
            lblPrecioVenta.Visible = true;
            lblCantidadVenta.Visible = true;
            lblMoneda.Visible = true;
            lblEmpresa.Visible = true;
            btnVender.Visible = true;

            if (usuario.Empresa == true)
            {
                txtCantidadCompra.Visible = true;
                txtPrecioCompra.Visible = true;
                lblPrecioCompra.Visible = true;
            }


        }

        private void btnGenerarOferta_Click(object sender, EventArgs e)
        {
            if (usuario.Empresa == false)
            {
                lblCantidadCompra.Visible = true;
                lblPrecioCompra.Visible = true;
                lblEmpresa.Visible = true;
                lblMoneda.Visible = true;
                lblCantidadVenta.Visible = false;
                lblPrecioVenta.Visible = false;
                txtMoneda.Visible = true;
                txtNombreEmpresa.Visible = true;
                txtCantidadCompra.Visible = true;
                txtPrecioCompra.Visible = true;
                txtCantidadVenta.Visible = false;
                txtPrecioVenta.Visible = false;
            }
            else
            {

            }

            btnVender.Visible = false;


        }




        private void AlternarTextBox(bool alternar)
        {
            this.txtCantidadVenta.Visible = alternar;
            this.txtPrecioVenta.Visible = alternar;
            this.txtPrecioCompra.Visible = alternar;
            this.txtCantidadCompra.Visible = alternar;
            this.cmbTipoMonedas.Visible = alternar;
            this.txtNombreEmpresa.Visible = alternar;
            this.lblCantidadCompra.Visible = alternar;
            this.lblCantidadVenta.Visible = alternar;
            this.lblEmpresa.Visible = alternar;
            this.lblIntereses.Visible = alternar;
            this.lblMoneda.Visible = alternar;
            this.lblPrecioCompra.Visible = alternar;
            this.lblPrecioVenta.Visible = alternar;
            this.txtIntereses.Visible = alternar;
        }

        private bool verificarActivosEnUsuario()
        {
            bool verificar = true;
            if (usuario.ListaActivos.Count <= 0)
            {
                verificar = false;
            }
            return verificar;
        }

        private void cmbTipoMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbTipoMonedas.SelectedIndex;
            switch (indice)
            {
                case 0:
                    tipoMoneda = ETipoMoneda.ARG;
                    moneda = "ARG";
                    break;
                case 1:
                    tipoMoneda = ETipoMoneda.USD;
                    moneda = "USD";
                    break;
            }
        }

        private void pictureBoxBotonVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            fm.Show();
            this.Hide();
        }
    }

}
