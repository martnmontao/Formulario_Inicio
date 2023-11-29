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
            

            
        }


        private void btnVender_Click(object sender, EventArgs e)
        {

            try
            {
                Administrador admin = new Administrador();
                int cantidadAVender = int.Parse(txtCantidadVenta.Text);
                Activos activo = null;
                string distintivo;

                if (usuario.Empresa == false)
                {
                    distintivo = dgvActivosUsuario.Rows[dgvActivosUsuario.CurrentRow.Index].Cells[8].Value.ToString();

                    activo = usuario.ObtenerActivo(distintivo, tipoMoneda);
                    if (usuario.verificarActivosEnUsuario(usuario, cantidadAVender, activo))
                    {

                        usuario.VenderActivoPropio(usuario, activo, txtCantidadCompra.Text, txtPrecioCompra.Text, txtCantidadVenta.Text, txtPrecioVenta.Text);
                        MostrarActivos(usuario.ListaActivosVentas);
                    }
                    else
                    {
                        MessageBox.Show("No posee esa cantidad de activos en su cuenta");
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
            catch
            {
                MessageBox.Show("No posee activos para vender");
            }




        }

        private void cmbActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbActivo.SelectedIndex;
            AlternarTextBox(false);
            Administrador admin = new Administrador();
            tipoActivo = admin.IndicarTipoActivo(indice);

            switch (tipoActivo)
            {
                case ETipoActivo.Accion:
                    AlternarTextBox(true);
                    txtIntereses.Visible = false;
                    lblIntereses.Visible = false;
                    break;
                case ETipoActivo.Cedear:
                    AlternarTextBox(true);
                    txtIntereses.Visible = false;
                    lblIntereses.Visible = false;
                    break;
                case ETipoActivo.Bono:
                    AlternarTextBox(true);
                    if(usuario.Empresa == false)
                    {
                        txtIntereses.Visible = false;
                        lblIntereses.Visible = false;
                    }
                    break;
            }

            if (usuario.Empresa == false)
            {
                txtNombreEmpresa.Visible = false;
                lblEmpresa.Visible = false;
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
            Administrador admin = new Administrador();
            usuario = usuario.DevolverUsuarios(usuario);
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
            this.btnVender.Visible = alternar;
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
