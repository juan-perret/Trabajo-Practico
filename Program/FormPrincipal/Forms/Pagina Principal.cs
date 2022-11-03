using System;
using System.Windows.Forms;

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
            despensa.ShowDialog(this);
        }

        private void tusRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecetas recetas = new FormRecetas();
            recetas.ShowDialog(this);
        }

        private void tusComidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComidas comidas = new FormComidas();
            comidas.ShowDialog(this);
        }

        private void consultaLoQueTenesQueComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaSuper listaSuper = new FormListaSuper();
            listaSuper.ShowDialog(this);
        }

        private void cargaUnIngredienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaIngredientes altaIngredientes = new FormAltaIngredientes();
            altaIngredientes.ShowDialog(this);
        }

        private void btnCerrarProg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creaUnaRecetaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearReceta crearReceta = new FormCrearReceta();
            crearReceta.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaUnaComidaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarComida registrarComida = new FormRegistrarComida();
            registrarComida.ShowDialog(this);
        }

    }
}
