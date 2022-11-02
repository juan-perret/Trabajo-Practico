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
            this.MsComidas = new System.Windows.Forms.MenuStrip();
            this.registrarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodigoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidas)).BeginInit();
            this.MsComidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComidas
            // 
            this.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoReceta,
            this.Fecha_hora,
            this.Nombre_Receta,
            this.Tipo_de_comida,
            this.Saludable});
            this.dgvComidas.Location = new System.Drawing.Point(12, 27);
            this.dgvComidas.Name = "dgvComidas";
            this.dgvComidas.Size = new System.Drawing.Size(445, 350);
            this.dgvComidas.TabIndex = 0;
            // 
            // MsComidas
            // 
            this.MsComidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsComidas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarComidaToolStripMenuItem,
            this.filtrarPorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MsComidas.Location = new System.Drawing.Point(0, 0);
            this.MsComidas.Name = "MsComidas";
            this.MsComidas.Size = new System.Drawing.Size(467, 25);
            this.MsComidas.TabIndex = 1;
            this.MsComidas.Text = "menuStrip1";
            // 
            // registrarComidaToolStripMenuItem
            // 
            this.registrarComidaToolStripMenuItem.Name = "registrarComidaToolStripMenuItem";
            this.registrarComidaToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.registrarComidaToolStripMenuItem.Text = "Registrar comida";
            this.registrarComidaToolStripMenuItem.Click += new System.EventHandler(this.registrarComidaToolStripMenuItem_Click);
            // 
            // filtrarPorToolStripMenuItem
            // 
            this.filtrarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtro1ToolStripMenuItem,
            this.filtro2ToolStripMenuItem,
            this.filtro3ToolStripMenuItem,
            this.filtro4ToolStripMenuItem});
            this.filtrarPorToolStripMenuItem.Name = "filtrarPorToolStripMenuItem";
            this.filtrarPorToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.filtrarPorToolStripMenuItem.Text = "Filtrar por";
            // 
            // filtro1ToolStripMenuItem
            // 
            this.filtro1ToolStripMenuItem.Name = "filtro1ToolStripMenuItem";
            this.filtro1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.filtro1ToolStripMenuItem.Text = "Filtro 1";
            // 
            // filtro2ToolStripMenuItem
            // 
            this.filtro2ToolStripMenuItem.Name = "filtro2ToolStripMenuItem";
            this.filtro2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.filtro2ToolStripMenuItem.Text = "Filtro 2";
            // 
            // filtro3ToolStripMenuItem
            // 
            this.filtro3ToolStripMenuItem.Name = "filtro3ToolStripMenuItem";
            this.filtro3ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.filtro3ToolStripMenuItem.Text = "Filtro 3";
            // 
            // filtro4ToolStripMenuItem
            // 
            this.filtro4ToolStripMenuItem.Name = "filtro4ToolStripMenuItem";
            this.filtro4ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.filtro4ToolStripMenuItem.Text = "Filtro 4";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // CodigoReceta
            // 
            this.CodigoReceta.DataPropertyName = "CodigoReceta";
            this.CodigoReceta.HeaderText = "CodigoReceta";
            this.CodigoReceta.Name = "CodigoReceta";
            this.CodigoReceta.Visible = false;
            // 
            // Fecha_hora
            // 
            this.Fecha_hora.DataPropertyName = "FechaDeRegistro";
            this.Fecha_hora.HeaderText = "Fecha y hora";
            this.Fecha_hora.Name = "Fecha_hora";
            this.Fecha_hora.ReadOnly = true;
            // 
            // Nombre_Receta
            // 
            this.Nombre_Receta.DataPropertyName = "Nombre";
            this.Nombre_Receta.HeaderText = "Nombre de la Receta";
            this.Nombre_Receta.Name = "Nombre_Receta";
            this.Nombre_Receta.ReadOnly = true;
            // 
            // Tipo_de_comida
            // 
            this.Tipo_de_comida.DataPropertyName = "TipoComida";
            this.Tipo_de_comida.HeaderText = "Tipo de Comida";
            this.Tipo_de_comida.Name = "Tipo_de_comida";
            this.Tipo_de_comida.ReadOnly = true;
            // 
            // Saludable
            // 
            this.Saludable.HeaderText = "Es saludable?";
            this.Saludable.Name = "Saludable";
            this.Saludable.ReadOnly = true;
            this.Saludable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saludable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 391);
            this.Controls.Add(this.dgvComidas);
            this.Controls.Add(this.MsComidas);
            this.MainMenuStrip = this.MsComidas;
            this.Name = "FormComidas";
            this.Text = "Comidas";
            this.Load += new System.EventHandler(this.FormComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidas)).EndInit();
            this.MsComidas.ResumeLayout(false);
            this.MsComidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComidas;
        private System.Windows.Forms.MenuStrip MsComidas;
        private System.Windows.Forms.ToolStripMenuItem registrarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro4ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_comida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saludable;
    }
}