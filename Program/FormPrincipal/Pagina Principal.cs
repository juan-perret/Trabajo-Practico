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
    public partial class Pag_Principal : Form
    {
        public Pag_Principal()
        {
            InitializeComponent();
        }

        private void tusIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDespensa despensa = new FormDespensa();
            despensa.ShowDialog();
        }

        private void tusRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecetas recetas = new FormRecetas();
            recetas.ShowDialog();
        }

        private void tusComidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComidas comidas = new FormComidas();
            comidas.ShowDialog();
        }

        private void consultaLoQueTenesQueComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaSuper listaSuper = new FormListaSuper();
            listaSuper.ShowDialog();
        }

        private void cargaUnIngredienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaIngredientes altaIngredientes = new FormAltaIngredientes();
            altaIngredientes.ShowDialog();
        }

        private void btnCerrarProg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creaUnaRecetaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearReceta crearReceta = new FormCrearReceta();
            crearReceta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaUnaComidaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarComida registrarComida = new FormRegistrarComida();
            registrarComida.ShowDialog();
        }
    }
}
