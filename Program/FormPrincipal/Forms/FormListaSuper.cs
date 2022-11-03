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
    public partial class FormListaSuper : Form
    {
        private Super logica;
        public FormListaSuper()
        {
            InitializeComponent();
            logica = new Super();
        }     
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaSuper_Load(object sender, EventArgs e)
        {
            tscmbTipoProducto.ComboBox.DataSource = Enum.GetValues(typeof(TiposProducto));
            dgvListaSuper.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista();
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }
        public void CargarGrilla()
        {
            ActualizarGrilla();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                logica.AgregarStock(Convert.ToInt32(row.Cells["Id"].Value));
            }
            ActualizarGrilla();
            //obtener todos los datos que hay en el dgv y agregarles a sus cantidades con el metodo ya creado
        }

        private void filtro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
