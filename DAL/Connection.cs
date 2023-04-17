using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection dbConn;
        private static readonly String dbConnString = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        public static void connect()
        {
            dbConn = new SqlConnection(dbConnString);
            dbConn.Open();
        }

        public static void ProductActionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, dbConn);

            cmd.ExecuteNonQuery();
        }

        public static DataTable ProductSelectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, dbConn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
