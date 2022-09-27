using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    internal class Bebida :Cantidad
    {
        public enum VariedadBebida { alcoholica, altaEnAzucar, normal}
        public VariedadBebida TipoBebida { get; set; }
    }
}
