using proyectoHidro.Entidades;
using proyectoHidro.Presentacion;
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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TraerCultivos();
        }

        private List<Cultivo> TraerCultivos()
        {
            List<Cultivo> lCultivos = new List<Cultivo>();

            return lCultivos;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCultivo nuevoCultivo = new FrmNuevoCultivo();
            nuevoCultivo.ShowDialog();
        }
    }
}
