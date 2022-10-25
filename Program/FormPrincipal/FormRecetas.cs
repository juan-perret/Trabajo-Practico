﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPrincipal;

namespace FormPrincipal
{
    public partial class FormRecetas : Form
    {
        private Receta logica;
        public FormRecetas()
        {
            InitializeComponent();
            logica = new Receta();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearReceta crearReceta = new FormCrearReceta();
            crearReceta.ShowDialog();
        }

        private void GridRecetas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(dgvRecetas);
        }

        private void FormRecetas_Load(object sender, EventArgs e)
        {
            dgvRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvRecetas.DataSource = null;
            //dgvRecetas.DataSource = logica.
        }

        private void CargarGrilla()
        {
            ActualizarGrilla();
        }
    }
}