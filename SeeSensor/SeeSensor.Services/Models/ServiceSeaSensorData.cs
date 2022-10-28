using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Services.Models
{
    public class ServiceSeaSensorData 
    {
        public string Id { get; set; } = string.Empty;
        public string MacAdress { get; set; } = string.Empty;
        public int Light { get; set; }
        public float AirTemperature { get; set; }
        public float AirPressure { get; set; }
        public float AirHumidity { get; set; }
        public float WaterTemperature { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinatY { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
