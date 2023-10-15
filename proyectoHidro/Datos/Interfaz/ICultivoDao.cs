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
        List<Control> ObtenerControles();
        List<Cultivo> ObtenerCultivos();
        Cultivo ObtenerCultivo(int codigo);

        List<TipoCultivo> ObtenerTipos();

        bool Crear(Cultivo cultivo);
        bool Actualizar(Cultivo cultivo);
        bool Eliminar(Cultivo cultivo);

    }
}
