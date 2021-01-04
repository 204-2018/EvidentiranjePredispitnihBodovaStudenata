using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentRepository
    {
        public List<Student> GetStudent()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Students";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Student s = new Student();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.Surname = sqlDataReader.GetString(2);
                    s.IndexNumber = sqlDataReader.GetString(3);

                    students.Add(s);

                }
                return students;
            }

        }

        public int Insert(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Students VALUES({0}, '{1}','{2}','{3}')", s.Id, s.Name, s.Surname, s.IndexNumber);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


        public int Update(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE Students SET Homework=5 WHERE Id=1";

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
        public int Delete1(Student s, int idNew)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM Students WHERE Id=idNew";

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
