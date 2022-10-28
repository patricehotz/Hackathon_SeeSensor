using Newtonsoft.Json;

namespace SeeSensor.Api.Controllers.Models
{
    public class SeaSensorStatusRequest
    {
        [JsonProperty(PropertyName = "macadress")]
        public string MacAdress { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "batterycharge")]
        public string BatteryCharge { get; set; }
    }
}
