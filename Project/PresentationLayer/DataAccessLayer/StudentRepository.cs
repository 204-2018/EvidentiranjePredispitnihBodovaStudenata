using Shared.Interface.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
       

        public List<Student> GetStudent()
        {
            List<Student> students = new List<Student>();


            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Students");
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
            DBConnection.CloseConnection();
            return students;
            }

       

        public int Insert(Student s)
        {
        var result = DBConnection.EditData(string.Format("INSERT INTO Students VALUES ({0},'{1}','{2}','{3}',{4},{5},{6},{7})", s.Id, s.Name, s.Surname, s.IndexNumber, s.Colloquium,
                    s.SeminaryWork, s.Homework, s.Activity));
        DBConnection.CloseConnection();
        return result;
            }

        public int Update(Student s)
        {

        var result = DBConnection.EditData("UPDATE Students  SET SeminaryWork=20 WHERE Id LIKE 26");

        DBConnection.CloseConnection();
        return result;
            }
        public int Delete1(int id)
        {
            var result = DBConnection.EditData("DELETE FROM Students WHERE Id='" + id + "'");

            DBConnection.CloseConnection();
            return result;
            }
        }

        
    }
