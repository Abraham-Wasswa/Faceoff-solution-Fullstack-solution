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

        readonly string uri = "https://api.chucknorris.io/jokes/categories";

        public async Task<List<categories>> _categories()
        {
            using (HttpClient httpClient = new HttpClient())
            {

                return JsonConvert.DeserializeObject<List<categories>>(
                    await httpClient.GetStringAsync(uri)
                );
            }
        }
    }

    public class categories
    {
        public int Id { get; set; }

        public string CategoriesName { get; set; }
    }
}
