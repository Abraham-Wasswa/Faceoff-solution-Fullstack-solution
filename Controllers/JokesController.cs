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

namespace JSONApi.Controllers
{
    public class JokesController : Controller
    {
        
        private categories service = new categories();

        [HttpGet("api/Category")]
        public async Task<ActionResult> Categs()
        {

            return View("index",
                await service._categories()
            ); ;
        }



        [HttpGet("api/Jokes")]
        public IActionResult Index()
        {
            WebRequest request = HttpWebRequest.Create("https://api.chucknorris.io/jokes/random");
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string Norris_JSON = reader.ReadToEnd();

            Jokes myJoke = Newtonsoft.Json.JsonConvert.DeserializeObject<Jokes>(Norris_JSON);

            return Ok(myJoke);
        }
    }
}