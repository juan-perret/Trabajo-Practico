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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punto_de_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsListaSuper = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSuper)).BeginInit();
            this.MsListaSuper.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaSuper
            // 
            this.dgvListaSuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSuper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Punto_de_Pedido,
            this.Total});
            this.dgvListaSuper.Location = new System.Drawing.Point(12, 36);
            this.dgvListaSuper.Name = "dgvListaSuper";
            this.dgvListaSuper.RowHeadersWidth = 51;
            this.dgvListaSuper.Size = new System.Drawing.Size(747, 350);
            this.dgvListaSuper.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Punto_de_Pedido
            // 
            this.Punto_de_Pedido.DataPropertyName = "PuntoPedido";
            this.Punto_de_Pedido.HeaderText = "Punto de Pedido";
            this.Punto_de_Pedido.MinimumWidth = 6;
            this.Punto_de_Pedido.Name = "Punto_de_Pedido";
            this.Punto_de_Pedido.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.MsListaSuper.Size = new System.Drawing.Size(776, 25);
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
            this.filtro1ToolStripMenuItem,
            this.filtro2ToolStripMenuItem,
            this.filtro3ToolStripMenuItem,
            this.filtro4ToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.filtrosToolStripMenuItem.Text = "Filtrar por";
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
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(501, 406);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(128, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo total de la Compra: ";
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Location = new System.Drawing.Point(711, 406);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoTotal.TabIndex = 3;
            this.lblResultadoTotal.Text = "0";
            // 
            // FormListaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 428);
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
        private System.Windows.Forms.ToolStripMenuItem filtro1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto_de_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}