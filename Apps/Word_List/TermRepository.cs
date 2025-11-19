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
        public List<MedicalTerm> SelectAll()
        {
            List<MedicalTerm> list = new List<MedicalTerm>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM tb_medical_terms;";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MedicalTerm term = new MedicalTerm();

                            term.Id = Convert.ToInt32(reader["Id"]);
                            term.TermCode = reader["term_code"].ToString();
                            term.FullName = reader["full_name"].ToString();
                            term.Description = reader["description"].ToString();
                            term.RegDate = DateTime.Now.ToString("yyyy-mm-dd");

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

                string sql = "INSERT INTO tb_medical_terms (Id, term_code, full_name, description, reg_date) VALUES Id = @Id, TermCode = @term_code, FullName = @full_name, Description = @description, RegDate = @reg_date;";

                using (MySqlCommand cmd = new MySqlCommand (sql, con)) 
                {
                    cmd.Parameters.AddWithValue("@code", term.TermCode);
                    cmd.Parameters.AddWithValue("@name", term.FullName);
                    cmd.Parameters.AddWithValue("@description", term.Description);
                    cmd.Parameters.AddWithValue("@date", term.RegDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
