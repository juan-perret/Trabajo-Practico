using LogicaPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormComidaFiltroReceta : Form
    {
        ModuloComida logica;
        public FormComidaFiltroReceta()
        {
            logica = new ModuloComida();
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void FormComidaFiltroReceta_Load(object sender, EventArgs e)
        {
            dgvComidaFiltroReceta.AutoGenerateColumns = false;
            dgvComidaFiltroReceta.DataSource = logica.LeerRecetas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(dgvComidaFiltroReceta.SelectedRows[0].Cells[UtilidadesGrilla.ObtenerIndice(dgvComidaFiltroReceta, "Id")].Value);
            this.Close();
            //ActualizarGrilla(idReceta);
        }
    }
}
