using SeeSensor.Services.Models;
using SeeSensor.Services.Services;

namespace SeeSensor.Api.Controllers.Models
{
    public static class SeaSensorExtension
    {

        public static ServiceSeaSensorData toServiceSeaSensorData(this SeaSensorDataRequest seaSensorDataRequest) {
            ServiceSeaSensorData serviceSeaSensorData = new ServiceSeaSensorData();
            serviceSeaSensorData.MacAdress = seaSensorDataRequest.macaddress;
            serviceSeaSensorData.Light = seaSensorDataRequest.Light;
            serviceSeaSensorData.AirHumidity = seaSensorDataRequest.Airhumidity;
            serviceSeaSensorData.AirTemperature = seaSensorDataRequest.Airtemperature;
            serviceSeaSensorData.AirPressure = seaSensorDataRequest.Airpressure;
            serviceSeaSensorData.WaterTemperature =seaSensorDataRequest.Watertemperature;
            serviceSeaSensorData.CoordinateX = seaSensorDataRequest.CoordinateX;
            serviceSeaSensorData.CoordinatY = seaSensorDataRequest.CoordinateY;
            return serviceSeaSensorData;
        }

        public static ServiceSeaSensorStatus toServiceSeaSensorStatus(this SeaSensorStatusRequest seaSensorStatusRequest) {
            ServiceSeaSensorStatus serviceSeaSensorStatus = new ServiceSeaSensorStatus();
            serviceSeaSensorStatus.MacAddress = seaSensorStatusRequest.MacAdress;
            serviceSeaSensorStatus.BatteryCharge = seaSensorStatusRequest.BatteryCharge;
            return serviceSeaSensorStatus;
        }
    }
}
