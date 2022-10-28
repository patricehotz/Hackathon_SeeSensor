using SeaSensor.Repositories;
using SeaSensor.Repositories.Models;
using SeeSensor.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Services.Models
{
    public static class ServiceSeaSensorExtension
    {
        public static RepoSeaSensorData toRepoSeaSensorData(this ServiceSeaSensorData seaSensordata)
        {
            RepoSeaSensorData repoSeaSensorData = new RepoSeaSensorData()
            {
                MacAddress = seaSensordata.MacAdress,
                AirHumidity = seaSensordata.AirHumidity,
                AirPressure = seaSensordata.AirPressure,
                AirTemperature = seaSensordata.AirTemperature,
                CoordinatesX = seaSensordata.CoordinateX,
                CoordinatesY = seaSensordata.CoordinatY,
                Id = seaSensordata.Id,
                Light = seaSensordata.Light,
                Timestamp = seaSensordata.Timestamp,
                WaterTemperature = seaSensordata.WaterTemperature,
            };
            
            return repoSeaSensorData;
        }

        public static RepoSeaSensorStatus toRepoSeaSensorStatus(this ServiceSeaSensorStatus seaSensorStatus){
            RepoSeaSensorStatus repoSeaSensorStatus = new RepoSeaSensorStatus();
            repoSeaSensorStatus.BatteryCharge = seaSensorStatus.BatteryCharge;
            repoSeaSensorStatus.MacAddress = seaSensorStatus.MacAddress;
            return repoSeaSensorStatus;
        }
    }
}
