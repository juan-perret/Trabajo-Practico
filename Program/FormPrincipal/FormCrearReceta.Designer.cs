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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 42);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RECETAS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoReceta
            // 
            this.lblTipoReceta.AutoSize = true;
            this.lblTipoReceta.Location = new System.Drawing.Point(43, 160);
            this.lblTipoReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoReceta.Name = "lblTipoReceta";
            this.lblTipoReceta.Size = new System.Drawing.Size(101, 16);
            this.lblTipoReceta.TabIndex = 2;
            this.lblTipoReceta.Text = "Tipo de Receta";
            // 
            // lblSaludable
            // 
            this.lblSaludable.AutoSize = true;
            this.lblSaludable.Location = new System.Drawing.Point(43, 212);
            this.lblSaludable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludable.Name = "lblSaludable";
            this.lblSaludable.Size = new System.Drawing.Size(76, 16);
            this.lblSaludable.TabIndex = 3;
            this.lblSaludable.Text = "Saludable?";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(43, 261);
            this.lblIngredientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(81, 16);
            this.lblIngredientes.TabIndex = 4;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 24);
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
            this.cmbTipoReceta.Location = new System.Drawing.Point(216, 156);
            this.cmbTipoReceta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoReceta.Name = "cmbTipoReceta";
            this.cmbTipoReceta.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoReceta.TabIndex = 6;
            // 
            // checkbSaludable
            // 
            this.checkbSaludable.AutoSize = true;
            this.checkbSaludable.Location = new System.Drawing.Point(216, 212);
            this.checkbSaludable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbSaludable.Name = "checkbSaludable";
            this.checkbSaludable.Size = new System.Drawing.Size(109, 20);
            this.checkbSaludable.TabIndex = 7;
            this.checkbSaludable.Text = "Tildar si lo es";
            this.checkbSaludable.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(47, 352);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(289, 348);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormCrearReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 410);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCrearReceta";
            this.Text = "Crea tu Receta";
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
    }
}