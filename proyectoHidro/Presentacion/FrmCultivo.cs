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
        public FrmCultivo(int codCultivo)
        {
            InitializeComponent();
            servicio = new Servicio();
            cultivo = servicio.TraerCultivo(codCultivo);
        }

        private void FrmCultivo_Load(object sender, EventArgs e)
        {
            // cargo los datos del cultivo
            lblGenetica.Text = "Genética: " + cultivo.Genetica;
            lblObservaciones.Text = "Observaciones: " + cultivo.Descripcion;

            // aca deberia traer los controles del cultivo y cargarlos en el dgvControles
        }
    }
}
