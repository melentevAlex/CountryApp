using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Saving
    {
        SqlCommand cmd;
        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True";

        private string capital;
        private string area;
        private string population;
        private string code;
        private string name;
        private string region;
        private string input;

        public string Capital { get => capital; set => capital = value; }
        public string Area { get => area; set => area = value; }
        public string Population { get => population; set => population = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Region { get => region; set => region = value; }
        public string Input { get => input; set => input = value; }


        public void MethSave()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string name = Name;
            string code = Code;
            string capital = Capital;
            string area = Area;
            string population = Population;
            string region = Region;




            if (con.State == ConnectionState.Open)
            {
                string q = $"INSERT INTO CountriesDB(Name, Code, Capital, Area, Population, [Region]) VALUES('" + name + "', '" + code + "', '" + capital + "',  '" + area + "', '" + population + "', '" + region + "')";           /////////////////////////////////////////////////

                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
