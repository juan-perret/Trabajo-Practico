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
            this.CodigoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MsComidas = new System.Windows.Forms.MenuStrip();
            this.registrarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFiltroSaludable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSiSaludable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoSaludable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipoComida = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesayuno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlmuerzo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMerienda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCena = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReceta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitarFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntreDos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiFiltroSaludable,
            this.tsmiTipoComida,
            this.tsmiReceta,
            this.tsmiFecha,
            this.tsmiQuitarFiltro});
            this.filtrarPorToolStripMenuItem.Name = "filtrarPorToolStripMenuItem";
            this.filtrarPorToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.filtrarPorToolStripMenuItem.Text = "Filtrar por";
            // 
            // tsmiFiltroSaludable
            // 
            this.tsmiFiltroSaludable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSiSaludable,
            this.tsmiNoSaludable});
            this.tsmiFiltroSaludable.Name = "tsmiFiltroSaludable";
            this.tsmiFiltroSaludable.Size = new System.Drawing.Size(180, 22);
            this.tsmiFiltroSaludable.Text = "Saludable";
            // 
            // tsmiSiSaludable
            // 
            this.tsmiSiSaludable.Name = "tsmiSiSaludable";
            this.tsmiSiSaludable.Size = new System.Drawing.Size(94, 22);
            this.tsmiSiSaludable.Text = "Si";
            this.tsmiSiSaludable.Click += new System.EventHandler(this.tsmiSiSaludable_Click);
            // 
            // tsmiNoSaludable
            // 
            this.tsmiNoSaludable.Name = "tsmiNoSaludable";
            this.tsmiNoSaludable.Size = new System.Drawing.Size(94, 22);
            this.tsmiNoSaludable.Text = "No";
            this.tsmiNoSaludable.Click += new System.EventHandler(this.tsmiNoSaludable_Click);
            // 
            // tsmiTipoComida
            // 
            this.tsmiTipoComida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDesayuno,
            this.tsmiAlmuerzo,
            this.tsmiMerienda,
            this.tsmiCena});
            this.tsmiTipoComida.Name = "tsmiTipoComida";
            this.tsmiTipoComida.Size = new System.Drawing.Size(180, 22);
            this.tsmiTipoComida.Text = "Tipo de comida";
            // 
            // tsmiDesayuno
            // 
            this.tsmiDesayuno.Name = "tsmiDesayuno";
            this.tsmiDesayuno.Size = new System.Drawing.Size(137, 22);
            this.tsmiDesayuno.Text = "Desayuno";
            this.tsmiDesayuno.Click += new System.EventHandler(this.tsmiDesayuno_Click);
            // 
            // tsmiAlmuerzo
            // 
            this.tsmiAlmuerzo.Name = "tsmiAlmuerzo";
            this.tsmiAlmuerzo.Size = new System.Drawing.Size(137, 22);
            this.tsmiAlmuerzo.Text = "Almuerzo";
            this.tsmiAlmuerzo.Click += new System.EventHandler(this.tsmiAlmuerzo_Click);
            // 
            // tsmiMerienda
            // 
            this.tsmiMerienda.Name = "tsmiMerienda";
            this.tsmiMerienda.Size = new System.Drawing.Size(137, 22);
            this.tsmiMerienda.Text = "Merienda";
            this.tsmiMerienda.Click += new System.EventHandler(this.tsmiMerienda_Click);
            // 
            // tsmiCena
            // 
            this.tsmiCena.Name = "tsmiCena";
            this.tsmiCena.Size = new System.Drawing.Size(137, 22);
            this.tsmiCena.Text = "Cena";
            this.tsmiCena.Click += new System.EventHandler(this.tsmiCena_Click);
            // 
            // tsmiReceta
            // 
            this.tsmiReceta.Name = "tsmiReceta";
            this.tsmiReceta.Size = new System.Drawing.Size(180, 22);
            this.tsmiReceta.Text = "Receta";
            this.tsmiReceta.Click += new System.EventHandler(this.tsmiReceta_Click);
            // 
            // tsmiFecha
            // 
            this.tsmiFecha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUnica,
            this.tsmiEntreDos});
            this.tsmiFecha.Name = "tsmiFecha";
            this.tsmiFecha.Size = new System.Drawing.Size(180, 22);
            this.tsmiFecha.Text = "Fecha";
            // 
            // tsmiQuitarFiltro
            // 
            this.tsmiQuitarFiltro.Name = "tsmiQuitarFiltro";
            this.tsmiQuitarFiltro.Size = new System.Drawing.Size(180, 22);
            this.tsmiQuitarFiltro.Text = "Quitar filtro";
            this.tsmiQuitarFiltro.Click += new System.EventHandler(this.tsmiQuitarFiltro_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmiUnica
            // 
            this.tsmiUnica.Name = "tsmiUnica";
            this.tsmiUnica.Size = new System.Drawing.Size(180, 22);
            this.tsmiUnica.Text = "Unica";
            this.tsmiUnica.Click += new System.EventHandler(this.tsmiUnica_Click);
            // 
            // tsmiEntreDos
            // 
            this.tsmiEntreDos.Name = "tsmiEntreDos";
            this.tsmiEntreDos.Size = new System.Drawing.Size(180, 22);
            this.tsmiEntreDos.Text = "Entre dos";
            this.tsmiEntreDos.Click += new System.EventHandler(this.tsmiEntreDos_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiFiltroSaludable;
        private System.Windows.Forms.ToolStripMenuItem tsmiTipoComida;
        private System.Windows.Forms.ToolStripMenuItem tsmiReceta;
        private System.Windows.Forms.ToolStripMenuItem tsmiFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_comida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saludable;
        private System.Windows.Forms.ToolStripMenuItem tsmiSiSaludable;
        private System.Windows.Forms.ToolStripMenuItem tsmiNoSaludable;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesayuno;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlmuerzo;
        private System.Windows.Forms.ToolStripMenuItem tsmiMerienda;
        private System.Windows.Forms.ToolStripMenuItem tsmiCena;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitarFiltro;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnica;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntreDos;
    }
}