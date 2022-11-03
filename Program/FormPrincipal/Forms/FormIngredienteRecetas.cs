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
        public FormIngredienteRecetas(string id)
        {
            InitializeComponent();
            logica = new ModuloReceta();
            this.id = id;
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
            //Crear metodo que lea los ingredientes del id de la receta pasado como parametro
            //dgvIngredientesRecetas.DataSource = logica.LeerIngredienteReceta(id)
        }
    }
}
