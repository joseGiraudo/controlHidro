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
        List<TipoCultivo> TraerTipos();
        List<Cultivo> TraerCultivos();
        Cultivo TraerCultivo(int codCultivo);
        List<Control> TraerControles();
        int ProximoCultivo();
        bool CargarCultivo(Cultivo cultivo);
        bool ActualizarCultivo();
        bool EliminarCultivo();
    }
}
