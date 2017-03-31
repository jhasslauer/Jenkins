using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ForgeLauncher
{
    public class Player
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("online")]
        public string Online { get; set; }

        [JsonProperty("id_server")]
        public string IdServer { get; set; }

        [JsonProperty("time_played")]
        public string TimePlayed { get; set; }

        [JsonProperty("last_online")]
        public string LastOnline { get; set; }
    }
}
