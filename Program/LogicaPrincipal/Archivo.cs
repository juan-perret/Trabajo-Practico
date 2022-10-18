using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    public class Archivo
    {   
        string direccion = @"C:/";
        internal bool EscribirProducto(List<Producto> lista)
        {
            List<Producto> bebidas = new List<Producto>();
            List<Producto> carnes = new List<Producto>();
            foreach (Producto p in lista)
            {
                if (p is Bebida)
                {
                    bebidas.Add((Bebida)p);                    
                }
                if (p is Carne)
                {
                    carnes.Add((Carne)p);                   
                }
            }
            Escribir(bebidas,"bebidas");
            Escribir(carnes, "carnes");
            return true;
        }
        public bool Escribir(List<Producto> lista, string ubicacion)
        {
            using (StreamWriter writer = new StreamWriter(direccion +ubicacion+ ".txt"))
            {
                string archivo = JsonConvert.SerializeObject(lista);
                writer.WriteLine(archivo);
                return true;
            }
        }
        
        public List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>(); 
            //Bebidas
            List<Bebida> bebidas = new List<Bebida>();
            if (!File.Exists(direccion + "bebidas.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "bebidas.txt"))
            {
                string bebida = reader.ReadToEnd();
                bebidas = JsonConvert.DeserializeObject<List<Bebida>>(bebida);
            }
            foreach (Producto p in bebidas)
            {
                productos.Add(p);
            }
            //
            //Carnes
            List<Carne> carnes = new List<Carne>();
            if (!File.Exists(direccion + "carnes.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "carnes.txt"))
            {
                string carne = reader.ReadToEnd();
                carnes = JsonConvert.DeserializeObject<List<Carne>>(carne);
            }
            foreach (Producto p in carnes)
            {
                productos.Add(p);
            }
            //
            return productos;
        }
        //public List<Producto> CrearArchivo(string ubicacion, List<Producto> lista)
        //{
        //    if (!File.Exists(direccion + ubicacion + ".txt"))
        //    {
        //        return new List<Producto>();
        //    }
        //    else
        //    {
        //        using (StreamReader reader = new StreamReader(direccion + ubicacion + ".txt"))
        //        {
        //            string objeto = reader.ReadToEnd();
        //            lista = JsonConvert.DeserializeObject<List<Producto>>(objeto);
        //        }
        //        return lista;
        //    }
        //}
        //public List<Producto> Leer(string ubicacion)
        //{

            //    using (StreamReader reader = new StreamReader(direccion + ubicacion +".txt"))
            //    {
            //        string bebida = reader.ReadToEnd();
            //        bebidas = JsonConvert.DeserializeObject<List<Bebida>>(bebida);
            //    }
            //}


            //metodo escribir y leer json's
        }
}
