using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoHidro.Datos.Interfaz;
using proyectoHidro.Entidades;

namespace proyectoHidro.Datos.Implementacion
{
    public class CultivoDao : ICultivoDao
    {
        public bool Actualizar(Cultivo cultivo)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Cultivo cultivo)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Cultivo cultivo)
        {
            throw new NotImplementedException();
        }

        public List<Control> ObtenerControles()
        {
            throw new NotImplementedException();
        }

        public Cultivo ObtenerCultivo(int codigo)
        {
            Cultivo cultivo = new Cultivo();
            List<Parametro> lparams = new List<Parametro>();
            Parametro param = new Parametro("codigo", codigo);
            lparams.Add(param);

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_CULTIVO", lparams);

            foreach(DataRow row in tabla.Rows)
            {
                cultivo.CodCultivo = Convert.ToInt32(row[0].ToString());
                cultivo.FechaInicio = DateTime.Parse(row[1].ToString());
                cultivo.TipoCultivo = Convert.ToInt32(row[2].ToString());
                cultivo.Descripcion = row[3].ToString();
                cultivo.Genetica = row[4].ToString();
            }

            return cultivo;
        }

        public List<Cultivo> ObtenerCultivos()
        {
            List<Cultivo> cultivos = new List<Cultivo>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_CULTIVOS");
            foreach(DataRow row in tabla.Rows)
            {
                int codigo = Convert.ToInt32(row[0].ToString());
                DateTime fecha = DateTime.Parse(row[1].ToString());
                int tipo = Convert.ToInt32(row[2].ToString());
                string desc = row[3].ToString();
                string genetica = row[4].ToString();
                Cultivo cult = new Cultivo(codigo, tipo, desc, fecha, genetica);
                cultivos.Add(cult);
            }
            return cultivos;
        }

        public int ProximoCultivo()
        {
            throw new NotImplementedException();
        }
    }
}
