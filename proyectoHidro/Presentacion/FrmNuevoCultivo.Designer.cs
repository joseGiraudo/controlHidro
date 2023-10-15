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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.lblFecha.Location = new System.Drawing.Point(221, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha inicio: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(297, 31);
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
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(313, 124);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(143, 20);
            this.txtDesc.TabIndex = 8;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(309, 96);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(84, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Observaciones: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(297, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(78, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 278);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDesc);
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
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}