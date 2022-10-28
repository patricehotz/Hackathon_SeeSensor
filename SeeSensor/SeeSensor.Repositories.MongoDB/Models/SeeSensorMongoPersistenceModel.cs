using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Repositories.MongoDB.Models
{
    public class SeeSensorMongoPersistenceModel
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("macaddress")]
        public string MacAddress { get; set; }

        [BsonElement("story")]
        public string Story { get; set; } = string.Empty;

        [BsonElement("light")]
        public string Light { get; set; } = string.Empty;

        [BsonElement("airtemperature")]
        public double AirTemperature { get; set; }

        [BsonElement("airhumidity")]
        public double AirHumidity { get; set; }

        [BsonElement("airpressure")]
        public double AirPressure { get; set; }

        [BsonElement("watertemperature")]
        public double WaterTemperature { get; set; }

        [BsonElement("coordinatesY")]
        public double CoordinatesY { get; set; }

        [BsonElement("coordinatesX")]
        public double CoordinatesX { get; set; }

        [BsonElement("timestamp")]
        public double Timestamp { get; set; }
    }
}
