namespace proyectoHidro.Presentacion
{
    partial class FrmNuevoCultivo
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
            this.lblCodCultivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.cboTipoCultivo = new System.Windows.Forms.ComboBox();
            this.lblGenetica = new System.Windows.Forms.Label();
            this.txtGenetica = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodCultivo
            // 
            this.lblCodCultivo.AutoSize = true;
            this.lblCodCultivo.Location = new System.Drawing.Point(42, 31);
            this.lblCodCultivo.Name = "lblCodCultivo";
            this.lblCodCultivo.Size = new System.Drawing.Size(55, 13);
            this.lblCodCultivo.TabIndex = 0;
            this.lblCodCultivo.Text = "Cultivo n°:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(287, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(349, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Location = new System.Drawing.Point(37, 91);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(84, 13);
            this.lblTipoCultivo.TabIndex = 3;
            this.lblTipoCultivo.Text = "Tipo de Cultivo: ";
            // 
            // cboTipoCultivo
            // 
            this.cboTipoCultivo.FormattingEnabled = true;
            this.cboTipoCultivo.Location = new System.Drawing.Point(127, 88);
            this.cboTipoCultivo.Name = "cboTipoCultivo";
            this.cboTipoCultivo.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCultivo.TabIndex = 4;
            // 
            // lblGenetica
            // 
            this.lblGenetica.AutoSize = true;
            this.lblGenetica.Location = new System.Drawing.Point(42, 130);
            this.lblGenetica.Name = "lblGenetica";
            this.lblGenetica.Size = new System.Drawing.Size(56, 13);
            this.lblGenetica.TabIndex = 5;
            this.lblGenetica.Text = "Genética: ";
            // 
            // txtGenetica
            // 
            this.txtGenetica.Location = new System.Drawing.Point(105, 130);
            this.txtGenetica.Name = "txtGenetica";
            this.txtGenetica.Size = new System.Drawing.Size(143, 20);
            this.txtGenetica.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(286, 74);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(84, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Observaciones: ";
            // 
            // FrmNuevoCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtGenetica);
            this.Controls.Add(this.lblGenetica);
            this.Controls.Add(this.cboTipoCultivo);
            this.Controls.Add(this.lblTipoCultivo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCodCultivo);
            this.Name = "FrmNuevoCultivo";
            this.Text = "FrmNuevoCultivo";
            this.Load += new System.EventHandler(this.FrmNuevoCultivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCultivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.ComboBox cboTipoCultivo;
        private System.Windows.Forms.Label lblGenetica;
        private System.Windows.Forms.TextBox txtGenetica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDesc;
    }
}