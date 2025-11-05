using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exam_MySQL
{
    public class Exam_repository
    {
        private readonly DBHelper dBHelper = new DBHelper();

        public void AddExam(Exam exam)
        {
            string sql = "INSERT INTO User(name, phone) VALUES (@Name, @Phone)";

            MySqlParameter[] sp = new MySqlParameter[]
            {
                new MySqlParameter("@Name", exam.Name),
                new MySqlParameter("@Phone", exam.Phone)
            };

            dBHelper.ExecuteNonQuery(sql, sp);
        }

        public List<Exam> getAllExams()
        {
            List<Exam> exams = new List<Exam>();
            string sql = "SELECT Id, name, phone FROM User";

            // DBHelper 에서 DataReader를 가져옵니다.
            using (MySqlDataReader reader = dBHelper.ExecuteReader(sql))
            {
                // Reader를 순회하며 데이터를 읽습니다. 
                while (reader.Read())
                {
                    // 읽은 데이터를 Exam 객체로 변환합니다.
                    Exam exam = new Exam
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("name"),
                        Phone = reader.GetString("phone")
                    };
                    exams.Add(exam);
                }
            }
            return exams;
        }

        public List<Exam> GetFilteredExams(string name, string phone)
        {
            List<Exam> exams = new List<Exam>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT Id ,name, phone FROM User WHERE 1 = 1");

            if (!string.IsNullOrWhiteSpace(name))
            {
                sqlBuilder.Append(" AND name LIKE @Name");
                parameters.Add(new MySqlParameter("@Name", $"%{name}%"));
            }

            if (!string.IsNullOrWhiteSpace(phone))
            {
                sqlBuilder.Append(" AND phone LIKE @Phone");
                parameters.Add(new MySqlParameter("@Phone", $"%{phone}%"));
            }

            using (MySqlDataReader reader = dBHelper.ExecuteReader(sqlBuilder.ToString(), parameters.ToArray()))
            {
                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("name"),
                        Phone = reader.GetString("phone")
                    });
                }
            }
            return exams;
        }
    
        
        public void UpdateExam(Exam exam)
        {
            string sql = "UPDATE User SET name = @Name , phone = @Phone WHERE Id = @id";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", exam.Name),
                new MySqlParameter("@Phone", exam.Phone),
                new MySqlParameter("@Id", exam.Id)
            };

            dBHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteExam(int id) 
        {
            string sql = "DELETE FROM User WHERE Id = @id";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Id", id )
            };
            dBHelper.ExecuteNonQuery (sql, parameters);
        }
    }    
}
