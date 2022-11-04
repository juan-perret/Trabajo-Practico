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
    public partial class FormFiltroComidaFecha : Form
    {
        public FormFiltroComidaFecha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFiltroComidaFecha_Load(object sender, EventArgs e)
        {
            dtpFecha1.MaxDate = DateTime.Now;
            dtpFecha2.MaxDate = DateTime.Now;
        }

        private void dtpFecha1_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha2.MinDate = dtpFecha1.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ActualizarGrilla(dtpFecha1.Value, dtpFecha2.Value); 
        }
    }
}
