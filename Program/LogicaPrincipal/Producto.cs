using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PuntoPedido { get; set; }
        public decimal Precio { get; set; }

    }
}
