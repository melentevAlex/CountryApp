using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class Connection
    {
        public List<string[]> Data { get; set; }

        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True";
        public void GetConnection()
        {
            SqlConnection Mycon = new SqlConnection(conString);

            Mycon.Open();

            string query = "Select * from CountriesDB";

            SqlCommand command = new SqlCommand(query, Mycon);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            Data = data;
            reader.Close();
            Mycon.Close();
        }



    }
}
