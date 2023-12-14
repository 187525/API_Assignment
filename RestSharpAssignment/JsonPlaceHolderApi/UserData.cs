using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceHolderApi
{
    internal class UserData
    {
        [JsonProperty("firstname")]
        public int FirstName { get; set; }

        [JsonProperty("lastname")]
        public int Lastname { get; set; }

        [JsonProperty("totalprice")]
        public string? TotalPrice { get; set; }

        [JsonProperty("depositpaid")]
        public string? DepositPaid { get; set; }

        [JsonProperty("checkin")]
        public string? CheckIn { get; set; }

        [JsonProperty("checkout")]
        public string? checkout { get; set; }

        [JsonProperty("additionalneeds")]
        public string? AdditionalNeeds { get; set; }

    }
}
