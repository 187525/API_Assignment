using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_Booker_Project
{
    internal class Cookie
    {
        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
