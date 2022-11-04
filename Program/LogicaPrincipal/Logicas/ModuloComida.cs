using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaPrincipal
{
    public class ModuloComida :Archivo
    {
        List<Comida> comidas = new List<Comida>();
        private ModuloReceta logica;
        public ModuloComida()
        {
            logica = new ModuloReceta();
            comidas = LeerComidas();
            //foreach (Comida comida in comidas)
            //{
            //    comida.RecetaElegida = logica.DevolverReceta(comida.CodigoReceta);
            //}
            //foreach buscando la receta por ID.
        }
        public void GuardarComida(Comida comida)
        {
            comida.RecetaElegida= logica.DevolverReceta(comida.CodigoReceta);
            logica.DescontarIngredientes(comida.CodigoReceta);
            comidas.Add(comida);
            EscribirComidas(comidas);
        }
        public void LeerComida()
        {
        }
        public List<Receta> DevolverListaRecetasAccesibles()
        {
            List<Receta> recetas = logica.LeerRecetas();
            List<Producto> stockProductos = logica.LeerProductos();
            List<Receta> recetasAMostrar = new List<Receta>();
            foreach (Receta rec in recetas)
            {
                bool noCantidad = false;
                foreach (Producto p in stockProductos)
                {
                    int indice = rec.CodigosIngredientes.FindIndex(x => x == p.Id);
                    if (indice != -1)
                    {
                        if (p.Cantidad < (rec.CantidadXIngrediente)[indice])
                        {
                            noCantidad = true;
                            break;
                        }
                    }
                }
                if (!noCantidad)
                {
                    recetasAMostrar.Add(rec);
                }
            }
            return recetasAMostrar;
        }
        public List<Receta> DevolverListaRecetasAccesiblesXFiltro(TiposComida tipoComida)
        {
            List<Receta> recetas = logica.LeerRecetas();
            List<Producto> stockProductos = logica.LeerProductos();
            List<Receta> recetasAMostrar = new List<Receta>();
            foreach (Receta rec in recetas)
            {
                bool noCantidad = false;
                foreach (Producto p in stockProductos)
                {
                    int indice = rec.CodigosIngredientes.FindIndex(x => x == p.Id);
                    if (indice != -1)
                    {
                        if (p.Cantidad < (rec.CantidadXIngrediente)[indice])
                        {
                            noCantidad = true;
                            break;
                        }
                    }
                }
                if (!noCantidad && rec.TipoComida == tipoComida)
                {
                    recetasAMostrar.Add(rec);
                }
            }
            return recetasAMostrar;
        }
        //guarda(), al guardar modificar en despensa las cantidades
        //Comidas filtros

        public List<Comida> ObtenerComidasSaludables(bool saludable)
        {
            List<Comida> comidasSaludables = new List<Comida>();
            foreach (Comida comida in comidas)
            {
                if (comida.RecetaElegida.Saludable == saludable)
                {
                    comidasSaludables.Add(comida);
                }
            }
            return comidasSaludables;
        }
        public List<Comida> ObtenerComidasXTipo (TiposComida tipoComida)
        {
            List<Comida> comidasXTipo = new List<Comida>();
            foreach(Comida comida in comidas)
            {
                if(comida.RecetaElegida.TipoComida == tipoComida)
                {
                    comidasXTipo.Add(comida);
                }
            }
            return comidasXTipo;
        }
        public List<Comida> ObtenerComidasXReceta (int idReceta)
        {
            List<Comida> comidasXReceta = new List<Comida>();
            foreach (Comida comida in comidas)
            {
                if (comida.RecetaElegida == logica.DevolverReceta(idReceta))
                {
                    comidasXReceta.Add(comida);
                }
            }
            return comidasXReceta;
        }
        public List<Comida> ObtenerComidasXFecha (DateTime fecha1, DateTime fecha2)
        {
            List<Comida> comidasXFecha = new List<Comida>();
            foreach (Comida comida in comidas)
            {
                if (comida.FechaDeRegistro>=fecha1 && comida.FechaDeRegistro<=fecha2)
                {
                    comidasXFecha.Add(comida);
                }
            }
            return comidasXFecha;
        }
    }
}
