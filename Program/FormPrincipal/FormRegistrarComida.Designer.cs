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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionReceta
            // 
            this.dgvSeleccionReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionReceta.Location = new System.Drawing.Point(152, 110);
            this.dgvSeleccionReceta.Name = "dgvSeleccionReceta";
            this.dgvSeleccionReceta.Size = new System.Drawing.Size(359, 170);
            this.dgvSeleccionReceta.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(40, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registra tus Comidas";
            // 
            // dtpFechaComida
            // 
            this.dtpFechaComida.Location = new System.Drawing.Point(147, 69);
            this.dtpFechaComida.Name = "dtpFechaComida";
            this.dtpFechaComida.Size = new System.Drawing.Size(185, 20);
            this.dtpFechaComida.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Selecciona tu fecha:";
            // 
            // lblSeleccionaReceta
            // 
            this.lblSeleccionaReceta.AutoSize = true;
            this.lblSeleccionaReceta.Location = new System.Drawing.Point(36, 110);
            this.lblSeleccionaReceta.Name = "lblSeleccionaReceta";
            this.lblSeleccionaReceta.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccionaReceta.TabIndex = 4;
            this.lblSeleccionaReceta.Text = "Selecciona la receta: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(463, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 345);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSeleccionaReceta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaComida);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSeleccionReceta);
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
    }
}