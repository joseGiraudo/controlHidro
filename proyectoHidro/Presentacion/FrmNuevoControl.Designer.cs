namespace proyectoHidro.Presentacion
{
    partial class FrmNuevoControl
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboTipoControl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(359, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(177, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboTipoControl
            // 
            this.cboTipoControl.FormattingEnabled = true;
            this.cboTipoControl.Location = new System.Drawing.Point(112, 27);
            this.cboTipoControl.Name = "cboTipoControl";
            this.cboTipoControl.Size = new System.Drawing.Size(140, 21);
            this.cboTipoControl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Control";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(359, 53);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PH:";
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(112, 57);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(82, 20);
            this.txtPH.TabIndex = 7;
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(112, 109);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(82, 20);
            this.txtEC.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EC:";
            // 
            // txtPPM
            // 
            this.txtPPM.Location = new System.Drawing.Point(112, 83);
            this.txtPPM.Name = "txtPPM";
            this.txtPPM.Size = new System.Drawing.Size(82, 20);
            this.txtPPM.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PPM:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(347, 79);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(306, 20);
            this.txtObs.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Obs:";
            // 
            // FrmNuevoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 200);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoControl);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmNuevoControl";
            this.Text = "FrmNuevoControl";
            this.Load += new System.EventHandler(this.FrmNuevoControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboTipoControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtEC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label6;
    }
}