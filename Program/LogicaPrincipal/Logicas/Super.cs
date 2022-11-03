using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    public class Super
    {
        private Despensa logica;
        List<Producto> ingredientesFaltantes = new List<Producto>();
        public Super()
        {
            logica = new Despensa();
            //ingredientesFaltantes = logica.ProductosAComprar();
        }                                              // aca va metodo de los productos
        public List<Producto> DevolverLista()
        {
            ingredientesFaltantes = logica.ProductosAComprar();
            return ingredientesFaltantes;
        }
        public List<Producto> DevolverLista(TiposProducto tipoProducto)
        {
            ingredientesFaltantes = logica.ProductosAComprarPorTipo(tipoProducto);
            return ingredientesFaltantes;
        }
        //Pedir de despensa, que devuelva una lista con los productos que tienen cant menor
        //a la minima
        public void AgregarStock(int idIngrediente)
        {
            logica.AgregarIngredientesXSuper(idIngrediente);
        }
    }
}
