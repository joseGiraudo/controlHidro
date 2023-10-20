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
    public partial class FrmCultivo : Form
    {
        Cultivo cultivo;
        IServicio servicio;
        List<Entidades.Control> lControles;
        public FrmCultivo(int codCultivo)
        {
            InitializeComponent();
            servicio = new Servicio();
            cultivo = servicio.TraerCultivo(codCultivo);
        }

        private void FrmCultivo_Load(object sender, EventArgs e)
        {
            // cargo los datos del cultivo
            lblNroCult.Text = "Cultivo N° " + cultivo.CodCultivo.ToString();
            lblGenetica.Text = "Genética: " + cultivo.Genetica;
            lblObservaciones.Text = "Observaciones: " + cultivo.Descripcion;

            // aca deberia traer los controles del cultivo y cargarlos en el dgvControles
            CargarControles();
        }
        private void CargarControles()
        {
            lControles = servicio.TraerControles(cultivo.CodCultivo);
            dgvControles.Rows.Clear();
            foreach (Entidades.Control c in lControles)
            {
                dgvControles.Rows.Add(new object[] { c.CodControl, c.TipoControl, c.FechaControl, c.Ph, c.Ppm, c.Ec, "Observaciones" });
            }
        }

        private void btnAgregarControl_Click(object sender, EventArgs e)
        {
            FrmNuevoControl frm = new FrmNuevoControl(cultivo.CodCultivo);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarControles();
        }
    }
}
