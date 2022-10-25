using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    public class ModuloReceta : Archivo
    {
        private Despensa logica;
        List<Receta> recetas = new List<Receta>();
        public ModuloReceta()
        {
            logica = new Despensa();
            recetas=LeerRecetas();
            foreach (Receta rec in recetas)
            {
                List<Producto> ingredientes = new List<Producto>();
                foreach (int idBuscado in rec.CodigosIngredientes)
                {
                    ingredientes.Add(logica.Ingrediente(idBuscado));
                }
            }
        }
        
        public void GuardarReceta(Receta receta)
        {
            receta.Id = recetas.Count + 1;
            recetas.Add(receta);
            EscribirReceta(recetas);
        }
        //Generar metodo que devuelva receta por ID
        //guardad()
    }
}
