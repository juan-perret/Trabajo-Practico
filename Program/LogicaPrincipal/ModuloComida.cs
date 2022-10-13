using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    internal class ModuloComida :Archivo
    {
        List<Comida> comidas = new List<Comida>();
        string direccion = @"C:\comidas.txt";
        

        //guarda(), al guardar modificar en despensa las cantidades
    }
}
