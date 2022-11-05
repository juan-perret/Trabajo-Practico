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
        private string id { get; set; }

        public FormCrearReceta()
        {
            InitializeComponent();
            logica = new ModuloReceta();

        }

        public FormCrearReceta(string id)
        {
            InitializeComponent();
            logica = new ModuloReceta();
            this.id = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearReceta_Load(object sender, EventArgs e)
        {
            cmbTipoReceta.DataSource = Enum.GetValues(typeof(TiposComida));
            dgvIngredientesRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
            if (!string.IsNullOrEmpty(id))
            {
                int Id = Convert.ToInt32(id);
                Receta receta = logica.DevolverReceta(Id);
                txtNombre.Text = receta.Nombre;
                cmbTipoReceta.Text = receta.TipoComida.ToString();
                checkbSaludable.Checked = receta.Saludable;
                foreach (int id in receta.CodigosIngredientes)
                {
                    for (int fila = 0; fila < dgvIngredientesRecetas.Rows.Count; fila++)
                    {
                        if (Convert.ToInt32(dgvIngredientesRecetas.Rows[fila].Cells["Id"].Value) == id)
                        {
                            dgvIngredientesRecetas.Rows[fila].Cells["Cantidad"].Value = receta.CantidadXIngrediente[receta.CodigosIngredientes.FindIndex(x=>x == id)];
                            dgvIngredientesRecetas.Rows[fila].Cells["Seleccion"].Value = true;
                            break;
                        }
                    }                      
                }
                //falta igualar las listas de ingredientes
            }
        }
        private void ActualizarGrilla()
        {
            dgvIngredientesRecetas.DataSource = null;
            dgvIngredientesRecetas.DataSource = logica.LeerProductos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Enum.TryParse(cmbTipoReceta.Text, out TiposComida tipo);
            string resutlado = logica.ValidadDatos(this.id, txtNombre.Text, checkbSaludable.Checked,tipo);
            MessageBox.Show(resutlado);
            ActualizarGrilla padre = this.Owner as ActualizarGrilla;
            if (padre != null)
            {
                padre.CargarGrilla();
            }
            this.Close();
            if(resutlado == "La receta se ha guardado correctamente")
                this.Close();
            
        }

       

        private void dgvIngredientesRecetas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredientesRecetas.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvIngredientesRecetas.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                DataGridViewCell cellCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    if (cellCantidad.Value != null)
                    {
                        DataGridViewCell celdaCodigo = row.Cells["Id"] as DataGridViewCell;
                        int codigo = Convert.ToInt32(celdaCodigo.Value);
                        DataGridViewCell celdaCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                        double cantidad = Convert.ToInt32(celdaCantidad.Value);
                        logica.AgregarAListaCodigos(codigo, cantidad);
                    }
                }
                else
                {
                    DataGridViewCell celdaCodigo = row.Cells["Id"] as DataGridViewCell;
                    int codigo = Convert.ToInt32(celdaCodigo.Value);
                    logica.EliminarAListaCodigos(codigo);
                }
            }
            if (dgvIngredientesRecetas.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dgvIngredientesRecetas.Rows[e.RowIndex];
                DataGridViewCell cellCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                if(cellCantidad.Value != null)
                {
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        DataGridViewCell celdaCodigo = row.Cells["Id"] as DataGridViewCell;
                        int codigo = Convert.ToInt32(celdaCodigo.Value);
                        DataGridViewCell celdaCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                        double cantidad = Convert.ToInt32(celdaCantidad.Value);
                        logica.AgregarAListaCodigos(codigo, cantidad);
                    }
                }
                else
                {
                    DataGridViewCell celdaCodigo = row.Cells["Id"] as DataGridViewCell;
                    int codigo = Convert.ToInt32(celdaCodigo.Value);
                    logica.EliminarAListaCodigos(codigo);
                }
            }
            
        }
    }
}
