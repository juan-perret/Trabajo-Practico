using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Receta 
    {
        public enum TiposComida { Desayuno, Almuerzo, Merienda, Cena }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TiposComida TipoComida { get; set; }
        public bool Saludable { get; set; }
        public List<int> CodigosIngredientes { get; set; }
        public List<double> CantidadXIngrediente { get; set; }
        [JsonIgnore]
        public List<Producto> Ingredientes { get; set; }
    }
}
