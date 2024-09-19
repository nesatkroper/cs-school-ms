using backend.config;
using backend.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.service
{
    public class StudentService
    {
        public static DataTable GetStudent()
        {
            SqlCommand cmd = new SqlCommand("SPGetStudent", DBContext.ConnGet());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void CreateStudent(Student student)
        {
            SqlCommand cmd = new SqlCommand("SPCreateStudent", DBContext.ConnGet());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@photo", student.photo);
            cmd.Parameters.AddWithValue("@fname", student.fname);
            cmd.Parameters.AddWithValue("@lname", student.lname);
            cmd.Parameters.AddWithValue("@gender", student.gender);
            cmd.Parameters.AddWithValue("@dob", student.dob);
            cmd.Parameters.AddWithValue("@email", student.email);
            cmd.Parameters.AddWithValue("@phone", student.phone);
            cmd.Parameters.AddWithValue("@address", student.address);
            cmd.Parameters.AddWithValue("@enrollment", student.enrollment);
            cmd.Parameters.AddWithValue("@cou_id", student.cou_id);
            cmd.Parameters.AddWithValue("@status", student.status);
            cmd.Parameters.AddWithValue("@isDelete", student.isDelete);
            cmd.Parameters.AddWithValue("@created_at", student.created_at);
            cmd.Parameters.AddWithValue("@updated_at", student.updated_at);
            cmd.ExecuteNonQuery();
        }
    }
}
