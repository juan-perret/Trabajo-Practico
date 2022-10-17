using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormDespensa : Form
    {
        public FormDespensa()
        {
            InitializeComponent();
        }

        private void cargarUnIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaIngredientes altaIngredientes = new FormAltaIngredientes();
            altaIngredientes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
