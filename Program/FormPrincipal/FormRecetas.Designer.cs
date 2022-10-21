namespace FormPrincipal
{
    partial class FormRecetas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRecetas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo_de_receta,
            this.Saludable,
            this.Ingredientes,
            this.Editar,
            this.Eliminar});
            this.dgvRecetas.Location = new System.Drawing.Point(12, 27);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.Size = new System.Drawing.Size(700, 350);
            this.dgvRecetas.TabIndex = 0;
            this.dgvRecetas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridRecetas_DataBindingComplete);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRecetaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearRecetaToolStripMenuItem
            // 
            this.crearRecetaToolStripMenuItem.Name = "crearRecetaToolStripMenuItem";
            this.crearRecetaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.crearRecetaToolStripMenuItem.Text = "Crear Receta";
            this.crearRecetaToolStripMenuItem.Click += new System.EventHandler(this.crearRecetaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo_de_receta
            // 
            this.Tipo_de_receta.HeaderText = "Tipo de Receta";
            this.Tipo_de_receta.Name = "Tipo_de_receta";
            // 
            // Saludable
            // 
            this.Saludable.HeaderText = "Es Saludable?";
            this.Saludable.Name = "Saludable";
            // 
            // Ingredientes
            // 
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // FormRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 384);
            this.Controls.Add(this.dgvRecetas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRecetas";
            this.Text = "Recetas";
            this.Load += new System.EventHandler(this.FormRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecetas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saludable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}