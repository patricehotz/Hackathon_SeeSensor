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
        public float AirTemperature { get; set; }

        [BsonElement("airhumidity")]
        public float AirHumidity { get; set; }

        [BsonElement("airpressure")]
        public float AirPressure { get; set; }

        [BsonElement("watertemperature")]
        public float WaterTemperature { get; set; }

        [BsonElement("coordinatesy")]
        public double CoordinatesY { get; set; }

        [BsonElement("coordinatesx")]
        public double CoordinatesX { get; set; }

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
