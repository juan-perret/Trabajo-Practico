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
    public partial class FormRegistrarComida : Form
    {
        private ModuloComida logica;
        public FormRegistrarComida()
        {
            InitializeComponent();
            logica = new ModuloComida();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarFiltro() == false)
            {
                return;
            }
            Comida comida = new Comida();
            comida.FechaDeRegistro = dtpFechaComida.Value;
            //Faltar agregar lista de recetas que poseen los ingredientes necesarios
            //para su creacion, y agregarlos a comida.RecetaElegida y comida.CodigoReceta
        }

        private bool validarFiltro()
        {
            if (string.IsNullOrEmpty(cmbFiltro.Text))
            {
                erpError.SetError(cmbFiltro, "Debe seleccionar un filtro");
                return false;
            }
            else
            {
                erpError.SetError(cmbFiltro, "");
                return true;
            }
        }

        private void dgvSeleccionReceta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeleccionReceta.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvSeleccionReceta.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    DataGridViewCell celda = row.Cells["Id"] as DataGridViewCell;
                    int codigo = Convert.ToInt32(celda.Value);

                }
            }
        }

        private void FormRegistrarComida_Load(object sender, EventArgs e)
        {
            dgvSeleccionReceta.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvSeleccionReceta.DataSource = null;
            List<Receta> recetasAMostrar = logica.LeerRecetas();
            List<Producto> stockProductos = logica.LeerProductos();
            foreach (Receta rec in recetasAMostrar)
            {
                foreach (Producto p in stockProductos)
                {
                    if (p.Cantidad<p.Cantidad/* aca iria cantidad que se necesita para la receta*/)
                    {
                        recetasAMostrar.Remove(rec);
                        break;
                    }
                }
            }
            dgvSeleccionReceta.DataSource = recetasAMostrar;
        }
    }
}
