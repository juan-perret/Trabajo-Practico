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
    public partial class FormIngredienteRecetas : Form
    {
        private ModuloReceta logica;
        private string id { get; set; }
        public FormIngredienteRecetas(string Id)
        {
            InitializeComponent();
            logica = new ModuloReceta();
            this.id = Id;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIngredienteRecetas_Load(object sender, EventArgs e)
        {
            dgvIngredientesRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvIngredientesRecetas.DataSource = null;
            dgvIngredientesRecetas.DataSource = logica.DevolverIngredientesDeReceta(id);
        }
    }
}
