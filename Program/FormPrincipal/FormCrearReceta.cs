using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormPrincipal.FormAltaIngredientes;
using LogicaPrincipal;

namespace FormPrincipal
{
    public partial class FormCrearReceta : Form
    {
        private ModuloReceta logica;
        public FormCrearReceta()
        {
            InitializeComponent();
            logica = new ModuloReceta();

        }
        public enum TiposComida { Desayuno, Almuerzo, Merienda, Cena }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearReceta_Load(object sender, EventArgs e)
        {
            dgvIngredientesRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvIngredientesRecetas.DataSource = null;
            dgvIngredientesRecetas.DataSource = logica.LeerProductos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarNombre() == false)
            {
                return;
            }
            if (validarTipoReceta() == false)
            {
                return;
            }
            
            Receta receta = new Receta();
            receta.Nombre = txtNombre.Text;
            receta.Saludable = checkbSaludable.Checked;
            Enum.TryParse(cmbTipoReceta.Text, out TiposComida tipo);
            switch (tipo)
            {
                case TiposComida.Desayuno:
                    receta.TipoComida = Receta.TiposComida.Desayuno;
                    break;
                case TiposComida.Almuerzo:
                    receta.TipoComida = Receta.TiposComida.Almuerzo;
                    break;
                case TiposComida.Merienda:
                    receta.TipoComida = Receta.TiposComida.Merienda;
                    break;
                case TiposComida.Cena:
                    receta.TipoComida = Receta.TiposComida.Cena;
                    break;
            }
            logica.GuardarReceta(receta);
            //con la interface, hacer owner a la ventana anterior, es decir, FormRecetas para llamar al metodo
            //CargarGrilla, asi se actualiza
        }

        private bool validarTipoReceta()
        {
            if (string.IsNullOrEmpty(cmbTipoReceta.Text))
            {
                erpError.SetError(cmbTipoReceta, "Debe ingresar un tipo de receta");
                return false;
            }
            else
            {
                erpError.SetError(cmbTipoReceta, "");
                return true;
            }
        }

        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        private void dgvIngredientesRecetas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredientesRecetas.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvIngredientesRecetas.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    DataGridViewCell celda = row.Cells["Id"] as DataGridViewCell;
                    int codigo = Convert.ToInt32(celda.Value);
                    logica.AgregarAListaCodigos(codigo);
                }
                else
                {
                    DataGridViewCell celda = row.Cells["Id"] as DataGridViewCell;
                    int codigo = Convert.ToInt32(celda.Value);
                    logica.EliminarAListaCodigos(codigo);
                }
            }
        }
    }
}
