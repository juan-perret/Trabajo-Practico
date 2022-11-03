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
            if(validarNombre() == false)
            {
                return;
            }
            if (validarTipoReceta() == false)
            {
                return;
            }          
            Receta receta = new Receta();
            receta.Id = Convert.ToInt32(id);
            receta.Nombre = txtNombre.Text;
            receta.Saludable = checkbSaludable.Checked;
            Enum.TryParse(cmbTipoReceta.Text, out TiposComida tipo);
            switch (tipo)
            {
                case TiposComida.Desayuno:
                    receta.TipoComida = tipo;
                    break;
                case TiposComida.Almuerzo:
                    receta.TipoComida = tipo;
                    break;
                case TiposComida.Merienda:
                    receta.TipoComida = tipo;
                    break;
                case TiposComida.Cena:
                    receta.TipoComida = tipo;
                    break;
            }
            logica.GuardarReceta(receta);
            ActualizarGrilla padre = this.Owner as ActualizarGrilla;
            if (padre != null)
            {
                padre.CargarGrilla();
            }
            this.Close();
          
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
