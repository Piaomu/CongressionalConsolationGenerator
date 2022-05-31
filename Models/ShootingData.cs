using Newtonsoft.Json;

namespace CongressionalConsolationGenerator.Models
{
    [JsonObject]
    public class ShootingData
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("killed")]
        public string Killed { get; set; }
        [JsonProperty("wounded")]
        public string Wounded { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("names")]
        public List<string> Names { get; set; }
        [JsonProperty("sources")]
        public List<string> Sources { get; set; }
    }
}
