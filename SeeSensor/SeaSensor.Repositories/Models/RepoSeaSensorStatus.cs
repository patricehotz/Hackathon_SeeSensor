using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories.Models
{
    public class RepoSeaSensorStatus
    {
        public string Id { get; set; }
        public string MacAddress { get; set; }
        public float BatteryCharge { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
