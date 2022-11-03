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
            ActualizarGrilla padre = this.Owner as ActualizarGrilla;
            if (padre != null)
            {
                padre.CargarGrilla();
            }
            this.Close();
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
            cmbFiltro.DataSource = Enum.GetValues(typeof(TiposComida));
            dgvSeleccionReceta.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvSeleccionReceta.DataSource = null;
            dgvSeleccionReceta.DataSource = logica.DevolverListaRecetasAccesibles();
        }
        private void ActualizarGrilla(TiposComida tipoComida)
        {
            dgvSeleccionReceta.DataSource = null;
            dgvSeleccionReceta.DataSource = logica.DevolverListaRecetasAccesiblesXFiltro(tipoComida);
        }
        private void cmbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Enum.TryParse(cmbFiltro.Text, out TiposComida tipo);
            ActualizarGrilla(tipo);
        }

        private void btn_QuitarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
