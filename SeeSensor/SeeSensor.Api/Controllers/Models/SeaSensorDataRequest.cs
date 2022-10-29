using Newtonsoft.Json;

namespace SeeSensor.Api.Controllers.Models
{
    public class SeaSensorDataRequest
    {
        [JsonProperty(PropertyName = "macaddress")]
        public string macaddress { get; set; }

        [JsonProperty(PropertyName = "light")]
        public int Light { get; set; }

        [JsonProperty(PropertyName = "airtemperature")]
        public float Airtemperature { get; set; }

        [JsonProperty(PropertyName = "airhumidity")]
        public float Airhumidity { get; set; }

        [JsonProperty(PropertyName = "airpressure")]
        public float Airpressure { get; set; }

        [JsonProperty(PropertyName = "watertemperature")]
        public float Watertemperature { get; set; }

        [JsonProperty(PropertyName = "coordinatex")]
        public double CoordinateX { get; set; }

        [JsonProperty(PropertyName = "coordinatey")]
        public double CoordinateY { get; set; }

    }
}
