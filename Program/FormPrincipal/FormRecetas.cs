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
    public partial class FormRecetas : Form, ActualizarGrilla
    {
        private ModuloReceta logica;
        public FormRecetas()
        {
            InitializeComponent();
            logica = new ModuloReceta();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearReceta crearReceta = new FormCrearReceta();
            crearReceta.ShowDialog(this);
        }

        private void GridRecetas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvRecetas);
        }

        private void FormRecetas_Load(object sender, EventArgs e)
        {
            dgvRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvRecetas.DataSource = null;
            dgvRecetas.DataSource = logica.LeerRecetas();
        }

        public void CargarGrilla()
        {
            ActualizarGrilla();
        }

        private void dgvRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indiceEditar = UtilidadesGrilla.ObtenerIndice(dgvRecetas, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(dgvRecetas, "Eliminar");

            if (indiceEditar == e.ColumnIndex)
            {
                //hizo clic en editar
                var indiceId = UtilidadesGrilla.ObtenerIndice(dgvRecetas, "Id");
                var idIngrediente = dgvRecetas.Rows[e.RowIndex].Cells[indiceId].Value.ToString();

                FormCrearReceta formCrearReceta = new FormCrearReceta(idIngrediente);
                formCrearReceta.ShowDialog(this);
            }
            if (indiceEliminar == e.ColumnIndex)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    ModuloReceta receta = new ModuloReceta();
                    var indiceId = UtilidadesGrilla.ObtenerIndice(dgvRecetas, "Id");
                    var idIngrediente = dgvRecetas.Rows[e.RowIndex].Cells[indiceId].Value.ToString();

                    //eliminar registro
                    receta.EliminarReceta(idIngrediente);
                    ActualizarGrilla();
                }
            }
        }
    }
}
