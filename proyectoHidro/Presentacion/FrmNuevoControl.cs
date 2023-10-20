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
    public partial class FrmNuevoControl : Form
    {
        IServicio servicio;
        Entidades.Control control;
        int codCultivo;
        public FrmNuevoControl(int codigo)
        {
            InitializeComponent();
            servicio = new Servicio();
            control = new Entidades.Control();
            codCultivo = codigo;
        }

        private void FrmNuevoControl_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        private void CargarTipos()
        {
            cboTipoControl.DataSource = servicio.TraerTiposControles();
            cboTipoControl.ValueMember = "Codigo";
            cboTipoControl.DisplayMember = "Tipo";
            cboTipoControl.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // validaciones

            
            control.TipoControl = (int)cboTipoControl.SelectedValue;
            control.FechaControl = DateTime.Parse(dtpFecha.Text);
            control.Ph = Convert.ToDouble(txtPH.Text);
            control.Ppm = Convert.ToDouble(txtPPM.Text);
            control.Ec = Convert.ToDouble(txtEC.Text);
            control.Descripcion = txtObs.Text;
            control.CodCultivo = codCultivo;



            if (servicio.CargarControl(control))
            {
                MessageBox.Show("Se cargo con exito el cultivo");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
