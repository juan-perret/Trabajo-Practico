using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPrincipal.Forms;
using LogicaPrincipal;

namespace FormPrincipal
{
    public partial class FormListaSuper : Form , ActualizarGrillaSuper
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
                logica.AgregarStock(Convert.ToInt32(row.Cells[UtilidadesGrilla.ObtenerIndice(dgvListaSuper, "Id")].Value));
            }
            ActualizarGrilla();
            //obtener todos los datos que hay en el dgv y agregarles a sus cantidades con el metodo ya creado
            //falta ver que compra por partes

        }

        private void filtro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarGrilla(TiposProducto tipoProducto)
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista(tipoProducto);
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }
        private void ActualizarGrilla(string unidadMedida)
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista(unidadMedida);
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }
        public void ActualizarGrilla(decimal costo, bool max)
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista(costo, max);
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }
        public void ActualizarGrilla(int puntoPedido, bool max)
        {
            decimal total = 0;
            dgvListaSuper.DataSource = null;
            dgvListaSuper.DataSource = logica.DevolverLista(puntoPedido, max);
            foreach (DataGridViewRow row in dgvListaSuper.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
                total += Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Punto_de_Pedido"].Value);
            }
            lblResultadoTotal.Text = Convert.ToString(total);
        }

        private void tsmiHortalizasYVerduras_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Hortalizas_y_Verduras);
        }

        private void tsmiFruta_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Frutas);
        }

        private void tsmiQueso_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Quesos);
        }

        private void tsmiLacteo_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Lacteos);
        }

        private void tsmiCarnes_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Carnes);
        }

        private void tsmiPescado_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Pescados);
        }

        private void tsmiPanaderia_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Panaderia);
        }

        private void tsmiBebidaAltaAzucar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Bebidas_Alta_en_Azucar);
        }

        private void tsmiBebidaNormal_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Bebidas_Normal);
        }

        private void tsmiBebidaAlcoholica_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(TiposProducto.Bebidas_Alcoholicas);
        }

        private void tsmiQuitarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void tsmiCosto_Click(object sender, EventArgs e)
        {
            SuperXCosto superXCosto = new SuperXCosto();
            superXCosto.ShowDialog(this);
        }

        private void kilogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarGrilla("Kilogramo");
        }

        private void litrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarGrilla("Litros");
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarGrilla("Unidad");
        }

        private void tsmiPuntoPedido_Click(object sender, EventArgs e)
        {
            SuperXPuntoPedido puntoPedido = new SuperXPuntoPedido();
            puntoPedido.ShowDialog(this);
        }
    }
}
