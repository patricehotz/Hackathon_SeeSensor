using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Repositories.MongoDB.Models
{
    public class SeeSensorMongoPersistenceModelStatus
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("macaddress")]
        public string MacAddress { get; set; }

        [BsonElement("batterycharge")]
        public string BatteryCharge { get; set; }

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
