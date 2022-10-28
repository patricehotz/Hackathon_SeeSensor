using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories.Models
{
    public class RepoSeaSensor
    {
        public string Id { get; set; }
        public string MacAddress { get; set; }
        public int Light { get; set; }
        public double AirTemperature { get; set; }
        public double AirHumidity { get; set; }
        public double AirPressure { get; set; }
        public double WaterTemperature { get; set; }
        public double CoordinatesY { get; set; }
        public double CoordinatesX { get; set; }
        public DateTime Timestamp { get; set; }
    }
}