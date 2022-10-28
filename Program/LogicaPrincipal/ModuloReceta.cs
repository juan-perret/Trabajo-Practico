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
        int id = 0;
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
            if (recetas.Count != 0)
            {
                id = recetas[recetas.Count - 1].Id;
            }
        }
        
        public void GuardarReceta(Receta receta)
        {
            receta.Id = id + 1;
            recetas.Add(receta);
            EscribirReceta(recetas);
            id += 1;
        }

        //Generar metodo que devuelva receta por ID
        //guardad()
    }
}
