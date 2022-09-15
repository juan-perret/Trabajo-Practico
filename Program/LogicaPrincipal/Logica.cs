using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public class Logica
    {
        List<Despensa> Ingredientes=new List<Despensa>();
        List<Receta> Recetas=new List<Receta>();
        List<Comida> Comidas=new List<Comida>();
        public void RegistroProducto() { }
        public void RegistroReceta() { }
        public void FiltrarRecetas() { }
        internal void RegistroComida() { }
        internal void RestarIngredientes() { }
        public void ListaSuper() {
            /*Al acceder a este "metodo" nos debe listar todos los ingredientes 
            donde la cantidad en stock sea menor al punto de pedido y a su lado 
            aparezca el precio por unidad. Tambien se debe poder filtrar por el tipo 
            de ingrediente. Este metodo siempre nos va a mandar a comprar la cantidad 
            necesaria hasta llegar al punto de pedido a su vez debe ir sumando todos 
            los precios para mostrar el total de la compra.*/
            List<string> listaSuper = new List<string>();
            decimal costoTotalCompra = 0;
            foreach (Despensa ingrediente in Ingredientes)
            {
                if (ingrediente.Cantidad<ingrediente.PuntoPedido)
                {
                    costoTotalCompra = costoTotalCompra + ingrediente.Precio;
                    string caracteristicasIngrediente = $"{ingrediente.TipoCategoria} | {ingrediente.Precio} | {costoTotalCompra}";
                    listaSuper.Add(caracteristicasIngrediente);
                }
            }
        }
        public void FiltrarListaSuper() { }

        public void FiltrarComida()
        {
            //La aplicación debe permitir registrar comidas. Es decir, debe permitir seleccionar 
            //las recetas que tengan todos los ingredientes disponibles y filtrar por el tipo de
            //comida.Una vez que registra la comida, se debe descontar las cantidades utilizadas de 
            //todos los ingredientes de la receta.

        }
    }
}
