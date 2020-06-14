using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
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
        public void GetInfoAPI()
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

    }
}
