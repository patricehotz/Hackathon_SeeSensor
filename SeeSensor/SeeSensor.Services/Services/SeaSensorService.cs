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
        public SeaSensorService(ISeaSensorRepository seaSensorRepository) {
            this.seaSensorRepository = seaSensorRepository;
        }

        public ServiceSeaSensorResponse addSensorData(ServiceSeaSensorData sensorData)
        {
            try {
                sensorData.Timestamp = DateTime.Now;
                sensorData.Id = Guid.NewGuid().ToString();
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
                sensorState.Timestamp = DateTime.UtcNow;
                sensorState.Id = Guid.NewGuid().ToString();
                seaSensorRepository.addStatus(ServiceSeaSensorExtension.toRepoSeaSensorStatus(sensorState));
                return ServiceSeaSensorResponse.Success;
            }
            catch (Exception e){
                return ServiceSeaSensorResponse.InvalidValue;
            }
        }

    }
}
