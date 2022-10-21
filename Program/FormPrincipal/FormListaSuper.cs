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

        private void dgvListaSuper_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvListaSuper);
        }
        private void ActualizarGrilla()
        {
            dgvListaSuper.DataSource = null;
            //dgvListaSuper.DataSource = logica.LeerProductos();
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }
    }
}
