using Newtonsoft.Json;

namespace SeeSensor.Api.Controllers.Models
{
    public class SeaSensorDataRequest
    {
        [JsonProperty(PropertyName = "macadress")]
        public string Macadress { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "light")]
        public int Light { get; set; }

        [JsonProperty(PropertyName = "airtemperature")]
        public float Airtemperature { get; set; }

        [JsonProperty(PropertyName = "airhumidity")]
        public int Airhumidity { get; set; }

        [JsonProperty(PropertyName = "airpressure")]
        public float Airpressure { get; set; }

        [JsonProperty(PropertyName = "watertemperature")]
        public int Watertemperature { get; set; }

        [JsonProperty(PropertyName = "coordinatex")]
        public float CoordinateX { get; set; }

        [JsonProperty(PropertyName = "coordinatey")]
        public int CoordinateY { get; set; }

    }
}
