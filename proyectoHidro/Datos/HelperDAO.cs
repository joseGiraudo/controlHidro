using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Datos
{
    public class HelperDAO
    {
        private string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DBControlHidro;Integrated Security=True";
        private SqlConnection connection;
        private static HelperDAO instance;

        private HelperDAO()
        {
            connection = new SqlConnection(connString);
        }

        // el ObtenerInstancia() debe ser static y la instancia tambien
        public static HelperDAO ObtenerInstancia()
        {
            if (instance == null)
            {
                instance = new HelperDAO();
            }
            return instance;
        }

        // metodos

        public SqlConnection GetConnection()
        {
            return this.connection;
        }

        public int ConsultarEscalar(string nombreSP, string paramOut)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;

            SqlParameter param = new SqlParameter();
            param.ParameterName = paramOut;
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;

            command.Parameters.Add(param);
            command.ExecuteNonQuery();

            connection.Close();

            return (int)param.Value;
        }

        public DataTable Consultar(string nombreSP)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            connection.Close();

            return table;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> lparams)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;

            command.Parameters.Clear();

            foreach (Parametro param in lparams)
            {
                command.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            connection.Close();

            return table;
        }
    }
}
