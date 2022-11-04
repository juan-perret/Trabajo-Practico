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
                id = recetas.Max(x=>x.Id);
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
                        recetaBuscada.CodigosIngredientes = listaIngredientes;
                        recetaBuscada.CantidadXIngrediente = cantidadXIngrediente;
                        recetaBuscada.Ingredientes = BuscarProductosReceta(recetaBuscada.CodigosIngredientes);
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
        public List<Producto> DevolverIngredientesDeReceta(string id)
        {
            int codigo = Convert.ToInt32(id);
            Receta receta = DevolverReceta(codigo);
            List<Producto> ingredientes = BuscarProductosReceta(receta.CodigosIngredientes);
            foreach (Producto ingrediente in ingredientes)
            {
                ingrediente.Cantidad = (receta.CantidadXIngrediente)[receta.CodigosIngredientes.FindIndex(x=>x == ingrediente.Id)];
            }
            return ingredientes;
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
       
        //Eliminar receta
        public void EliminarReceta (string idReceta)
        {
            int id = Convert.ToInt32(idReceta);
            foreach (var rec in recetas)
            {
                if (rec.Id == id)
                {
                    recetas.Remove(rec);
                    EscribirReceta(recetas);
                    break;
                }
            }
        }
        public void EliminarRecetaXIngredienteFaltante(int idIngredienteAQuitar)
        {
            List<Receta> recetas = LeerRecetas();
            foreach (Receta rec in recetas)
            {
                foreach (int idIngrediente in rec.CodigosIngredientes)
                {
                    if (idIngrediente == idIngredienteAQuitar)
                    {
                        EliminarReceta(rec.Id.ToString());
                    }    
                }
            }
        }
        //
        //Para descontar ingredientes
        //
        public void DescontarIngredientes(int idReceta)
        {
            Receta receta = recetas.Find(rec => rec.Id == idReceta);
            foreach (int idIngrediente in receta.CodigosIngredientes)
            {
                double cantidad = receta.CantidadXIngrediente[receta.CodigosIngredientes.FindIndex(x => x == idIngrediente)];
                logica.EliminarCantidadProducto(idIngrediente, cantidad);
            }
        }
    }
}
