using proyectoHidro.Entidades;
using proyectoHidro.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHidro.Presentacion
{
    public partial class FrmNuevoCultivo : Form
    {
        IServicio servicio;
        Cultivo cultivo;
        int nroCultivo;
        public FrmNuevoCultivo()
        {
            InitializeComponent();
            servicio = new Servicio();
            nroCultivo = servicio.ProximoCultivo();
            lblCodCultivo.Text = "Cultivo n° " + nroCultivo.ToString();
        }

        private void FrmNuevoCultivo_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        private void CargarTipos()
        {
            cboTipoCultivo.DataSource = servicio.TraerTipos();
            cboTipoCultivo.ValueMember = "Codigo";
            cboTipoCultivo.DisplayMember = "Tipo";
            cboTipoCultivo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // validaciones

            int tipo = (int)cboTipoCultivo.SelectedValue;
            string gen = txtGenetica.Text;
            string obs = txtDesc.Text;
            DateTime fecha = dtpFecha.Value;

            cultivo = new Cultivo(nroCultivo, tipo, obs, fecha, gen);
            if (servicio.CargarCultivo(cultivo))
            {
                MessageBox.Show("Se cargo con exito el cultivo");
            }
        }
    }
}
