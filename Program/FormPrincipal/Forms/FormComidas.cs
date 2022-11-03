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
    public partial class FormComidas : Form, ActualizarGrilla
    {
        private ModuloComida logica;
        public FormComidas()
        {
            InitializeComponent();
            logica = new ModuloComida();
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
        private void ActualizarGrilla()
        {
            dgvComidas.DataSource = null;
            List<Comida> comidas = logica.LeerComidas();
            dgvComidas.DataSource = comidas;
            foreach (Comida comida in comidas)
            {
                foreach(DataGridViewRow row in dgvComidas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == comida.CodigoReceta)
                    {
                        row.Cells[2].Value = comida.RecetaElegida.Nombre;
                        row.Cells[3].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[4].Value = comida.RecetaElegida.Saludable;
                    }
                }               
            }
        }
        private void ActualizarGrilla(bool saludable)
        {
            dgvComidas.DataSource = null;
            List<Comida> comidas = logica.ObtenerComidasSaludables(saludable);
            dgvComidas.DataSource = comidas;
            foreach (Comida comida in comidas)
            {
                foreach (DataGridViewRow row in dgvComidas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == comida.CodigoReceta)
                    {
                        row.Cells[2].Value = comida.RecetaElegida.Nombre;
                        row.Cells[3].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[4].Value = comida.RecetaElegida.Saludable;
                    }
                }
            }
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }

        private void tsmiSiSaludable_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(true);
        }

        private void tsmiNoSaludable_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(false);
        }
    }
}
