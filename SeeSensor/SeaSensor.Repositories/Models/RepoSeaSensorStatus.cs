using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories.Models
{
    public class RepoSeaSensorStatus
    {
        public string MacAddress { get; set; }
        public string BatteryCharge { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
