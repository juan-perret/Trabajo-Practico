using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Comida
    {
        public Receta RecetaElegida { get; set; }
        public int CodigoReceta { get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
