using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    public class Super
    {
        List<Producto> ingredientesFaltantes = new List<Producto>();
        string direccion = @"C:\super.txt";
        internal bool Guardar()
        {
            using (StreamWriter writer = new StreamWriter(direccion))
            {
                string archivo = JsonConvert.SerializeObject(ingredientesFaltantes);
                writer.WriteLine(archivo);
                return true;
            }
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
                ingredientesFaltantes = JsonConvert.DeserializeObject<List<Producto>>(archivo);
                return ingredientesFaltantes;
            }
        }
        //Pedir de despensa, que devuelva una lista con los productos que tienen cant menor
        //a la minima
    }
}
