using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    internal class Carne : Kilogramo
    {
        public Carne() { }
        public Carne(string nombre, int puntoPedido, decimal precio, double kg)
        {
            Nombre = nombre;
            PuntoPedido = puntoPedido;
            Precio = precio;
            Kg = kg;
        }
    }
}
