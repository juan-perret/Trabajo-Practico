using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaPrincipal;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Despensa despensa = new Despensa();
            despensa.GuardarPBebida("Sprite", 3, 123, 231, 0);
            despensa.GuardarPBebida("Coca", 5, 542, 34, 1);
        }
    }
}
