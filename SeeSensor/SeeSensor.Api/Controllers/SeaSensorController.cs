using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SeeSensor.Api.Controllers.Models;
using SeeSensor.Services.Models;
using SeeSensor.Services.Services;
using Newtonsoft.Json;

namespace SeeSensor.Api.Controllers
{
    public class SeaSensorController : Controller
    {
        private ISeaSensorService seaSensorService;

        public SeaSensorController(ISeaSensorService SeaSensor)
        {
            seaSensorService = SeaSensor;
        }

        [HttpPost ("/data")]
        public ActionResult addDataSet([FromBody] SeaSensorDataRequest seaSensorData)
        {

            Console.WriteLine(JsonConvert.SerializeObject(seaSensorData));

            ServiceSeaSensorResponse response = seaSensorService.addSensorData(seaSensorData.toServiceSeaSensorData());

            if (isSuccsess(response))
            {
                return StatusCode(200);
            }
            else {
                return StatusCode(400);
            }
            

        }

        [HttpPost ("/status")]
        public ActionResult addStatus([FromBody] SeaSensorStatusRequest seaSensorStatus)
        {

            ServiceSeaSensorResponse response = seaSensorService.setStatus(seaSensorStatus.toServiceSeaSensorStatus());
            if (isSuccsess(response))
            {
                return StatusCode(200);
            }
            else
            {
                return StatusCode(422);
            }

        }

        private static bool isSuccsess(ServiceSeaSensorResponse response)
        {
            return response == ServiceSeaSensorResponse.Success;
        }
    }
}
