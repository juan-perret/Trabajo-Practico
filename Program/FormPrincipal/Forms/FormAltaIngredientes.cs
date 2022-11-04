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
    public partial class FormAltaIngredientes : Form
    {
        private Despensa logica;
        private string Id { get; set; }
        public FormAltaIngredientes()
        {
            InitializeComponent();
            logica = new Despensa();
        }
        //Maskedtextbox
        public FormAltaIngredientes(string Id)
        {
            InitializeComponent();
            logica = new Despensa();
            this.Id = Id;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Enum.TryParse(CmbBoxCategoria.Text, out TiposProducto tipo);
            logica.ValidarDatos(this.Id, txtNombre.Text, tipo, decimal.Parse(txtPrecio.Text), int.Parse(txtStockPedido.Text), double.Parse(txtCantidad.Text));
            ActualizarGrilla padre = this.Owner as ActualizarGrilla;
            if (padre != null)
            {
                padre.CargarGrilla();
            }
            this.Close();
        }


        private void FormAltaIngredientes_Load(object sender, EventArgs e)
        {
           
            CmbBoxCategoria.DataSource = Enum.GetValues(typeof(TiposProducto));
            if (!string.IsNullOrEmpty(Id))
            {
                int id = Convert.ToInt32(Id);
                Producto producto = logica.Ingrediente(id);
                txtNombre.Text = producto.Nombre;
                CmbBoxCategoria.Text = producto.TipoProducto.ToString();
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                txtStockPedido.Text = producto.PuntoPedido.ToString();
            }
        }

        
    }
}
