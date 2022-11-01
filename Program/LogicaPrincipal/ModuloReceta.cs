using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace LogicaPrincipal
{
    public class ModuloReceta : Archivo
    {
        private Despensa logica;
        List<Receta> recetas = new List<Receta>();
        List<int> listaIngredientes = new List<int>();
        List<double> cantidadXIngrediente = new List<double>();
        int id = 0;
        public ModuloReceta()
        {
            logica = new Despensa();
            recetas=LeerRecetas();
            foreach (Receta rec in recetas)
            {
                List<Producto> ingredientes = new List<Producto>();
                foreach (int id in rec.CodigosIngredientes)
                {
                    ingredientes.Add(logica.Ingrediente(id));
                }
            }
            if (recetas.Count != 0)
            {
                id = recetas[recetas.Count - 1].Id;
            }
        }
        
        public void GuardarReceta(Receta receta)
        {
            if (receta.Id == 0)
            {
                receta.Id = id + 1;
                receta.CodigosIngredientes = listaIngredientes;
                receta.CantidadXIngrediente = cantidadXIngrediente;
                receta.Ingredientes = BuscarProductosReceta(receta.CodigosIngredientes);
                recetas.Add(receta);
                listaIngredientes = new List<int>();
                EscribirReceta(recetas);
                id += 1;
            }
            else
            {
                foreach (Receta recetaBuscada in recetas)
                {
                    if (recetaBuscada.Id == receta.Id)
                    {
                        recetaBuscada.Id = receta.Id;
                        recetaBuscada.Nombre = receta.Nombre;
                        recetaBuscada.Saludable = receta.Saludable;
                        //falta igualar ingredientes
                        EscribirReceta(recetas);
                    }
                }
            }
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
            int indice = listaIngredientes.FindIndex(x=>x == codigo);
            if (indice != -1)
            {
                listaIngredientes.Remove(codigo);
                cantidadXIngrediente.RemoveAt(indice);
            }

        }
        public void AgregarAListaCodigos(int codigo, double cantidad)
        {
            if (listaIngredientes.Exists(x=>x == codigo))
            {
                cantidadXIngrediente[listaIngredientes.FindIndex(x=>x == codigo)] = cantidad;
            }
            else
            {
                listaIngredientes.Add(codigo);
                cantidadXIngrediente.Add(cantidad);
            }
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
