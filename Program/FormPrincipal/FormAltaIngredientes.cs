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
        public enum Ingredientes
        {
            Hortalizas_y_Verduras, Frutas, Quesos, Lacteos, Carnes, Pescados,
            Panaderia, Bebidas_Alta_en_Azucar, Bebidas_Normal,
            Bebidas_Alcoholicas
        }
        public FormAltaIngredientes()
        {
            InitializeComponent();
            logica = new Despensa();
        }

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
            if (validarNombre() == false)
            {
                return;
            }
            if (validarCategoria() == false)
            {
                return;
            }
            if (validarCandtidad() == false)
            {
                return;
            }
            if (validarPrecio() == false)
            {
                return;
            }
            if (validarStockMinimo() == false)
            {
                return;
            }
            
            Enum.TryParse(CmbBoxCategoria.Text, out Ingredientes tipo);
            switch (tipo)
            {   
                case Ingredientes.Carnes:
                    Carne carne = new Carne();
                    carne.Id = Convert.ToInt32(this.Id);
                    carne.Nombre = txtNombre.Text;
                    carne.Precio = decimal.Parse(txtPrecio.Text) ;
                    carne.PuntoPedido = double.Parse(txtStockPedido.Text);
                    carne.Cantidad = double.Parse(txtCantidad.Text);                  
                    logica.GuardarActualizarProducto(carne);
                    break;
                case Ingredientes.Bebidas_Normal:
                    Bebida bebidaN = new Bebida();
                    bebidaN.Id = Convert.ToInt32(this.Id);
                    bebidaN.Nombre = txtNombre.Text;
                    bebidaN.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaN.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaN.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaN.TipoBebida = bebidaN.TiposBebidas(0);
                    logica.GuardarActualizarProducto(bebidaN);
                    break;
                case Ingredientes.Bebidas_Alta_en_Azucar:
                    Bebida bebidaAA = new Bebida();
                    bebidaAA.Id = Convert.ToInt32(this.Id);
                    bebidaAA.Nombre = txtNombre.Text;
                    bebidaAA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaAA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaAA.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaAA.TipoBebida = bebidaAA.TiposBebidas(1);
                    logica.GuardarActualizarProducto(bebidaAA);
                    break;
                case Ingredientes.Bebidas_Alcoholicas:
                    Bebida bebidaA = new Bebida();
                    bebidaA.Id = Convert.ToInt32(this.Id);
                    bebidaA.Nombre = txtNombre.Text;
                    bebidaA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaA.Cantidad = int.Parse(txtCantidad.Text);
                    bebidaA.TipoBebida = bebidaA.TiposBebidas(2);
                    logica.GuardarActualizarProducto(bebidaA);
                    break;
            }
            //falta interface, donde owner es FormDespensa para llamara cargargrilla
            //falta metodo en la logica donde dependiendo de si el codigo es nulo o no Guarde o Actualize el registro
            this.Close();
        }

        private bool validarStockMinimo()
        {
            int stockMinimo;
            if (!int.TryParse(txtStockPedido.Text, out stockMinimo) || txtStockPedido.Text == "")
            {
                erpError.SetError(txtStockPedido, "Debe ingresar un valor numerico");
                return false;
            }
            else
            {
                erpError.SetError(txtStockPedido, "");
                return true;
            }
        }

        private bool validarPrecio()
        {
            int precio;
            if (!int.TryParse(txtPrecio.Text, out precio) || txtPrecio.Text == "")
            {
                erpError.SetError(txtPrecio, "Debe ingresar un valor numerico");
                return false;
            }
            else
            {
                erpError.SetError(txtPrecio, "");
                return true;
            }
        }

        private bool validarCandtidad()
        {
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || txtCantidad.Text == "")
            {
                erpError.SetError(txtCantidad, "Debe ingresar un valor numerico");
                return false;
            }
            else
            {
                erpError.SetError(txtCantidad, "");
                return true;
            }
        }

        private bool validarCategoria()
        {
            if (string.IsNullOrEmpty(CmbBoxCategoria.Text))
            {
                erpError.SetError(CmbBoxCategoria, "Debe seleccionar una categoria");
                return false;
            }
            else
            {
                erpError.SetError(CmbBoxCategoria, "");
                return true;
            }
        }

        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        private void FormAltaIngredientes_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Id))
            {
                int id = Convert.ToInt32(Id);
                Producto producto = logica.Ingrediente(id);
                txtNombre.Text = producto.Nombre;
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                txtStockPedido.Text = producto.PuntoPedido.ToString();
            }
        }
    }
}
