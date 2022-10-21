namespace FormPrincipal
{
    partial class FormComidas
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
            this.dgvComidas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComidas
            // 
            this.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_hora,
            this.Nombre_Receta,
            this.Tipo_de_comida,
            this.Saludable,
            this.Editar,
            this.Eliminar});
            this.dgvComidas.Location = new System.Drawing.Point(12, 27);
            this.dgvComidas.Name = "dgvComidas";
            this.dgvComidas.Size = new System.Drawing.Size(700, 350);
            this.dgvComidas.TabIndex = 0;
            this.dgvComidas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvComidas_DataBindingComplete);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarComidaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarComidaToolStripMenuItem
            // 
            this.registrarComidaToolStripMenuItem.Name = "registrarComidaToolStripMenuItem";
            this.registrarComidaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.registrarComidaToolStripMenuItem.Text = "Registrar comida";
            this.registrarComidaToolStripMenuItem.Click += new System.EventHandler(this.registrarComidaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Fecha_hora
            // 
            this.Fecha_hora.HeaderText = "Fecha y hora";
            this.Fecha_hora.Name = "Fecha_hora";
            // 
            // Nombre_Receta
            // 
            this.Nombre_Receta.HeaderText = "Nombre de la Receta";
            this.Nombre_Receta.Name = "Nombre_Receta";
            // 
            // Tipo_de_comida
            // 
            this.Tipo_de_comida.HeaderText = "Tipo de Comida";
            this.Tipo_de_comida.Name = "Tipo_de_comida";
            // 
            // Saludable
            // 
            this.Saludable.HeaderText = "Es saludable?";
            this.Saludable.Name = "Saludable";
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
            // FormComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.Controls.Add(this.dgvComidas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComidas";
            this.Text = "Comidas";
            this.Load += new System.EventHandler(this.FormComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComidas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saludable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}