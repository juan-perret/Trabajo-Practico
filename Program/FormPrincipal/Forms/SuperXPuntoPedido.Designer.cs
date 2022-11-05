namespace FormPrincipal.Forms
{
    partial class SuperXPuntoPedido
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
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPuntoPedido = new System.Windows.Forms.TextBox();
            this.cmbMaxMin = new System.Windows.Forms.ComboBox();
            this.lblPuntoPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.Location = new System.Drawing.Point(26, 66);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(49, 13);
            this.lblMaxMin.TabIndex = 11;
            this.lblMaxMin.Text = "Max/Min";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(167, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPuntoPedido
            // 
            this.txtPuntoPedido.Location = new System.Drawing.Point(142, 24);
            this.txtPuntoPedido.Name = "txtPuntoPedido";
            this.txtPuntoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoPedido.TabIndex = 8;
            // 
            // cmbMaxMin
            // 
            this.cmbMaxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxMin.FormattingEnabled = true;
            this.cmbMaxMin.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cmbMaxMin.Location = new System.Drawing.Point(142, 63);
            this.cmbMaxMin.Name = "cmbMaxMin";
            this.cmbMaxMin.Size = new System.Drawing.Size(100, 21);
            this.cmbMaxMin.TabIndex = 7;
            // 
            // lblPuntoPedido
            // 
            this.lblPuntoPedido.AutoSize = true;
            this.lblPuntoPedido.Location = new System.Drawing.Point(26, 27);
            this.lblPuntoPedido.Name = "lblPuntoPedido";
            this.lblPuntoPedido.Size = new System.Drawing.Size(70, 13);
            this.lblPuntoPedido.TabIndex = 6;
            this.lblPuntoPedido.Text = "Punto pedido";
            // 
            // SuperXPuntoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 154);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPuntoPedido);
            this.Controls.Add(this.cmbMaxMin);
            this.Controls.Add(this.lblPuntoPedido);
            this.Name = "SuperXPuntoPedido";
            this.Text = "SuperXPuntoPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxMin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPuntoPedido;
        private System.Windows.Forms.ComboBox cmbMaxMin;
        private System.Windows.Forms.Label lblPuntoPedido;
    }
}