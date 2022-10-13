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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Despensa despensa = new Despensa();
            despensa.GuardarPBebida("Sprite", 3, 123, 231, 0);
            despensa.GuardarPBebida("Coca", 5, 542, 34, 1);
        }
    }
}
