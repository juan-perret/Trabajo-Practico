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
        //
        //Despensa
        //
        public bool EscribirProducto(List<Producto> lista)
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
            productos.AddRange(bebidas);
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
            productos.AddRange(carnes);
            //
            return productos;
        }
        //
        //
        //
        public bool EscribirReceta(List<Receta> lista)
        {
            using (StreamWriter writer = new StreamWriter(direccion + "recetas.txt"))
            {
                string archivo = JsonConvert.SerializeObject(lista);
                writer.WriteLine(archivo);
                return true;
            }
        }
        public List<Receta> LeerRecetas()
        {
            List<Receta> listadoRecetas = new List<Receta>();
            if (!File.Exists(direccion+ "recetas.txt"))
            {
                return new List<Receta>();
            }
            using (StreamReader reader = new StreamReader(direccion + "recetas.txt"))
            {
                string recetas = reader.ReadToEnd();
                listadoRecetas = JsonConvert.DeserializeObject<List<Receta>>(recetas);
            }
            return listadoRecetas;
        }
            //metodo escribir y leer json's
        }
}
