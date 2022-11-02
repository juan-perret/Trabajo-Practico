using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Bebida : Producto
    {
        public VariedadBebida TipoBebida { get; set; }
        public VariedadBebida TiposBebidas(int codigo)
        {
            switch (codigo)
            {
                case 0:
                    return VariedadBebida.normal;
                case 1:
                    return VariedadBebida.altaEnAzucar;
                default:
                    return VariedadBebida.alcoholica;
            }
        }
        // escribir y leer aca
    }
}
