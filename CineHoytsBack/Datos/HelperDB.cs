using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.Properties;

namespace Cine_Hoyts.Datos
{
    public class HelperDB
    {
        SqlConnection conn = new SqlConnection(Resources.Connection);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        private int id;

        private static HelperDB instance;

        public static HelperDB ObtenerInstancia()
        {
            if(instance == null)
            {
                return instance = new HelperDB();
            }
            return instance;
        }

        public SqlCommand Command
        {
            get { return cmd; }
            set { cmd = value; }
        }
        public SqlDataReader Dr
        {
            get { return dr; }
            set { dr = value; }
        }
        public SqlDataReader LeerDB(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            return dr;
        }
        public void open()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                HelperDB.ObtenerInstancia().close();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
            }

        }

        public void close()
        {
            conn.Close();
        }

        public DataTable tabla_db(string procedure)
        {
            DataTable table = new DataTable();
            open();
            cmd.CommandText = procedure;
            table.Load(cmd.ExecuteReader());
            cmd.Parameters.Clear();
            return table;
        }

        public void updatear_db(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            close();
        }

        public int proximo_id(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            id = Convert.ToInt32(param.Value);
            cmd.Parameters.Clear();
            close();
            return id;
        }
        public SqlConnection conexion()
        {
            return this.conn;
        }

    }
}
