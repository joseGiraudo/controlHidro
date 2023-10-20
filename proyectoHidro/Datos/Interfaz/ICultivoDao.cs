using proyectoHidro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Datos.Interfaz
{
    interface ICultivoDao
    {
        int ProximoCultivo();
        List<Control> ObtenerControles(int idCultivo);
        List<Cultivo> ObtenerCultivos();
        Cultivo ObtenerCultivo(int codigo);
        List<TipoC> ObtenerTiposCultivos();
        List<TipoC> ObtenerTiposControles();
        bool Crear(Control control);
        bool Crear(Cultivo cultivo);
        bool Actualizar(Cultivo cultivo);
        bool Eliminar(Cultivo cultivo);

    }
}
