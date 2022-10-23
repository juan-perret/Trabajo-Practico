using LogicaPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormPrincipal.FormAltaIngredientes;

namespace FormPrincipal
{
    public partial class FormCrearReceta : Form
    {
        private ModuloReceta logica;
        public FormCrearReceta()
        {
            InitializeComponent();
            logica = new ModuloReceta();
        }
        public enum TiposComida { Desayuno, Almuerzo, Merienda, Cena }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Receta receta = new Receta();
            receta.Nombre = txtNombre.Text;
            receta.Saludable = checkbSaludable.Checked;
            Enum.TryParse(cmbTipoReceta.Text, out TiposComida tipo);
            switch (tipo)
            {
                case TiposComida.Desayuno:
                    receta.TipoComida = Receta.TiposComida.Desayuno;
                    break;
                case TiposComida.Almuerzo:
                    receta.TipoComida = Receta.TiposComida.Almuerzo;
                    break;
                case TiposComida.Merienda:
                    receta.TipoComida = Receta.TiposComida.Merienda;
                    break;
                case TiposComida.Cena:
                    receta.TipoComida = Receta.TiposComida.Cena;
                    break;
            }
            List<int> codigos = new List<int>();
            List<Producto> ingredientes = new List<Producto>();
            receta.Ingredientes = ingredientes;
            receta.CodigosIngredientes = codigos;
            logica.GuardarReceta(receta);
        }
    }
}
