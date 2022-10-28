using SeeSensor.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Services.Services
{
    public  interface  ISeeSensorService
    {
        public ServiceSeeSensorResponse addSensorData(ServiceSeeSensorData sensorData);
        public ServiceSeeSensorResponse deleteSensorData(ServiceSeeSensorData sensorData);
    }
}
