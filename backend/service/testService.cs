using backend.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.model;

namespace backend.service
{
    public class testService
    {
        public static DataTable gettest()
        {
            SqlCommand cmd = new SqlCommand("spgettest", DBContext.ConnGet());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void add(test t)
        {
            SqlCommand cmd = new SqlCommand("spaddtest", DBContext.ConnGet());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", t.name);
            cmd.Parameters.AddWithValue("@photo", t.photo);
            cmd.ExecuteNonQuery();
        }
    }
}
