using proyectoHidro.Datos.Interfaz;
using proyectoHidro.Datos.Implementacion;
using proyectoHidro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Servicios
{
    public class Servicio : IServicio
    {
        private ICultivoDao cultivoDao;

        public Servicio()
        {
            cultivoDao = new CultivoDao();
        }

        public bool ActualizarCultivo()
        {
            throw new NotImplementedException();
        }

        public bool CargarCultivo(Cultivo cultivo)
        {
            return cultivoDao.Crear(cultivo);
        }

        public bool EliminarCultivo()
        {
            throw new NotImplementedException();
        }

        public bool CargarControl(Control control)
        {
            return cultivoDao.Crear(control);
        }

        public List<Control> TraerControles(int codCultivo)
        {
            return cultivoDao.ObtenerControles(codCultivo);
        }

        public List<Cultivo> TraerCultivos()
        {
            return cultivoDao.ObtenerCultivos();
        }

        public Cultivo TraerCultivo(int cod)
        {
            return cultivoDao.ObtenerCultivo(cod);
        }

        public List<TipoC> TraerTiposControles()
        {
            return cultivoDao.ObtenerTiposControles();
        }
        public List<TipoC> TraerTiposCultivos()
        {
            return cultivoDao.ObtenerTiposCultivos();
        }

        public int ProximoCultivo()
        {
            return cultivoDao.ProximoCultivo();
        }
    }
}
