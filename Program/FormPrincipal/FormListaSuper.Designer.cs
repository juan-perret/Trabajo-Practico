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
            this.filtro1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punto_de_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Punto_de_Pedido});
            this.dgvListaSuper.Location = new System.Drawing.Point(16, 44);
            this.dgvListaSuper.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaSuper.Name = "dgvListaSuper";
            this.dgvListaSuper.RowHeadersWidth = 51;
            this.dgvListaSuper.Size = new System.Drawing.Size(996, 431);
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
            this.MsListaSuper.Size = new System.Drawing.Size(1035, 31);
            this.MsListaSuper.TabIndex = 1;
            this.MsListaSuper.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
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
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.filtrosToolStripMenuItem.Text = "Filtrar por";
            // 
            // filtro1ToolStripMenuItem
            // 
            this.filtro1ToolStripMenuItem.Name = "filtro1ToolStripMenuItem";
            this.filtro1ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.filtro1ToolStripMenuItem.Text = "Filtro 1";
            // 
            // filtro2ToolStripMenuItem
            // 
            this.filtro2ToolStripMenuItem.Name = "filtro2ToolStripMenuItem";
            this.filtro2ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.filtro2ToolStripMenuItem.Text = "Filtro 2";
            // 
            // filtro3ToolStripMenuItem
            // 
            this.filtro3ToolStripMenuItem.Name = "filtro3ToolStripMenuItem";
            this.filtro3ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.filtro3ToolStripMenuItem.Text = "Filtro 3";
            // 
            // filtro4ToolStripMenuItem
            // 
            this.filtro4ToolStripMenuItem.Name = "filtro4ToolStripMenuItem";
            this.filtro4ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.filtro4ToolStripMenuItem.Text = "Filtro 4";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Costo total de la Compra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
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
            // FormListaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaSuper);
            this.Controls.Add(this.MsListaSuper);
            this.MainMenuStrip = this.MsListaSuper;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto_de_Pedido;
    }
}