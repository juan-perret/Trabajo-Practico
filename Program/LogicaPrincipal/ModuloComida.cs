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
            //foreach buscando la receta por ID.
        }
        public void GuardarComida(Comida comida)
        {
            comidas.Add(comida);
            EscribirComidas(comidas);
        }
        public void LeerComida()
        {

        }

        //guarda(), al guardar modificar en despensa las cantidades
    }
}
