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

        public TiposProducto TiposDeProducto(int codigo)
        {
            switch (codigo)
            {
                case 0:
                    return TiposProducto.Hortalizas_y_Verduras;
                case 1:
                    return TiposProducto.Frutas;
                case 2:
                    return TiposProducto.Quesos;
                case 3:
                    return TiposProducto.Lacteos;
                case 4:
                    return TiposProducto.Carnes;
                case 5:
                    return TiposProducto.Pescados;
                case 6:
                    return TiposProducto.Panaderia;
                case 7:
                    return TiposProducto.Bebidas_Alta_en_Azucar;
                case 8:
                    return TiposProducto.Bebidas_Normal;
                default:
                    return TiposProducto.Bebidas_Alcoholicas;
            }
        }
    }
}
