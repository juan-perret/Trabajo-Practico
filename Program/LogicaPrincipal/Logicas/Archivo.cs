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
            List<Producto> frutas = new List<Producto>();
            List<Producto> hortalizas = new List<Producto>();
            List<Producto> lacteos = new List<Producto>();
            List<Producto> panaderia = new List<Producto>();
            List<Producto> pescados = new List<Producto>();
            List<Producto> quesos = new List<Producto>();
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
                if (p is Fruta)
                {
                    frutas.Add((Fruta)p);
                }
                if(p is Hortaliza)
                {
                    hortalizas.Add((Hortaliza)p);
                }
                if (p is Lacteo)
                {
                    lacteos.Add((Lacteo)p);
                }
                if (p is Panaderia)
                {
                    panaderia.Add((Panaderia)p);
                }
                if(p is Pescado)
                {
                    pescados.Add((Pescado)p);
                }
                if (p is Queso)
                {
                    quesos.Add((Queso)p);
                }
            }
            Escribir(bebidas,"bebidas");
            Escribir(carnes, "carnes");
            Escribir(frutas, "frutas");
            Escribir(hortalizas, "hortalizas");
            Escribir(lacteos, "lacteos");
            Escribir(panaderia, "panaderia");
            Escribir(pescados, "pescados");
            Escribir(quesos, "quesos");  
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
                string archivo = reader.ReadToEnd();
                bebidas = JsonConvert.DeserializeObject<List<Bebida>>(archivo);
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
                string archivo = reader.ReadToEnd();
                carnes = JsonConvert.DeserializeObject<List<Carne>>(archivo);
            }
            productos.AddRange(carnes);
            //
            //Frutas
            List<Fruta> frutas = new List<Fruta>();
            if (!File.Exists(direccion + "frutas.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "frutas.txt"))
            {
                string archivo = reader.ReadToEnd();
                frutas = JsonConvert.DeserializeObject<List<Fruta>>(archivo);
            }
            productos.AddRange(frutas);
            //
            //Hortalizas
            List<Hortaliza> hortalizas = new List<Hortaliza>();
            if (!File.Exists(direccion + "hortalizas.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "hortalizas.txt"))
            {
                string archivo = reader.ReadToEnd();
                hortalizas = JsonConvert.DeserializeObject<List<Hortaliza>>(archivo);
            }
            productos.AddRange(hortalizas);
            //
            //Lacteos
            List<Lacteo> lacteos = new List<Lacteo>();
            if (!File.Exists(direccion + "lacteos.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "lacteos.txt"))
            {
                string archivo = reader.ReadToEnd();
                lacteos = JsonConvert.DeserializeObject<List<Lacteo>>(archivo);
            }
            productos.AddRange(lacteos);
            //
            //Panaderia
            List<Panaderia> panaderia = new List<Panaderia>();
            if (!File.Exists(direccion + "panaderia.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "panaderia.txt"))
            {
                string archivo = reader.ReadToEnd();
                panaderia = JsonConvert.DeserializeObject<List<Panaderia>>(archivo);
            }
            productos.AddRange(panaderia);
            //
            //Pescados
            List<Pescado> pescados = new List<Pescado>();
            if (!File.Exists(direccion + "pescados.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "pescados.txt"))
            {
                string archivo = reader.ReadToEnd();
                pescados = JsonConvert.DeserializeObject<List<Pescado>>(archivo);
            }
            productos.AddRange(pescados);
            //
            //Quesos
            List<Queso> quesos = new List<Queso>();
            if (!File.Exists(direccion + "quesos.txt"))
            {
                return new List<Producto>();
            }
            using (StreamReader reader = new StreamReader(direccion + "quesos.txt"))
            {
                string archivo = reader.ReadToEnd();
                quesos = JsonConvert.DeserializeObject<List<Queso>>(archivo);
            }
            productos.AddRange(quesos);
            //
            return productos;
        }
        //
        //Recetas
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
        //
        //Comidas
        //
        public bool EscribirComidas(List<Comida> lista)
        {
            using (StreamWriter writer = new StreamWriter(direccion + "comidas.txt"))
            {
                string archivo = JsonConvert.SerializeObject(lista);
                writer.WriteLine(archivo);
                return true;
            }
        }
        public List<Comida> LeerComidas()
        {
            List<Comida> listadoComidas= new List<Comida>();
            if (!File.Exists(direccion + "comidas.txt"))
            {
                return new List<Comida>();
            }
            using (StreamReader reader = new StreamReader(direccion + "comidas.txt"))
            {
                string comidas = reader.ReadToEnd();
                listadoComidas = JsonConvert.DeserializeObject<List<Comida>>(comidas);
            }
            return listadoComidas;
        }
        //
        //super
        //
        //metodo escribir y leer json's
    }
}
