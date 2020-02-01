using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using JSONApi.Models;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;
using System.Net.Http;
using Newtonsoft.Json;

namespace JSONApi.Controllers
{
    public class JokesController : Controller
    {
        
        private Category service = new Category();

        [HttpGet("api/Category")]
        public async Task<ActionResult> Cates()
        {
            List<string> result = new List<string>();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Get", "application/json");
                var response = await httpClient.GetAsync("https://api.chucknorris.io/jokes/categories");
               
                var content = await response.Content.ReadAsStringAsync();
                
                result = JsonConvert.DeserializeObject<List<string>>(content);
                           
            }
            return Ok(result);
        }

        [HttpGet("api/Jokes")]
        public IActionResult Index()
        {
            WebRequest request = HttpWebRequest.Create("https://api.chucknorris.io/jokes/random");
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string Norris_JSON = reader.ReadToEnd();

            RandomJ myJoke = Newtonsoft.Json.JsonConvert.DeserializeObject<RandomJ>(Norris_JSON);

            return Ok(myJoke);
        }
    }
}