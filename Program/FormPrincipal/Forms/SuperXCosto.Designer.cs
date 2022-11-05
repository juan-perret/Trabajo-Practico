namespace FormPrincipal.Forms
{
    partial class SuperXCosto
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
            this.lblCosto = new System.Windows.Forms.Label();
            this.cmbMaxMin = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(27, 27);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 0;
            this.lblCosto.Text = "Costo";
            // 
            // cmbMaxMin
            // 
            this.cmbMaxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxMin.FormattingEnabled = true;
            this.cmbMaxMin.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cmbMaxMin.Location = new System.Drawing.Point(143, 66);
            this.cmbMaxMin.Name = "cmbMaxMin";
            this.cmbMaxMin.Size = new System.Drawing.Size(100, 21);
            this.cmbMaxMin.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(143, 27);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(168, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.Location = new System.Drawing.Point(27, 74);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(49, 13);
            this.lblMaxMin.TabIndex = 5;
            this.lblMaxMin.Text = "Max/Min";
            // 
            // SuperXCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 153);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.cmbMaxMin);
            this.Controls.Add(this.lblCosto);
            this.Name = "SuperXCosto";
            this.Text = "SuperXCosto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbMaxMin;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMaxMin;
    }
}