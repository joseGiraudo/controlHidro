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
            this.btnAgregarControl = new System.Windows.Forms.Button();
            this.lblNroCult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenetica
            // 
            this.lblGenetica.AutoSize = true;
            this.lblGenetica.Location = new System.Drawing.Point(12, 40);
            this.lblGenetica.Name = "lblGenetica";
            this.lblGenetica.Size = new System.Drawing.Size(50, 13);
            this.lblGenetica.TabIndex = 0;
            this.lblGenetica.Text = "Genética";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(12, 72);
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
            this.dgvControles.Location = new System.Drawing.Point(58, 110);
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.ReadOnly = true;
            this.dgvControles.Size = new System.Drawing.Size(568, 183);
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
            // btnAgregarControl
            // 
            this.btnAgregarControl.Location = new System.Drawing.Point(483, 81);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarControl.TabIndex = 3;
            this.btnAgregarControl.Text = "Agregar Control";
            this.btnAgregarControl.UseVisualStyleBackColor = true;
            this.btnAgregarControl.Click += new System.EventHandler(this.btnAgregarControl_Click);
            // 
            // lblNroCult
            // 
            this.lblNroCult.AutoSize = true;
            this.lblNroCult.Location = new System.Drawing.Point(12, 9);
            this.lblNroCult.Name = "lblNroCult";
            this.lblNroCult.Size = new System.Drawing.Size(57, 13);
            this.lblNroCult.TabIndex = 4;
            this.lblNroCult.Text = "Cultivo N° ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNroCult);
            this.Controls.Add(this.btnAgregarControl);
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
        private System.Windows.Forms.Button btnAgregarControl;
        private System.Windows.Forms.Label lblNroCult;
        private System.Windows.Forms.Button button1;
    }
}