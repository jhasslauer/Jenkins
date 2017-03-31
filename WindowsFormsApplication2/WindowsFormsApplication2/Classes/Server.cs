using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeLauncher
{
    public class Server
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("admin")]
        public string Admin { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("players")]
        public int Players { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
