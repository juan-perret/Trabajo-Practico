namespace FormPrincipal
{
    partial class FormListaSuper
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
            this.dgvListaSuper = new System.Windows.Forms.DataGridView();
            this.MsListaSuper = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHortalizasYVerduras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFruta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLacteo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCarnes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPescado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPanaderia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBebidaAltaAzucar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBebidaNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBebidaAlcoholica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCosto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnidadMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLitros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPuntoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitarFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punto_de_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSuper)).BeginInit();
            this.MsListaSuper.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaSuper
            // 
            this.dgvListaSuper.AllowUserToResizeColumns = false;
            this.dgvListaSuper.AllowUserToResizeRows = false;
            this.dgvListaSuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSuper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Punto_de_Pedido,
            this.Total,
            this.TipoComida,
            this.Id});
            this.dgvListaSuper.Location = new System.Drawing.Point(12, 36);
            this.dgvListaSuper.Name = "dgvListaSuper";
            this.dgvListaSuper.RowHeadersWidth = 51;
            this.dgvListaSuper.Size = new System.Drawing.Size(531, 350);
            this.dgvListaSuper.TabIndex = 0;
            // 
            // MsListaSuper
            // 
            this.MsListaSuper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsListaSuper.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsListaSuper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MsListaSuper.Location = new System.Drawing.Point(0, 0);
            this.MsListaSuper.Name = "MsListaSuper";
            this.MsListaSuper.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MsListaSuper.Size = new System.Drawing.Size(557, 25);
            this.MsListaSuper.TabIndex = 1;
            this.MsListaSuper.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTipoProducto,
            this.tsmiCosto,
            this.tsmiUnidadMedida,
            this.tsmiPuntoPedido,
            this.tsmiQuitarFiltro});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.filtrosToolStripMenuItem.Text = "Filtrar por";
            // 
            // tsmiTipoProducto
            // 
            this.tsmiTipoProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHortalizasYVerduras,
            this.tsmiFruta,
            this.tsmiQueso,
            this.tsmiLacteo,
            this.tsmiCarnes,
            this.tsmiPescado,
            this.tsmiPanaderia,
            this.tsmiBebidaAltaAzucar,
            this.tsmiBebidaNormal,
            this.tsmiBebidaAlcoholica});
            this.tsmiTipoProducto.Name = "tsmiTipoProducto";
            this.tsmiTipoProducto.Size = new System.Drawing.Size(183, 22);
            this.tsmiTipoProducto.Text = "Tipo de producto";
            this.tsmiTipoProducto.Click += new System.EventHandler(this.filtro1ToolStripMenuItem_Click);
            // 
            // tsmiHortalizasYVerduras
            // 
            this.tsmiHortalizasYVerduras.Name = "tsmiHortalizasYVerduras";
            this.tsmiHortalizasYVerduras.Size = new System.Drawing.Size(219, 22);
            this.tsmiHortalizasYVerduras.Text = "Hortalizas y verduras";
            this.tsmiHortalizasYVerduras.Click += new System.EventHandler(this.tsmiHortalizasYVerduras_Click);
            // 
            // tsmiFruta
            // 
            this.tsmiFruta.AccessibleName = "";
            this.tsmiFruta.Name = "tsmiFruta";
            this.tsmiFruta.Size = new System.Drawing.Size(219, 22);
            this.tsmiFruta.Text = "Frutas";
            this.tsmiFruta.Click += new System.EventHandler(this.tsmiFruta_Click);
            // 
            // tsmiQueso
            // 
            this.tsmiQueso.AccessibleName = "Frutas";
            this.tsmiQueso.Name = "tsmiQueso";
            this.tsmiQueso.Size = new System.Drawing.Size(219, 22);
            this.tsmiQueso.Text = "Quesos";
            this.tsmiQueso.Click += new System.EventHandler(this.tsmiQueso_Click);
            // 
            // tsmiLacteo
            // 
            this.tsmiLacteo.Name = "tsmiLacteo";
            this.tsmiLacteo.Size = new System.Drawing.Size(219, 22);
            this.tsmiLacteo.Text = "Lacteos";
            this.tsmiLacteo.Click += new System.EventHandler(this.tsmiLacteo_Click);
            // 
            // tsmiCarnes
            // 
            this.tsmiCarnes.Name = "tsmiCarnes";
            this.tsmiCarnes.Size = new System.Drawing.Size(219, 22);
            this.tsmiCarnes.Text = "Carnes";
            this.tsmiCarnes.Click += new System.EventHandler(this.tsmiCarnes_Click);
            // 
            // tsmiPescado
            // 
            this.tsmiPescado.Name = "tsmiPescado";
            this.tsmiPescado.Size = new System.Drawing.Size(219, 22);
            this.tsmiPescado.Text = "Pescados";
            this.tsmiPescado.Click += new System.EventHandler(this.tsmiPescado_Click);
            // 
            // tsmiPanaderia
            // 
            this.tsmiPanaderia.Name = "tsmiPanaderia";
            this.tsmiPanaderia.Size = new System.Drawing.Size(219, 22);
            this.tsmiPanaderia.Text = "Panaderia";
            this.tsmiPanaderia.Click += new System.EventHandler(this.tsmiPanaderia_Click);
            // 
            // tsmiBebidaAltaAzucar
            // 
            this.tsmiBebidaAltaAzucar.Name = "tsmiBebidaAltaAzucar";
            this.tsmiBebidaAltaAzucar.Size = new System.Drawing.Size(219, 22);
            this.tsmiBebidaAltaAzucar.Text = "Bebidas altas en azucar";
            this.tsmiBebidaAltaAzucar.Click += new System.EventHandler(this.tsmiBebidaAltaAzucar_Click);
            // 
            // tsmiBebidaNormal
            // 
            this.tsmiBebidaNormal.Name = "tsmiBebidaNormal";
            this.tsmiBebidaNormal.Size = new System.Drawing.Size(219, 22);
            this.tsmiBebidaNormal.Text = "Bebidas normales";
            this.tsmiBebidaNormal.Click += new System.EventHandler(this.tsmiBebidaNormal_Click);
            // 
            // tsmiBebidaAlcoholica
            // 
            this.tsmiBebidaAlcoholica.Name = "tsmiBebidaAlcoholica";
            this.tsmiBebidaAlcoholica.Size = new System.Drawing.Size(219, 22);
            this.tsmiBebidaAlcoholica.Text = "Bebidas alcoholicas";
            this.tsmiBebidaAlcoholica.Click += new System.EventHandler(this.tsmiBebidaAlcoholica_Click);
            // 
            // tsmiCosto
            // 
            this.tsmiCosto.Name = "tsmiCosto";
            this.tsmiCosto.Size = new System.Drawing.Size(183, 22);
            this.tsmiCosto.Text = "Costo";
            this.tsmiCosto.Click += new System.EventHandler(this.tsmiCosto_Click);
            // 
            // tsmiUnidadMedida
            // 
            this.tsmiUnidadMedida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKg,
            this.tsmiLitros,
            this.tsmiUnidad});
            this.tsmiUnidadMedida.Name = "tsmiUnidadMedida";
            this.tsmiUnidadMedida.Size = new System.Drawing.Size(183, 22);
            this.tsmiUnidadMedida.Text = "Unidad medida";
            // 
            // tsmiKg
            // 
            this.tsmiKg.Name = "tsmiKg";
            this.tsmiKg.Size = new System.Drawing.Size(140, 22);
            this.tsmiKg.Text = "Kilogramo";
            this.tsmiKg.Click += new System.EventHandler(this.kilogramoToolStripMenuItem_Click);
            // 
            // tsmiLitros
            // 
            this.tsmiLitros.Name = "tsmiLitros";
            this.tsmiLitros.Size = new System.Drawing.Size(140, 22);
            this.tsmiLitros.Text = "Litros";
            this.tsmiLitros.Click += new System.EventHandler(this.litrosToolStripMenuItem_Click);
            // 
            // tsmiUnidad
            // 
            this.tsmiUnidad.Name = "tsmiUnidad";
            this.tsmiUnidad.Size = new System.Drawing.Size(140, 22);
            this.tsmiUnidad.Text = "Unidad";
            this.tsmiUnidad.Click += new System.EventHandler(this.unidadToolStripMenuItem_Click);
            // 
            // tsmiPuntoPedido
            // 
            this.tsmiPuntoPedido.Name = "tsmiPuntoPedido";
            this.tsmiPuntoPedido.Size = new System.Drawing.Size(183, 22);
            this.tsmiPuntoPedido.Text = "Punto pedido";
            this.tsmiPuntoPedido.Click += new System.EventHandler(this.tsmiPuntoPedido_Click);
            // 
            // tsmiQuitarFiltro
            // 
            this.tsmiQuitarFiltro.Name = "tsmiQuitarFiltro";
            this.tsmiQuitarFiltro.Size = new System.Drawing.Size(183, 22);
            this.tsmiQuitarFiltro.Text = "Quitar Filtro";
            this.tsmiQuitarFiltro.Click += new System.EventHandler(this.tsmiQuitarFiltro_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(323, 406);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(128, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo total de la Compra: ";
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Location = new System.Drawing.Point(494, 406);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoTotal.TabIndex = 3;
            this.lblResultadoTotal.Text = "0";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(12, 401);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(103, 23);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Punto_de_Pedido
            // 
            this.Punto_de_Pedido.DataPropertyName = "PuntoPedido";
            this.Punto_de_Pedido.HeaderText = "Punto de Pedido";
            this.Punto_de_Pedido.MinimumWidth = 6;
            this.Punto_de_Pedido.Name = "Punto_de_Pedido";
            this.Punto_de_Pedido.ReadOnly = true;
            this.Punto_de_Pedido.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoComida
            // 
            this.TipoComida.DataPropertyName = "TipoProducto";
            this.TipoComida.HeaderText = "TipoComida";
            this.TipoComida.Name = "TipoComida";
            this.TipoComida.ReadOnly = true;
            this.TipoComida.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FormListaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 428);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.dgvListaSuper);
            this.Controls.Add(this.MsListaSuper);
            this.MainMenuStrip = this.MsListaSuper;
            this.Name = "FormListaSuper";
            this.Text = "Lista del Super";
            this.Load += new System.EventHandler(this.FormListaSuper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSuper)).EndInit();
            this.MsListaSuper.ResumeLayout(false);
            this.MsListaSuper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaSuper;
        private System.Windows.Forms.MenuStrip MsListaSuper;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiCosto;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnidadMedida;
        private System.Windows.Forms.ToolStripMenuItem tsmiPuntoPedido;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ToolStripMenuItem tsmiHortalizasYVerduras;
        private System.Windows.Forms.ToolStripMenuItem tsmiFruta;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueso;
        private System.Windows.Forms.ToolStripMenuItem tsmiLacteo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCarnes;
        private System.Windows.Forms.ToolStripMenuItem tsmiPescado;
        private System.Windows.Forms.ToolStripMenuItem tsmiPanaderia;
        private System.Windows.Forms.ToolStripMenuItem tsmiBebidaAltaAzucar;
        private System.Windows.Forms.ToolStripMenuItem tsmiBebidaNormal;
        private System.Windows.Forms.ToolStripMenuItem tsmiBebidaAlcoholica;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitarFiltro;
        private System.Windows.Forms.ToolStripMenuItem tsmiKg;
        private System.Windows.Forms.ToolStripMenuItem tsmiLitros;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto_de_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}