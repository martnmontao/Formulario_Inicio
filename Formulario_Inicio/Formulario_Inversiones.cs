using Biblioteca_Clases;
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
        private Usuario usuario;
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

        Formulario_Ingresar_Sueldo fi = new Formulario_Ingresar_Sueldo();

        public Formulario_Inversiones(Usuario usuario) : this()
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contador = 0;
            MostrarSueldos();
        }
        public Formulario_Inversiones()
        {
            //InitializeComponent();
            admin = new Administrador();
            usuario = new Usuario();
        }


        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            fm.Show();
            this.Hide();

        }

        private void MostrarSueldos()
        {
            lblSueldoPesos.Text = "$ARG: " + usuario.Sueldo.ToString();
            lblSueldoDolar.Text = "$USD: " + usuario.SueldoDolares.ToString();
        }
        private void cmbActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Activos> listaActivos = null;
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
            listaActivos = admin.FiltrarPorActivos(tipoActivo, pathActivos);
            MostrarActivos(listaActivos);
        }


        private void MostrarActivos(List<Activos> listaActivos)
        {
            try
            {
                dgvActivos.DataSource = listaActivos;
            }
            catch
            {
                MessageBox.Show("No hay activos.");
            }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            var serializadorJson = new SerializadorJSON<Activos>(pathActivos);
            string empresa;
            Activos activo;
            List<Activos> listaActivos = serializadorJson.Deserializar();
            try
            {
                tipoMoneda = (ETipoMoneda)dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[2].Value;
                empresa = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[8].Value.ToString();
                activo = usuario.ObtenerActivo(empresa, tipoMoneda);
                Formulario_Invertir fi = new Formulario_Invertir(activo, usuario);
                fi.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("No hay activos.");
            }

        }

    }
}
