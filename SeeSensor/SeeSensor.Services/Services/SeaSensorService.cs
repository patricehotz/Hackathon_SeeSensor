using SeaSensor.Repositories;
using SeaSensor.Repositories.Models;
using SeeSensor.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSensor.Services.Services
{
    public class SeaSensorService : ISeaSensorService
    {
        private ISeaSensorRepository seaSensorRepository;
        public SeaSensorService() { 
        }

        public ServiceSeaSensorResponse addSensorData(ServiceSeaSensorData sensorData)
        {
            try {
                seaSensorRepository.addData(ServiceSeaSensorExtension.toRepoSeaSensorData(sensorData));
                return ServiceSeaSensorResponse.Success;
            }
            catch (Exception e){
                return ServiceSeaSensorResponse.InvalidValue;
            }

        }

        public ServiceSeaSensorResponse setStatus(ServiceSeaSensorStatus sensorState)
        {
            try
            {
                seaSensorRepository.addStatus(ServiceSeaSensorExtension.toRepoSeaSensorStatus(sensorState));
                return ServiceSeaSensorResponse.Success;
            }
            catch (Exception e){
                return ServiceSeaSensorResponse.InvalidValue;
            }
        }

    }
}
