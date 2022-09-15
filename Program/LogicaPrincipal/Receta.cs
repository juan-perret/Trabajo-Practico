using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    internal class Receta
    {
        public enum TiposDeReceta
        {
            Desayuno, Almuerzo, Merienda, Cena
        }
        public TiposDeReceta TipoReceta { get; set; }
        public string TipoComida { get; set; }
        public List<Despensa> ListaIngredientes { get; set; }
    }
}
