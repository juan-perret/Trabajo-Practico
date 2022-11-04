namespace FormPrincipal
{
    partial class FormFiltroComidaFecha
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
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.lblfecha1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(164, 27);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha1.TabIndex = 0;
            this.dtpFecha1.ValueChanged += new System.EventHandler(this.dtpFecha1_ValueChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(164, 78);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha2.TabIndex = 1;
            // 
            // lblfecha1
            // 
            this.lblfecha1.AutoSize = true;
            this.lblfecha1.Location = new System.Drawing.Point(9, 27);
            this.lblfecha1.Name = "lblfecha1";
            this.lblfecha1.Size = new System.Drawing.Size(135, 13);
            this.lblfecha1.TabIndex = 2;
            this.lblfecha1.Text = "Seleccione la primer fecha:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(280, 122);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblfecha2
            // 
            this.lblfecha2.AutoSize = true;
            this.lblfecha2.Location = new System.Drawing.Point(8, 84);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(148, 13);
            this.lblfecha2.TabIndex = 5;
            this.lblfecha2.Text = "Seleccione la segunda fecha:";
            // 
            // FormFiltroComidaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 160);
            this.Controls.Add(this.lblfecha2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblfecha1);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Name = "FormFiltroComidaFecha";
            this.Text = "Filtrar comida por fecha";
            this.Load += new System.EventHandler(this.FormFiltroComidaFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label lblfecha1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblfecha2;
    }
}