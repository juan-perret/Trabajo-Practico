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
    public partial class FormComidas : Form
    {
        private Comida logica;
        public FormComidas()
        {
            InitializeComponent();
            logica = new Comida();
        }

        private void registrarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarComida registrarComida = new FormRegistrarComida();
            registrarComida.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormComidas_Load(object sender, EventArgs e)
        {
            dgvComidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void dgvComidas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvComidas);
        }

        private void ActualizarGrilla()
        {
            dgvComidas.DataSource = null;
            //dgvComidas.DataSource = logica.LeerProductos();
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }
    }
}
