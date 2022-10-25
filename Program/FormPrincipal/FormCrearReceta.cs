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
    public partial class FormCrearReceta : Form
    {
        private Despensa logica;
        public FormCrearReceta()
        {
            InitializeComponent();
            logica = new Despensa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearReceta_Load(object sender, EventArgs e)
        {
            dgvIngredientes.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void dgvIngredientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvIngredientes);
        }

        private void ActualizarGrilla()
        {
            dgvIngredientes.DataSource = null;
            dgvIngredientes.DataSource = logica.LeerProductos();
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }
    }
}
