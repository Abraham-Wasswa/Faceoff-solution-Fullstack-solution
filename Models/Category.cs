using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JSONApi.Models
{
    public class Category
    {

        public string myUri = "https://api.chucknorris.io/jokes/categories";

        public async Task<List<string>> Getcategories()
        {
            string uri = myUri;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Get", "application/json");
                var response = await httpClient.GetAsync(uri);
                //Task<string> response = httpClient.GetStringAsync(uri);
                var content = await response.Content.ReadAsStringAsync();
                //var me = JsonConvert.SerializeObject(response.Result);
                var result = JsonConvert.DeserializeObject<List<string>>(content);
                return result;
                //return JsonConvert.DeserializeObject<List<categories>>(me);               
            }
        }

        public categories GetCategoriesId(int Id)
        {
            string uri = myUri + Id;

            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<categories>(response.Result);
            }
        }
    }

    public class categories
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CategoriesValue { get; set; }
    }
}
