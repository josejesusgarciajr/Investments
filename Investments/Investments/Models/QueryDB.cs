
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Investments.Models
{
    public class QueryDB
    {
        private static string CS {get; set;}

        public QueryDB()
        {
            CS = "Server=localhost;Database=TEST;User Id=sa;Password=myPassw0rd;";
        }

        public DateIdea GetDateIdea(int id)
        {
            DateIdea dateIdea = new DateIdea();
            // establish sql connection
            using(SqlConnection sqlConnection = new SqlConnection(CS))
            {
                // query
                string query = "SELECT * FROM DateIdeas"
                    + $" WHERE ID={id};";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        dateIdea = new DateIdea((int) reader[0], (string) reader[1], (string) reader[2],
                            (string) reader[3], (string) reader[4], (string) reader[5]);
                    }
                }

                // close connection
                sqlConnection.Close();

            }

            return dateIdea;
        }

        public List<DateIdea> GetDateIdeas()
        {
            List<DateIdea> dateIdeas = new List<DateIdea>();

            // establish sql connection
            using(SqlConnection sqlConnection = new SqlConnection(CS))
            {
                // query
                string query = "SELECT * From DateIdeas;";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // GET Date Ideas
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        // id, nameOfEvent, address, href, linkText, imagePath
                        dateIdeas.Add(new DateIdea((int)reader[0], (string)reader[1],
                            (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]));
                    }
                }

                // close connection
                sqlConnection.Close();
            }

            return dateIdeas;
        }

        public void AddDateIdeaToDB(DateIdea dateIdea)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CS))
            {
                // query
                string query = "INSERT INTO DateIDeas(NameOfEvent, Address, Href, LinkText, ImagePath)" + 
                    $" VALUES('{dateIdea.NameOfEvent}', '{dateIdea.Address}', '{dateIdea.Href}', '{dateIdea.LinkText}', '{dateIdea.ImagePath}'); ";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public void DeleteDateIdea(DateIdea dateIdea)
        {
            // establish sql connection
            using(SqlConnection sqlConnection = new SqlConnection(CS))
            {
                string query = $"DELETE FROM DateIdeas WHERE ID={dateIdea.ID};";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
    }
}
