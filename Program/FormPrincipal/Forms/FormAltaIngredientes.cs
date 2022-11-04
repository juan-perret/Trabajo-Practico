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
            switch (tipo)
            {   
                case TiposProducto.Carnes:
                    Carne carne = new Carne();
                    carne.Id = Convert.ToInt32(this.Id); ;
                    carne.Nombre = txtNombre.Text;
                    carne.TipoProducto = tipo;
                    carne.Precio = decimal.Parse(txtPrecio.Text) ;
                    carne.PuntoPedido = double.Parse(txtStockPedido.Text);
                    carne.Cantidad = double.Parse(txtCantidad.Text); 
                    break;
                case TiposProducto.Bebidas_Normal:
                    Bebida bebidaN = new Bebida();
                    bebidaN.Id = Convert.ToInt32(this.Id);
                    bebidaN.Nombre = txtNombre.Text;
                    bebidaN.TipoProducto = tipo;
                    bebidaN.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaN.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaN.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaN.TipoBebida = VariedadBebida.normal;
                    logica.GuardarActualizarProducto(bebidaN);
                    break;
                case TiposProducto.Bebidas_Alta_en_Azucar:
                    Bebida bebidaAA = new Bebida();
                    bebidaAA.Id = Convert.ToInt32(this.Id);
                    bebidaAA.Nombre = txtNombre.Text;
                    bebidaAA.TipoProducto = tipo;
                    bebidaAA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaAA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaAA.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaAA.TipoBebida = VariedadBebida.altaEnAzucar;
                    logica.GuardarActualizarProducto(bebidaAA);
                    break;
                case TiposProducto.Bebidas_Alcoholicas:
                    Bebida bebidaA = new Bebida();
                    bebidaA.Id = Convert.ToInt32(this.Id);
                    bebidaA.Nombre = txtNombre.Text;
                    bebidaA.TipoProducto = tipo;
                    bebidaA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaA.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaA.TipoBebida = VariedadBebida.alcoholica;
                    logica.GuardarActualizarProducto(bebidaA);
                    break;
                case TiposProducto.Frutas:
                    Fruta fruta = new Fruta();
                    fruta.Id = Convert.ToInt32(this.Id); ;
                    fruta.Nombre = txtNombre.Text;
                    fruta.TipoProducto = tipo;
                    fruta.Precio = decimal.Parse(txtPrecio.Text);
                    fruta.PuntoPedido = double.Parse(txtStockPedido.Text);
                    fruta.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(fruta);
                    break;
                case TiposProducto.Hortalizas_y_Verduras:
                    Hortaliza hortaliza = new Hortaliza();
                    hortaliza.Id = Convert.ToInt32(this.Id); ;
                    hortaliza.Nombre = txtNombre.Text;
                    hortaliza.TipoProducto = tipo;
                    hortaliza.Precio = decimal.Parse(txtPrecio.Text);
                    hortaliza.PuntoPedido = double.Parse(txtStockPedido.Text);
                    hortaliza.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(hortaliza);
                    break;
                case TiposProducto.Lacteos:
                    Lacteo lacteo = new Lacteo();
                    lacteo.Id = Convert.ToInt32(this.Id); ;
                    lacteo.Nombre = txtNombre.Text;
                    lacteo.TipoProducto = tipo;
                    lacteo.Precio = decimal.Parse(txtPrecio.Text);
                    lacteo.PuntoPedido = double.Parse(txtStockPedido.Text);
                    lacteo.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(lacteo);
                    break;
                case TiposProducto.Panaderia:
                    Panaderia panaderia = new Panaderia();
                    panaderia.Id = Convert.ToInt32(this.Id); ;
                    panaderia.Nombre = txtNombre.Text;
                    panaderia.TipoProducto = tipo;
                    panaderia.Precio = decimal.Parse(txtPrecio.Text);
                    panaderia.PuntoPedido = double.Parse(txtStockPedido.Text);
                    panaderia.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(panaderia);
                    break;
                case TiposProducto.Pescados:
                    Pescado pescado = new Pescado();
                    pescado.Id = Convert.ToInt32(this.Id); ;
                    pescado.Nombre = txtNombre.Text;
                    pescado.TipoProducto = tipo;
                    pescado.Precio = decimal.Parse(txtPrecio.Text);
                    pescado.PuntoPedido = double.Parse(txtStockPedido.Text);
                    pescado.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(pescado);
                    break;
                case TiposProducto.Quesos:
                    Queso queso = new Queso();
                    queso.Id = Convert.ToInt32(this.Id); ;
                    queso.Nombre = txtNombre.Text;
                    queso.TipoProducto = tipo;
                    queso.Precio = decimal.Parse(txtPrecio.Text);
                    queso.PuntoPedido = double.Parse(txtStockPedido.Text);
                    queso.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(queso);
                    break;
            }
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
