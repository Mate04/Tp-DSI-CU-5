using PPAI_CU_5.Entidades;
using PPAI_CU_5.Interfacez;
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
    public partial class ResumenActualizacion : Form
    {
        List<VinoAccion> resumen;
        public ResumenActualizacion(List<VinoAccion> BodegasResumen, string TituloBodegaa)
        {
            InitializeComponent();
            this.resumen = BodegasResumen;
            for (int i = 0; i < this.resumen.Count; i++) { Grid2.Rows.Add(BodegasResumen[i].getVinoSeleccionado(), BodegasResumen[i].getAccion()); }
            TituloBodega.Text = TituloBodegaa;

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
