namespace FormPrincipal
{
    partial class FormComidaFiltroReceta
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
            this.dgvComidaFiltroReceta = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidaFiltroReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComidaFiltroReceta
            // 
            this.dgvComidaFiltroReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComidaFiltroReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.TipodeReceta,
            this.Saludable});
            this.dgvComidaFiltroReceta.Location = new System.Drawing.Point(12, 12);
            this.dgvComidaFiltroReceta.Name = "dgvComidaFiltroReceta";
            this.dgvComidaFiltroReceta.Size = new System.Drawing.Size(362, 209);
            this.dgvComidaFiltroReceta.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(299, 264);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipodeReceta
            // 
            this.TipodeReceta.DataPropertyName = "TipoComida";
            this.TipodeReceta.HeaderText = "Tipo de Receta";
            this.TipodeReceta.Name = "TipodeReceta";
            this.TipodeReceta.ReadOnly = true;
            // 
            // Saludable
            // 
            this.Saludable.DataPropertyName = "Saludable";
            this.Saludable.FalseValue = "false";
            this.Saludable.HeaderText = "Saludable?";
            this.Saludable.Name = "Saludable";
            this.Saludable.ReadOnly = true;
            this.Saludable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saludable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Saludable.TrueValue = "true";
            // 
            // FormComidaFiltroReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 299);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvComidaFiltroReceta);
            this.Name = "FormComidaFiltroReceta";
            this.Text = "FormComidaFiltroReceta";
            this.Load += new System.EventHandler(this.FormComidaFiltroReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComidaFiltroReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComidaFiltroReceta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeReceta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saludable;
    }
}