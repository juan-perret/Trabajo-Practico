namespace FormPrincipal
{
    partial class FormRegistrarComida
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
            this.dgvSeleccionReceta = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaComida = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSeleccionaReceta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltroComida = new System.Windows.Forms.Label();
            this.Nombre_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionReceta
            // 
            this.dgvSeleccionReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Receta,
            this.Tipo_de_comida,
            this.Saludable,
            this.Seleccion});
            this.dgvSeleccionReceta.Location = new System.Drawing.Point(203, 135);
            this.dgvSeleccionReceta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSeleccionReceta.Name = "dgvSeleccionReceta";
            this.dgvSeleccionReceta.RowHeadersWidth = 51;
            this.dgvSeleccionReceta.Size = new System.Drawing.Size(457, 209);
            this.dgvSeleccionReceta.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRA TUS COMIDAS";
            // 
            // dtpFechaComida
            // 
            this.dtpFechaComida.Location = new System.Drawing.Point(203, 78);
            this.dtpFechaComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaComida.Name = "dtpFechaComida";
            this.dtpFechaComida.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaComida.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 85);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(127, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Selecciona tu fecha:";
            // 
            // lblSeleccionaReceta
            // 
            this.lblSeleccionaReceta.AutoSize = true;
            this.lblSeleccionaReceta.Location = new System.Drawing.Point(32, 135);
            this.lblSeleccionaReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionaReceta.Name = "lblSeleccionaReceta";
            this.lblSeleccionaReceta.Size = new System.Drawing.Size(136, 16);
            this.lblSeleccionaReceta.TabIndex = 4;
            this.lblSeleccionaReceta.Text = "Selecciona la receta: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 382);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(617, 382);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.comboBox1.Location = new System.Drawing.Point(36, 209);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lblFiltroComida
            // 
            this.lblFiltroComida.AutoSize = true;
            this.lblFiltroComida.Location = new System.Drawing.Point(36, 178);
            this.lblFiltroComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroComida.Name = "lblFiltroComida";
            this.lblFiltroComida.Size = new System.Drawing.Size(66, 16);
            this.lblFiltroComida.TabIndex = 8;
            this.lblFiltroComida.Text = "Filtrar por:";
            // 
            // Nombre_Receta
            // 
            this.Nombre_Receta.DataPropertyName = "Nombre";
            this.Nombre_Receta.HeaderText = "Nombre de la Receta";
            this.Nombre_Receta.MinimumWidth = 6;
            this.Nombre_Receta.Name = "Nombre_Receta";
            this.Nombre_Receta.Width = 125;
            // 
            // Tipo_de_comida
            // 
            this.Tipo_de_comida.DataPropertyName = "TipoComida";
            this.Tipo_de_comida.HeaderText = "Tipo de Comida";
            this.Tipo_de_comida.MinimumWidth = 6;
            this.Tipo_de_comida.Name = "Tipo_de_comida";
            this.Tipo_de_comida.Width = 125;
            // 
            // Saludable
            // 
            this.Saludable.DataPropertyName = "Saludable";
            this.Saludable.HeaderText = "Es saludable?";
            this.Saludable.MinimumWidth = 6;
            this.Saludable.Name = "Saludable";
            this.Saludable.Width = 125;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "";
            this.Seleccion.MinimumWidth = 6;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 125;
            // 
            // FormRegistrarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 425);
            this.Controls.Add(this.lblFiltroComida);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSeleccionaReceta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaComida);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSeleccionReceta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegistrarComida";
            this.Text = "FormRegistrarComida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionReceta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaComida;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSeleccionaReceta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltroComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saludable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccion;
    }
}