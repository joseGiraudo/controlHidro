using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            bool result = true;
            SqlConnection connection = HelperDAO.ObtenerInstancia().GetConnection();
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_INSERTAR_CULTIVO";

                command.Parameters.AddWithValue("@fecha", cultivo.FechaInicio);
                command.Parameters.AddWithValue("@id_tipo_cul", cultivo.TipoCultivo);
                command.Parameters.AddWithValue("@descripcion", cultivo.Descripcion);
                command.Parameters.AddWithValue("@genetica", cultivo.Genetica);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                int nro = (int)param.Value;

                transaction.Commit();

            }
            catch (Exception ex)
            {
                if(transaction != null)
                {
                    transaction.Rollback();
                    result = false;
                }
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return result;
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

        public List<TipoCultivo> ObtenerTipos()
        {
            List<TipoCultivo> tipos = new List<TipoCultivo>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_CULTIVOS");
            foreach(DataRow row in tabla.Rows)
            {
                int cod = Convert.ToInt32(row[0].ToString());
                string tipo = row[1].ToString();
                TipoCultivo tipoC = new TipoCultivo(cod, tipo);
                tipos.Add(tipoC);
            }
            return tipos;
        }

        public int ProximoCultivo()
        {
            return HelperDAO.ObtenerInstancia().ConsultarEscalar("SP_CONSULTAR_PROX", "@nro");
        }
    }
}
