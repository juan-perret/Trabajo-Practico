using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace LogicaPrincipal
{
    public class Despensa : Archivo
    {       
        List<Producto> despensa = new List<Producto>();
        int id = 0;
        public Despensa()
        {
            despensa = LeerProductos();
            if (despensa.Count != 0)
            {
                id = despensa.Max(x=>x.Id);
            }
        }
        
        public void GuardarActualizarProducto(Producto ingrediente)
        {
                if (ingrediente.Id == 0)
                {
                    ingrediente.Id = id + 1;
                    despensa.Add(ingrediente);
                    EscribirProducto(despensa);
                    id += 1;
                }
                else
                {
                    foreach (Producto producto in despensa)
                    {
                        if (producto.Id == ingrediente.Id)
                        {
                            producto.Id = ingrediente.Id;
                            producto.Nombre = ingrediente.Nombre;
                            producto.TipoProducto = ingrediente.TipoProducto;
                            producto.Cantidad = ingrediente.Cantidad;
                            producto.PuntoPedido = ingrediente.PuntoPedido;
                            producto.Precio = ingrediente.Precio;
                            EscribirProducto(despensa);
                        }
                    }
                } 
        }
        public void CrearIngrediente(string id, string nombre, TiposProducto tipo, string Precio, string PuntoPedido, string Cantidad)
        {
            
            decimal precio = Convert.ToDecimal(Precio);
            int puntoPedido = Convert.ToInt32(PuntoPedido);
            double cantidad = Convert.ToDouble(Cantidad);
            switch (tipo)
            {
                case TiposProducto.Carnes:
                    Carne carne = new Carne();
                    carne.Id = Convert.ToInt32(id); ;
                    carne.Nombre = nombre;
                    carne.TipoProducto = tipo;
                    carne.Precio = precio;
                    carne.PuntoPedido = puntoPedido;
                    carne.Cantidad = cantidad;
                    GuardarActualizarProducto(carne);
                    break;
                case TiposProducto.Bebidas_Normal:
                    Bebida bebidaN = new Bebida();
                    bebidaN.Id = Convert.ToInt32(id);
                    bebidaN.Nombre = nombre;
                    bebidaN.TipoProducto = tipo;
                    bebidaN.Precio = precio;
                    bebidaN.PuntoPedido = puntoPedido;
                    bebidaN.Cantidad = cantidad;
                    bebidaN.TipoBebida = VariedadBebida.normal;
                    GuardarActualizarProducto(bebidaN);
                    break;
                case TiposProducto.Bebidas_Alta_en_Azucar:
                    Bebida bebidaAA = new Bebida();
                    bebidaAA.Id = Convert.ToInt32(id);
                    bebidaAA.Nombre = nombre;
                    bebidaAA.TipoProducto = tipo;
                    bebidaAA.Precio = precio;
                    bebidaAA.PuntoPedido = puntoPedido;
                    bebidaAA.Cantidad = cantidad;
                    bebidaAA.TipoBebida = VariedadBebida.altaEnAzucar;
                    GuardarActualizarProducto(bebidaAA);
                    break;
                case TiposProducto.Bebidas_Alcoholicas:
                    Bebida bebidaA = new Bebida();
                    bebidaA.Id = Convert.ToInt32(id);
                    bebidaA.Nombre = nombre;
                    bebidaA.TipoProducto = tipo;
                    bebidaA.Precio = precio;
                    bebidaA.PuntoPedido = puntoPedido;
                    bebidaA.Cantidad = cantidad;
                    bebidaA.TipoBebida = VariedadBebida.alcoholica;
                    GuardarActualizarProducto(bebidaA);
                    break;
                case TiposProducto.Frutas:
                    Fruta fruta = new Fruta();
                    fruta.Id = Convert.ToInt32(id); ;
                    fruta.Nombre = nombre;
                    fruta.TipoProducto = tipo;
                    fruta.Precio = precio;
                    fruta.PuntoPedido = puntoPedido;
                    fruta.Cantidad = cantidad;
                    GuardarActualizarProducto(fruta);
                    break;
                case TiposProducto.Hortalizas_y_Verduras:
                    Hortaliza hortaliza = new Hortaliza();
                    hortaliza.Id = Convert.ToInt32(id); ;
                    hortaliza.Nombre = nombre;
                    hortaliza.TipoProducto = tipo;
                    hortaliza.Precio = precio;
                    hortaliza.PuntoPedido = puntoPedido;
                    hortaliza.Cantidad = cantidad;
                    GuardarActualizarProducto(hortaliza);
                    break;
                case TiposProducto.Lacteos:
                    Lacteo lacteo = new Lacteo();
                    lacteo.Id = Convert.ToInt32(id); ;
                    lacteo.Nombre = nombre;
                    lacteo.TipoProducto = tipo;
                    lacteo.Precio = precio;
                    lacteo.PuntoPedido = puntoPedido;
                    lacteo.Cantidad = cantidad;
                    GuardarActualizarProducto(lacteo);
                    break;
                case TiposProducto.Panaderia:
                    Panaderia panaderia = new Panaderia();
                    panaderia.Id = Convert.ToInt32(id); ;
                    panaderia.Nombre = nombre;
                    panaderia.TipoProducto = tipo;
                    panaderia.Precio = precio;
                    panaderia.PuntoPedido = puntoPedido;
                    panaderia.Cantidad = cantidad;
                    GuardarActualizarProducto(panaderia);
                    break;
                case TiposProducto.Pescados:
                    Pescado pescado = new Pescado();
                    pescado.Id = Convert.ToInt32(id); ;
                    pescado.Nombre = nombre;
                    pescado.TipoProducto = tipo;
                    pescado.Precio = precio;
                    pescado.PuntoPedido = puntoPedido;
                    pescado.Cantidad = cantidad;
                    GuardarActualizarProducto(pescado);
                    break;
                case TiposProducto.Quesos:
                    Queso queso = new Queso();
                    queso.Id = Convert.ToInt32(id); ;
                    queso.Nombre = nombre;
                    queso.TipoProducto = tipo;
                    queso.Precio = precio;
                    queso.PuntoPedido = puntoPedido;
                    queso.Cantidad = cantidad;
                    GuardarActualizarProducto(queso);
                    break;
            }
        }
        public string ValidarDatos(string id, string nombre, TiposProducto tipo, string precio, string puntoPedido, string cantidad)
        {
            
            try
            {
                double numero;
                decimal numero1;
                int numero2;
                //validar nombre
                if (string.IsNullOrEmpty(nombre) || int.TryParse(nombre, out numero2) == true)
                {
                    return "Verificar que el nombre este correctamente ingresado";
                }
                //validar categoria
                else if(string.IsNullOrEmpty(tipo.ToString()))
                {
                    return "Verificar que la categoria este correctamente ingresado";
                }
                //validar cantidad
                else if (double.TryParse(cantidad.ToString(), out numero) == false)
                {
                    return "Verificar que la cantidad este correctamente ingresado";
                }
                //precio
                else if (decimal.TryParse(precio, out numero1) == false)
                {
                    return "Verificar que el precio este correctamente ingresado";
                }
                //validar punto de pedido
                else if (int.TryParse(puntoPedido, out numero2) == false)
                {
                    return "Verificar que el punto de pedido este correctamente ingresado";
                }
                //CrearIngrediente(id, nombre, tipo, precio, puntoPedido, cantidad);
                else
                {
                    CrearIngrediente( id,  nombre,  tipo,  precio,  puntoPedido,  cantidad);
                    return "El ingrediente se cargo correctamente";
                }
            }
            catch (Exception ex)
            {
                return "Completar todos los campos";
            }
        }

        public Producto Ingrediente(int idBuscado)
        {
            Producto producto = despensa.Find(x => x.Id == idBuscado);
            return producto;
        }
        //Metodo que devuelva lista<productos> que esten bajo de su
        //punto de pedido 
        public List<Producto> ProductosAComprar()
        {
            List<Producto> listaAComprar = new List<Producto>();
            foreach (Producto p in despensa)
            {
                if (p.Cantidad < p.PuntoPedido)
                {
                    listaAComprar.Add(p);
                }
            }
            return listaAComprar;
        }
        public List<Producto> ProductosAComprarPorTipo(TiposProducto tipoProducto)
        {
            List<Producto> listaAComprar = new List<Producto>();
            foreach (Producto p in despensa)
            {
                if (p.Cantidad <= p.PuntoPedido && p.TipoProducto == tipoProducto)
                {
                    listaAComprar.Add(p);
                }
            }
            return listaAComprar;   
        }
        //
        //Metodos para recetas
        public void EliminarCantidadProducto(int idProducto, double cantidad)
        {
            Producto producto = Ingrediente(idProducto);
            producto.Cantidad -= cantidad;
            GuardarActualizarProducto(producto);
        }
        public void EliminarProducto(string idIngrediente)
        {
            List<Producto> productos = LeerProductos();
            foreach (Producto p in productos)
            {
                if(p.Id == Convert.ToInt32(idIngrediente))
                {
                    productos.Remove(p);
                    ModuloReceta moduloReceta = new ModuloReceta();
                    moduloReceta.EliminarRecetaXIngredienteFaltante(Convert.ToInt32(idIngrediente));
                    EscribirProducto(productos);
                    break;
                }
            }
        }
        //
        //Para el super
        //
        public void AgregarIngredientesXSuper(int idIngrediente)
        {
            Producto producto = Ingrediente(idIngrediente);
            producto.Cantidad += producto.PuntoPedido;
            GuardarActualizarProducto(producto);
        }
        //guardad()
    }
}
