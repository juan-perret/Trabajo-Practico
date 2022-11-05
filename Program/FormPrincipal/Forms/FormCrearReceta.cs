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
            string resultado2 = ValidarCantidad();
            string resultado = logica.ValidadDatos(this.id, txtNombre.Text, checkbSaludable.Checked,tipo, resultado2);
            if (resultado == "La receta se ha guardado correctamente")
            {
                if(resultado2 == "La receta se ha creado correctamente")
                {
                    MessageBox.Show(resultado);
                    this.Close();
                }
                else
                    MessageBox.Show(resultado2);
            }
            else
            {
                MessageBox.Show(resultado);
            }    
            ActualizarGrilla padre = this.Owner as ActualizarGrilla;
            if (padre != null)
            {
                padre.CargarGrilla();
            }
            
            
        }
        public string ValidarCantidad()
        {
            int indiceAgregar = UtilidadesGrilla.ObtenerIndice(dgvIngredientesRecetas, "Seleccion");
            int indiceCantidad = UtilidadesGrilla.ObtenerIndice(dgvIngredientesRecetas, "Cantidad");
            double numero;
            foreach (DataGridViewRow row in dgvIngredientesRecetas.Rows)
            {
                if (row.Cells[indiceAgregar].Value != null)
                {
                    if (row.Cells[indiceCantidad].Value == null)
                    {
                        return "Debe ingresar una cantidad";
                    }
                    else if (double.TryParse(row.Cells[indiceCantidad].Value.ToString(), out numero ) == false)
                    {
                        return "Debe ingresar valor numerico para la cantidad";
                    }
                    else if (Convert.ToDouble(row.Cells[indiceCantidad].Value) <= 0)
                    {
                        return "El valor ingresado debe ser mayor que 0";
                    }
                    
                }
            }
            return "La receta se ha creado correctamente";
        }
        private void dgvIngredientesRecetas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double numero;
            if (dgvIngredientesRecetas.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvIngredientesRecetas.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                DataGridViewCell cellCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    if (cellCantidad.Value != null)
                    {
                        if (double.TryParse(cellCantidad.Value.ToString(), out numero) == false)
                        {
                            MessageBox.Show("Verificar el valor de cantidad este correctamente ingresado");
                        }
                        else
                        {
                            DataGridViewCell celdaCodigo = row.Cells["Id"] as DataGridViewCell;
                            int codigo = Convert.ToInt32(celdaCodigo.Value);
                            DataGridViewCell celdaCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                            double cantidad = Convert.ToInt32(celdaCantidad.Value);
                            logica.AgregarAListaCodigos(codigo, cantidad);
                        }                       
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
                    if (double.TryParse(cellCantidad.Value.ToString(), out numero) == false)
                    {
                        MessageBox.Show("Verificar el valor de cantidad este correctamente ingresado");
                    }
                    else if (Convert.ToBoolean(cellSeleccion.Value))
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
