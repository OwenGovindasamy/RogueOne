using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RogueOne.ViewModels
{
    public class UserDescription
    {
        [JsonProperty("status")]
        public string? Status { get; set; }
        [JsonProperty("username")]
        public string? Username { get; set; }
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
        [JsonProperty("attempts")]
        public int Attempts { get; set; }
    }
}
