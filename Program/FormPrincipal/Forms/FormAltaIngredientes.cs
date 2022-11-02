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
                    carne.Id = Convert.ToInt32(this.Id); ;
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
                case Ingredientes.Frutas:
                    Fruta fruta = new Fruta();
                    fruta.Id = Convert.ToInt32(this.Id); ;
                    fruta.Nombre = txtNombre.Text;
                    fruta.Precio = decimal.Parse(txtPrecio.Text);
                    fruta.PuntoPedido = double.Parse(txtStockPedido.Text);
                    fruta.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(fruta);
                    break;
                case Ingredientes.Hortalizas_y_Verduras:
                    Hortaliza hortaliza = new Hortaliza();
                    hortaliza.Id = Convert.ToInt32(this.Id); ;
                    hortaliza.Nombre = txtNombre.Text;
                    hortaliza.Precio = decimal.Parse(txtPrecio.Text);
                    hortaliza.PuntoPedido = double.Parse(txtStockPedido.Text);
                    hortaliza.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(hortaliza);
                    break;
                case Ingredientes.Lacteos:
                    Lacteo lacteo = new Lacteo();
                    lacteo.Id = Convert.ToInt32(this.Id); ;
                    lacteo.Nombre = txtNombre.Text;
                    lacteo.Precio = decimal.Parse(txtPrecio.Text);
                    lacteo.PuntoPedido = double.Parse(txtStockPedido.Text);
                    lacteo.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(lacteo);
                    break;
                case Ingredientes.Panaderia:
                    Panaderia panaderia = new Panaderia();
                    panaderia.Id = Convert.ToInt32(this.Id); ;
                    panaderia.Nombre = txtNombre.Text;
                    panaderia.Precio = decimal.Parse(txtPrecio.Text);
                    panaderia.PuntoPedido = double.Parse(txtStockPedido.Text);
                    panaderia.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(panaderia);
                    break;
                case Ingredientes.Pescados:
                    Pescado pescado = new Pescado();
                    pescado.Id = Convert.ToInt32(this.Id); ;
                    pescado.Nombre = txtNombre.Text;
                    pescado.Precio = decimal.Parse(txtPrecio.Text);
                    pescado.PuntoPedido = double.Parse(txtStockPedido.Text);
                    pescado.Cantidad = double.Parse(txtCantidad.Text);
                    logica.GuardarActualizarProducto(pescado);
                    break;
                case Ingredientes.Quesos:
                    Queso queso = new Queso();
                    queso.Id = Convert.ToInt32(this.Id); ;
                    queso.Nombre = txtNombre.Text;
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
            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio) || txtPrecio.Text == "")
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
                //CmbBoxCategoria.Text = producto.
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                txtStockPedido.Text = producto.PuntoPedido.ToString();
            }
        }


    }
}
