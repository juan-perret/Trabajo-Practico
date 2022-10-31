namespace FormPrincipal
{
    partial class FormCrearReceta
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoReceta = new System.Windows.Forms.Label();
            this.lblSaludable = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoReceta = new System.Windows.Forms.ComboBox();
            this.checkbSaludable = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvIngredientesRecetas = new System.Windows.Forms.DataGridView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RECETAS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoReceta
            // 
            this.lblTipoReceta.AutoSize = true;
            this.lblTipoReceta.Location = new System.Drawing.Point(32, 130);
            this.lblTipoReceta.Name = "lblTipoReceta";
            this.lblTipoReceta.Size = new System.Drawing.Size(81, 13);
            this.lblTipoReceta.TabIndex = 2;
            this.lblTipoReceta.Text = "Tipo de Receta";
            // 
            // lblSaludable
            // 
            this.lblSaludable.AutoSize = true;
            this.lblSaludable.Location = new System.Drawing.Point(32, 172);
            this.lblSaludable.Name = "lblSaludable";
            this.lblSaludable.Size = new System.Drawing.Size(60, 13);
            this.lblSaludable.TabIndex = 3;
            this.lblSaludable.Text = "Saludable?";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(32, 212);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(65, 13);
            this.lblIngredientes.TabIndex = 4;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 95);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbTipoReceta
            // 
            this.cmbTipoReceta.FormattingEnabled = true;
            this.cmbTipoReceta.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.cmbTipoReceta.Location = new System.Drawing.Point(162, 130);
            this.cmbTipoReceta.Name = "cmbTipoReceta";
            this.cmbTipoReceta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReceta.TabIndex = 6;
            // 
            // checkbSaludable
            // 
            this.checkbSaludable.AutoSize = true;
            this.checkbSaludable.Location = new System.Drawing.Point(162, 172);
            this.checkbSaludable.Name = "checkbSaludable";
            this.checkbSaludable.Size = new System.Drawing.Size(87, 17);
            this.checkbSaludable.TabIndex = 7;
            this.checkbSaludable.Text = "Tildar si lo es";
            this.checkbSaludable.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(35, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(474, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(66, 26);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvIngredientesRecetas
            // 
            this.dgvIngredientesRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientesRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Cantidad,
            this.Seleccion});
            this.dgvIngredientesRecetas.Location = new System.Drawing.Point(162, 212);
            this.dgvIngredientesRecetas.Name = "dgvIngredientesRecetas";
            this.dgvIngredientesRecetas.Size = new System.Drawing.Size(347, 124);
            this.dgvIngredientesRecetas.TabIndex = 10;
            this.dgvIngredientesRecetas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientesRecetas_CellValueChanged);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 40;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 50F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Seleccion";
            this.Cantidad.HeaderText = "Cantidad (Kg/Un)";
            this.Cantidad.MinimumWidth = 120;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccion.FalseValue = "false";
            this.Seleccion.HeaderText = "Agregar?";
            this.Seleccion.MinimumWidth = 30;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.TrueValue = "true";
            this.Seleccion.Width = 75;
            // 
            // FormCrearReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.dgvIngredientesRecetas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkbSaludable);
            this.Controls.Add(this.cmbTipoReceta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblSaludable);
            this.Controls.Add(this.lblTipoReceta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormCrearReceta";
            this.Text = "Crea tu Receta";
            this.Load += new System.EventHandler(this.FormCrearReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoReceta;
        private System.Windows.Forms.Label lblSaludable;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipoReceta;
        private System.Windows.Forms.CheckBox checkbSaludable;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvIngredientesRecetas;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
    }
}