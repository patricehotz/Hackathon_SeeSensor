using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSensor.Repositories.Models;

namespace SeeSensor.Repositories.MongoDB.Models
{
    public static class ParkingSpaceExtensions
    {
        public static RepoSeaSensorData ToRepoCarSpace(this SeeSensorMongoPersistenceModel seeSensorPersistence)
        {
            var seaSensor = new RepoSeaSensorData()
            {
                Id = seeSensorPersistence.Id,
                MacAddress = seeSensorPersistence.MacAddress,
                Light = seeSensorPersistence.Light,
                AirTemperature = seeSensorPersistence.AirTemperature,
                AirHumidity = seeSensorPersistence.AirHumidity,
                AirPressure = seeSensorPersistence.AirPressure,
                WaterTemperature = seeSensorPersistence.WaterTemperature,
                CoordinatesY = seeSensorPersistence.CoordinatesY,
                CoordinatesX = seeSensorPersistence.CoordinatesX,
                Timestamp = seeSensorPersistence.Timestamp,
            };

            return seaSensor;
        }
    }
}
