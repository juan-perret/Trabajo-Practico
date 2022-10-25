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
    public partial class FormDespensa : Form
    {
        private Despensa logica;
        public FormDespensa()
        {
            InitializeComponent();
            logica = new Despensa();
        }

        private void cargarUnIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaIngredientes altaIngredientes = new FormAltaIngredientes();
            altaIngredientes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dgvDespensa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvDespensa);
        }

        private void FormDespensa_Load(object sender, EventArgs e)
        {
            dgvDespensa.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvDespensa.DataSource = null;
            dgvDespensa.DataSource = logica.LeerProductos();
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }

        private void dgvDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
