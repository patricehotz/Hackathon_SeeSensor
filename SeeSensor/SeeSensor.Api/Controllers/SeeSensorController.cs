using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SeeSensor.Api.Controllers.Models;

namespace SeeSensor.Api.Controllers
{
    public class SeeSensorController : Controller
    {
        [HttpPost ("/data")]
        public ActionResult addDataSet([FromBody] SeeSensorDataRequest seaSensorData)
        {
            return null;
        }

        [HttpPost ("/status")]
        public ActionResult addStatus([FromBody] SeaSensorStatusRequest seaSensorStatus)
        {
            return null;
        }
    }
}
