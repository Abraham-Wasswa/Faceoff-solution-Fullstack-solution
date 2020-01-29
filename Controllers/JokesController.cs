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
        
        private Category service = new Category();

        [HttpGet("api/Category")]
        public ActionResult Cates()
        {
            return View(service.Getcategories());
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