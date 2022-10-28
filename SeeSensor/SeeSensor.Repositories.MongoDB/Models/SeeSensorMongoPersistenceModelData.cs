using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Repositories.MongoDB.Models
{
    public class SeeSensorMongoPersistenceModelData
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("macaddress")]
        public string MacAddress { get; set; }

        [BsonElement("light")]
        public int Light { get; set; }

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
        public DateTime Timestamp { get; set; }
    }
}
