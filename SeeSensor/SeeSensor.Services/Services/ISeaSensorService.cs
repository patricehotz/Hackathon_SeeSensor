using SeeSensor.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Services.Services
{
    public  interface  ISeaSensorService
    {
        public ServiceSeaSensorResponse addSensorData(ServiceSeaSensorData sensorData);
        public ServiceSeaSensorResponse setStatus(ServiceSeaSensorStatus sensorState);
    }
}
