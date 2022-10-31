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
    }
}
