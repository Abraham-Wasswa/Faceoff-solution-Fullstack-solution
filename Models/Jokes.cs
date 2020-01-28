using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSONApi.Models
{
    public class Jokes
    {
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}
