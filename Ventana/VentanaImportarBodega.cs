using PPAI_CU_5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU_5.Ventana
{
    public partial class VentanaImportarBodega : Form
    {
        ResumenActualizacion ResumenActualizacion;
        Gestor.GestorImortarBodega gestor;
        BaseDeDatos.DATOS BaseDeDatos;
        List<Bodega> vinosActualizar;
        public VentanaImportarBodega()
        {
            InitializeComponent();
            gestor = new Gestor.GestorImortarBodega(this);
            BaseDeDatos = new BaseDeDatos.DATOS(gestor);
            BaseDeDatos.inicializarDatos();
            Grid.Hide();
            tomarSeleccion.Hide();
            tomarSeleccion.Enabled = false;
            Grid.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mostrarPantalla();

        }
        private void mostrarPantalla()
        {
            button1.Hide();
            vinosActualizar = this.gestor.opcionImportarActualizacionVinos();
            for (int i = 0; i < vinosActualizar.Count; i++) { Grid.Rows.Add(i + 1, vinosActualizar[i].getNombre()); }
            Grid.Show();
            tomarSeleccion.Show();
        }


        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
            tomarSeleccion.Enabled = true;

            }
        }

        private void VentanaImportarBodega_Load(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            tomarSeleccion.Enabled = false;
            foreach (DataGridViewRow fila in Grid.SelectedRows)
            {
                string nombreBodega = fila.Cells[1].Value.ToString();
                var res = await this.gestor.tomarSeleccionBodegas(nombreBodega);
                ResumenActualizacion = new ResumenActualizacion(res, nombreBodega);

                ResumenActualizacion.Show();


            }

        }
    }
}
