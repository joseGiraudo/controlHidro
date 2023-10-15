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

        public List<Control> TraerControles()
        {
            throw new NotImplementedException();
        }

        public List<Cultivo> TraerCultivos()
        {
            return cultivoDao.ObtenerCultivos();
        }

        public Cultivo TraerCultivo(int cod)
        {
            return cultivoDao.ObtenerCultivo(cod);
        }

        public List<TipoCultivo> TraerTipos()
        {
            return cultivoDao.ObtenerTipos();
        }

        public int ProximoCultivo()
        {
            return cultivoDao.ProximoCultivo();
        }
    }
}
