using Biblioteca_Clases;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Inversiones : Form
    {
        private UsuarioADO usuario;
        private Usuario user;
        private Administrador admin;
        private double porcentajeRandomApple;
        private double porcentajeRandomMicrosoft;
        private double porcentajeRandomTesla;
        private double porcentajeRandomAmazon;
        private int contador;
        private string accion;
        private double gananciaFinal;
        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        ETipoMoneda tipoMoneda;
        ETipoActivo tipoActivo;



        public Formulario_Inversiones(UsuarioADO usuario) : this()
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contador = 0;
            MostrarSueldos();
            //ConfigurarGridView();
        }
        public Formulario_Inversiones()
        {
            //InitializeComponent();
            admin = new Administrador();
            user = new Usuario();
            //ConfigurarGridView();
        }


        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            fm.Show();
            this.Hide();

        }

        private void MostrarSueldos()
        {
            lblSueldoPesos.Text = "$ARG: " + usuario.Pesos.ToString();
            lblSueldoDolar.Text = "$USD: " + usuario.Dolares.ToString();
        }
        private void cmbActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ActivosADO> listaActivos = null;
            int indice = cmbActivos.SelectedIndex;
            switch (indice)
            {
                case 0:
                    tipoActivo = ETipoActivo.Accion;

                    break;
                case 1:
                    tipoActivo = ETipoActivo.Cedear;

                    break;
                case 2:
                    tipoActivo = ETipoActivo.Bono;

                    break;
                default:
                    tipoActivo = ETipoActivo.MEP;

                    break;
            }
            listaActivos = admin.FiltrarPorActivos(tipoActivo);
            MostrarActivos(listaActivos);
        }



        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string empresa;
            ActivosADO activo;
            string moneda;
            try
            {
                moneda = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[2].Value.ToString();
                if (moneda == "ARG")
                {
                    tipoMoneda = ETipoMoneda.ARG;
                }
                else
                {
                    tipoMoneda = ETipoMoneda.USD;

                }
                
                string idActivo = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[0].Value.ToString();
                activo = user.ObtenerActivo("activos", idActivo);
                Formulario_Invertir fi = new Formulario_Invertir(activo, usuario);
                fi.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("No hay activos.");
            }

        }

        private void MostrarActivos(List<ActivosADO> listaActivos)
        {


            dgvActivos.Rows.Clear();
            foreach (ActivosADO act in listaActivos)
            {
                dgvActivos.Rows.Add(act.Activo, act.Empresa, act.Moneda, act.CantidadCompra, act.PrecioCompra, act.CantidadVenta, act.PrecioVenta, act.Distintivo);
            }


        }
        private void ConfigurarGridView()
        {
            dgvActivos.ColumnCount = 8;

            dgvActivos.Columns[0].Name = "Activo";
            dgvActivos.Columns[1].Name = "Empresa";
            dgvActivos.Columns[2].Name = "Moneda";
            dgvActivos.Columns[3].Name = "Cc";
            dgvActivos.Columns[4].Name = "Pc";
            dgvActivos.Columns[5].Name = "Cv";
            dgvActivos.Columns[6].Name = "Pv";
            dgvActivos.Columns[7].Name = "Distintivo";

        }


        private void Formulario_Inversiones_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM activos;";
            LlenarDataGridView(dgvActivos, query);

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
