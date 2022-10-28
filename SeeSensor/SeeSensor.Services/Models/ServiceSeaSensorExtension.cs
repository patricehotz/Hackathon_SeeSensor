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
            RepoSeaSensorData repoSeaSensorData = new RepoSeaSensorData();
            repoSeaSensorData.MacAddress = seaSensordata.MacAdress;
            repoSeaSensorData.Light = seaSensordata.Light;
            repoSeaSensorData.AirHumidity = seaSensordata.AirHumidity;
            repoSeaSensorData.AirPressure = seaSensordata.AirPressure;
            repoSeaSensorData.WaterTemperature = seaSensordata.WaterTemperature;
            repoSeaSensorData.CoordinatesX = seaSensordata.CoordinateX;
            repoSeaSensorData.CoordinatesY = seaSensordata.CoordinateX;
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
