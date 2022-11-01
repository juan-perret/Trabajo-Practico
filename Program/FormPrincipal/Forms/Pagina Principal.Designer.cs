namespace FormPrincipal
{
    partial class Pag_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.despensaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tusIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaUnIngredienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tusRecetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaUnaRecetaNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tusComidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaUnaComidaNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDelSuperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaLoQueTenesQueComprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despensaToolStripMenuItem,
            this.recetasToolStripMenuItem,
            this.comidasToolStripMenuItem,
            this.listaDelSuperToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // despensaToolStripMenuItem
            // 
            this.despensaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tusIngredientesToolStripMenuItem,
            this.cargaUnIngredienteNuevoToolStripMenuItem});
            this.despensaToolStripMenuItem.Name = "despensaToolStripMenuItem";
            this.despensaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.despensaToolStripMenuItem.Text = "Despensa";
            // 
            // tusIngredientesToolStripMenuItem
            // 
            this.tusIngredientesToolStripMenuItem.Name = "tusIngredientesToolStripMenuItem";
            this.tusIngredientesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tusIngredientesToolStripMenuItem.Text = "Tus ingredientes";
            this.tusIngredientesToolStripMenuItem.Click += new System.EventHandler(this.tusIngredientesToolStripMenuItem_Click);
            // 
            // cargaUnIngredienteNuevoToolStripMenuItem
            // 
            this.cargaUnIngredienteNuevoToolStripMenuItem.Name = "cargaUnIngredienteNuevoToolStripMenuItem";
            this.cargaUnIngredienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cargaUnIngredienteNuevoToolStripMenuItem.Text = "Carga un ingrediente nuevo";
            this.cargaUnIngredienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.cargaUnIngredienteNuevoToolStripMenuItem_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tusRecetasToolStripMenuItem,
            this.creaUnaRecetaNuevaToolStripMenuItem});
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // tusRecetasToolStripMenuItem
            // 
            this.tusRecetasToolStripMenuItem.Name = "tusRecetasToolStripMenuItem";
            this.tusRecetasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tusRecetasToolStripMenuItem.Text = "Tus Recetas";
            this.tusRecetasToolStripMenuItem.Click += new System.EventHandler(this.tusRecetasToolStripMenuItem_Click);
            // 
            // creaUnaRecetaNuevaToolStripMenuItem
            // 
            this.creaUnaRecetaNuevaToolStripMenuItem.Name = "creaUnaRecetaNuevaToolStripMenuItem";
            this.creaUnaRecetaNuevaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.creaUnaRecetaNuevaToolStripMenuItem.Text = "Crea una receta nueva";
            this.creaUnaRecetaNuevaToolStripMenuItem.Click += new System.EventHandler(this.creaUnaRecetaNuevaToolStripMenuItem_Click);
            // 
            // comidasToolStripMenuItem
            // 
            this.comidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tusComidasToolStripMenuItem,
            this.cargaUnaComidaNuevaToolStripMenuItem});
            this.comidasToolStripMenuItem.Name = "comidasToolStripMenuItem";
            this.comidasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comidasToolStripMenuItem.Text = "Comidas";
            // 
            // tusComidasToolStripMenuItem
            // 
            this.tusComidasToolStripMenuItem.Name = "tusComidasToolStripMenuItem";
            this.tusComidasToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.tusComidasToolStripMenuItem.Text = "Tus Comidas";
            this.tusComidasToolStripMenuItem.Click += new System.EventHandler(this.tusComidasToolStripMenuItem_Click);
            // 
            // cargaUnaComidaNuevaToolStripMenuItem
            // 
            this.cargaUnaComidaNuevaToolStripMenuItem.Name = "cargaUnaComidaNuevaToolStripMenuItem";
            this.cargaUnaComidaNuevaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cargaUnaComidaNuevaToolStripMenuItem.Text = "Carga una comida nueva";
            this.cargaUnaComidaNuevaToolStripMenuItem.Click += new System.EventHandler(this.cargaUnaComidaNuevaToolStripMenuItem_Click);
            // 
            // listaDelSuperToolStripMenuItem
            // 
            this.listaDelSuperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaLoQueTenesQueComprarToolStripMenuItem});
            this.listaDelSuperToolStripMenuItem.Name = "listaDelSuperToolStripMenuItem";
            this.listaDelSuperToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.listaDelSuperToolStripMenuItem.Text = "Lista del Super";
            // 
            // consultaLoQueTenesQueComprarToolStripMenuItem
            // 
            this.consultaLoQueTenesQueComprarToolStripMenuItem.Name = "consultaLoQueTenesQueComprarToolStripMenuItem";
            this.consultaLoQueTenesQueComprarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaLoQueTenesQueComprarToolStripMenuItem.Text = "Que debo comprar?";
            this.consultaLoQueTenesQueComprarToolStripMenuItem.Click += new System.EventHandler(this.consultaLoQueTenesQueComprarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbLogo.Image = global::FormPrincipal.Properties.Resources._5dfb70fe26266074c99911272330eb03;
            this.PbLogo.Location = new System.Drawing.Point(0, 27);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(429, 373);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // Pag_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pag_Principal";
            this.Text = "Cook This";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem despensaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tusIngredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaUnIngredienteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tusRecetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaUnaRecetaNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tusComidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaUnaComidaNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDelSuperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaLoQueTenesQueComprarToolStripMenuItem;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

