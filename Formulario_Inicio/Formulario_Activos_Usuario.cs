using Biblioteca_Clases;
using MySql.Data.MySqlClient;
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
        private UsuarioADO usuario;
        private Usuario user;

        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        string moneda;
        ETipoActivo tipoActivo;
        ETipoMoneda tipoMoneda;
        public Formulario_Activos_Usuario(UsuarioADO usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AlternarTextBox(false);

        }

        private void Formulario_Activos_Usuario_Load(object sender, EventArgs e)
        {
            user = (Usuario)usuario;
            dgvActivosUsuario.DataSource = user.ListaActivos;
            

            
        }


        private void btnVender_Click(object sender, EventArgs e)
        {

            try
            {
                Administrador admin = new Administrador();
                int cantidadAVender = int.Parse(txtCantidadVenta.Text);
                ActivosADO activo = null;
                string idActivo;
                string distintivo;
                string intereses;
                string empresa;
                DataBase db = new DataBase();
                string idUsuario = db.DevolverIDUsuario(usuario.Documento);

                if (usuario.Empresa == "False")
                {
                    //intereses = dgvActivosUsuario.Rows[dgvActivosUsuario.CurrentRow.Index].Cells[8].Value.ToString();
                    empresa = dgvActivosUsuario.Rows[dgvActivosUsuario.CurrentRow.Index].Cells[2].Value.ToString();
                    idActivo = dgvActivosUsuario.Rows[dgvActivosUsuario.CurrentRow.Index].Cells[0].Value.ToString();

                    activo = user.ObtenerActivo("activossinvender", idActivo);
                    if (Usuario.VerificarActivosEnUsuario(user, cantidadAVender, activo))
                    {
                        admin.AgregarActivoMySql(tipoActivo, empresa, moneda, txtCantidadCompra.Text, txtPrecioCompra.Text, txtCantidadVenta.Text, txtPrecioVenta.Text, "1", usuario.Documento, usuario);
                        
                        user.VenderActivoPropio(txtCantidadCompra.Text,txtCantidadVenta.Text, idActivo, idUsuario);
                        MostrarActivos(user.ListaActivosVentas);
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
                        
                            admin.AgregarActivoMySql(tipoActivo, txtNombreEmpresa.Text, moneda, txtCantidadCompra.Text,txtPrecioCompra.Text, txtCantidadVenta.Text,txtPrecioVenta.Text,txtIntereses.Text, usuario.Documento, usuario);
                            //admin.CrearActivo(usuario, tipoActivo, txtNombreEmpresa.Text, txtCantidadCompra.Text, txtPrecioCompra.Text, txtCantidadVenta.Text, txtPrecioVenta.Text, tipoMoneda, txtIntereses.Text, usuario.Documento, pathActivos);
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
                    if(usuario.Empresa == "False")
                    {
                        txtIntereses.Visible = false;
                        lblIntereses.Visible = false;
                    }
                    break;
            }

            if (usuario.Empresa == "False")
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
            DataBase db = new DataBase();
            string idUsuario = db.DevolverIDUsuario(usuario.Documento);
            string query = $"SELECT * FROM activossinvender WHERE idUsuario = '{idUsuario}';";
            LlenarDataGridView(dgvActivosUsuario, query);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
            DataBase db = new DataBase();
            string idUsuario = db.DevolverIDUsuario(usuario.Documento);
            string query = $"SELECT * FROM activos WHERE idUsuario = '{idUsuario}';";
            LlenarDataGridView(dgvActivosUsuario,query);
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

            if (usuario.Empresa == "True")
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
