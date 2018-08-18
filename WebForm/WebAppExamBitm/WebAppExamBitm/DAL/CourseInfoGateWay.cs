using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebAppExamBitm.Model;

namespace WebAppExamBitm.DAL
{
    public class CourseInfoGateWay
    {
        private string connectionString;
        private SqlConnection connection;
        public void SetConnection()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["CourseDBconnectionStrings"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public bool IsExited(Course course)
        {     
            SetConnection();
            string query = "SELECT * FROM course WHERE Code='" + course.Code + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();  
            bool exited=false;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
               exited=true;
            }
            reader.Close();
            connection.Close();
            return exited;
        }
        
        public int SaveCourse(Course course)
        {
         
            SetConnection();
            string query = "INSERT INTO course(Code,CourseName,Description,Credit) VALUES('" + course.Code+ "','" + course.CourseName + "','" + course.Description+ "'," + course.Credit+ ")";         
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        
        }

    }
}