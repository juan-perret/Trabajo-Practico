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
    public partial class FormDespensa : Form, ActualizarGrilla
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
            altaIngredientes.ShowDialog(this);
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

        private void dgvDespensa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = UtilidadesGrilla.ObtenerIndice(dgvDespensa, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(dgvDespensa, "Eliminar");

            if (indiceEditar == e.ColumnIndex)
            {
                //hizo clic en editar
                var indiceId = UtilidadesGrilla.ObtenerIndice(dgvDespensa, "Id");
                var idIngrediente = dgvDespensa.Rows[e.RowIndex].Cells[indiceId].Value.ToString();

                FormAltaIngredientes formAltaIngredientes = new FormAltaIngredientes(idIngrediente);
                formAltaIngredientes.ShowDialog(this);
            }
            if(indiceEliminar == e.ColumnIndex)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de que desea eliminar el registro?","Eliminar registro",MessageBoxButtons.OKCancel);
                if(resultado == DialogResult.OK)
                {
                    //eliminar registro
                    Despensa despensa = new Despensa();
                    var indiceId = UtilidadesGrilla.ObtenerIndice(dgvDespensa, "Id");
                    var idIngrediente = dgvDespensa.Rows[e.RowIndex].Cells[indiceId].Value.ToString();
                    despensa.EliminarProducto(idIngrediente);
                    ActualizarGrilla();
                }
            }
        }

       
    }
}
