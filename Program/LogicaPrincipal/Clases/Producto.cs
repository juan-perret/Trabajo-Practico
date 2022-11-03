using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogicaPrincipal.Bebida;

namespace LogicaPrincipal
{
    public abstract class Producto
    {        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TiposProducto TipoProducto { get; set; }
        public double PuntoPedido { get; set; }
        public decimal Precio { get; set; }
        public double Cantidad { get; set; }
    }
}
