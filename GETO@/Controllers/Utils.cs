using GETO_.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace GETO_.Controllers
{
    public class Utils
    {
        HttpClient client = new HttpClient();
       

        public async Task<Rootobject> GetStates() {
            var pocoObject = new
            {
                country = "India",  
            };
            string json = JsonConvert.SerializeObject(pocoObject);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");
            string Url = "https://countriesnow.space/api/v0.1/countries/states";
            var  response = await client.PostAsync(Url, data);
            string result = await response.Content.ReadAsStringAsync();
            var m = JsonConvert.DeserializeObject<Rootobject>(result);
            Rootobject Model = JsonConvert.DeserializeObject<Rootobject>(result);
            return Model;

        }
    }
}
