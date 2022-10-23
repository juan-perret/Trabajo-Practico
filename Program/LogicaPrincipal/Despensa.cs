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


        //guardad()
    }
}
