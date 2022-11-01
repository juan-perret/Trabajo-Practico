using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPrincipal;

namespace FormPrincipal
{
    public partial class FormListaSuper : Form
    {
        private Super logica;
        public FormListaSuper()
        {
            InitializeComponent();
            logica = new Super();
        }     
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaSuper_Load(object sender, EventArgs e)
        {
            dgvListaSuper.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista();
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }


    }
}
