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
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RECETAS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoReceta
            // 
            this.lblTipoReceta.AutoSize = true;
            this.lblTipoReceta.Location = new System.Drawing.Point(20, 103);
            this.lblTipoReceta.Name = "lblTipoReceta";
            this.lblTipoReceta.Size = new System.Drawing.Size(81, 13);
            this.lblTipoReceta.TabIndex = 2;
            this.lblTipoReceta.Text = "Tipo de Receta";
            // 
            // lblSaludable
            // 
            this.lblSaludable.AutoSize = true;
            this.lblSaludable.Location = new System.Drawing.Point(20, 145);
            this.lblSaludable.Name = "lblSaludable";
            this.lblSaludable.Size = new System.Drawing.Size(60, 13);
            this.lblSaludable.TabIndex = 3;
            this.lblSaludable.Text = "Saludable?";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(20, 185);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(65, 13);
            this.lblIngredientes.TabIndex = 4;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 61);
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
            this.cmbTipoReceta.Location = new System.Drawing.Point(150, 100);
            this.cmbTipoReceta.Name = "cmbTipoReceta";
            this.cmbTipoReceta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReceta.TabIndex = 6;
            // 
            // checkbSaludable
            // 
            this.checkbSaludable.AutoSize = true;
            this.checkbSaludable.Location = new System.Drawing.Point(150, 145);
            this.checkbSaludable.Name = "checkbSaludable";
            this.checkbSaludable.Size = new System.Drawing.Size(87, 17);
            this.checkbSaludable.TabIndex = 7;
            this.checkbSaludable.Text = "Tildar si lo es";
            this.checkbSaludable.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(17, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(440, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(66, 26);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Acpetar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoria,
            this.Seleccionar});
            this.dgvIngredientes.Location = new System.Drawing.Point(123, 185);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(371, 177);
            this.dgvIngredientes.TabIndex = 10;
            this.dgvIngredientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIngredientes_DataBindingComplete);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // FormCrearReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 403);
            this.Controls.Add(this.dgvIngredientes);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}