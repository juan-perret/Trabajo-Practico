using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Despensa
    {
        public enum TiposDeCategorias { HortalizasYVerduras, Frutas, Quesos, Lacteos, Carnes, Pescados, Panaderia, Bebidas}
        public string Nombre { get; set; }
        public TiposDeCategorias TipoCategoria { get; set; }
        public double Cantidad { get; set; }
        public decimal Precio { get; set; }
        public double PuntoPedido { get; set; }
        protected decimal PrecioPuntoPedido() { return 2m; }
        public decimal SumaPrecioPuntoPeidod() { return 2m; }
    }
}
