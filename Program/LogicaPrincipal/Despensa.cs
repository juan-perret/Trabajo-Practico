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
        public Despensa()
        {
           despensa = LeerProductos();
        }        
        public void GuardarProducto(Producto ingrediente)
        {
            ingrediente.Id = despensa.Count + 1;
            despensa.Add(ingrediente);
            EscribirProducto(despensa);
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
                    if (bebida.CantidadProducto < p.PuntoPedido)
                    {
                        listaAComprar.Add(p);
                    }
                }
            }
            return listaAComprar;
        }
        //guardad()
    }
}
