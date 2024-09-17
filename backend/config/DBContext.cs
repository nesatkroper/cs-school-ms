using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.config
{
    public class DBContext
    {
        static SqlConnection conn;

        public static void ConnOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-BRGH90J\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True;";
                conn.Open();
            }
        }

        public static void ConnClose()
        {
            if (conn != null)
                conn.Close();
        }

        public static SqlConnection ConnGet()
        {
            if (conn == null)
                ConnOpen();
            return conn;
        }
    }
}
