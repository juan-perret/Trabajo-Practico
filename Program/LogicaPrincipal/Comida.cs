using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    internal class Comida :ModuloComida
    {
        public Receta RecetaElegida { get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
