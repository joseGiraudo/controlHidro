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
        List<Control> ObtenerControles();

    }
}
