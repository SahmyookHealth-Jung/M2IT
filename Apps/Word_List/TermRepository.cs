using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Word_List
{
    public class TermRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySql"].ConnectionString;

        // 조회 기능 (SELECT)
        public List<MedicalTerm> SelectAll(string keyword)
        {
            List<MedicalTerm> list = new List<MedicalTerm>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM tb_medical_terms";

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    sql += " WHERE term_code LIKE @keyword OR full_name LIKE @keyword OR description LIKE @keyword";
                }

                sql += " ORDER BY Id DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MedicalTerm term = new MedicalTerm();

                            term.Id = Convert.ToInt32(reader["Id"]);

                            // ToString()은 Null이어도 에러 안 나고 빈칸이 됨.
                            term.TermCode = reader["term_code"].ToString();
                            term.FullName = reader["full_name"].ToString();
                            term.Description = reader["description"].ToString();

                            //DB에서 읽어온 날짜를 넣는 로직
                            if (reader["reg_date"] != DBNull.Value)
                            {
                                term.RegDate = Convert.ToDateTime(reader["reg_date"]).ToString("yyyy-MM-dd");
                            }
                            else{
                                term.RegDate = "";
                            }
                            list.Add(term);
                        }
                    }
                }
            }
            return list;
        }
        public void Insert(MedicalTerm term)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString)) 
            {
                con.Open();

                string sql = "INSERT INTO tb_medical_terms (term_code, full_name, description, reg_date) VALUES (@term_code, @full_name, @description, @reg_date);";

                using (MySqlCommand cmd = new MySqlCommand (sql, con)) 
                {                   
                    cmd.Parameters.AddWithValue("@term_code", term.TermCode);
                    cmd.Parameters.AddWithValue("@full_name", term.FullName);
                    cmd.Parameters.AddWithValue("@description", term.Description);
                    cmd.Parameters.AddWithValue("@reg_date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(MedicalTerm term) 
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "UPDATE tb_medical_terms SET term_code = @term_code, full_name = @full_name, description = @description WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@term_code", term.TermCode);
                    cmd.Parameters.AddWithValue("@full_name", term.FullName);
                    cmd.Parameters.AddWithValue("@description", term.Description);
                    cmd.Parameters.AddWithValue("@Id", term.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM tb_medical_terms WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
