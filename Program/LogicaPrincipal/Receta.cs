using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    internal class Receta :ModuloReceta
    {
        public enum TiposComida { Desayuno, Almuerzo, Merienda, Cena }
        public string Nombre { get; set; }
        public TiposComida TipoComida { get; set; }
        public bool Saludable { get; set; }
        public List<Producto> Ingredientes { get; set; }

    }
}
