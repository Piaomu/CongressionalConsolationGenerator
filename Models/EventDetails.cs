using Newtonsoft.Json;

namespace CongressionalConsolationGenerator.Models
{
    public class EventDetails
    {
        public string Id { get; set; }
        public Year Year { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

    }
}
