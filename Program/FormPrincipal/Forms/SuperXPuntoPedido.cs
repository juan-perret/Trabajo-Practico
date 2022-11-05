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
    public partial class SuperXPuntoPedido : Form
    {
        public SuperXPuntoPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarCosto() == true && ValidarMaxMin() == true)
            {
                int puntoPedido = Convert.ToInt32(txtPuntoPedido.Text);
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
                    padre.ActualizarGrilla(puntoPedido, max);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete los datos correctamente");
            }
            
        }

        private bool ValidarCosto()
        {
            int numero;
            if (string.IsNullOrEmpty(txtPuntoPedido.Text) || int.TryParse(txtPuntoPedido.Text, out numero) == false)
                return false;
            return true;
        }

        private bool ValidarMaxMin()
        {
            if (string.IsNullOrEmpty(cmbMaxMin.Text))
                return false;
            return true;
        }
    }
}
