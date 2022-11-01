using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPrincipal;

namespace Prueba
{
    public partial class Form1 : Form
    {
        private Despensa despensa;
        public Form1()
        {
            InitializeComponent();
            despensa = new Despensa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();
            bebida.Nombre = textBox1.Text;
            despensa.GuardarActualizarProducto(bebida);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //genero instancia de carga de valores
            Carne carne = new Carne();
            carne.Nombre = textBox1.Text;
            despensa.GuardarActualizarProducto(carne);
        }
    }
}
