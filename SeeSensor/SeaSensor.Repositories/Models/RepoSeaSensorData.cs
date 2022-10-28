using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories.Models
{
    public class RepoSeaSensorData
    {
        public string Id { get; set; }
        public string MacAddress { get; set; }
        public int Light { get; set; }
        public float AirTemperature { get; set; }
        public float AirHumidity { get; set; }
        public float AirPressure { get; set; }
        public float WaterTemperature { get; set; }
        public double CoordinatesY { get; set; }
        public double CoordinatesX { get; set; }
        public DateTime Timestamp { get; set; }
    }
}