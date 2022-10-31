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
        List<int> listaIngredientes = new List<int>();
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
            receta.CodigosIngredientes = listaIngredientes;
            receta.Ingredientes = BuscarProductosReceta(receta.CodigosIngredientes);
            recetas.Add(receta);
            listaIngredientes = new List<int>();
            EscribirReceta(recetas);
            id += 1;
        }
        public List<Producto> BuscarProductosReceta(List<int> lista)
        {
            List<Producto> listaIngredientes = new List<Producto>();
            foreach (int id in lista)
            {
                listaIngredientes.Add(logica.Ingrediente(id));
            }
            return listaIngredientes;
        }
        public void EliminarAListaCodigos(int codigo)
        {
            listaIngredientes.Remove(codigo);
        }
        public void AgregarAListaCodigos(int codigo)
        {
            listaIngredientes.Add(codigo);
        }
        //
        //Para registrar comidas
        //Buscar receta
        public Receta DevolverReceta(int codigo)
        {
            foreach (Receta rec in recetas)
            {
                if (rec.Id == codigo)
                {
                    return rec;
                }
            }
            return null;
        }
        //Generar metodo que devuelva receta por ID
        //guardad()
    }
}
