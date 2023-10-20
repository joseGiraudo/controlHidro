using proyectoHidro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Servicios
{
    interface IServicio
    {
        List<TipoC> TraerTiposCultivos();
        List<TipoC> TraerTiposControles();
        List<Cultivo> TraerCultivos();
        Cultivo TraerCultivo(int codCultivo);
        List<Control> TraerControles(int codCultivo);
        int ProximoCultivo();
        bool CargarCultivo(Cultivo cultivo);
        bool ActualizarCultivo();
        bool EliminarCultivo();
        bool CargarControl(Control control);
    }
}
