namespace proyectoHidro.Presentacion
{
    partial class FrmCultivo
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
            this.lblGenetica = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.dgvControles = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenetica
            // 
            this.lblGenetica.AutoSize = true;
            this.lblGenetica.Location = new System.Drawing.Point(39, 40);
            this.lblGenetica.Name = "lblGenetica";
            this.lblGenetica.Size = new System.Drawing.Size(50, 13);
            this.lblGenetica.TabIndex = 0;
            this.lblGenetica.Text = "Genética";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(39, 74);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 1;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // dgvControles
            // 
            this.dgvControles.AllowUserToAddRows = false;
            this.dgvControles.AllowUserToDeleteRows = false;
            this.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipo,
            this.colFecha,
            this.colPH,
            this.colPPM,
            this.colEC,
            this.colAccion});
            this.dgvControles.Location = new System.Drawing.Point(64, 130);
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.ReadOnly = true;
            this.dgvControles.Size = new System.Drawing.Size(568, 150);
            this.dgvControles.TabIndex = 2;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 50;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Control";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 150;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colPH
            // 
            this.colPH.HeaderText = "ph";
            this.colPH.Name = "colPH";
            this.colPH.ReadOnly = true;
            this.colPH.Width = 50;
            // 
            // colPPM
            // 
            this.colPPM.HeaderText = "ppm";
            this.colPPM.Name = "colPPM";
            this.colPPM.ReadOnly = true;
            this.colPPM.Width = 50;
            // 
            // colEC
            // 
            this.colEC.HeaderText = "ec";
            this.colEC.Name = "colEC";
            this.colEC.ReadOnly = true;
            this.colEC.Width = 50;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Width = 75;
            // 
            // FrmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.dgvControles);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblGenetica);
            this.Name = "FrmCultivo";
            this.Text = "FrmCultivo";
            this.Load += new System.EventHandler(this.FrmCultivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenetica;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.DataGridView dgvControles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEC;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
    }
}