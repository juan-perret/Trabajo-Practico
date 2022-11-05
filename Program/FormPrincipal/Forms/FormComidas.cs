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
    public partial class FormComidas : Form, ActualizarGrillaComidas
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
                    if (Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "CodigoReceta")].Value) == comida.CodigoReceta)
                    {
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas,"Nombre_Receta")].Value = comida.RecetaElegida.Nombre;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Tipo_de_comida")].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Saludable")].Value = comida.RecetaElegida.Saludable;
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
                    if (Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "CodigoReceta")].Value) == comida.CodigoReceta)
                    {
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Nombre_Receta")].Value = comida.RecetaElegida.Nombre;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Tipo_de_comida")].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Saludable")].Value = comida.RecetaElegida.Saludable;
                    }
                }
            }
        }
        private void ActualizarGrilla(TiposComida tipoComida)
        {
            dgvComidas.DataSource = null;
            List<Comida> comidas = logica.ObtenerComidasXTipo(tipoComida);
            dgvComidas.DataSource = comidas;
            foreach (Comida comida in comidas)
            {
                foreach (DataGridViewRow row in dgvComidas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "CodigoReceta")].Value) == comida.CodigoReceta)
                    {
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Nombre_Receta")].Value = comida.RecetaElegida.Nombre;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Tipo_de_comida")].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Saludable")].Value = comida.RecetaElegida.Saludable;
                    }
                }
            }
        }
        public void ActualizarGrilla(int idReceta)
        {
            dgvComidas.DataSource = null;
            List<Comida> comidas = logica.ObtenerComidasXReceta(idReceta);
            dgvComidas.DataSource = comidas;
            foreach (Comida comida in comidas)
            {
                foreach (DataGridViewRow row in dgvComidas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "CodigoReceta")].Value) == comida.CodigoReceta)
                    {
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Nombre_Receta")].Value = comida.RecetaElegida.Nombre;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Tipo_de_comida")].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Saludable")].Value = comida.RecetaElegida.Saludable;
                    }
                }
            }
        }
        public void ActualizarGrilla(DateTime fecha1, DateTime fecha2)
        {
            dgvComidas.DataSource = null;
            List<Comida> comidas = logica.ObtenerComidasXFecha(fecha1, fecha2);
            dgvComidas.DataSource = comidas;
            foreach (Comida comida in comidas)
            {
                foreach (DataGridViewRow row in dgvComidas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "CodigoReceta")].Value) == comida.CodigoReceta)
                    {
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Nombre_Receta")].Value = comida.RecetaElegida.Nombre;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Tipo_de_comida")].Value = comida.RecetaElegida.TipoComida;
                        row.Cells[UtilidadesGrilla.ObtenerIndice(dgvComidas, "Saludable")].Value = comida.RecetaElegida.Saludable;
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
        private void tsmiCena_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposComida.Cena);
        }
        private void tsmiAlmuerzo_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposComida.Almuerzo);
        }
        private void tsmiDesayuno_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposComida.Desayuno);
        }
        private void tsmiMerienda_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposComida.Merienda);
        }
        private void tsmiQuitarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void tsmiReceta_Click(object sender, EventArgs e)
        {
            FormComidaFiltroReceta formComidaFiltroReceta = new FormComidaFiltroReceta();
            formComidaFiltroReceta.ShowDialog(this);
            //ActualizarGrilla(idReceta);
        }

        private void tsmiFecha_Click(object sender, EventArgs e)
        {
            FormFiltroComidaFecha formFiltroComidaFecha = new FormFiltroComidaFecha();
            formFiltroComidaFecha.ShowDialog(this);
            //ActualizarGrilla(fecha1, fecha2)
        }
    }
}
