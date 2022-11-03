using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Comida
    {
        public int CodigoReceta { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public Receta RecetaElegida { get; set; }
    }
}
