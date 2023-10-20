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
        public bool Crear(Control control)
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
                command.CommandText = "SP_INSERTAR_CONTROL";

                command.Parameters.AddWithValue("@id_tipo_control", control.TipoControl);
                command.Parameters.AddWithValue("@fecha", control.FechaControl);
                command.Parameters.AddWithValue("@id_cultivo", control.CodCultivo);
                command.Parameters.AddWithValue("@ph", control.Ph);
                command.Parameters.AddWithValue("@ppm", control.Ppm);
                command.Parameters.AddWithValue("@ec", control.Ec);
                command.Parameters.AddWithValue("@observacion", control.Descripcion);

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
                if (transaction != null)
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

        public List<Control> ObtenerControles(int idCultivo)
        {
            List<Control> list = new List<Control>();
            List<Parametro> lParam = new List<Parametro>();
            Parametro param = new Parametro("codigo", idCultivo);
            lParam.Add(param);

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_CONTROLES", lParam);

            foreach(DataRow r in tabla.Rows)
            {
                Control c = new Control();
                c.CodControl = Convert.ToInt32(r[0].ToString());
                c.TipoControl = Convert.ToInt32(r[1].ToString());
                c.FechaControl = DateTime.Parse(r[2].ToString());
                c.CodCultivo = idCultivo;
                c.Ph = Convert.ToDouble(r[4].ToString());
                c.Ppm = Convert.ToDouble(r[5].ToString());
                c.Ec = Convert.ToDouble(r[6].ToString());
                c.Descripcion = r[7].ToString();
                list.Add(c);
            }
            return list;
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

        public List<TipoC> ObtenerTiposCultivos()
        {
            List<TipoC> tipos = new List<TipoC>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_CULTIVOS");
            foreach(DataRow row in tabla.Rows)
            {
                int cod = Convert.ToInt32(row[0].ToString());
                string tipo = row[1].ToString();
                TipoC tipoC = new TipoC(cod, tipo);
                tipos.Add(tipoC);
            }
            return tipos;
        }
        public List<TipoC> ObtenerTiposControles()
        {
            List<TipoC> tipos = new List<TipoC>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_CONTROLES");
            foreach (DataRow row in tabla.Rows)
            {
                int cod = Convert.ToInt32(row[0].ToString());
                string tipo = row[1].ToString();
                TipoC tipoC = new TipoC(cod, tipo);
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
