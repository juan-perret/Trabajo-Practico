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
        public void GuardarBebida(string nombre, int puntoPedido, decimal precio, int cantidadProducto, int tipoBebida)
        {
            Nombre = nombre;
            PuntoPedido = puntoPedido;
            Precio = precio;
            CantidadProducto = cantidadProducto;
            switch (tipoBebida)
            {
                case 0:
                    TipoBebida = VariedadBebida.alcoholica;
                    break;
                case 1:
                    TipoBebida = VariedadBebida.altaEnAzucar;
                    break;
                case 2:
                    TipoBebida = VariedadBebida.normal;
                    break;
            }        
        }
        public Bebida(string nombre, int puntoPedido, decimal precio, int cantidadProducto, int tipoBebida)
        {
            Nombre = nombre;
            PuntoPedido = puntoPedido;
            Precio = precio;
            CantidadProducto = cantidadProducto;
            switch (tipoBebida)
            {
                case 0:
                    TipoBebida = VariedadBebida.alcoholica;
                    break;
                case 1:
                    TipoBebida = VariedadBebida.altaEnAzucar;
                    break;
                case 2:
                    TipoBebida = VariedadBebida.normal;
                    break;
            }
        }
        // escribir y leer aca
    }
}
