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
        public static RepoSeaSensor ToRepoCarSpace(this SeeSensorMongoPersistenceModel seeSensorPersistence)
        {
            var seaSensor = new RepoSeaSensor()
            {
                Id = seeSensorPersistence.Id,
                MacAddress = seeSensorPersistence.MacAddress,
            };

            return seaSensor;
        }
    }
}
