﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Connection
    {
        //public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True";
        //public void GetConnection()
        //{
        //    SqlConnection Mycon = new SqlConnection(conString);

        //    Mycon.Open();

        //    string query = "SELECT Name FROM Countries";

        //    SqlCommand command = new SqlCommand(query, Mycon);

        //    SqlDataReader reader = command.ExecuteReader();
            
        //    List<string[]> data = new List<string[]>();
        //    while (reader.Read())
        //    {
        //        data.Add(new string[3]);

        //        data[data.Count - 1][0] = reader[1].ToString();
        //        data[data.Count - 1][1] = reader[2].ToString();
        //    }
        //    reader.Close();
        //    Mycon.Close();
        //    foreach (string[] s in data)
        //        dataGridView1.Rows.Add(s);
        //}

    }
}
