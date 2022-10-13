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
        public bool EscribirProducto(List<Producto> lista, string direccion)
        {
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
