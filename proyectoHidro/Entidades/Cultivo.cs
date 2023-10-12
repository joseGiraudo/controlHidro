using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Entidades
{
    public class Cultivo
    {
        private int codCultivo;
        private int tipoCultivo;
        private string descripcion;
        private DateTime fechaInicio;
        private string genetica;
        private List<Control> lControles;

        public int CodCultivo { get { return codCultivo; } set { codCultivo = value; } }
        public int TipoCultivo { get { return tipoCultivo; } set { tipoCultivo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
        public string Genetica { get { return genetica; } set { genetica = value; } }

        public Cultivo()
        {
            List<Control> lControles = new List<Control>();
        }
    }
}
