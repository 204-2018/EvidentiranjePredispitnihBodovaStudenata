
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

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
                    s.Colloquium = sqlDataReader.GetInt32(4);
                    s.SeminaryWork = sqlDataReader.GetInt32(5);
                    s.Homework = sqlDataReader.GetInt32(6);
                    s.Activity = sqlDataReader.GetInt32(7);
                    students.Add(s);
                }
                return students;
            }
                }

        public int Delete1(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM Students WHERE Id='" + id + "'";

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
                sqlCommand.CommandText = "UPDATE Students SET SeminaryWork=20 WHERE Id LIKE 26";
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }

        public int Insert(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = (string.Format("INSERT INTO Students VALUES ({0},'{1}','{2}','{3}',{4},{5},{6},{7})", s.Id, s.Name, s.Surname, s.IndexNumber, s.Colloquium,
                s.SeminaryWork, s.Homework, s.Activity));

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


    } }
