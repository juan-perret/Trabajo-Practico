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
        List<Bebida> bebidas = new List<Bebida>();
        string direccion = @"C:\despensa.txt";

        public void GuardarPBebida(string nombre, int puntoPedido, decimal precio, int cantidadProducto, int tipoBebida)
        {
            Bebida bebida = new Bebida(nombre, puntoPedido, precio, cantidadProducto, tipoBebida);
            GuardarProducto(bebida);
        }
        public void GuardarPCarne(string nombre, int puntoPedido, decimal precio, double kg)
        {
            Carne carne = new Carne(nombre, puntoPedido, precio, kg);
            GuardarProducto(carne);
        }
        public void GuardarProducto(Producto ingrediente)
        {
            despensa.Add(ingrediente);
            EscribirProducto(despensa);
        }

        internal List<Producto> Leer()
        {
            if (!File.Exists(direccion))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion))
            {
                string archivo = reader.ReadToEnd();
                despensa = JsonConvert.DeserializeObject<List<Producto>>(archivo);
                return despensa;
            }
            
        }
        
        
        //guardad()
    }
}
