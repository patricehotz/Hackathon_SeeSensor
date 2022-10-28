using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSensor.Repositories.Models;

namespace SeeSensor.Repositories.MongoDB.Models
{
    public static class SeeSensorExtensions
    {
        public static RepoSeaSensorData ToRepoSeaSensorData(this SeeSensorMongoPersistenceModelData seeSensorPersistence)
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
        public static RepoSeaSensorStatus ToRepoSeaSensorStatus(this SeeSensorMongoPersistenceModelStatus seeSensorPersistence)
        {
            var seaSensor = new RepoSeaSensorStatus()
            {
                MacAddress = seeSensorPersistence.MacAddress,
                BatteryCharge = seeSensorPersistence.BatteryCharge,
                Timestamp = seeSensorPersistence.Timestamp,
            };

            return seaSensor;
        }

        public static SeeSensorMongoPersistenceModelData ToMongoPersistenceSeaSensorData(this RepoSeaSensorData seeSensorPersistence)
        {
            var seaSensor = new SeeSensorMongoPersistenceModelData()
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

        public static SeeSensorMongoPersistenceModelStatus ToMongoPersistenceSeaSensorStatus(this RepoSeaSensorStatus seeSensorPersistence)
        {
            var seaSensor = new SeeSensorMongoPersistenceModelStatus()
            {
                MacAddress = seeSensorPersistence.MacAddress,
                BatteryCharge = seeSensorPersistence.BatteryCharge,
                Timestamp = seeSensorPersistence.Timestamp,
            };

            return seaSensor;
        }

    }
}
