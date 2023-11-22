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
    public partial class Formulario_Administrar_Activos : Form
    {
        int n = 0;
        ETipoActivo tipoActivo;
        Activos activo;
        private Administrador admin;
        private List<Activos> listaActivos;
        private string empresa;
        private string pathActivos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Activos.json";
        private string fechaHoy = DateTime.Now.ToString();
        public Formulario_Administrar_Activos()
        {
            InitializeComponent();
            btnConfirmarCambios.Visible = false;
            this.admin = new Administrador();
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            
        }

        private void Formulario_Administrar_Activos_Load(object sender, EventArgs e)
        {
            MostrarActivos();
        }

        private void dgvActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

        }

        private void btnEliminarActivo_Click(object sender, EventArgs e)
        {
            var serializadorJson = new SerializadorJSON<Activos>(pathActivos);
            string nombreActivo;
            if (n != -1)
            {
                try
                {
                    Administrador admin = new Administrador();
                    nombreActivo = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[1].Value.ToString();
                    listaActivos = serializadorJson.Deserializar();
                    admin.EliminarActivo(listaActivos, nombreActivo, pathActivos);
                    MostrarActivos();

                }
                catch
                {
                    MessageBox.Show("No se puede eliminar esa linea");
                }
            }
        }

        private void cmbActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbActivo.SelectedIndex;
            btnConfirmarCambios.Visible = true;
            tipoActivo = admin.IndicarTipoActivo(indice);
        }

        private void MostrarActivos()
        {
            try
            {
                string filejson = File.ReadAllText(pathActivos);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
                dgvActivos.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No hay activos.");
            }
        }


    }
}
