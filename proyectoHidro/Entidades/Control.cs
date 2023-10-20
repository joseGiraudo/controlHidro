using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Entidades
{
    public class Control
    {
        private int codControl;
        private int tipoControl;
        private DateTime fechaControl;
        private int codCultivo;
        private string descripcion;
        private double ph;
        private double ppm;
        private double ec;

        public int CodControl { get { return codControl; } set { codControl = value; } }
        public int TipoControl { get { return tipoControl; } set { tipoControl = value; } }
        public DateTime FechaControl { get { return fechaControl; } set { fechaControl = value; } }
        public int CodCultivo { get { return codCultivo; } set { codCultivo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public double Ph { get { return ph; } set { ph = value; } }
        public double Ppm { get { return ppm; } set { ppm = value; } }
        public double Ec { get { return ec; } set { ec = value; } }

        public Control() { }


    }
}
