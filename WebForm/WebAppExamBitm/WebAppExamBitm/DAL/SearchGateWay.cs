using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebAppExamBitm.Model;

namespace WebAppExamBitm.DAL
{
    public class SearchGateWay
    {
        private string connectionString;
        private SqlConnection connection;
        public void SetConnection()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["CourseDBconnectionStrings"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public List<Course> GetAllCourse()
        {

            SetConnection();
            string query = "SELECT * FROM course";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            List<Course> AllCourse = new List<Course>();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               Course acourse=new Course();
                acourse.Code=reader["Code"].ToString();
                acourse.CourseName=reader["CourseName"].ToString();
                acourse.Description=reader["Description"].ToString();
                double credit = Convert.ToDouble(reader["Credit"]);
                acourse.Credit=(float)credit;                   
                AllCourse.Add(acourse);
            }
            reader.Close();
            connection.Close();

            return AllCourse;

        }
     
        public List<Course> SearchByCode(string code)
        {
            SetConnection();
            string query = "SELECT * FROM course  WHERE Code LIKE \'%"+code+"%\'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            List<Course> CourseBycode = new List<Course>();
            Course acourse = null;
            if (reader.HasRows)
            {
                acourse= new Course();
                acourse.Code = reader["Code"].ToString();
                acourse.CourseName = reader["CourseName"].ToString();
                acourse.Description = reader["Description"].ToString();
                double credit = Convert.ToDouble(reader["Credit"]);
                acourse.Credit = (float)credit;
                CourseBycode.Add(acourse);
                reader.Close();
                connection.Close();
            }
            return CourseBycode;
        }

        public List<Course> SearchByName(string CourseName)
        {
            SetConnection();
            string query = "SELECT * FROM course  WHERE CourseName LIKE \'%" + CourseName+"%\'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            List<Course> CourseByName = new List<Course>();
            Course acourse = null;
            if (reader.HasRows)
            {
                acourse = new Course();
                acourse.Code = reader["Code"].ToString();
                acourse.CourseName = reader["CourseName"].ToString();
                acourse.Description = reader["Description"].ToString();
                double credit = Convert.ToDouble(reader["Credit"]);
                acourse.Credit = (float)credit;
                CourseByName.Add(acourse);
                reader.Close();
                connection.Close();
            }
            return CourseByName;
        }
    }
}