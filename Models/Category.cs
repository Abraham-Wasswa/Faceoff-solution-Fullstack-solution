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

        readonly string myUri = "https://api.chucknorris.io/jokes/categories";

        public List<categories> Getcategories()
        {
            string uri = myUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<categories>>(response.Result);               
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
        public int Id { get; set; }

        public List<string> CategoriesValue { get; set; }
    }
}
