using proyectoHidro.Entidades;
using proyectoHidro.Presentacion;
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

namespace proyectoHidro
{
    public partial class FrmPrincipal : Form
    {
        IServicio servicio;
        public FrmPrincipal()
        {
            InitializeComponent();
            servicio = new Servicio();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<Cultivo> lCultivos = servicio.TraerCultivos();
            foreach (Cultivo c in lCultivos)
            {
                dgvCultivos.Rows.Add(new object[] { c.CodCultivo, c.Genetica, c.FechaInicio, c.TipoCultivo, "Consultar" });
            }
        }

        private List<Cultivo> TraerCultivos()
        {
            List<Cultivo> lCultivos = servicio.TraerCultivos();
            return lCultivos;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCultivo nuevoCultivo = new FrmNuevoCultivo();
            nuevoCultivo.ShowDialog();
        }

        private void dgvCultivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCultivos.CurrentCell.ColumnIndex == 4)
            {
                int codCultivo = Convert.ToInt32(dgvCultivos.CurrentRow.Cells["colCodigo"].Value.ToString());
                new FrmCultivo(codCultivo).ShowDialog();
            }
        }
    }
}
