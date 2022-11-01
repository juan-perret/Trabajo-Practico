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
                id = despensa[despensa.Count-1].Id;
            }
 
        }        
        //El metodo deberia ser GuardarActualizarProducto en el cual dependiendo si el Id es vacio debe agregar el producto
        // y generarle un id y si no es vacio debe modificar el registro
        public void GuardarActualizarProducto(Producto ingrediente)
        {
            if(ingrediente.Id == 0)
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
                    if(producto.Id == ingrediente.Id)
                    {
                        producto.Id = ingrediente.Id;
                        producto.Nombre = ingrediente.Nombre;
                        producto.Cantidad = ingrediente.Cantidad;
                        producto.PuntoPedido = ingrediente.PuntoPedido;
                        producto.Precio = ingrediente.Precio;
                    }
                }
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
                if (p is Bebida)
                {
                    Bebida bebida = (Bebida)p;
                    if (bebida.Cantidad < p.PuntoPedido)
                    {
                        listaAComprar.Add(p);
                    }
                }
                if (p is Carne)
                {
                    Carne carne = (Carne)p;
                    if (carne.Cantidad < p.PuntoPedido)
                    {
                        listaAComprar.Add(p);
                    }
                }
            }
            return listaAComprar;
        }
        //
        //Metodos para recetas
        List<int> listadoIngredientes = new List<int>();
        //guardad()
    }
}
