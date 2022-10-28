using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SeeSensor.Api.Controllers.Models;
using SeeSensor.Services.Models;
using SeeSensor.Services.Services;

namespace SeeSensor.Api.Controllers
{
    public class SeaSensorController : Controller
    {
        private SeaSensorService seaSensorService;

        [HttpPost ("/data")]
        public ActionResult addDataSet([FromBody] SeaSensorDataRequest seaSensorData)
        {


            ServiceSeaSensorResponse response = seaSensorService.addSensorData(SeaSensorExtension.toServiceSeaSensorData(seaSensorData));

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

            ServiceSeaSensorResponse response = seaSensorService.setStatus(SeaSensorExtension.toServiceSeaSensorStatus(seaSensorStatus));
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
