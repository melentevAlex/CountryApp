using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class GetInfo
    {
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
        public void GetInfoAPI() //  that method receives country information through API
        {
            RestClient client = new RestClient("https://restcountries.eu/rest/v2/alpha/" + input);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", "Token 71cfe35b9e2348a27fc7839e11b1a04873cd03cd");
            IRestResponse response = client.Execute(request);

            string stream = response.Content;
            dynamic data = JsonConvert.DeserializeObject(stream);
            if (data.capital == null)
            {
                throw new ThatCountryDoesNotExist();
            }
            capital = data.capital;
            area = data.area;
            population = data.population;
            code = data.callingCodes[0];
            name = data.name;
            region = data.region;

        }





        public List<string> Data2 { get; set; }

        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True";
        public void GetInfoName() // we need to check is there a country with that name in the DB, save names of countries from DB to list
        {
            SqlConnection Mycon = new SqlConnection(conString);

            Mycon.Open();

            string query = "Select Name from CountriesDB"; // do select Name of countries from DB

            SqlCommand command = new SqlCommand(query, Mycon);

            SqlDataReader reader = command.ExecuteReader();

            List<string> data = new List<string>();
            while (reader.Read())
            {
                data.Add(reader[0].ToString());
            }
            Data2 = data; 
            reader.Close();
            Mycon.Close();
        }


        public void Checking() // check is the country with such name in the DB already
        {
            string name = Name;
            string code = Code;
            string capital = Capital;
            string area = Area;
            string population = Population;
            string region = Region;

            if (Data2.Contains(Name))
            {
                throw new AlreadyExistInDB();
            }
        }

    }
}
