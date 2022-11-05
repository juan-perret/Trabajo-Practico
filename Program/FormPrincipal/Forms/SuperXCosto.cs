using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal.Forms
{
    public partial class SuperXCosto : Form
    {
        public SuperXCosto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(txtCosto.Text);
            bool max = true;
            if (cmbMaxMin.Text == "Max")
            {
                max = true;
            }
            if (cmbMaxMin.Text == "Min")
            {
                max = false;
            }
            ActualizarGrillaSuper padre = this.Owner as ActualizarGrillaSuper;
            if (padre != null)
            {
                padre.ActualizarGrilla(costo, max);
            }
            this.Close();
        }
    }
}
