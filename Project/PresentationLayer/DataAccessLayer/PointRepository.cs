using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PointRepository
    {
        public List<PreexeminationPoints> GetPoints()
        {
            List<PreexeminationPoints> points = new List<PreexeminationPoints>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Points";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    PreexeminationPoints p = new PreexeminationPoints();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Colloquium = sqlDataReader.GetInt32(1);
                    p.SeminaryWork = sqlDataReader.GetInt32(2);
                    p.Homework = sqlDataReader.GetInt32(3);
                    p.Activity = sqlDataReader.GetInt32(4);
                    points.Add(p);

                }
                return points;
            }

        }

        public int InsertPoint(PreexeminationPoints p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Points VALUES({0}, {1}, {2}, {3}, {4})", p.Id, p.Colloquium, p.SeminaryWork, p.Homework, p.Activity);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


        public int UpdatePoint(PreexeminationPoints p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE Points SET Homework=5 WHERE Id=1";

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }

        public int DeletePoint1(PreexeminationPoints p, int idNew)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM Points WHERE Id=idNew";

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
