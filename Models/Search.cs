using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSONApi.Models
{
    public class Search
    {
        public DateTime timestamp { get; set; }
        public int status { get; set; }
        public string error { get; set; }
        public string message { get; set; }
        public string violations { get; set; }
    }
}
