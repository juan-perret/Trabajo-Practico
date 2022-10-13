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
        List<Bebida> bebidas = new List<Bebida>();
        List<Carne> carnes = new List<Carne>();
        string direccion = @"C:/";
        internal bool EscribirProducto(List<Producto> lista)
        {
            foreach (Producto p in lista)
            {
                if (p is Bebida)
                {
                    bebidas.Add((Bebida)p);
                    using (StreamWriter writer = new StreamWriter(direccion+"bebidas.txt"))
                    {
                        string archivo = JsonConvert.SerializeObject(bebidas);
                        writer.WriteLine(archivo);
                        return true;
                    }
                }
                if (p is Carne)
                {
                    carnes.Add((Carne)p);
                    using (StreamWriter writer = new StreamWriter(direccion + "carnes.txt"))
                    {
                        string archivo = JsonConvert.SerializeObject(carnes);
                        writer.WriteLine(archivo);
                        return true;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(direccion))
            {
                string archivo = JsonConvert.SerializeObject(lista);
                writer.WriteLine(archivo);
                return true;
            }
        }
        

        //metodo escribir y leer json's
    }
}
