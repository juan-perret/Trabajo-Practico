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
            comida.CodigoReceta = Convert.ToInt32(dgvSeleccionReceta.SelectedRows[0].Cells[0].Value);
            logica.GuardarComida(comida);
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
        private void FormRegistrarComida_Load(object sender, EventArgs e)
        {
            dgvSeleccionReceta.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvSeleccionReceta.DataSource = null;
            List<Receta> recetas = logica.LeerRecetas();
            List<Producto> stockProductos = logica.LeerProductos();
            List<Receta> recetasAMostrar = new List<Receta>();
            foreach (Receta rec in recetas)
            {
                bool noCantidad = false;
                foreach (Producto p in stockProductos)
                {
                    int indice = rec.CodigosIngredientes.FindIndex(x=>x == p.Id);
                    if (indice != -1 )
                    {
                        if (p.Cantidad < (rec.CantidadXIngrediente)[indice])
                        {
                            noCantidad = true;
                            break;
                        }
                    }                   
                }
                if (!noCantidad)
                {
                    recetasAMostrar.Add(rec);
                }
            }
            dgvSeleccionReceta.DataSource = recetasAMostrar;
        }
    }
}
