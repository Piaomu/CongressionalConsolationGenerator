using Newtonsoft.Json;

namespace CongressionalConsolationGenerator.Models
{
    [JsonArray]
    public class ShootingDataRoot
    {
        public List<ShootingData>? ShootingData;
    }
}
